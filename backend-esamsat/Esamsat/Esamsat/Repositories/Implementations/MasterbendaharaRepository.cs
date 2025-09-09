using Esamsat.Db;
using Esamsat.Dto;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class MasterbendaharaRepository : IMasterbendaharaRepository
    {
        private readonly DataContext _context;

        public MasterbendaharaRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MasterbendaharaDto>> GetAllAsync()
        {
            return await _context.Masterbendaharas
                .Include(m => m.IdpegawaiNavigation)  // JOIN ke MASTERPEGAWAI
                .Include(m => m.IdbankNavigation)     // JOIN ke MASTERBANK
                .Include(m => m.IdreknrcNavigation)   // JOIN ke MASTERREKNRC
                .Include(m => m.KoordinatorNavigation) // dari MASTERUPT
                .Select(m => new MasterbendaharaDto
                {
                    Idbend = m.Idbend,
                    Idpegawai = m.Idpegawai,
                    Idbank = m.Idbank,
                    Norek = m.Norek,
                    Namarek = m.Namarek,
                    Jnsbend = m.Jnsbend,
                    Status = m.Status,
                    Jabatan = m.IdpegawaiNavigation.Jabatan,
                    Pangkat = m.IdpegawaiNavigation.Pangkat,
                    Uid = m.Uid,
                    Koordinator = m.Koordinator,
                    Idreknrc = m.Idreknrc,
                    Telepon = m.Telepon,
                    Ket = m.Ket,
                    Createby = m.Createby,
                    Createdate = m.Createdate,
                    Updateby = m.Updateby,
                    Updatedate = m.Updatedate,

                    // Data dari tabel lain
                    Nama = m.IdpegawaiNavigation.Nama,
                    Namabank = m.IdbankNavigation.Namabank,
                    Nmrek = m.IdreknrcNavigation.Nmrek,

                     // Ambil nama Koordinator dari MASTERUPT
                    NamaKoordinator = m.KoordinatorNavigation.Nmupt
                })
                .ToListAsync();
        }

        public async Task<MasterbendaharaDto?> GetByIdAsync(long id)
        {
            return await _context.Masterbendaharas
                .Include(m => m.IdpegawaiNavigation)
                .Include(m => m.IdbankNavigation)
                .Include(m => m.IdreknrcNavigation)
                .Include(m => m.KoordinatorNavigation)
                .Where(m => m.Idbend == id)
                .Select(m => new MasterbendaharaDto
                {
                    Idbend = m.Idbend,
                    Idpegawai = m.Idpegawai,
                    Idbank = m.Idbank,
                    Norek = m.Norek,
                    Namarek = m.Namarek,
                    Jnsbend = m.Jnsbend,
                    Status = m.Status,
                    Jabatan = m.IdpegawaiNavigation.Jabatan,
                    Pangkat = m.IdpegawaiNavigation.Pangkat,
                    Uid = m.Uid,
                    Koordinator = m.Koordinator,
                    Idreknrc = m.Idreknrc,
                    Telepon = m.Telepon,
                    Ket = m.Ket,
                    Createby = m.Createby,
                    Createdate = m.Createdate,
                    Updateby = m.Updateby,
                    Updatedate = m.Updatedate,

                    Nama = m.IdpegawaiNavigation.Nama,
                    Namabank = m.IdbankNavigation.Namabank,
                    Nmrek = m.IdreknrcNavigation.Nmrek,
                    NamaKoordinator = m.KoordinatorNavigation.Nmupt
                })
                .FirstOrDefaultAsync();
        }

        public async Task<Masterbendahara> CreateAsync(createMasterbendaharaDto dto)
        {
            // Validasi Koordinator
            long? koordinatorId = null;
            if (dto.Koordinator.HasValue)
            {
                var upt = await _context.Masterupts
                    .AsNoTracking()
                    .FirstOrDefaultAsync(u => u.Idupt == dto.Koordinator.Value);
                if (upt != null) koordinatorId = upt.Idupt;
            }

            var entity = new Masterbendahara
            {
                Idpegawai = dto.Idpegawai,
                Idbank = dto.Idbank,
                Norek = dto.Norek,
                Namarek = dto.Namarek,
                Jnsbend = dto.Jnsbend,
                Status = dto.Status,
                Jabatan = dto.Jabatan ?? string.Empty,
                Pangkat = dto.Pangkat ?? string.Empty,
                Uid = dto.Uid,
                Koordinator = koordinatorId, 
                Idreknrc = dto.Idreknrc,
                Telepon = dto.Telepon,
                Ket = dto.Ket,
                Createby = dto.Createby,
                Createdate = DateTime.UtcNow
            };

            _context.Masterbendaharas.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }



        public async Task<Masterbendahara?> UpdateAsync(long id, UpdateMasterbendaharaDto dto)
        {
            var entity = await _context.Masterbendaharas.FindAsync(id);
            if (entity == null) return null;

            var pegawai = await _context.Masterpegawais
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Idpegawai == dto.Idpegawai);

            long? koordinatorId = null;
            if (dto.Koordinator.HasValue)
            {
                var upt = await _context.Masterupts
                    .AsNoTracking()
                    .FirstOrDefaultAsync(u => u.Idupt == dto.Koordinator.Value);
                if (upt != null) koordinatorId = upt.Idupt;
            }

            entity.Idpegawai = dto.Idpegawai;
            entity.Idbank = dto.Idbank;
            entity.Norek = dto.Norek;
            entity.Namarek = dto.Namarek;
            entity.Jnsbend = dto.Jnsbend;
            entity.Status = dto.Status;
            entity.Jabatan = dto.Jabatan;
            entity.Pangkat = dto.Pangkat;
            entity.Uid = dto.Uid;
            entity.Koordinator = koordinatorId; // gunakan hasil validasi
            entity.Idreknrc = dto.Idreknrc;
            entity.Telepon = dto.Telepon;
            entity.Ket = dto.Ket;
            entity.Updateby = dto.Updateby;
            entity.Updatedate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.Masterbendaharas.FindAsync(id);
            if (entity == null) return false;

            _context.Masterbendaharas.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
