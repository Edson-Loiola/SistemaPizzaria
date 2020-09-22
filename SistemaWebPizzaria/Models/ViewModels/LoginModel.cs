using SistemaWebPizzaria.Data;
using System.ComponentModel.DataAnnotations;

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


        private readonly BancoPizzariaContext _context;

        public LoginModel()
        {

        }

        public LoginModel(int id, string email, string senha, BancoPizzariaContext context)
        {

            Id = id;
            Email = email;
            Senha = senha;
            _context = context;
        }



    }
}