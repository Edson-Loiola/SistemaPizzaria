#pragma checksum "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81ab3a3e1bc9808c663793538afee6c86ec8624c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorios_Saida), @"mvc.1.0.view", @"/Views/Relatorios/Saida.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Relatorios/Saida.cshtml", typeof(AspNetCore.Views_Relatorios_Saida))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab3a3e1bc9808c663793538afee6c86ec8624c", @"/Views/Relatorios/Saida.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7a64b0f2b1af7acb52ba994ab904de62e595e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorios_Saida : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebPizzaria.Models.ViewModels.RelatoriosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Relatorios/Entrada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Relatorios/Saida", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Relatorios/Ganho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Home/MenuSistema", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal col-md-offset-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Saida", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(67, 242, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container-fluid\">\r\n\r\n    <h2>Total de Saídas</h2>\r\n    <hr />\r\n    <div class=\"row col-md-12\">\r\n\r\n        <div class=\"col-sm-2 col-md-2 sidebar\">\r\n            <ul class=\"nav nav-sidebar\">\r\n                <li class=\"active\">");
            EndContext();
            BeginContext(309, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9708b9e097a74aa3b2ac1acaa9046c8d", async() => {
                BeginContext(347, 47, true);
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
            BeginContext(398, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(425, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcf9c93f4407413b816c07d8e99cd24a", async() => {
                BeginContext(461, 6, true);
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
            BeginContext(471, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(498, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1275ea25fd3e4688b97f6be8e140fb6a", async() => {
                BeginContext(534, 6, true);
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
            BeginContext(544, 28, true);
            WriteLiteral("</li>\r\n                <li> ");
            EndContext();
            BeginContext(572, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18263dda9365418ca06e1aea32c0a0dd", async() => {
                BeginContext(608, 4, true);
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
            BeginContext(616, 129, true);
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n\r\n        <div class=\"col-sm-6 col-sm-offset-3 col-md-9 col-md-offset-0\">\r\n            ");
            EndContext();
            BeginContext(745, 801, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57d36712214544bba293b91a8b9eda6e", async() => {
                BeginContext(810, 204, true);
                WriteLiteral("\r\n                <fieldset>\r\n                    <div class=\"col-md-4\">\r\n                        <label>Data Início</label>\r\n                        <input type=\"date\" name=\"minDate\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1014, "", 1041, 1);
#line 26 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
WriteAttributeValue("", 1021, ViewData["minDate"], 1021, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1041, 205, true);
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\" col-md-4\">\r\n                        <label>Data Fim</label>\r\n                        <input type=\"date\" name=\"maxDate\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1246, "", 1273, 1);
#line 30 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
WriteAttributeValue("", 1253, ViewData["maxDate"], 1253, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1273, 266, true);
                WriteLiteral(@" />
                    </div>
                    <div class=""col-md-4"">
                        <br />
                        <button type=""submit"" class=""btn btn-primary "">Submit</button>
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
            BeginContext(1546, 226, true);
            WriteLiteral("<br />\r\n            <div class=\"img-rounded col-md-12 text-center\" style=\"box-shadow: #505050 0px 1px 5px; background-color: #ff6666\">\r\n                <br />\r\n                <h1  style=\"color:#424242; font-family:Impact\">R$ ");
            EndContext();
            BeginContext(1774, 96, false);
#line 40 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                                                              Write((Model.Despesas.Sum(x => x.Valor) + Model.Produtoestoque.Sum(x => x.PrecoCompra)).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 864, true);
            WriteLiteral(@"</h1>
                <br /><br />
            </div>

        </div>
    </div>

    <div class=""col-sm-6 col-sm-offset-3 col-md-9 col-md-offset-2"">
        <br />
        <table class=""table table-bordered table-hover"">
            <thead>
                <tr class="""">
                    <th>
                        <label class=""control-label text-center"">Nome da Despesa</label>
                    </th>
                    <th>
                        <label class=""control-label"">Valor (R$)</label>
                    </th>
                    <th>
                        <label class=""control-label"">Descrição</label>
                    </th>
                    <th>
                        <label class=""control-label"">Data</label>
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 67 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                 foreach (var item in Model.Despesas)
                {

#line default
#line hidden
            BeginContext(2809, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2894, 46, false);
#line 71 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NomeDespesa));

#line default
#line hidden
            EndContext();
            BeginContext(2940, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3032, 40, false);
#line 74 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(3072, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3164, 44, false);
#line 77 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(3208, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3300, 46, false);
#line 80 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataDespesa));

#line default
#line hidden
            EndContext();
            BeginContext(3346, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 83 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                }

#line default
#line hidden
            BeginContext(3425, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 85 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                 foreach (var item in Model.Produtoestoque)
                {

#line default
#line hidden
            BeginContext(3507, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3592, 39, false);
#line 89 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3631, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3723, 46, false);
#line 92 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PrecoCompra));

#line default
#line hidden
            EndContext();
            BeginContext(3769, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3861, 44, false);
#line 95 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(3905, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3997, 45, false);
#line 98 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataCompra));

#line default
#line hidden
            EndContext();
            BeginContext(4042, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 101 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                }

#line default
#line hidden
            BeginContext(4121, 70, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
