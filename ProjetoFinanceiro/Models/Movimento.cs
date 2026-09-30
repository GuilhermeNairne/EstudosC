using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinanceiro.Models
{
   public class Movimento
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Nome {  get; set; } = string.Empty;

        public decimal Valor { get; set; }
        public TipoMovimento TipoMovimento { get; set; }
        public DateTime Data {  get; set; }

        public Guid PainelId { get; set; }
        public Painel Painel { get; set; } = null!;

        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;
    }
}
