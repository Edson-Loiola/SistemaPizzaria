
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models.ViewModels
{
    public class LoginModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} não informado!")]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [StringLength(30, ErrorMessage = "{0} Máximo de 30 caracteres")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "{0} não informada!")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "{0} Máximo de 30 caracteres")]
        [Compare("SenhaNova", ErrorMessage = "Senhas são diferentes")]
        public string Senha { get; set; }

        [Display(Name = "SenhaNova")]
        [Remote("ComparaSenhaNova", "Home", ErrorMessage = "Senha Nova precisa ser diferente da Senha Atual")]
        [Required(ErrorMessage = "Senha Nova não informada!")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Senha Nova Máximo de 30 caracteres")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{6,}$", ErrorMessage = "A senha precisa ter pelo menos 6 caractéres e conter letras maiúsculas, minúsculas, números e caractéres especiais(!@#$%^&*)")]
        public string SenhaNova { get; set; }

        [Display(Name = "SenhaAtual")]
        [Required(ErrorMessage = "Senha Atual não informada!")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Senha Atual Máximo de 30 caracteres")]
        [Remote("VerificaSenhaAtual", "Home", ErrorMessage = "Senha é diferente da senha cadastrada atualmente")]
        public string SenhaAtual { get; set; }




        public LoginModel()
        {

        }

        public LoginModel(int id, string email, string senha)
        {

            Id = id;
            Email = email;
            Senha = senha;
        
        }



    }
}