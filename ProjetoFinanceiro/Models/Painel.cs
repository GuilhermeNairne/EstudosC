using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinanceiro.Models
{
    public class Painel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public Decimal Valor { get; set; }

        public ICollection<Categoria> Categoria { get; set; } = new List<Categoria>();
        public ICollection<Movimento> Movimentos { get; set; } = new List<Movimento>();
    }
}
