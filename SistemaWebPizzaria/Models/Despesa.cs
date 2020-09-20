using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Despesa
    {
        public int IdDespesa { get; set; }
        public string NomeDespesa { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime? DataDespesa { get; set; }
    }
}
