using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinanceiro.Models
{
    public class Categoria
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Nome { get; set; } = string.Empty;

        public Guid PainelId { get; set; }
        public Painel Painel { get; set; } = null!;

        public ICollection<Movimento> Movimentos { get; set; } = new List<Movimento>();


    }
}
