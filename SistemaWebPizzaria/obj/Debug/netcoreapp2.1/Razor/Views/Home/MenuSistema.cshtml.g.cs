<<<<<<< HEAD
#pragma checksum "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Home\MenuSistema.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29eb12ac4734fd95697f7b3691bd5c4fd5cb10bf"
=======
#pragma checksum "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Home\MenuSistema.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85093975882ba212517a0e875f1f27470a9d95c8"
>>>>>>> master
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
<<<<<<< HEAD
#line 1 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\_ViewImports.cshtml"
>>>>>>> master
using SistemaWebPizzaria;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\_ViewImports.cshtml"
>>>>>>> master
using SistemaWebPizzaria.Models;

#line default
#line hidden
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29eb12ac4734fd95697f7b3691bd5c4fd5cb10bf", @"/Views/Home/MenuSistema.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85093975882ba212517a0e875f1f27470a9d95c8", @"/Views/Home/MenuSistema.cshtml")]
>>>>>>> master
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6723b1cdb572f594cecf8d9a743ca2d0fc5f4aad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MenuSistema : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD
#line 1 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Home\MenuSistema.cshtml"
  ViewData["Title"] = "Menu";

#line default
#line hidden
            BeginContext(32, 2745, true);
            WriteLiteral(@"
<style>
    .btn-menu {
        padding: 20px;
        background-color: transparent;
        color: #ac2925;
    }
    .btn-menu:hover {
        background-color: #ac2925;
        color:white;
    }
    .icone-menu {
        font-size: 50px;
        text-align: center;
        vertical-align: middle;
    }
    .icone-menu:hover {
        /*font-size: 70px;*/
    }
    .font-menu{
        font-size:20px;
        font-weight:bold;
    }
</style>


<div class=""container"">
    <div class=""row col-md-offset-2"">
        <div class=""col-lg-3 text-center"">
            <div class=""row"">
                <a class=""btn btn-danger btn-menu"" href=""../Teste/Index"" role=""button"">
                    <i class=""material-icons icone-menu"">person_add</i>
                </a>
            </div>
            <span class=""font-menu"">Clientes</span>
        </div>

        <div class=""col-lg-3 text-center"">
            <div class=""row"">
                <a class=""btn btn-danger btn-menu"" href=""");
            WriteLiteral(@"../Teste/Index"" role=""button"">
                    <i class=""material-icons icone-menu"">local_pizza</i>
                </a>
            </div>
            <span class=""font-menu"">Cardápio</span>
        </div>

        <div class=""col-lg-3 text-center"">
            <div class=""row"">
                <a class=""btn btn-danger btn-menu"" href=""../Teste/StatusPed"" role=""button"">
                    <i class=""material-icons icone-menu"">list_alt</i>
                </a>
            </div>
            <span class=""font-menu"">Pedidos</span>
        </div>

    </div>
    <div class=""row col-md-offset-2"">
        <div class=""col-lg-3 text-center"">
            <div class=""row"">
                <a class=""btn btn-danger btn-menu"" href=""../Funcionarios/Create"" role=""button"">
                    <i class=""material-icons icone-menu"">add_business</i>
                </a>
            </div>
            <span class=""font-menu"">Funcionários</span>
        </div>


        <div class=""col-lg-3 text-cen");
            WriteLiteral(@"ter"">
            <div class=""row"">
                <a class=""btn btn-danger btn-menu"" href=""../Produtos/Index"" role=""button"">
                    <i class=""material-icons icone-menu"">content_paste</i>
                </a>
            </div>
            <span class=""font-menu"">Produtos</span>
        </div>

        <div class=""col-lg-3 text-center"">
            <div class=""row"">
                <a class=""btn btn-danger btn-menu"" href=""../Despesas/Index"" role=""button"">
                    <i class=""material-icons icone-menu"">monetization_on</i>
                </a>
            </div>
            <span class=""font-menu"">Despesas</span>
        </div>

    </div>
</div>
=======
            BeginContext(0, 3885, true);
            WriteLiteral(@"
<br />
<br />
<br />


    <div class=""container"">
        <div class=""row col-md-offset-2"">

            <div class=""col-lg-3 text-center"">
                <div class=""row"">
                    <a href=""../Clientes/Lista""> <svg class=""img-circle"" width=""140"" height=""140"" focusable=""false"" role=""img"" style=""box-shadow: #000000 0px 2px 10px""><rect width=""100%"" height=""100%"" fill=""#90EE90"" /></svg></a>
                </div>
                <span>Cadastro de Clientes</span>
            </div>


            <div class=""col-lg-3 text-center"">
                <div class=""row"">
                    <svg class=""img-circle"" width=""140"" height=""140"" focusable=""false"" role=""img"" style=""box-shadow: #000000 0px 2px 10px""><rect width=""100%"" height=""100%"" fill=""#90EE90"" /></svg>
                </div>
                <span>Cadastro de Pedidos</span>
            </div>

            <div class=""col-lg-3 text-center"">
                <div class=""row"">
                    <a href=""../Teste/StatusPed"">");
            WriteLiteral(@" <svg class=""img-circle"" width=""140"" height=""140"" focusable=""false"" role=""img"" style=""box-shadow: #000000 0px 2px 10px""><rect width=""100%"" height=""100%"" fill=""#90EE90"" /></svg> </a>
                </div>
                <span>Status do Pedido</span>
            </div>

        </div>
        <br />

        <div class=""row col-md-offset-2"">
            <div class=""col-lg-3 text-center"">
                <div class=""row"">
                    <a href=""../Funcionarios/CreateFuncionario"">  <svg class=""img-circle"" width=""140"" height=""140"" focusable=""false"" role=""img"" style=""box-shadow: #000000 0px 2px 10px""><rect width=""100%"" height=""100%"" fill=""#90EE90"" /></svg></a>
                </div>
                <span>Cadastro de Funcionários</span>
            </div>


            <div class=""col-lg-3 text-center"">
                <div class=""row"">
                    <a href=""../Teste/Produto"">  <svg class=""img-circle"" width=""140"" height=""140"" focusable=""false"" role=""img"" style=""box-shadow: #000000 0");
            WriteLiteral(@"px 2px 10px""><rect width=""100%"" height=""100%"" fill=""#90EE90"" /></svg></a>
                </div>
                <span>Cadastro de Produtos </span>
            </div>

            <div class=""col-lg-3 text-center"">
                <div class=""row"">
                    <a href=""../Despesas/Index""> <svg class=""img-circle"" width=""140"" height=""140"" focusable=""false"" role=""img"" style=""box-shadow: #000000 0px 2px 10px""><rect width=""100%"" height=""100%"" fill=""#90EE90"" /></svg></a>
                </div>
                <span>Cadastro de Despesas</span>
            </div>

        </div>
        <br />

        <div class=""row col-md-offset-2"">
            <div class=""col-lg-3 text-center"">
                <div class=""row"">
                    <svg class=""img-circle"" width=""140"" height=""140"" focusable=""false"" role=""img"" style=""box-shadow: #000000 0px 2px 10px""><rect width=""100%"" height=""100%"" fill=""#90EE90"" /></svg>
                </div>
                <span>Histórico de Pedido</span>
          ");
            WriteLiteral(@"  </div>
            <div class=""col-lg-3 text-center"">
                <div class=""row"">

                    <a href=""../Teste/Relatorio"">  <svg class=""img-circle"" width=""140"" height=""140"" focusable=""false"" role=""img"" style=""box-shadow: #000000 0px 2px 10px"">  <rect width=""100%"" height=""100%"" fill=""#90EE90"" /></svg></a>
                </div>
                <span>Relatórios</span>
            </div>


            <div class=""col-lg-3 text-center"">
                <div class=""row"">
                    <svg class=""img-circle"" width=""140"" height=""140"" focusable=""false"" role=""img"" style=""box-shadow: #000000 0px 2px 10px""><rect width=""100%"" height=""100%"" fill=""#90EE90"" /></svg>
                </div>
                <span>Meu Cardápio</span>
            </div>
        </div>
    </div>
>>>>>>> master
");
            EndContext();
        }
        #pragma warning restore 1998
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
