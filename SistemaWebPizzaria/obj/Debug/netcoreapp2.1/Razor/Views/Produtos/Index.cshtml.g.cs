#pragma checksum "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f52ef5027449397675a5af04913e45a491b8600"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Index), @"mvc.1.0.view", @"/Views/Produtos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/Index.cshtml", typeof(AspNetCore.Views_Produtos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f52ef5027449397675a5af04913e45a491b8600", @"/Views/Produtos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7a64b0f2b1af7acb52ba994ab904de62e595e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaWebPizzaria.Models.Produtoestoque>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarProdPeloNome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProduto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
  ViewData["Title"] = "Produtos";

#line default
#line hidden
            BeginContext(102, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(109, 17, false);
#line 6 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(126, 40, true);
            WriteLiteral("</h2>\r\n<hr />  \r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(166, 366, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39714a7012644186a7c951f61c90a3b7", async() => {
                BeginContext(218, 307, true);
                WriteLiteral(@"
        <div class=""col-md-10 input-group-lg"">
            <input class=""form-control"" type=""text"" name=""nomeprod""  placeholder=""Buscar produto"">
        </div>
        <div class=""col-md-2"">
            <button class=""btn btn-info btn-block btn-lg"" type=""submit"">Buscar</button>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(532, 74, true);
            WriteLiteral("\r\n</div>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            EndContext();
            BeginContext(606, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e3f7de9f80748e0827c17af80e4e5c2", async() => {
                BeginContext(661, 16, true);
                WriteLiteral("Cadatrar Produto");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(681, 1237, true);
            WriteLiteral(@"
        <a href=""../Home/MenuSistema"" class=""btn btn-danger btn-lg pull-right"">Voltar</a>
    </div>
</div>
<br />
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-striped table-bordered table-hover"">
            <thead>
                <tr>
                    <th>
                        <label class=""control-label text-center"">ID</label>
                    </th>
                    <th>
                        <label class=""control-label text-center"">Nome da Despesa</label>
                    </th>
                    <th>
                        <label class=""control-label"">Valor (R$)</label>
                    </th>
                    <th>
                        <label class=""control-label"">Estoq</label>
                    </th>
                    <th>
                        <label class=""control-label"">Marca</label>
                    </th>
                    <th>
                        <label class=""control-label"">Descrição</label>
 ");
            WriteLiteral("                   </th>\r\n                    <th>\r\n                        <label class=\"control-label\">Ações</label>\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 55 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1983, 93, true);
            WriteLiteral("                    <tr>\r\n                        <td readonly>\r\n                            ");
            EndContext();
            BeginContext(2077, 44, false);
#line 59 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdProduto));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2213, 39, false);
#line 62 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2252, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2344, 45, false);
#line 65 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PrecoVenda));

#line default
#line hidden
            EndContext();
            BeginContext(2389, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2481, 45, false);
#line 68 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(2526, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2528, 48, false);
#line 68 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.UnidadeMedida));

#line default
#line hidden
            EndContext();
            BeginContext(2576, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2668, 40, false);
#line 71 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(2708, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2800, 44, false);
#line 74 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2844, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2935, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e16f55b3ff6a4c29abdab750301cbdfb", async() => {
                BeginContext(3021, 40, true);
                WriteLiteral("<span class=\"material-icons\">edit</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                                     WriteLiteral(item.IdProduto);

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
            BeginContext(3065, 105, true);
            WriteLiteral("\r\n                            <a class=\"btn btn-danger btn-sm\" data-toggle=\"modal\" data-target=\"#myModal-");
            EndContext();
            BeginContext(3171, 14, false);
#line 78 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                                                  Write(item.IdProduto);

#line default
#line hidden
            EndContext();
            BeginContext(3185, 187, true);
            WriteLiteral("\"><span class=\"material-icons\">delete</span></a>\r\n                        </td>\r\n                    </tr>\r\n                    <!-- Modal -->\r\n                    <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3372, "\"", 3400, 2);
            WriteAttributeValue("", 3377, "myModal-", 3377, 8, true);
#line 82 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
WriteAttributeValue("", 3385, item.IdProduto, 3385, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3401, 490, true);
            WriteLiteral(@" role=""dialog"" aria-labelledby=""myModalLabel"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h3 class=""modal-title"" id=""myModalLabel"">Atenção</h3>
                                </div>
                                <div class=""modal-body"">
                                    <p>Deseja mesmo deletar o item ");
            EndContext();
            BeginContext(3892, 14, false);
#line 89 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                              Write(item.IdProduto);

#line default
#line hidden
            EndContext();
            BeginContext(3906, 263, true);
            WriteLiteral(@"?</p>
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-success"" data-dismiss=""modal"">voltar</button>
                                    ");
            EndContext();
            BeginContext(4169, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a68db68b24c0447ea66f97b2083f9f90", async() => {
                BeginContext(4253, 7, true);
                WriteLiteral("Deletar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                    WriteLiteral(item.IdProduto);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4264, 138, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 98 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4421, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaWebPizzaria.Models.Produtoestoque>> Html { get; private set; }
    }
}
#pragma warning restore 1591
