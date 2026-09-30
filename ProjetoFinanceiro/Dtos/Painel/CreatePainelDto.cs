using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinanceiro.Dtos.Painel
{
    public class CreatePainelDto
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracters")]
        public string Nome { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "O valor não pode ser negativo")]
        public decimal Valor { get; set; }
    }
}
