using Microsoft.AspNetCore.Mvc;
using ProjetoFinanceiro.Dtos.Painel;
using ProjetoFinanceiro.Services;
using ProjetoFinanceiro.Services.Painel;

namespace ProjetoFinanceiro.Controllers
{
    [ApiController]
    [Route("api/Paineis")]
    public class PainelController : ControllerBase
    {
        private readonly IPainelService _painelService;

        public PainelController(IPainelService painelService)
        {
            _painelService = painelService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PainelRespondeDto>>> GetAll()
        {
            var paineis = await _painelService.GetAllSync();
            return Ok(paineis);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PainelRespondeDto>> GetById(Guid id)
        {
            var painel = await _painelService.GetByIdAsync(id);
            return Ok(painel);
        }

        [HttpPost]
        public async Task<ActionResult<PainelRespondeDto>> CreateAsync(CreatePainelDto dto)
        {
            var painel = await _painelService.CreateAsync(dto);
            return Ok(painel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PainelRespondeDto>> UpdateAsync(Guid id, CreatePainelDto dto)
        {
            var painel = await _painelService.UpdateAsync(id, dto);
            if (painel is null) return NotFound();

            return Ok(painel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            var painel = await _painelService.DeleteAsync(id);
            if (!painel) return NotFound();

            return Ok(painel);
        }

    }
}
