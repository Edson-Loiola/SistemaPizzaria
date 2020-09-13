using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models
{
    public partial class Despesa
    {
        public int IdDespesa { get; set; }


        [Required(ErrorMessage = "Informar um nome!")] // para campo obrigatório. posso definir uma msg de errou não.
        public string NomeDespesa { get; set; }


        public string Descricao { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")] //formatação para que o salario na tela apareça apareça com duas casas decimais
        [Required(ErrorMessage ="Informar um valor!")]
        public decimal Valor { get; set; }


        [DataType(DataType.Date)] // Annotations: retira a parte de hora/minuto do campo onde tem o form de criar nova despesa.
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime? DataDespesa { get; set; }

      
    }
}
