
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services.Exception;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services { 

    public class PedidoService : ControllerBase
{
        private readonly BancoPizzariaContext _context;

        public PedidoService(BancoPizzariaContext context)
        {
            _context = context;
        }


        //função de inserir no banco
        public async Task InsertAsync(Pedido obj)
        {
            obj.DataHora = DateTime.Now;
            obj.IdClienteNavigation = _context.Cliente.Find(obj.IdCliente);
            obj.IdFuncioarioNavigation = _context.Funcionario.Find(obj.IdFuncioario);
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        //função de fazer listagem dos pedidos
        public async Task<List<Pedido>> FindAllAsync()
        {
            return await _context.Pedido.Include(f => f.IdFuncioarioNavigation).Include(c => c.IdClienteNavigation).Include(i => i.Itempedido).ToListAsync();
        }

        //função de fazer listagem dos funcionarios
        public async Task<List<Funcionario>> ListaFuncionarios()
        {
            return await _context.Funcionario.ToListAsync();
        }

        //função de fazer listagem dos Clientes
        public async Task<List<Cliente>> ListaClientes()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<List<Cardapiopizza>> ListaCardapio()
        {
            return await _context.Cardapiopizza.ToListAsync();
        }

        public async Task<Cardapiopizza> FindByIdCardapio(int id)
        {
            return await _context.Cardapiopizza.FindAsync(id);
        }

        public async Task<List<Produtoestoque>> ListaProduto()
        {
            return await _context.Produtoestoque.ToListAsync();
        }

        public async Task<Produtoestoque> FindByIdProduto(int id)
        {
            return await _context.Produtoestoque.FindAsync(id);
        }

        public async Task InsertItemPedido(ItemPedido itemPedido)
        {
            if (itemPedido.CardapioPizzaIdCardapio != null)
            {
                itemPedido.CardapioPizzaIdCardapioNavigation = _context.Cardapiopizza.Find(itemPedido.CardapioPizzaIdCardapio);

            }

            if (itemPedido.ProdutoEstoqueIdProduto != null)
            {
                itemPedido.ProdutoEstoqueIdProdutoNavigation = _context.Produtoestoque.Find(itemPedido.ProdutoEstoqueIdProduto);
            }

            _context.Add(itemPedido);
            await _context.SaveChangesAsync();
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
            var pedido = await _context.Pedido.Include(f => f.IdFuncioarioNavigation).Include(c => c.IdClienteNavigation).FirstOrDefaultAsync(obj => obj.IdPedido == id);

            var listaItemPedido = await _context.Itempedido.ToListAsync();

            foreach (ItemPedido item in listaItemPedido)
            {
                if (item.PedidoIdPedido == pedido.IdPedido)
                {
                    pedido.Itempedido.Add(item);
                }
            }

            return pedido;

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
