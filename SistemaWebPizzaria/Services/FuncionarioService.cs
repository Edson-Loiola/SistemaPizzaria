using SistemaWebPizzaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaWebPizzaria.Services.Exception;
using Microsoft.EntityFrameworkCore;

namespace SistemaWebPizzaria.Services
{
    public class FuncionarioService
    {

        private readonly BancoPizzariaContext _context;

        public FuncionarioService(BancoPizzariaContext context)
        {
            _context = context;
        }

        public FuncionarioService(){
        }

        //função de inserir no banco
        public async Task InsertAsync(Funcionario obj)
        {
            _context.Add(obj); //função para pegar os dados do formulario e salvar no banco
            await _context.SaveChangesAsync(); //função para confirmar a gravação dos dados no banco, (aqui deve ter a versão async)
        }

        //funcao retorna ultimo id inserido
        public async Task<Funcionario> LastAsync()
        {
            return  await _context.Funcionario.LastAsync();
         
        }

        //função de fazer listagem das funcionarios
        public async Task<List<Funcionario>> FindAllAsync()
        {
            return await _context.Funcionario.Include(c => c.IdLoginNavigation).ToListAsync();
        }

        public async Task<List<Funcionario>> listaFuncionarios()
        {
            return await _context.Funcionario.ToListAsync();
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


        public async Task<Funcionario> FindByIdAsync(int id)
        {
            return await _context.Funcionario.FirstOrDefaultAsync(obj => obj.IdFuncionario == id);
            //eager loading (inlcude): inner join para carregar outros objetos associados ao obj principal (no caso o departamento)
        }
      



        //função de atualizar uma despesa
        public async Task UpdateAsync(Funcionario obj)
        {
            //pra atualizar um objeto o id desse objeto já precisa existir no banco
            bool hasAny = await _context.Funcionario.AnyAsync(x => x.IdFuncionario == obj.IdFuncionario);

            if (!hasAny)  // verifica se expressão passada não existe no banco
            {
                throw new NotFiniteNumberException("Funcionário não existe!");
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
