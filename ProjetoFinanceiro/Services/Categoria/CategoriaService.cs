
using Microsoft.EntityFrameworkCore;
using ProjetoFinanceiro.Data;
using ProjetoFinanceiro.Dtos.Categoria;

namespace ProjetoFinanceiro.Services.Categoria
{
    public class CategoriaService : ICategoriaService
    {

        private readonly AppDbContext _context;

        public CategoriaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoriaResponseDto>> GetAll()
        {
            return await _context.Categorias.Select(p => new CategoriaResponseDto
            {
                Id = p.Id,
                Nome = p.Nome,
                PainelId = p.PainelId,
            }).ToListAsync();
        }

        public async Task<CategoriaResponseDto?> GetById(Guid Id)
        {
            var categoria = await _context.Categorias.FindAsync(Id);
            if (categoria is null) return null;

            return new CategoriaResponseDto
            {
                Id = categoria.Id,
                Nome = categoria.Nome,
                PainelId = categoria.PainelId
            };
        }

        public async Task<List<CategoriaResponseDto>> GetByPainelId(Guid PainelId)
        {
            return await _context.Categorias
        .Where(c => c.PainelId == PainelId)
        .Select(c => new CategoriaResponseDto
        {
            Id = c.Id,
            Nome = c.Nome,
            PainelId = c.PainelId
        })
        .ToListAsync();
        }

        public async Task<CategoriaResponseDto> Create(CreateCategoriaDto dto)
        {
            var categoria = new Models.Categoria
            {
                Nome = dto.Nome,
                PainelId = dto.PainelId
            };

            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return new CategoriaResponseDto
            {
                Id = categoria.Id,
                Nome = categoria.Nome,
                PainelId = categoria.PainelId
            };
        }

        public async Task<CategoriaResponseDto?> Update(Guid Id,  UpdateCategoriaDto dto)
        {
            var categoria = await _context.Categorias.FindAsync(Id);
            if (categoria is null) return null;

            if (dto.Nome is not null) categoria.Nome = dto.Nome;
            if (dto.PainelId is not null) categoria.PainelId = dto.PainelId.Value;

            await _context.SaveChangesAsync();

            return new CategoriaResponseDto
            {
                Id = categoria.Id,
                Nome = categoria.Nome,
                PainelId = categoria.PainelId
            };
        }

        public async Task<bool> Delete(Guid Id)
        {
            var categoria = await _context.Categorias.FindAsync(Id);
            if (categoria is null) return false;

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
            return true;


        }
    }
}
