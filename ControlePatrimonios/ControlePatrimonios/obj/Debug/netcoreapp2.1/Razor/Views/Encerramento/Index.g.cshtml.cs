#pragma checksum "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6743221b58a64bc4efcd678e65d158dda28b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Encerramento_Index), @"mvc.1.0.view", @"/Views/Encerramento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Encerramento/Index.cshtml", typeof(AspNetCore.Views_Encerramento_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd6743221b58a64bc4efcd678e65d158dda28b25", @"/Views/Encerramento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a0f352c20338f3fe76679740689d455af2fcf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Encerramento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControlePatrimonios.Models.TbEncerramento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
  
    ViewData["Title"] = "Encerramentos";

#line default
#line hidden
            BeginContext(114, 426, true);
            WriteLiteral(@"
<h2>Encerramentos</h2>
<div class=""row"">
    <div class=""col-md-offset-1 col-md-10"">
        <div align=""right"">
            <button class=""btn btn-primary"" onclick=""onClickCriar()"">Criar novo encerramento</button>
        </div>
        <hr />
        <table class=""table table-striped table-bordered"">
            <thead>
                <tr class=""bg-primary"">
                    <th>
                        ");
            EndContext();
            BeginContext(541, 52, false);
#line 18 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataEncerramento));

#line default
#line hidden
            EndContext();
            BeginContext(593, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(673, 42, false);
#line 21 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Motivo));

#line default
#line hidden
            EndContext();
            BeginContext(715, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(795, 52, false);
#line 24 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.IdItemNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(847, 138, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th width=\"275\"></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1050, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1135, 51, false);
#line 34 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataEncerramento));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1278, 41, false);
#line 37 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Motivo));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1411, 60, false);
#line 40 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdItemNavigation.NomeItem));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 124, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td align=\"right\">\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1595, "\"", 1631, 3);
            WriteAttributeValue("", 1605, "Edit(", 1605, 5, true);
#line 43 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
WriteAttributeValue("", 1610, item.IdEncerramento, 1610, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1630, ")", 1630, 1, true);
            EndWriteAttribute();
            BeginContext(1632, 67, true);
            WriteLiteral(">Editar</button> |\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1699, "\"", 1738, 3);
            WriteAttributeValue("", 1709, "Details(", 1709, 8, true);
#line 44 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
WriteAttributeValue("", 1717, item.IdEncerramento, 1717, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1737, ")", 1737, 1, true);
            EndWriteAttribute();
            BeginContext(1739, 69, true);
            WriteLiteral(">Detalhes</button> |\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1808, "\"", 1846, 3);
            WriteAttributeValue("", 1818, "Delete(", 1818, 7, true);
#line 45 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
WriteAttributeValue("", 1825, item.IdEncerramento, 1825, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1845, ")", 1845, 1, true);
            EndWriteAttribute();
            BeginContext(1847, 77, true);
            WriteLiteral(">Excluir</button>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Encerramento\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1943, 2814, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<script>
    function onClickCriar() {
        window.location.href = ""./Encerramento/Create"";
    }
    function Edit(EncerramentoId) {
        window.location.href = ""./Encerramento/Edit/"" + EncerramentoId;
    }
    function Details(EncerramentoId) {
        $.get(""./Encerramento/Details"",
            {
                id: EncerramentoId
            })
            .done(function (result) {
                if (result.success)
                    swal({
                        title: ""Detalhes"",
                        text: ""Item do Encerramento: '"" + result.message + ""'"",
                        icon: ""success""
                    });
            });
    }
    function Delete(EncerramentoId) {
        $.get(""./Encerramento/GetNomeItemEncerramentoById"",
            {
                id: EncerramentoId
            })
            .done(function (resultNomeEncerramento) {
                if (resultNomeEncerramento.success)");
            WriteLiteral(@" {
                    swal({
                        title: ""Tem certeza?"",
                        text: ""Você irá excluir o Encerramento do Item: '"" + resultNomeEncerramento.message + ""'"",
                        icon: ""warning"",
                        buttons: true,
                        dangerMode: true,
                    })
                        .then((excluir) => {
                            if (excluir) {
                                $.post(""./Encerramento/DeleteConfirmed"",
                                    {
                                        id: EncerramentoId
                                    })
                                    .done(function (result) {
                                        if (result.success)
                                            swal({
                                                title: ""Encerramento do Item '"" + result.message + ""' deletado com sucesso"",
                                                icon: ""success""
         ");
            WriteLiteral(@"                                   }).then(() => {
                                                window.location.reload();
                                            });
                                    })
                                    .fail(function () {
                                        swal("""", ""Algo deu errado"", ""error"")
                                    });
                            } else {
                                swal({ title: ""Encerramento do Item: '"" + resultNomeEncerramento.message + ""' não deletado"" });
                            }
                        });
                } else {
                    swal("""", ""Erro ao encontrar Item"", ""error"")
                }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControlePatrimonios.Models.TbEncerramento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
