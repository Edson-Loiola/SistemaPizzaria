#pragma checksum "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e132e36d7abf877b1053104d48d1a8e7f7d18270"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e132e36d7abf877b1053104d48d1a8e7f7d18270", @"/Views/Funcionarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7a64b0f2b1af7acb52ba994ab904de62e595e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaWebPizzaria.Models.Funcionario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Home/MenuSistema", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inativa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
  ViewData["Title"] = "Funcionarios Cadastradas";

#line default
#line hidden
            BeginContext(117, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(124, 17, false);
#line 7 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(141, 26, true);
            WriteLiteral("</h2>\r\n<hr />\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(167, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab7d53344734ba6b0503b131292758e", async() => {
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
            BeginContext(241, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(247, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac53eb9ba1f498d9141786053c8f5ed", async() => {
                BeginContext(314, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(322, 1150, true);
            WriteLiteral(@"
</p>

<div class=""table-bordered"">
    <table class=""table table-striped table-hover"" border=""1"" style=""border-color:#9a9a9a"">
        <thead>
            <tr class=""bg-primary"">
                <th>
                    <label class=""control-label text-center"">Nome do Funcionário</label>
                </th>
                <th>
                    <label class=""control-label"">Tipo</label>
                </th>
                <th>
                    <label class=""control-label"">Email</label>
                </th>
                <th>
                    <label class=""control-label"">Celular</label>
                </th>
                <th>
                    <label class=""control-label"">Salario</label>
                </th>
                <th>
                    <label class=""control-label"">Status</label>
                </th>
                <th>
                    <label class=""control-label"">Senha Padrão</label>
                </th>
                <th>
               ");
            WriteLiteral("     <label class=\"control-label\">Ações</label>\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1535, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1596, 39, false);
#line 50 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1703, 39, false);
#line 53 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1810, 40, false);
#line 56 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1850, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1918, 42, false);
#line 59 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2028, 42, false);
#line 62 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(2070, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2138, 40, false);
#line 65 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(2178, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 68 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                      
                        if(item.IdLoginNavigation != null) { 
                            if (item.IdLoginNavigation.SenhaPadrao == "S")
                            {
                                

#line default
#line hidden
            BeginContext(2452, 58, false);
#line 72 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdLoginNavigation.Senha));

#line default
#line hidden
            EndContext();
#line 72 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                                                                           
                            }
                        }

                    

#line default
#line hidden
            BeginContext(2595, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2660, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d8da95cb587482097163e5df843e2f7", async() => {
                BeginContext(2747, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
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
            BeginContext(2757, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 80 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                       if (item.Ativo == "S")
                        {

#line default
#line hidden
            BeginContext(2833, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2857, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c5359a38db43aea85eb1626d554057", async() => {
                BeginContext(2947, 8, true);
                WriteLiteral("Inativar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
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
            BeginContext(2959, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 82 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                                                                                                                                                                                 
                            }
                        

#line default
#line hidden
            BeginContext(3086, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 87 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(3170, 40, true);
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
