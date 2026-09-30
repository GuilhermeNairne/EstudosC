using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ProjetoFinanceiro.Data;
using ProjetoFinanceiro.Dtos.Painel;

namespace ProjetoFinanceiro.Services.Painel
{
    internal class PainelService : IPainelService
    {
        private readonly AppDbContext _context;

        public PainelService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<PainelRespondeDto>> GetAllSync()
        {
            return await _context.Paineis.Select(p => new PainelRespondeDto
            {
                Id = p.Id,
                Nome = p.Nome,
                Valor = p.Valor,
            }).ToListAsync();
        }

        public async Task<PainelRespondeDto?> GetByIdAsync(Guid id)
        {
            var painel = await _context.Paineis.FindAsync(id);
            if (painel is null) return null;

            return new PainelRespondeDto
            {
                Id = painel.Id,
                Nome = painel.Nome,
                Valor = painel.Valor
            };
        }

        public async Task<PainelRespondeDto> CreateAsync(CreatePainelDto dto)
        {
            var painel = new Models.Painel
            {
                Nome = dto.Nome,
                Valor = dto.Valor,
            };

            _context.Paineis.Add(painel);
            await _context.SaveChangesAsync();
            return new PainelRespondeDto
            {
                Id = painel.Id,
                Nome = dto.Nome,
                Valor = dto.Valor,
            };

        }

        public async Task<PainelRespondeDto?> UpdateAsync(Guid id, UpdatePainelDto dto)
        {
            var painel = await _context.Paineis.FindAsync(id);
            if (painel is null) return null;

            if (dto.Nome is not null) painel.Nome = dto.Nome;
            if (dto.Valor is not null) painel.Valor = dto.Valor.Value;

            await _context.SaveChangesAsync();

            return new PainelRespondeDto
            {
                Id = painel.Id,
                Nome = painel.Nome,
                Valor = painel.Valor,
            };
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var painel = await _context.Paineis.FindAsync(id);
            if (painel is null) return false;

            _context.Paineis.Remove(painel);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
