using System;
using System.Collections.Generic;
using System.Text;
using ProjetoFinanceiro.Dtos.Painel;

namespace ProjetoFinanceiro.Services.Painel
{
    public interface IPainelService
    {
        Task<List<PainelRespondeDto>> GetAllSync();
        Task<PainelRespondeDto?> GetByIdAsync(Guid id);
        Task<PainelRespondeDto> CreateAsync(CreatePainelDto dto);
        Task<PainelRespondeDto> UpdateAsync(Guid id, CreatePainelDto dto);
        Task<bool> DeleteAsync(Guid Id);

    }
}
