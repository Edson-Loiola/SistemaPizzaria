#pragma checksum "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Entrada.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e04d8c84dd84729478a560e8ea943ebc39d5afb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorios_Entrada), @"mvc.1.0.view", @"/Views/Relatorios/Entrada.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Relatorios/Entrada.cshtml", typeof(AspNetCore.Views_Relatorios_Entrada))]
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
#line 1 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\_ViewImports.cshtml"
using SistemaWebPizzaria;

#line default
#line hidden
#line 2 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\_ViewImports.cshtml"
using SistemaWebPizzaria.Models;

#line default
#line hidden
#line 3 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\_ViewImports.cshtml"
using SistemaWebPizzaria.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e04d8c84dd84729478a560e8ea943ebc39d5afb", @"/Views/Relatorios/Entrada.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7a64b0f2b1af7acb52ba994ab904de62e595e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorios_Entrada : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebPizzaria.Models.ViewModels.RelatoriosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Relatorios/Entrada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Relatorios/Saida", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Relatorios/Ganho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Home/MenuSistema", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal col-md-offset-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Entrada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(67, 249, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <h2>Entradas</h2>\r\n    <hr />\r\n    <div class=\"row col-md-12\">\r\n        <div class=\"col-sm-2 col-md-2 sidebar\">\r\n            <ul class=\"nav nav-sidebar\">\r\n                <li class=\"active btn-outline-primary\">");
            EndContext();
            BeginContext(316, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "391c222161f848a0b20f0a73c91e057e", async() => {
                BeginContext(354, 47, true);
                WriteLiteral("Entradas <span class=\"sr-only\">(current)</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(405, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(432, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58d383a512114752bee7748a750f70d4", async() => {
                BeginContext(468, 6, true);
                WriteLiteral("Saídas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(478, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(505, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d65cf3f7b44c688c9544f5da3e799a", async() => {
                BeginContext(541, 6, true);
                WriteLiteral("Ganhos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(551, 28, true);
            WriteLiteral("</li>\r\n                <li> ");
            EndContext();
            BeginContext(579, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebebbe73377249aba61aa7059b0be974", async() => {
                BeginContext(615, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(623, 166, true);
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n\r\n        <div class=\"col-sm-6 col-sm-offset-3 col-md-9 col-md-offset-0\">\r\n\r\n            <div class=\"row\">\r\n                ");
            EndContext();
            BeginContext(789, 835, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55f1ac82cd14dc9ab9999809c7be0ef", async() => {
                BeginContext(856, 82, true);
                WriteLiteral("\r\n                    <fieldset>\r\n                        <div class=\"col-md-4\">\r\n");
                EndContext();
                BeginContext(998, 82, true);
                WriteLiteral("                            <input type=\"date\" name=\"minDate\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1080, "", 1107, 1);
#line 25 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Entrada.cshtml"
WriteAttributeValue("", 1087, ViewData["minDate"], 1087, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1107, 86, true);
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\" col-md-4\">\r\n");
                EndContext();
                BeginContext(1250, 82, true);
                WriteLiteral("                            <input type=\"date\" name=\"maxDate\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1332, "", 1359, 1);
#line 29 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Entrada.cshtml"
WriteAttributeValue("", 1339, ViewData["maxDate"], 1339, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1359, 258, true);
                WriteLiteral(@" />
                        </div>
                        <div class=""col-md-4"">
                            <button type=""submit"" class=""btn btn-primary "">Buscar</button>
                        </div>
                    </fieldset>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1624, 429, true);
            WriteLiteral(@"
            </div><br />

            <div class=""row"">
                <div class=""img-rounded col-md-8 text-center col-md-offset-2"" style=""box-shadow: #505050 0px 1px 5px; background-color: #ffea75"">
                    <br />
                    <span style=""color:#424242; font-family:Verdana; font-size:medium"">Valor de entrada com vendas</span>
                    <h1 style=""color:#424242; font-family:Impact""> R$ ");
            EndContext();
            BeginContext(2055, 98, false);
#line 42 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Entrada.cshtml"
                                                                  Write(Model.Pedidos.Where(x => x.Status == "Finalizado").Sum(p => (double) p.TotalPedido).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(2154, 425, true);
            WriteLiteral(@"</h1> <br />
                </div>
            </div><br />

            <div class=""row col-md-offset-2"">
                <div class=""img-rounded col-md-4 text-center"" style=""box-shadow: #505050 0px 1px 5px; background-color: #fff"">

                    <span style=""color:#424242; font-family:Verdana; font-size:medium"">Pedidos Finalizados</span>
                    <h2 style=""color:#2b42c7; font-family:Impact""> ");
            EndContext();
            BeginContext(2581, 58, false);
#line 50 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Entrada.cshtml"
                                                               Write(Model.Pedidos.Where(x => x.Status == "Finalizado").Count());

#line default
#line hidden
            EndContext();
            BeginContext(2640, 359, true);
            WriteLiteral(@" </h2>
                </div>

                <div class=""img-rounded col-md-4 text-center col-lg-offset-1"" style=""box-shadow: #505050 0px 1px 5px; background-color: #fff"">
                    <span style=""color:#424242; font-family:Verdana; font-size:medium"">Pedidos Cancelados</span>
                    <h2 style=""color:#f54f4f; font-family:Impact""> ");
            EndContext();
            BeginContext(3001, 57, false);
#line 55 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Entrada.cshtml"
                                                               Write(Model.Pedidos.Where(x => x.Status == "Cancelado").Count());

#line default
#line hidden
            EndContext();
            BeginContext(3059, 92, true);
            WriteLiteral(" </h2>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(5492, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaWebPizzaria.Models.ViewModels.RelatoriosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
