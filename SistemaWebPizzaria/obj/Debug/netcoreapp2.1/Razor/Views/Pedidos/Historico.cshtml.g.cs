#pragma checksum "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d843e708f480389f4c39f65724ce10cfe6e82658"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Historico), @"mvc.1.0.view", @"/Views/Pedidos/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedidos/Historico.cshtml", typeof(AspNetCore.Views_Pedidos_Historico))]
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
#line 7 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d843e708f480389f4c39f65724ce10cfe6e82658", @"/Views/Pedidos/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7a64b0f2b1af7acb52ba994ab904de62e595e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaWebPizzaria.Models.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-offset-6 right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Historico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
  ViewData["Title"] = "Histórico de Pedidos";

#line default
#line hidden
            BeginContext(104, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(194, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
  
    if (HttpContextAccessor.HttpContext.Session.GetString("Usuario") == null)
    {

#line default
#line hidden
            BeginContext(288, 88, true);
            WriteLiteral("        <script>\r\n            window.location.href = \"/Home/Index\";\r\n        </script>\r\n");
            EndContext();
#line 17 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"

    }

#line default
#line hidden
            BeginContext(388, 10, true);
            WriteLiteral("\r\n\r\n\r\n<h2>");
            EndContext();
            BeginContext(399, 17, false);
#line 23 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(416, 70, true);
            WriteLiteral("</h2>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(486, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8345fe67cc7423eb6df4012bfd52825", async() => {
                BeginContext(539, 6, true);
                WriteLiteral("Pedido");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(549, 97, true);
            WriteLiteral("\r\n        <a href=\"../Home/MenuSistema\" class=\"btn btn-primary btn-lg\">Home</a>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(646, 566, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76d85cc153ea4c3c9f2de5e8d37b3e78", async() => {
                BeginContext(705, 128, true);
                WriteLiteral("\r\n        <fieldset>\r\n            <div class=\"col-md-4\">\r\n                <input type=\"date\" name=\"minDate\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 833, "", 860, 1);
#line 33 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
WriteAttributeValue("", 840, ViewData["minDate"], 840, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(860, 132, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\" col-md-4\">\r\n                <input type=\"date\" name=\"maxDate\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 992, "", 1019, 1);
#line 36 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
WriteAttributeValue("", 999, ViewData["maxDate"], 999, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1019, 186, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <button type=\"submit\" class=\"btn btn-primary \">Buscar</button>\r\n            </div>\r\n        </fieldset>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1212, 1243, true);
            WriteLiteral(@"
</div>
<br />
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-striped table-bordered table-hover"">
            <thead>
                <tr>
                    <th>
                        <label class=""control-label"">Id</label>
                    </th>
                    <th>
                        <label class=""control-label"">Data</label>
                    </th>
                    <th>
                        <label class=""control-label"">Tipo de entrega</label>
                    </th>
                    <th>
                        <label class=""control-label"">Forma de pagamento</label>
                    </th>
                    <th>
                        <label class=""control-label"">Funcionário</label>
                    </th>
                    <th>
                        <label class=""control-label"">Cliente</label>
                    </th>
                    <th>
                        <label class=""control-label"">Total</labe");
            WriteLiteral("l>\r\n                    </th>\r\n                    <th>\r\n                        <label class=\"control-label\">Status</label>\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 77 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
                 foreach (var item in Model.OrderByDescending(x => x.IdPedido))
                {

#line default
#line hidden
            BeginContext(2555, 23, true);
            WriteLiteral("                    <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2578, "\"", 2628, 1);
#line 79 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
WriteAttributeValue("", 2586, Html.DisplayFor(modelItem => item.Status), 2586, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2629, 61, true);
            WriteLiteral(">\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2691, 43, false);
#line 81 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdPedido));

#line default
#line hidden
            EndContext();
            BeginContext(2734, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2826, 43, false);
#line 84 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataHora));

#line default
#line hidden
            EndContext();
            BeginContext(2869, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2961, 46, false);
#line 87 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TipoEntrega));

#line default
#line hidden
            EndContext();
            BeginContext(3007, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3099, 49, false);
#line 90 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FormaPagamento));

#line default
#line hidden
            EndContext();
            BeginContext(3148, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3240, 62, false);
#line 93 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdFuncioarioNavigation.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3302, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3394, 59, false);
#line 96 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdClienteNavigation.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3453, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3545, 46, false);
#line 99 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TotalPedido));

#line default
#line hidden
            EndContext();
            BeginContext(3591, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3683, 41, false);
#line 102 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3724, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 105 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Pedidos\Historico.cshtml"
                }

#line default
#line hidden
            BeginContext(3803, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaWebPizzaria.Models.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
