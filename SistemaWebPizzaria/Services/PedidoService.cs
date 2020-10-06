
using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services.Exception;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services
{
    public class PedidoService
    {
        private readonly BancoPizzariaContext _context;

        public PedidoService(BancoPizzariaContext context)
        {
            _context = context;
        }


        //função de inserir no banco
        public async Task InsertAsync(Pedido obj)
        {
            _context.Add(obj); //função para pegar os dados do formulario e salvar no banco
            await _context.SaveChangesAsync(); //função para confirmar a gravação dos dados no banco, (aqui deve ter a versão async)
        }


        //função de fazer listagem das 
        public async Task<List<Pedido>> FindAllAsync()
        {
            return await _context.Pedido.ToListAsync();
        }


        //função remover  do banco pelo id
        public async Task RemoveAsync(Pedido pedido)
        {
            try
            {
                _context.Pedido.Remove(pedido);
                await _context.SaveChangesAsync();
            }
            catch (NotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }
        }


        public async Task<Pedido> FindByIdAsync(int id)
        {
            return await _context.Pedido.FirstOrDefaultAsync(obj => obj.IdPedido == id);

            //eager loading (inlcude): inner join para carregar outros objetos associados ao obj principal (no caso o departamento)
        }

        //função de atualizar uma 
        public async Task UpdateAsync(Pedido obj)
        {
            //pra atualizar um objeto o id desse objeto já precisa existir no banco
            bool hasAny = await _context.Pedido.AnyAsync(x => x.IdPedido == obj.IdPedido);

            if (!hasAny)  // verifica se expressão passada não existe no banco
            {
                throw new NotFiniteNumberException("Pedido não existe!");
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
