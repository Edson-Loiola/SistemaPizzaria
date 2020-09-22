using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;

namespace SistemaWebPizzaria
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //confiuração do banco de dados MySql
            services.AddDbContext<BancoPizzariaContext>(options =>
                    options.UseMySql(Configuration.GetConnectionString("BancoPizzariaContext"), builder =>
                    builder.MigrationsAssembly("SistemaWebPizzaria"))); //responsável por criar as Migrations e criar o banco de dados a apartir dos nossos objetos

            //Para baixar o provider do MySql:
            //botão direito na solution (nome do projeto :SistemaWebPizzaria)
            //Manage Packge Nuget
            //Procurar: Pomelo.EntityFrameworkCore.MySql  e instalar a versão  2.1.1

            services.AddScoped<DespesaService>();
            services.AddScoped<ProdutoService>();

            //cinfigurando sessions
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
