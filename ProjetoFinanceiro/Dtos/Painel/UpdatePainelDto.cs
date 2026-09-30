using System.ComponentModel.DataAnnotations;

namespace ProjetoFinanceiro.Dtos.Painel
{
    public class UpdatePainelDto
    {
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracters")]
        public string? Nome { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor não pode ser negativo")]
        public decimal? Valor { get; set; }
    }
}
