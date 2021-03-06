﻿
using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services.Exception;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services
{
    public class ProdutoService
    {
        private readonly BancoPizzariaContext _context;

        public ProdutoService(BancoPizzariaContext context)
        {
            _context = context;
        }


        //função de inserir no banco
        public async Task InsertAsync(Produtoestoque obj)
        {
            _context.Add(obj); //função para pegar os dados do formulario e salvar no banco
            await _context.SaveChangesAsync(); //função para confirmar a gravação dos dados no banco, (aqui deve ter a versão async)
        }


        //função de fazer listagem das Produto
        public async Task<List<Produtoestoque>> FindAllAsync()
        {
            return await _context.Produtoestoque.ToListAsync();
        }


        //função remover Produtos do banco pelo id
        public async Task RemoveAsync(Produtoestoque produto)
        {
            try
            {
                _context.Produtoestoque.Remove(produto);
                await _context.SaveChangesAsync();
            }
            catch (NotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }
        }


        public async Task<Produtoestoque> FindByIdAsync(int? id)
        {
            return await _context.Produtoestoque.FirstOrDefaultAsync(obj => obj.IdProduto == id);

            //eager loading (inlcude): inner join para carregar outros objetos associados ao obj principal (no caso o departamento)
        }

        public async Task<Produtoestoque> FindByName(string nome)
        {
            return await _context.Produtoestoque.FirstOrDefaultAsync(obj => obj.Nome.Contains(nome));
        }

        //função de atualizar uma Produto
        public async Task UpdateAsync(Produtoestoque obj)
        {
            //pra atualizar um objeto o id desse objeto já precisa existir no banco
            bool hasAny = await _context.Produtoestoque.AnyAsync(x => x.IdProduto == obj.IdProduto);

            if (!hasAny)  // verifica se expressão passada não existe no banco
            {
                throw new NotFiniteNumberException("Produto não existe!");
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
