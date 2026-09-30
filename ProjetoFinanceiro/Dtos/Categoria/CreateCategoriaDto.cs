using System.ComponentModel.DataAnnotations;

namespace ProjetoFinanceiro.Dtos.Categoria
{
    public class CreateCategoriaDto
    {

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracters")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "É necessário informar o Id do Painel")]
        public Guid PainelId { get; set; }
    }
}
