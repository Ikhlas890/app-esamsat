using Esamsat.Db;
using Esamsat.Dto;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class MasterpegawaiRepository : IMasterpegawaiRepository
    {
        private readonly DataContext _context;

        public MasterpegawaiRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MasterpegawaiDto>> GetAllAsync()
        {
            return await _context.Masterpegawais
                .Include(m => m.IduptNavigation)
                .Select(m => new MasterpegawaiDto
                {
                    Idpegawai = m.Idpegawai,
                    Idktp = m.Idktp,
                    Nip = m.Nip,
                    Nik = m.Nik,
                    Nama = m.Nama,
                    Idupt = m.Idupt,
                    Nmupt = m.IduptNavigation.Nmupt,
                    Status = m.Status,
                    Jabatan = m.Jabatan,
                    Pangkat = m.Pangkat,
                    Golongan = m.Golongan,
                    Uid = m.Uid,
                    Telepon = m.Telepon,
                    Createby = m.Createby,
                    Createdate = m.Createdate,
                    Updateby = m.Updateby,
                    Updatedate = m.Updatedate
                })
                .ToListAsync();
        }


        public async Task<MasterpegawaiDto?> GetByIdAsync(long id)
        {
            return await _context.Masterpegawais
                .Include(m => m.IduptNavigation)
                .Where(m => m.Idpegawai == id)
                .Select(m => new MasterpegawaiDto
                {
                    Idpegawai = m.Idpegawai,
                    Idktp = m.Idktp,
                    Nip = m.Nip,
                    Nik = m.Nik,
                    Nama = m.Nama,
                    Idupt = m.Idupt,
                    Nmupt = m.IduptNavigation.Nmupt,
                    Status = m.Status,
                    Jabatan = m.Jabatan,
                    Pangkat = m.Pangkat,
                    Golongan = m.Golongan,
                    Uid = m.Uid,
                    Telepon = m.Telepon,
                    Createby = m.Createby,
                    Createdate = m.Createdate,
                    Updateby = m.Updateby,
                    Updatedate = m.Updatedate
                })
                .FirstOrDefaultAsync();
        }


        public async Task<Masterpegawai> CreateAsync(CreateMasterpegawaiDto dto)
        {
            var entity = new Masterpegawai
            {
                Idktp = dto.Idktp,
                Nip = dto.Nip,
                Nik = dto.Nik,
                Nama = dto.Nama,
                Idupt = dto.Idupt,
                Status = dto.Status,
                Jabatan = dto.Jabatan,
                Pangkat = dto.Pangkat,
                Golongan = dto.Golongan,
                Uid = dto.Uid,
                Telepon = dto.Telepon,
                Createby = dto.Createby,
                Createdate = DateTime.UtcNow
            };

            _context.Masterpegawais.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }


        public async Task<Masterpegawai?> UpdateAsync(long id, UpdateMasterpegawaiDto dto)
        {
            var entity = await _context.Masterpegawais.FindAsync(id);
            if (entity == null) return null;

            entity.Idktp = dto.Idktp;
            entity.Nip = dto.Nip;
            entity.Nik = dto.Nik;
            entity.Nama = dto.Nama;
            entity.Idupt = dto.Idupt;
            entity.Status = dto.Status;
            entity.Jabatan = dto.Jabatan;
            entity.Pangkat = dto.Pangkat;
            entity.Golongan = dto.Golongan;
            entity.Uid = dto.Uid;
            entity.Telepon = dto.Telepon;

            entity.Updateby = dto.Updateby;
            entity.Updatedate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return entity;
        }


        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.Masterpegawais.FindAsync(id);
            if (entity == null) return false;

            _context.Masterpegawais.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
