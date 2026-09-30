using System.ComponentModel.DataAnnotations;

namespace ProjetoFinanceiro.Dtos.Categoria
{
    public class UpdateCategoriaDto
    {
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracters")]
        public string? Nome { get; set; }

        public Guid? PainelId { get; set; }
    }
}
