#pragma checksum "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Tipo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "972672c80c87bf9cabc1cb984ae1ab34f915974e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tipo_Index), @"mvc.1.0.view", @"/Views/Tipo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tipo/Index.cshtml", typeof(AspNetCore.Views_Tipo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"972672c80c87bf9cabc1cb984ae1ab34f915974e", @"/Views/Tipo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a0f352c20338f3fe76679740689d455af2fcf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Tipo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControlePatrimonios.Models.TbTipo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tipo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Tipo\Index.cshtml"
  
    ViewData["Title"] = "Tipos";

#line default
#line hidden
            BeginContext(98, 409, true);
            WriteLiteral(@"
<h2>Tipos</h2>
<div class=""row"">
    <div class=""col-md-offset-2 col-md-8"">
        <div align=""right"">
            <button class=""btn btn-primary"" onclick=""onClickCriar()"">Criar novo tipo</button>
        </div>
        <hr />
        <table class=""table table-striped table-bordered"">
            <thead>
                <tr class=""bg-primary"">
                    <th>
                        ");
            EndContext();
            BeginContext(508, 49, false);
#line 18 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Tipo\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DescricaoTipo));

#line default
#line hidden
            EndContext();
            BeginContext(557, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(583, 271, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "972672c80c87bf9cabc1cb984ae1ab34f915974e5471", async() => {
                BeginContext(643, 204, true);
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
            BeginContext(854, 138, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th width=\"275\"></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Tipo\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1057, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1142, 48, false);
#line 32 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Tipo\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DescricaoTipo));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 124, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td align=\"right\">\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1314, "\"", 1342, 3);
            WriteAttributeValue("", 1324, "Edit(", 1324, 5, true);
#line 35 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Tipo\Index.cshtml"
WriteAttributeValue("", 1329, item.IdTipo, 1329, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1341, ")", 1341, 1, true);
            EndWriteAttribute();
            BeginContext(1343, 67, true);
            WriteLiteral(">Editar</button> |\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1410, "\"", 1441, 3);
            WriteAttributeValue("", 1420, "Details(", 1420, 8, true);
#line 36 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Tipo\Index.cshtml"
WriteAttributeValue("", 1428, item.IdTipo, 1428, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1440, ")", 1440, 1, true);
            EndWriteAttribute();
            BeginContext(1442, 69, true);
            WriteLiteral(">Detalhes</button> |\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1511, "\"", 1541, 3);
            WriteAttributeValue("", 1521, "Delete(", 1521, 7, true);
#line 37 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Tipo\Index.cshtml"
WriteAttributeValue("", 1528, item.IdTipo, 1528, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1540, ")", 1540, 1, true);
            EndWriteAttribute();
            BeginContext(1542, 77, true);
            WriteLiteral(">Excluir</button>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Tipo\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1638, 4417, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>



<script>
    function onClickCriar() {
        window.location.href = ""./Tipo/Create"";
    }
    function Edit(TipoId) {
        window.location.href = ""./Tipo/Edit/"" + TipoId;
    }
    function Details(TipoId) {
        $.get(""./Tipo/Details"",
            {
                id: TipoId
            })
            .done(function (result) {
                if (result.success)
                    swal({
                        title: ""Detalhes"",
                        text: ""Descrição do Tipo: "" + result.message,
                        icon: ""success""
                    });
            });
    }
    function Delete(TipoId) {
        $.get(""./Tipo/GetDescricaoTipoById"",
            {
                id: TipoId
            })
            .done(function (resultNomeTipo) {
                swal({
                    title: ""Tem certeza?"",
                    text: ""Você irá excluir o Tipo: '"" + resultNomeTipo.message + ""'");
            WriteLiteral(@""",
                    icon: ""warning"",
                    buttons: true,
                    dangerMode: true
                })
                    .then((excluir) => {
                        if (excluir) {
                            $.post(""./Tipo/Delete"",
                                {
                                    id: TipoId
                                })
                                .done(function (result) {
                                    if (result.success) {
                                        swal({
                                            title: ""Tipo '"" + result.message + ""' deletado com sucesso"",
                                            icon: ""success""
                                        }).then(() => {
                                            window.location.reload();
                                        });
                                    } else {
                                        swal({
                                  ");
            WriteLiteral(@"          title: ""Atenção!"",
                                            text: ""O Tipo '"" + result.message + ""' tem objetos atrelados a ele, ao confirmar todos os objetos serão excluidos, deseja excluir mesmo assim?"",
                                            icon: ""warning"",
                                            buttons: true,
                                            dangerMode: true,
                                        }).then((excluirMesmoAssim) => {
                                            if (excluirMesmoAssim) {
                                                $.post(""./Tipo/DeleteConfirmed"",
                                                    {
                                                        id: TipoId
                                                    })
                                                    .done(function (result) {
                                                        if (result.success) {
                                                        ");
            WriteLiteral(@"    swal({
                                                                text: ""Tipo '"" + result.message + ""' deletado com sucesso"",
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
                                .fail(function () {
              ");
            WriteLiteral(@"                      swal("""", ""Algo deu errado"", ""error"")
                                });
                        } else {
                            swal({ title: ""Tipo: '"" + resultNomeTipo.message + ""' não deletado"" });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControlePatrimonios.Models.TbTipo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
