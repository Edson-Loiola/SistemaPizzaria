
using Microsoft.EntityFrameworkCore;

using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services.Exception;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services
{
    public class DespesaService
    {
        private readonly BancoPizzariaContext _context;

        public DespesaService(BancoPizzariaContext context)
        {
            _context = context;
        }


        //função de inserir no banco
        public async Task InsertAsync(Despesa obj)
        {
            _context.Add(obj); //função para pegar os dados do formulario e salvar no banco
            await _context.SaveChangesAsync(); //função para confirmar a gravação dos dados no banco, (aqui deve ter a versão async)
        }


        //função de fazer listagem das despesas
        public async Task<List<Despesa>> FindAllAsync()
        {
            return await _context.Despesa.ToListAsync();
        }


        //função remover despesa do banco pelo id
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Despesa.FindAsync(id);
                _context.Despesa.Remove(obj);
                await _context.SaveChangesAsync(); //esse metodo confirma a operação no

            }
            catch (NotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }
        }


        public async Task<Despesa> FindByIdAsync(int id)
        {
            return await _context.Despesa.FirstOrDefaultAsync(obj => obj.IdDespesa == id);

            //eager loading (inlcude): inner join para carregar outros objetos associados ao obj principal
        }





        //função de atualizar uma despesa
        public async Task UpdateAsync(Despesa obj)
        {
            //pra atualizar um objeto o id desse objeto já precisa existir no banco
            bool hasAny = await _context.Despesa.AnyAsync(x => x.IdDespesa == obj.IdDespesa);

            if (!hasAny)  // verifica se expressão passada não existe no banco
            {
                throw new NotFiniteNumberException("Despesa não existe!");
            }

            try
            {
                _context.Update(obj); //atualiza o objeto
                await _context.SaveChangesAsync(); //confirmar alteração
            }
            catch (DllNotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }

        }



    }
}
