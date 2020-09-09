using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Models
{
    public class Despesa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Despesa()
        {
                
        }

        public Despesa(int id, string nome, string descricao, double valor)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }


        
    }
}
