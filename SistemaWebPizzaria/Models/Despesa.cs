using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models
{
    public partial class Despesa
    {
        public int IdDespesa { get; set; }
        public string NomeDespesa { get; set; }
        public string Descricao { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Valor { get; set; }
        public DateTime? DataDespesa { get; set; }
    }
}
