using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;
using System.Collections.Generic;
using System.Globalization;

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
            services.AddScoped<ClienteService>();
            services.AddScoped<FuncionarioService>();
            services.AddScoped<PedidoService>();
            services.AddScoped<LoginService>();
            services.AddScoped<CardapioService>();
            services.AddScoped<RelatorioService>();


            //cinfigurando sessions
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
      

        }



        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //var enBR = new CultureInfo("pt-BR");
            //var localizationOptions = new RequestLocalizationOptions
            //{
            //    DefaultRequestCulture = new RequestCulture(enBR),
            //    SupportedCultures = new List<CultureInfo> { enBR },
            //    SupportedUICultures = new List<CultureInfo> { enBR }
            //};

            //app.UseRequestLocalization(localizationOptions);

            //var supportedCultures = new[] { new CultureInfo("pt-BR") };
            //app.UseRequestLocalization(new RequestLocalizationOptions
            //{
            //    DefaultRequestCulture = new RequestCulture(culture: "pt-BR", uiCulture: "pt-BR"),
            //    SupportedCultures = supportedCultures,
            //    SupportedUICultures = supportedCultures
            //});

            var enUS = new CultureInfo("en-US");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(enUS),
                SupportedCultures = new List<CultureInfo> { enUS },
                SupportedUICultures = new List<CultureInfo> { enUS }
            };

            app.UseRequestLocalization(localizationOptions);



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
