#pragma checksum "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be055b06759ce5403e90a9d2910be13901e7883"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be055b06759ce5403e90a9d2910be13901e7883", @"/Views/Relatorios/Saida.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7a64b0f2b1af7acb52ba994ab904de62e595e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorios_Saida : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebPizzaria.Models.ViewModels.RelatoriosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Relatorios/Entrada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Relatorios/Saida", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Relatorios/Ganho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Home/MenuSistema", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal col-md-offset-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(67, 246, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <h2>Saída</h2>\r\n    <hr />\r\n    <div class=\"row col-md-12\">\r\n        <div class=\"col-sm-2 col-md-2 sidebar\">\r\n            <ul class=\"nav nav-sidebar\">\r\n                <li class=\"active btn-outline-primary\">");
            EndContext();
            BeginContext(313, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ce807f18a464ba4aa49e5f8ef73ccb3", async() => {
                BeginContext(351, 47, true);
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
            BeginContext(402, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(429, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "429316467cd74987873921e1e65ce8e0", async() => {
                BeginContext(465, 6, true);
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
            BeginContext(475, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(502, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20898a127014a3b91682590d80912d9", async() => {
                BeginContext(538, 6, true);
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
            BeginContext(548, 28, true);
            WriteLiteral("</li>\r\n                <li> ");
            EndContext();
            BeginContext(576, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f16cba639a54ec2a31aa375f4e2a154", async() => {
                BeginContext(612, 4, true);
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
            BeginContext(620, 166, true);
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n\r\n        <div class=\"col-sm-6 col-sm-offset-3 col-md-9 col-md-offset-0\">\r\n\r\n            <div class=\"row\">\r\n                ");
            EndContext();
            BeginContext(786, 833, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eeda2fb6e54147aeaf491f5ade29b2f7", async() => {
                BeginContext(851, 82, true);
                WriteLiteral("\r\n                    <fieldset>\r\n                        <div class=\"col-md-4\">\r\n");
                EndContext();
                BeginContext(993, 82, true);
                WriteLiteral("                            <input type=\"date\" name=\"minDate\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1075, "", 1102, 1);
#line 25 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
WriteAttributeValue("", 1082, ViewData["minDate"], 1082, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1102, 86, true);
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\" col-md-4\">\r\n");
                EndContext();
                BeginContext(1245, 82, true);
                WriteLiteral("                            <input type=\"date\" name=\"maxDate\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1327, "", 1354, 1);
#line 29 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
WriteAttributeValue("", 1334, ViewData["maxDate"], 1334, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1354, 258, true);
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
            BeginContext(1619, 428, true);
            WriteLiteral(@"
            </div><br />

            <div class=""row"">
                <div class=""img-rounded col-md-8 text-center col-md-offset-2"" style=""box-shadow: #505050 0px 1px 5px; background-color: #ff6666"">
                    <br />
                    <span style=""color:#424242; font-family:Verdana; font-size:medium"">Valor de saída com despesas</span>
                    <h1 style=""color:#424242; font-family:Impact"">R$ ");
            EndContext();
            BeginContext(2049, 96, false);
#line 42 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                                                                 Write((Model.Despesas.Sum(d => d.Valor) + Model.Produtoestoque.Sum(x => x.PrecoCompra)).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(2146, 954, true);
            WriteLiteral(@"</h1>
                    <br />
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
#line 69 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                     foreach (var item in Model.Despesas)
                    {

#line default
#line hidden
            BeginContext(3182, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3279, 46, false);
#line 73 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NomeDespesa));

#line default
#line hidden
            EndContext();
            BeginContext(3325, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3429, 40, false);
#line 76 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(3469, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3573, 44, false);
#line 79 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(3617, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3721, 46, false);
#line 82 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DataDespesa));

#line default
#line hidden
            EndContext();
            BeginContext(3767, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 85 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                    }

#line default
#line hidden
            BeginContext(3858, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 87 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                     foreach (var item in Model.Produtoestoque)
                    {

#line default
#line hidden
            BeginContext(3948, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4045, 39, false);
#line 91 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(4084, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4188, 46, false);
#line 94 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PrecoCompra));

#line default
#line hidden
            EndContext();
            BeginContext(4234, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4338, 44, false);
#line 97 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(4382, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4486, 45, false);
#line 100 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DataCompra));

#line default
#line hidden
            EndContext();
            BeginContext(4531, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 103 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Relatorios\Saida.cshtml"
                    }

#line default
#line hidden
            BeginContext(4622, 88, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
