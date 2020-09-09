using SistemaWebPizzaria.Data;
using SistemaWebPizzaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services
{
    public class DespesaService
    {
        private readonly SistemaWebPizzariaContext _context;

        public DespesaService( SistemaWebPizzariaContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(Despesa obj)
        {
            _context.Add(obj); //função para pegar os dados do formulario e salvar no banco
            await _context.SaveChangesAsync(); //função para confirmar a gravação dos dados no banco, (aqui deve ter a versão async)
        }          



    }
}
