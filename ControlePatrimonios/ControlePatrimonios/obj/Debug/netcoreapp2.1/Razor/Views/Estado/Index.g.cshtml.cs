#pragma checksum "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd9c020ac291368f78ab4251ec52cfbe95f5bf1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd9c020ac291368f78ab4251ec52cfbe95f5bf1", @"/Views/Estado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a0f352c20338f3fe76679740689d455af2fcf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Estado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControlePatrimonios.Models.TbEstado>>
    {
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
            BeginContext(567, 138, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th width=\"275\"></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(770, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(855, 50, false);
#line 28 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DescricaoEstado));

#line default
#line hidden
            EndContext();
            BeginContext(905, 124, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td align=\"right\">\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1029, "\"", 1059, 3);
            WriteAttributeValue("", 1039, "Edit(", 1039, 5, true);
#line 31 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
WriteAttributeValue("", 1044, item.IdEstado, 1044, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1058, ")", 1058, 1, true);
            EndWriteAttribute();
            BeginContext(1060, 67, true);
            WriteLiteral(">Editar</button> |\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1127, "\"", 1160, 3);
            WriteAttributeValue("", 1137, "Details(", 1137, 8, true);
#line 32 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
WriteAttributeValue("", 1145, item.IdEstado, 1145, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1159, ")", 1159, 1, true);
            EndWriteAttribute();
            BeginContext(1161, 69, true);
            WriteLiteral(">Detalhes</button> |\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1230, "\"", 1262, 3);
            WriteAttributeValue("", 1240, "Delete(", 1240, 7, true);
#line 33 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
WriteAttributeValue("", 1247, item.IdEstado, 1247, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1261, ")", 1261, 1, true);
            EndWriteAttribute();
            BeginContext(1263, 77, true);
            WriteLiteral(">Excluir</button>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 36 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Estado\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1359, 2301, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>


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
                        text: ""Descrição do Estado: "" + result.message,
                        icon: ""success""
                    });
            });
    }
    function Delete(EstadoId) {
        $.get(""./Estado/GetDescricaoEstadoById"",
            {
                id: EstadoId
            })
            .done(function (resultNomeEstado) {
                swal({
                    title: ""Tem certeza?"",
                    text: ""Você irá excluir o Estado: '"" + r");
            WriteLiteral(@"esultNomeEstado.message + ""'"",
                    icon: ""warning"",
                    buttons: true,
                    dangerMode: true,
                })
                .then((excluir) => {
                    if (excluir) {
                        $.post(""./Estado/DeleteConfirmed"",
                            {
                                id: EstadoId
                            })
                            .done(function (result) {
                                if (result.success)
                                    swal({
                                        title: ""Estado '"" + result.message + ""' deletado com sucesso"",
                                        icon: ""success""
                                    }).then(() => {
                                        window.location.reload();
                                    });
                            })
                            .fail(function () {
                                swal("""", ""Algo deu errado"", """);
            WriteLiteral("error\")\r\n                            });\r\n                    } else {\r\n                        swal({ title: \"Estado: \'\" + resultNomeEstado.message + \"\' não deletado\"});\r\n                    }\r\n                });\r\n            });\r\n\r\n    }\r\n</script>\r\n");
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
