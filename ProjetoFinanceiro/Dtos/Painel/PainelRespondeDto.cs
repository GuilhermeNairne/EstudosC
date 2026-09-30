using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinanceiro.Dtos.Painel
{
    public class PainelRespondeDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public Decimal Valor { get; set; }
    }
}
