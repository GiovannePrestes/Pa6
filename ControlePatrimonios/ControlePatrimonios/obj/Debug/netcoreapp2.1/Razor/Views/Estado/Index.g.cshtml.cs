#pragma checksum "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ecab471a06607eb5392dd506febde83b333e0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estado_Index), @"mvc.1.0.view", @"/Views/Estado/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estado/Index.cshtml", typeof(AspNetCore.Views_Estado_Index))]
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
#line 1 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\_ViewImports.cshtml"
using ControlePatrimonios;

#line default
#line hidden
#line 2 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\_ViewImports.cshtml"
using ControlePatrimonios.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ecab471a06607eb5392dd506febde83b333e0ca", @"/Views/Estado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a0f352c20338f3fe76679740689d455af2fcf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Estado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControlePatrimonios.Models.TbEstado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Estado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
  
    ViewData["Title"] = "Estados";

#line default
#line hidden
            BeginContext(102, 413, true);
            WriteLiteral(@"
<h2>Estados</h2>
<div class=""row"">
    <div class=""col-md-offset-2 col-md-8"">
        <div align=""right"">
            <button class=""btn btn-primary"" onclick=""onClickCriar()"">Criar novo estado</button>
        </div>
        <hr />
        <table class=""table table-striped table-bordered"">
            <thead>
                <tr class=""bg-primary"">
                    <th>
                        ");
            EndContext();
            BeginContext(516, 51, false);
#line 18 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DescricaoEstado));

#line default
#line hidden
            EndContext();
            BeginContext(567, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(593, 273, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ecab471a06607eb5392dd506febde83b333e0ca5502", async() => {
                BeginContext(655, 204, true);
                WriteLiteral("\r\n                            <input class=\"label-primary\" type=\"text\" name=\"search\">\r\n                            <input class=\"btn btn-primary\" type=\"submit\" value=\"Filtrar\" />\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(866, 138, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th width=\"275\"></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1069, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1154, 50, false);
#line 32 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DescricaoEstado));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 124, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td align=\"right\">\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1328, "\"", 1358, 3);
            WriteAttributeValue("", 1338, "Edit(", 1338, 5, true);
#line 35 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
WriteAttributeValue("", 1343, item.IdEstado, 1343, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1357, ")", 1357, 1, true);
            EndWriteAttribute();
            BeginContext(1359, 67, true);
            WriteLiteral(">Editar</button> |\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1426, "\"", 1459, 3);
            WriteAttributeValue("", 1436, "Details(", 1436, 8, true);
#line 36 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
WriteAttributeValue("", 1444, item.IdEstado, 1444, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1458, ")", 1458, 1, true);
            EndWriteAttribute();
            BeginContext(1460, 69, true);
            WriteLiteral(">Detalhes</button> |\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1529, "\"", 1561, 3);
            WriteAttributeValue("", 1539, "Delete(", 1539, 7, true);
#line 37 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
WriteAttributeValue("", 1546, item.IdEstado, 1546, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1560, ")", 1560, 1, true);
            EndWriteAttribute();
            BeginContext(1562, 77, true);
            WriteLiteral(">Excluir</button>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1658, 4458, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

#line default
#line hidden
            EndContext();
            BeginContext(1826, 74, true);
            WriteLiteral("\";\r\n    }\r\n    function Edit(EstadoId) {\r\n        window.location.href = \"");
            EndContext();
            BeginContext(1901, 28, false);
#line 52 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
                           Write(Url.Action("Edit", "Estado"));

<script>
    function onClickCriar() {
        window.location.href = ""./Estado/Create"";
    }
    function Edit(EstadoId) {
        window.location.href = ""./Estado/Edit/"" + EstadoId;
    }
    function Details(EstadoId) {
        $.get(""./Estado/Details"",
            {
                id: EstadoId
            })
            .done(function (result) {
                if (result.success)
                    swal({
                        title: ""Detalhes"",
                        text: ""Nome do Estado: "" + result.message,
                        //icon: ""success""
                    });
            });
    }
    function Delete(EstadoId) {
        $.get(""");
            EndContext();
            BeginContext(2455, 46, false);
#line 69 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
          Write(Url.Action("GetDescricaoEstadoById", "Estado"));

#line default
#line hidden
            EndContext();
            BeginContext(2501, 524, true);
            WriteLiteral(@""",
            {
                id: EstadoId
            })
            .done(function (resultNomeEstado) {
                swal({
                    title: ""Tem certeza?"",
                    text: ""Você irá excluir o Estado: '"" + result");
            WriteLiteral(@"NomeEstado.message + ""'"",
                    icon: ""warning"",
                    buttons: true,
                    dangerMode: true
                })
                    .then((excluir) => {
                        if (excluir) {
                            $.post(""");
            EndContext();
            BeginContext(3026, 30, false);
#line 83 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
                               Write(Url.Action("Delete", "Estado"));

#line default
#line hidden
            EndContext();
            BeginContext(3056, 1514, true);
            WriteLiteral(@""",
                                {
                                    id: EstadoId
                                })
                                .done(function (result) {
                                    if (result.success) {
                                        swal({
                                            title: ""Estado '"" + result.message + ""' deletado com sucesso"",
                                            icon: ""success""
                                        }).then(() => {
                                            window.location.reload();
                                        });
                                    } else {
                                        swal({
     ");
            WriteLiteral(@"                                       title: ""Atenção!"",
                                            text: ""O Estado '"" + result.message + ""' tem objetos atrelados a ele, ao confirmar todos os objetos serão excluidos, deseja excluir mesmo assim?"",
                                            icon: ""warning"",
                                            buttons: true,
                                            dangerMode: true,
                                        }).then((excluirMesmoAssim) => {
                                            if (excluirMesmoAssim) {
                                                $.post(""./Estado/DeleteConfirmed"",
                                                    {
                                                        id: EstadoId
                                                    })
                                                    .done(function (result) {
                                                        if (result.success) {
                     ");
            WriteLiteral(@"                                       swal({
                                                                text: ""Estado '"" + result.message + ""' deletado com sucesso"",
                                                                icon: ""success""
                                                            }).then(() => {
                                                                window.location.reload();
                                                            });
                                                        }
                                                    })
                                                    .fail(function () {
                                                        swal("""", ""Algo deu errado"", ""error"")
                                                    });
                                            }
                                        });
                                    }
                                })
                              ");
            WriteLiteral(@"  .fail(function () {
                                    swal("""", ""Algo deu errado"", ""error"")
                                });
                        } else {
                            swal({ title: ""Estado: '"" + resultNomeEstado.message + ""' não deletado"" });
                        }
                    });
            });

    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControlePatrimonios.Models.TbEstado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
