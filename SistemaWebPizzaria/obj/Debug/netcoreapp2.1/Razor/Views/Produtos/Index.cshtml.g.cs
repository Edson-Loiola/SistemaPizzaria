#pragma checksum "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4607faa59cd97ef86cd0073cd160cfe861bea6e7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4607faa59cd97ef86cd0073cd160cfe861bea6e7", @"/Views/Produtos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7a64b0f2b1af7acb52ba994ab904de62e595e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<SistemaWebPizzaria.Models.Produtoestoque>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../Home/MenuSistema", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarProdPeloNome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProdutosVencidos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EstoqueBaixo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProduto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
  ViewData["Title"] = "Produtos";

#line default
#line hidden
            BeginContext(111, 35, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>");
            EndContext();
            BeginContext(147, 17, false);
#line 7 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(164, 94, true);
            WriteLiteral("</h2>\r\n    <hr />\r\n    <div class=\"row md-12\">\r\n\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(258, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61a6bade50e040b6a7b7d0ecdae055e1", async() => {
                BeginContext(313, 17, true);
                WriteLiteral("Cadastrar Produto");
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
            BeginContext(334, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(348, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "647402d0895240b394fad1c881baba43", async() => {
                BeginContext(415, 4, true);
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
            BeginContext(423, 75, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-8 pull-right\">\r\n            ");
            EndContext();
            BeginContext(498, 421, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d9b254af344c49baec002059d0cef1", async() => {
                BeginContext(550, 362, true);
                WriteLiteral(@"
                <div class=""col-md-10 input-group-lg"">
                    <input class=""form-control"" type=""text"" name=""nomeprod"" placeholder=""Buscar produto"">
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(919, 54, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <hr />\r\n    <br />\r\n");
            EndContext();
            BeginContext(1000, 112, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"row col-md-12\">\r\n            <div class=\"col-md-9\">\r\n                ");
            EndContext();
            BeginContext(1112, 837, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dcfda6fb6f642bca76dafda33904b69", async() => {
                BeginContext(1162, 161, true);
                WriteLiteral("\r\n                    <a class=\"btn btn-default\" style=\"color:#ffffff; background-color:#b4b4b4; font-family:Verdana; font-size:large\"> Valor Total Estoque: (R$ ");
                EndContext();
                BeginContext(1325, 58, false);
#line 34 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                                                                                                           Write(Model.Sum(x => x.PrecoVenda * x.Quantidade).ToString("F2"));

#line default
#line hidden
                EndContext();
                BeginContext(1384, 161, true);
                WriteLiteral(")</a>\r\n                    <a class=\"btn btn-default\" style=\"color:#ffffff; background-color:#b4b4b4; font-family:Verdana; font-size:large\"> Total Cadastrados: (");
                EndContext();
                BeginContext(1547, 37, false);
#line 35 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                                                                                                      Write(Model.Select(x => x.Quantidade).Sum());

#line default
#line hidden
                EndContext();
                BeginContext(1585, 9, true);
                WriteLiteral(")</a>\r\n\r\n");
                EndContext();
                BeginContext(1683, 173, true);
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-default\" style=\"color:#ffffff; background-color:#b4b4b4; font-family:Verdana; font-size:large\"> Produtos Vencidos: (");
                EndContext();
                BeginContext(1858, 55, false);
#line 38 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                                                                                                                         Write(Model.Where(x => x.Validade <=    DateTime.Now).Count());

#line default
#line hidden
                EndContext();
                BeginContext(1914, 28, true);
                WriteLiteral(")</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            BeginContext(1949, 74, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                ");
            EndContext();
            BeginContext(2023, 294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363d9d07522f49b49b4f6dc8730717c2", async() => {
                BeginContext(2069, 166, true);
                WriteLiteral("\r\n                    <button class=\"btn btn-default\" style=\"color:#ffffff; background-color:#b4b4b4; font-family:Verdana; font-size:large\"> Prod com Estoque Baixo: (");
                EndContext();
                BeginContext(2237, 44, false);
#line 43 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                                                                                                                Write(Model.Where(x => x.Quantidade < 10 ).Count());

#line default
#line hidden
                EndContext();
                BeginContext(2282, 28, true);
                WriteLiteral(")</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2317, 1437, true);
            WriteLiteral(@"
            </div>

        </div>
    </div><br />



    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-striped table-bordered table-hover"">
                <thead>
                    <tr>
                        <th>
                            <label class=""control-label text-center"">ID</label>
                        </th>
                        <th>
                            <label class=""control-label text-center"">Nome do Produto</label>
                        </th>
                        <th>
                            <label class=""control-label"">Valor (R$)</label>
                        </th>
                        <th>
                            <label class=""control-label"">Quantidade</label>
                        </th>
                        <th>
                            <label class=""control-label"">Marca</label>
                        </th>
                        <th>
                            <label class=");
            WriteLiteral(@"""control-label"">Descrição</label>
                        </th>
                        <th>
                            <label class=""control-label"">Validade</label>
                        </th>
                        <th>
                            <label class=""control-label"">Ações</label>
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 84 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(3827, 105, true);
            WriteLiteral("                        <tr>\r\n                            <td readonly>\r\n                                ");
            EndContext();
            BeginContext(3933, 44, false);
#line 88 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdProduto));

#line default
#line hidden
            EndContext();
            BeginContext(3977, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4081, 39, false);
#line 91 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(4120, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4224, 45, false);
#line 94 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PrecoVenda));

#line default
#line hidden
            EndContext();
            BeginContext(4269, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4373, 45, false);
#line 97 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(4418, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4420, 48, false);
#line 97 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.UnidadeMedida));

#line default
#line hidden
            EndContext();
            BeginContext(4468, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4572, 40, false);
#line 100 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(4612, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4716, 44, false);
#line 103 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(4760, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4864, 43, false);
#line 106 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Validade));

#line default
#line hidden
            EndContext();
            BeginContext(4907, 123, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
            EndContext();
            BeginContext(5030, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ced95ae7bbd47999166a447e944ff0b", async() => {
                BeginContext(5116, 40, true);
                WriteLiteral("<span class=\"material-icons\">edit</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 109 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
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
            BeginContext(5160, 109, true);
            WriteLiteral("\r\n                                <a class=\"btn btn-danger btn-sm\" data-toggle=\"modal\" data-target=\"#myModal-");
            EndContext();
            BeginContext(5270, 14, false);
#line 110 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                                                      Write(item.IdProduto);

#line default
#line hidden
            EndContext();
            BeginContext(5284, 116, true);
            WriteLiteral("\"><span class=\"material-icons\">delete</span></a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
            BeginContext(5402, 47, true);
            WriteLiteral("                        <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5449, "\"", 5477, 2);
            WriteAttributeValue("", 5454, "myModal-", 5454, 8, true);
#line 114 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
WriteAttributeValue("", 5462, item.IdProduto, 5462, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5478, 518, true);
            WriteLiteral(@" role=""dialog"" aria-labelledby=""myModalLabel"">
                            <div class=""modal-dialog"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h3 class=""modal-title"" id=""myModalLabel"">Atenção</h3>
                                    </div>
                                    <div class=""modal-body"">
                                        <p>Deseja mesmo deletar o item ");
            EndContext();
            BeginContext(5997, 14, false);
#line 121 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                  Write(item.IdProduto);

#line default
#line hidden
            EndContext();
            BeginContext(6011, 279, true);
            WriteLiteral(@"?</p>
                                    </div>
                                    <div class=""modal-footer"">
                                        <button type=""button"" class=""btn btn-success"" data-dismiss=""modal"">voltar</button>
                                        ");
            EndContext();
            BeginContext(6290, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63f637975a0b441f8f4ae7e429661b4c", async() => {
                BeginContext(6374, 7, true);
                WriteLiteral("Deletar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 125 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                                                                        WriteLiteral(item.IdProduto);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6385, 154, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 130 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(6562, 215, true);
            WriteLiteral("                </tbody>\r\n            </table><br />\r\n            <div class=\"row col-md-12\">\r\n                <ul class=\"text-center\">\r\n\r\n                    <div class=\"col-md-12\">\r\n                        Página ");
            EndContext();
            BeginContext(6779, 57, false);
#line 137 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                           Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(6837, 29, true);
            WriteLiteral("\r\n                        de ");
            EndContext();
            BeginContext(6867, 15, false);
#line 138 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                      Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(6882, 32, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n");
            EndContext();
#line 141 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                     if (Model.HasPreviousPage)
                    {


#line default
#line hidden
            BeginContext(6988, 65, true);
            WriteLiteral("                        <button class=\"btn btn-sm btn-primary\">\r\n");
            EndContext();
            BeginContext(7235, 54, true);
            WriteLiteral("                            <a style=\"color : #ffffff\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7289, "\"", 7427, 1);
#line 146 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
WriteAttributeValue("", 7296, Url.Action("Index", new { pagina = Model.PageNumber - 1, sortOrder = ViewBag.CurrentSort, currentFilter = ViewBag.CurrentFilter }), 7296, 131, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7428, 51, true);
            WriteLiteral(">Anterior </a>\r\n                        </button>\r\n");
            EndContext();
#line 148 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"

                    }
                    else
                    {


#line default
#line hidden
            BeginContext(7555, 170, true);
            WriteLiteral("                        <button class=\"btn btn-sm btn-primary\">\r\n                            <a style=\"color : #ffffff\"> Anterior</a>\r\n                        </button>\r\n");
            EndContext();
#line 156 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(7748, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 158 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                     if (Model.HasNextPage)
                    {


#line default
#line hidden
            BeginContext(7820, 65, true);
            WriteLiteral("                        <button class=\"btn btn-sm btn-primary\">\r\n");
            EndContext();
            BeginContext(8066, 54, true);
            WriteLiteral("                            <a style=\"color : #ffffff\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8120, "\"", 8258, 1);
#line 163 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
WriteAttributeValue("", 8127, Url.Action("Index", new { pagina = Model.PageNumber + 1, sortOrder = ViewBag.CurrentSort, currentFilter = ViewBag.CurrentFilter }), 8127, 131, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8259, 50, true);
            WriteLiteral(">Próximo </a>\r\n                        </button>\r\n");
            EndContext();
#line 165 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(8383, 168, true);
            WriteLiteral("                        <button class=\"btn btn-sm btn-primary\">\r\n                            <a style=\"color : #ffffff\">Próximo</a>\r\n                        </button>\r\n");
            EndContext();
#line 172 "C:\Users\Edson\source\repos\SistemaPizzaria\SistemaWebPizzaria\Views\Produtos\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(8574, 101, true);
            WriteLiteral("                </ul><br /><br /><br /><br />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<SistemaWebPizzaria.Models.Produtoestoque>> Html { get; private set; }
    }
}
#pragma warning restore 1591
