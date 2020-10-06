using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services
{
    public class LoginService
    {
        private readonly BancoPizzariaContext _context;

        public LoginService(BancoPizzariaContext context)
        {
            _context = context;
        }


        //função de inserir no banco
        public async Task InsertAsync(Login obj)
        {
            _context.Add(obj); //função para pegar os dados do formulario e salvar no banco
            await _context.SaveChangesAsync(); //função para confirmar a gravação dos dados no banco, (aqui deve ter a versão async)
        }


        //função de fazer listagem das despesas
        public async Task<List<Login>> FindAllAsync()
        {
            return await _context.Login.ToListAsync();
        }


    //função remover despesa do banco pelo id
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Login.FindAsync(id);
                _context.Login.Remove(obj);
                await _context.SaveChangesAsync(); //esse metodo confirma a operação no

            }
            catch (NotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }
        }


        public async Task<Login> FindByIdAsync(int id)
        {
            return await _context.Login.FirstOrDefaultAsync(obj => obj.IdLogin == id);

            //eager loading (inlcude): inner join para carregar outros objetos associados ao obj principal
        }


        public async Task<Login> LoginAsync(string email, string senha)
        {
            return await _context.Login.FirstOrDefaultAsync(obj => obj.Email == email && obj.Senha == senha);
        }




        //função de atualizar uma despesa
        public async Task UpdateAsync(Login obj)
        {
            //pra atualizar um objeto o id desse objeto já precisa existir no banco
            bool hasAny = await _context.Login.AnyAsync(x => x.IdLogin == obj.IdLogin);

            if (!hasAny)  // verifica se expressão passada não existe no banco
            {
                throw new NotFiniteNumberException("Login não existe!");
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
