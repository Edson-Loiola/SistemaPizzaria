#pragma checksum "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c902ebee4e043c3b6432ee1b01cca0b420ce00a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c902ebee4e043c3b6432ee1b01cca0b420ce00a", @"/Views/Funcionarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7a64b0f2b1af7acb52ba994ab904de62e595e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaWebPizzaria.Models.Funcionario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Home/MenuSistema", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inativa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
  ViewData["Title"] = "Funcionarios Cadastrados";

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09ce8d87f6c04c80848c8140e6df0e6e", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cf526f5c16748f2941bc6a7f94d74fe", async() => {
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
            BeginContext(322, 1327, true);
            WriteLiteral(@"
</p>

<div >
    <table class=""table table-bordered table-hover""  style=""border-color:#9a9a9a"">
        <thead>
            <tr class=""bg-primary"">
                <th>
                    <label class=""control-label text-center"">Nome</label>
                </th>
                <th>
                    <label class=""control-label"">CPF</label>
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
                    <label class=""control-label"">Cadastro</label>
                </th>
                <th>
                    <label class=""control-label"">Senha Padrão</label");
            WriteLiteral(@">
                </th>
                <th>
                    <label class=""control-label"">Inativação</label>
                </th>
                <th>
                    <label class=""control-label"">Ações</label>
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 52 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
               foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1712, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1797, 39, false);
#line 56 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1928, 38, false);
#line 59 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1966, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2058, 39, false);
#line 62 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(2097, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2189, 40, false);
#line 65 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2321, 42, false);
#line 68 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(2363, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2455, 42, false);
#line 71 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(2497, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2589, 47, false);
#line 74 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(2636, 63, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 77 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                              
                                if (item.IdLoginNavigation != null)
                                {
                                    if (item.IdLoginNavigation.SenhaPadrao == "S")
                                    {
                                        

#line default
#line hidden
            BeginContext(2999, 58, false);
#line 82 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdLoginNavigation.Senha));

#line default
#line hidden
            EndContext();
#line 82 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                                                                                   
                                    }
                                }

                            

#line default
#line hidden
            BeginContext(3166, 89, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3256, 49, false);
#line 89 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataInativacao));

#line default
#line hidden
            EndContext();
            BeginContext(3305, 65, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n\r\n");
            EndContext();
#line 93 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                               if (item.Ativo == "S")
                                {

#line default
#line hidden
            BeginContext(3460, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(3496, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77c74bb88b1b42c48b68e3ae2b692add", async() => {
                BeginContext(3583, 40, true);
                WriteLiteral("<span class=\"material-icons\">edit</span>");
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
#line 95 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
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
            BeginContext(3627, 113, true);
            WriteLiteral("\r\n                                    <a class=\"btn btn-danger btn-sm\" data-toggle=\"modal\" data-target=\"#myModal-");
            EndContext();
            BeginContext(3741, 18, false);
#line 96 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                                                                                          Write(item.IdFuncionario);

#line default
#line hidden
            EndContext();
            BeginContext(3759, 63, true);
            WriteLiteral("\"><span class=\"material-icons\">person_add_disabled</span></a>\r\n");
            EndContext();
#line 97 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(3888, 101, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n                    <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3989, "\"", 4021, 2);
            WriteAttributeValue("", 3994, "myModal-", 3994, 8, true);
#line 101 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 4002, item.IdFuncionario, 4002, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4022, 777, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h3 class=""modal-title"" id=""myModalLabel"">Atenção</h3>
                                </div>
                                <div class=""modal-body"">
                                    <p>Deseja mesmo inativar este Funcionário?</p>
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-success"" data-dismiss=""modal"">voltar</button>
                                    ");
            EndContext();
            BeginContext(4799, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fb5b722231a4fb1a7591dd6b38614d0", async() => {
                BeginContext(4881, 8, true);
                WriteLiteral("Inativar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                                                              WriteLiteral(item.IdFuncionario);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4893, 138, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 117 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Funcionarios\Index.cshtml"
                }

            

#line default
#line hidden
            BeginContext(5067, 40, true);
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
