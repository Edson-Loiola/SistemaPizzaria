using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
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


        public DbSet<LoginModel> Login { get; set; }

        internal DataTable RetDataTable(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
