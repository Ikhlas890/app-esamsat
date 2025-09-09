using Esamsat.Db;
using Esamsat.Dto;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class MasteruptRepository : IMasteruptRepository
    {
        private readonly DataContext _context;

        public MasteruptRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Masterupt>> GetAllAsync()
        {
            return await _context.Masterupts.ToListAsync();
        }

        public async Task<Masterupt?> GetByIdAsync(long id)
        {
            return await _context.Masterupts.FindAsync(id);
        }

        public async Task<Masterupt> CreateAsync(CreateMasteruptDto dto)
        {
            var entity = new Masterupt
            {
                Idparent = dto.Idparent,
                Kdupt = dto.Kdupt,
                Nmupt = dto.Nmupt,
                Kdlevel = dto.Kdlevel,
                Type = dto.Type,
                Akroupt = dto.Akroupt,
                Alamat = dto.Alamat,
                Telepon = dto.Telepon,
                Idbank = dto.Idbank,
                Idkabkota = dto.Idkabkota,
                Kepala = dto.Kepala,
                Koordinator = dto.Koordinator,
                Bendahara = dto.Bendahara,
                Status = dto.Status,
                Createby = dto.Createby,
                Createdate = DateTime.UtcNow
            };

            _context.Masterupts.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }


        public async Task<Masterupt?> UpdateAsync(long id, UpdateMasterUptDto dto)
        {
            var entity = await _context.Masterupts.FindAsync(id);
            if (entity == null) return null;

            entity.Idparent = dto.Idparent;
            entity.Kdupt = dto.Kdupt;
            entity.Nmupt = dto.Nmupt;
            entity.Kdlevel = dto.Kdlevel;
            entity.Type = dto.Type;
            entity.Akroupt = dto.Akroupt;
            entity.Alamat = dto.Alamat;
            entity.Telepon = dto.Telepon;
            entity.Idbank = dto.Idbank;
            entity.Idkabkota = dto.Idkabkota;
            entity.Kepala = dto.Kepala;
            entity.Koordinator = dto.Koordinator;
            entity.Bendahara = dto.Bendahara;
            entity.Status = dto.Status;

            entity.Updateby = dto.Updateby;
            entity.Updatedate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return entity;
        }


        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.Masterupts.FindAsync(id);
            if (entity == null) return false;

            _context.Masterupts.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
