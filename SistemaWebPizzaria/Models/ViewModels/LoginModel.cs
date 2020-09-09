using SistemaWebPizzaria.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Models.ViewModels
{
    public class LoginModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }


        [StringLength(60, MinimumLength = 6, ErrorMessage = "Senha required")]
        public string Senha { get; set; }




        private readonly SistemaWebPizzariaContext _context;

        public LoginModel()
        {

        }

        public LoginModel(int id, string email, string senha, SistemaWebPizzariaContext context)
        {

            Id = id;
            Email = email;
            Senha = senha;
            _context = context;
        }



        //public bool ValidarLogin()
        //{
        //    string sql = $"Select Id from login where email ='{Email}' and senha ='{Senha}'";
        //    DataTable dt = _context.RetDataTable(sql);

        //    if (dt.Rows.Count == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

    }
}