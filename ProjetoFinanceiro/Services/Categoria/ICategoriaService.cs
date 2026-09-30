using ProjetoFinanceiro.Dtos.Categoria;
using ProjetoFinanceiro.Dtos.Painel;

namespace ProjetoFinanceiro.Services.Categoria
{
    public interface ICategoriaService
    {
        Task<List<CategoriaResponseDto>> GetAll();
        Task<CategoriaResponseDto?> GetById(Guid Id);
        Task<List<CategoriaResponseDto>> GetByPainelId(Guid PainelId);
        Task<CategoriaResponseDto> Create(CreateCategoriaDto dto);
        Task<CategoriaResponseDto?> Update(Guid Id, UpdateCategoriaDto dto);
        Task<bool> Delete(Guid Id); 


    }
}
