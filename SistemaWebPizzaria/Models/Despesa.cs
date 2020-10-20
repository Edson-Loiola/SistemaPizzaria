using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace SistemaWebPizzaria.Models
{
    public partial class Despesa
    {
        public int IdDespesa { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} não informado!")]
        [StringLength(50, ErrorMessage = "{0} Máximo de 50 caracteres")]
        public string NomeDespesa { get; set; }


        [StringLength(100, ErrorMessage = "{0} Máximo de 100 caracteres")]
        public string Descricao { get; set; }


        [Range(0.00, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        [DisplayFormat(DataFormatString = "{0:F2}")]        
        [Required(ErrorMessage = "{0} não informado!")]
        public double Valor { get; set; }


        [Display(Name = "Data")]
        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDespesa { get; set; }

        public Despesa()
        {

        }

        public Despesa(int idDespesa, string nomeDespesa, string descricao, double valor, DateTime dataDespesa)
        {
            IdDespesa = idDespesa;
            NomeDespesa = nomeDespesa;
            Descricao = descricao;
            Valor = valor;
            DataDespesa = dataDespesa;
        }
    }

}
