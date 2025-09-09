using Esamsat.Dto;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Esamsat.Db;
using System;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class MasterrekdRepository : IMasterrekdRepository
    {
        private readonly DataContext _context; 

        public MasterrekdRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Masterrekd>> GetAllAsync()
        {
            return await _context.Masterrekds.ToListAsync();
        }

        public async Task<Masterrekd?> GetByIdAsync(int id)
        {
            return await _context.Masterrekds.FindAsync(id);
        }

        public async Task<Masterrekd> CreateAsync(CreateMasterrekdDto dto)
        {
            var entity = new Masterrekd
            {
                Idrekd = dto.Idrekd,
                Idparent = dto.Idparent,
                Mtglevel = dto.Mtglevel,
                Kdrek = dto.Kdrek,
                Nmrek = dto.Nmrek,
                Kdjnspjk = dto.Kdjnspjk,
                Type = dto.Type,
                Status = dto.Status,
                Createby = dto.Createby,
            };

            _context.Masterrekds.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Masterrekd?> UpdateAsync(int id, UpdateMasterrekdDto dto)
        {
            var entity = await _context.Masterrekds.FindAsync(id);
            if (entity == null) return null;

            entity.Idparent = dto.Idparent;
            entity.Mtglevel = dto.Mtglevel;
            entity.Kdrek = dto.Kdrek;
            entity.Nmrek = dto.Nmrek;
            entity.Kdjnspjk = dto.Kdjnspjk;
            entity.Type = dto.Type;
            entity.Status = dto.Status;
            entity.Createby = dto.Createby;

            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Masterrekds.FindAsync(id);
            if (entity == null) return false;

            _context.Masterrekds.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
