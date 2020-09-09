using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Models.ViewModels;
using System;
using System.Data;

namespace SistemaWebPizzaria.Data
{
    public class SistemaWebPizzariaContext : DbContext
    {

        //ctor
        public SistemaWebPizzariaContext(DbContextOptions<SistemaWebPizzariaContext> options) : base(options)
        {
        }


        //public DbSet<ClientePz> ClientePz { get; set; }
        //public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Despesa> Despesa { get; set; }

    }
}
