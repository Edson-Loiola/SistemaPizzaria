
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services.Exception;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services { 

    public class ItempedidoService : ControllerBase
{
        private readonly BancoPizzariaContext _context;

        public ItempedidoService(BancoPizzariaContext context)
        {
            _context = context;
        }

        //função de inserir no banco
        public async Task InsertAsync(Itempedido obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        //função de fazer listagem dos pedidos
        public async Task<List<Itempedido>> FindAllAsync()
        {
            return await _context.Itempedido.ToListAsync();
        }

        //função remover  do banco pelo id
        public async Task RemoveAsync(Itempedido itempedido)
        {
            try
            {
                _context.Itempedido.Remove(itempedido);
                await _context.SaveChangesAsync();
            }
            catch (NotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }
        }


        public async Task<Itempedido> FindByIdAsync(int id)
        {
            var itempedido = await _context.Itempedido.FirstOrDefaultAsync(obj => obj.Id == id);

            return itempedido;
        }

        //função de atualizar uma 
        public async Task UpdateAsync(Itempedido obj)
        {
            //pra atualizar um objeto o id desse objeto já precisa existir no banco
            bool hasAny = await _context.Itempedido.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)  // verifica se expressão passada não existe no banco
            {
                throw new NotFiniteNumberException("itempedido não existe!");
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
