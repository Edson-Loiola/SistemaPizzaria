#pragma checksum "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc4d794103099b295cc6eed733f3dd93328c9a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Index), @"mvc.1.0.view", @"/Views/Funcionarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionarios/Index.cshtml", typeof(AspNetCore.Views_Funcionarios_Index))]
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
#line 1 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\_ViewImports.cshtml"
using SistemaWebPizzaria;

#line default
#line hidden
#line 2 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\_ViewImports.cshtml"
using SistemaWebPizzaria.Models;

#line default
#line hidden
#line 3 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\_ViewImports.cshtml"
using SistemaWebPizzaria.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4d794103099b295cc6eed733f3dd93328c9a2e", @"/Views/Funcionarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7a64b0f2b1af7acb52ba994ab904de62e595e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaWebPizzaria.Models.Funcionario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inativa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
  ViewData["Title"] = "Funcionarios Cadastradas";

#line default
#line hidden
            BeginContext(117, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(124, 17, false);
#line 7 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(141, 26, true);
            WriteLiteral("</h2>\r\n<hr />\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(167, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a555f89c2af940a2bb94fd9505734876", async() => {
                BeginContext(221, 16, true);
                WriteLiteral("Novo Funcionário");
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
            BeginContext(241, 1046, true);
            WriteLiteral(@"
</p>

<div class=""table-bordered"">
    <table class=""table table-striped table-hover"" border=""1"" style=""border-color:#9a9a9a"">
        <thead>
            <tr class=""bg-warning"">
                <th>
                    <label class=""control-label text-center"">Nome do Funcionário</label>
                </th>
                <th>
                    <label class=""control-label"">CPF:</label>
                </th>
                <th>
                    <label class=""control-label"">Email:</label>
                </th>
                <th>
                    <label class=""control-label"">Celular:</label>
                </th>
                <th>
                    <label class=""control-label"">Salario:</label>
                </th>
                <th>
                    <label class=""control-label"">Status:</label>
                </th>
                <th>
                    <label class=""control-label"">Senha Padrão:</label>
                </th>
            </tr>
        </the");
            WriteLiteral("ad>\r\n        <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1350, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1411, 39, false);
#line 46 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1518, 38, false);
#line 49 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1556, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1624, 40, false);
#line 52 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1732, 42, false);
#line 55 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1842, 42, false);
#line 58 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1952, 40, false);
#line 61 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 64 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                      
                        if(item.IdLoginNavigation != null) { 
                            if (item.IdLoginNavigation.SenhaPadrao == "S")
                            {
                                

#line default
#line hidden
            BeginContext(2266, 58, false);
#line 68 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdLoginNavigation.Senha));

#line default
#line hidden
            EndContext();
#line 68 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                                                                           
                            }
                        }

                    

#line default
#line hidden
            BeginContext(2409, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2474, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf29ea0d6fa244e684af83654e3f52ee", async() => {
                BeginContext(2561, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                                                          WriteLiteral(item.IdFuncionario);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2571, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 76 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                       if (item.Ativo == "S")
                        {

#line default
#line hidden
            BeginContext(2647, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2671, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdc0363a6e14304aa1031aefa9b877d", async() => {
                BeginContext(2761, 8, true);
                WriteLiteral("Inativar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                                                                 WriteLiteral(item.IdFuncionario);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2773, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 78 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                                                                                                                                                                                 
                            }
                        

#line default
#line hidden
            BeginContext(2900, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 83 "C:\Users\wellison\Documents\GitHub\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2984, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaWebPizzaria.Models.Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591