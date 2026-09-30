using Microsoft.AspNetCore.Mvc;
using ProjetoFinanceiro.Dtos.Categoria;
using ProjetoFinanceiro.Services.Categoria;

namespace ProjetoFinanceiro.Controllers
{
    [ApiController]
    [Route("api/Categorias")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoriaResponseDto>>> GetAll()
        {
            var categorias = await _categoriaService.GetAll();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaResponseDto>> GetById(Guid id)
        {
            var categoria = await _categoriaService.GetById(id);
            if (categoria is null) return NotFound();

            return Ok(categoria);
        }

        [HttpGet("painel/{painelId}")]
        public async Task<ActionResult<List<CategoriaResponseDto>>> GetByPainelId(Guid painelId)
        {
            var categorias = await _categoriaService.GetByPainelId(painelId);
            return Ok(categorias);
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaResponseDto>> Create(CreateCategoriaDto dto)
        {
            var categoria = await _categoriaService.Create(dto);
            return CreatedAtAction(nameof(GetById), new { id = categoria.Id }, categoria);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<CategoriaResponseDto>> Update(Guid id, UpdateCategoriaDto dto)
        {
            var categoria = await _categoriaService.Update(id, dto);
            if (categoria is null) return NotFound();

            return Ok(categoria);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _categoriaService.Delete(id);
            if (!deleted) return NotFound();

            return NoContent();
        }
    }
}
