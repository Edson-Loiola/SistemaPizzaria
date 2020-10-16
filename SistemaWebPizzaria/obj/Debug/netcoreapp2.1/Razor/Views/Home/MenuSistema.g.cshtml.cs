#pragma checksum "C:\Users\izaias\Documents\GitHub\SistemaPizzaria2\SistemaWebPizzaria\Views\Home\MenuSistema.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8e5ecba0d556efe44a79a09e09ac876f0664f3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MenuSistema), @"mvc.1.0.view", @"/Views/Home/MenuSistema.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MenuSistema.cshtml", typeof(AspNetCore.Views_Home_MenuSistema))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\izaias\Documents\GitHub\SistemaPizzaria2\SistemaWebPizzaria\Views\_ViewImports.cshtml"
using SistemaWebPizzaria;

#line default
#line hidden
#line 2 "C:\Users\izaias\Documents\GitHub\SistemaPizzaria2\SistemaWebPizzaria\Views\_ViewImports.cshtml"
using SistemaWebPizzaria.Models;

#line default
#line hidden
#line 3 "C:\Users\izaias\Documents\GitHub\SistemaPizzaria2\SistemaWebPizzaria\Views\_ViewImports.cshtml"
using SistemaWebPizzaria.Models.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\izaias\Documents\GitHub\SistemaPizzaria2\SistemaWebPizzaria\Views\Home\MenuSistema.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8e5ecba0d556efe44a79a09e09ac876f0664f3a", @"/Views/Home/MenuSistema.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7a64b0f2b1af7acb52ba994ab904de62e595e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MenuSistema : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\izaias\Documents\GitHub\SistemaPizzaria2\SistemaWebPizzaria\Views\Home\MenuSistema.cshtml"
  ViewData["Title"] = "Menu";

#line default
#line hidden
            BeginContext(116, 1651, true);
            WriteLiteral(@"
<style>
    .btn-menu {
        padding: 20px;
        background-color: transparent;
        color: #ac2925;
    }

        .btn-menu:hover {
            background-color: #ac2925;
            color: white;
        }

    .icone-menu {
        font-size: 50px;
        text-align: center;
        vertical-align: middle;
    }

        .icone-menu:hover {
            /*font-size: 70px;*/
        }

    .font-menu {
        font-size: 20px;
        font-weight: bold;
    }
</style>


<div class=""container"">
    <div class=""row col-md-offset-2"">
        <div class=""col-lg-3 text-center"">
            <div class=""row"">
                <a class=""btn btn-danger btn-menu"" href=""../Clientes/Lista"" role=""button"">
                    <i class=""material-icons icone-menu"">person_add</i>
                </a>
            </div>
            <span class=""font-menu"">Clientes</span>
        </div>

        <div class=""col-lg-3 text-center"">
            <div class=""row"">
              ");
            WriteLiteral(@"  <a class=""btn btn-danger btn-menu"" href=""../Cardapios/Index"" role=""button"">
                    <i class=""material-icons icone-menu"">local_pizza</i>
                </a>
            </div>
            <span class=""font-menu"">Cardápio</span>
        </div>

        <div class=""col-lg-3 text-center"">
            <div class=""row"">
                <a class=""btn btn-danger btn-menu"" href=""../Pedidos/Index"" role=""button"">
                    <i class=""material-icons icone-menu"">list_alt</i>
                </a>
            </div>
            <span class=""font-menu"">Pedidos</span>
        </div>

    </div>
");
            EndContext();
#line 64 "C:\Users\izaias\Documents\GitHub\SistemaPizzaria2\SistemaWebPizzaria\Views\Home\MenuSistema.cshtml"
      
        if (HttpContextAccessor.HttpContext.Session.GetString("Perfil") == "A")
        {

#line default
#line hidden
            BeginContext(1867, 1824, true);
            WriteLiteral(@"            <div class=""row col-md-offset-2"">
                <div class=""col-lg-3 text-center"">
                    <div class=""row"">
                        <a class=""btn btn-danger btn-menu"" href=""../Funcionarios/Index"" role=""button"">
                            <i class=""material-icons icone-menu"">add_business</i>
                        </a>
                    </div>
                    <span class=""font-menu"">Funcionários</span>
                </div>


                <div class=""col-lg-3 text-center"">
                    <div class=""row"">
                        <a class=""btn btn-danger btn-menu"" href=""../Produtos/Index"" role=""button"">
                            <i class=""material-icons icone-menu"">content_paste</i>
                        </a>
                    </div>
                    <span class=""font-menu"">Produtos</span>
                </div>

                <div class=""col-lg-3 text-center"">
                    <div class=""row"">
                        <a class=""btn");
            WriteLiteral(@" btn-danger btn-menu"" href=""../Despesas/Index"" role=""button"">
                            <i class=""material-icons icone-menu"">monetization_on</i>
                        </a>
                    </div>
                    <span class=""font-menu"">Despesas</span>
                </div>
            </div>
            <div class=""row col-md-offset-2"">
                <div class=""col-lg-3 text-center"">
                    <div class=""row"">
                        <a class=""btn btn-danger btn-menu"" href=""../Relatorios/Ganho"" role=""button"">
                            <i class=""material-icons icone-menu"">assessment</i>
                        </a>
                    </div>
                    <span class=""font-menu"">Relatórios</span>
                </div>

            </div>
");
            EndContext();
#line 107 "C:\Users\izaias\Documents\GitHub\SistemaPizzaria2\SistemaWebPizzaria\Views\Home\MenuSistema.cshtml"

        }
    

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
