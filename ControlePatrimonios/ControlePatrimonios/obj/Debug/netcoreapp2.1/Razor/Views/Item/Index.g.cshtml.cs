#pragma checksum "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73865a10e6a35545d1013b15313469d29775009e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item/Index.cshtml", typeof(AspNetCore.Views_Item_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73865a10e6a35545d1013b15313469d29775009e", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a0f352c20338f3fe76679740689d455af2fcf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControlePatrimonios.Models.TbItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 395, true);
            WriteLiteral(@"
<h2>Itens</h2>
<div class=""row"">
    <div class="" col-md-12"">
        <div align=""right"">
            <button class=""btn btn-primary"" onclick=""onClickCriar()"">Criar novo item</button>
        </div>
        <hr />
        <table class=""table table-striped table-bordered"">
            <thead>
                <tr class=""bg-primary"">
                    <th>
                        ");
            EndContext();
            BeginContext(494, 46, false);
#line 18 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Patrimonio));

#line default
#line hidden
            EndContext();
            BeginContext(540, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(620, 46, false);
#line 21 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ServiceTag));

#line default
#line hidden
            EndContext();
            BeginContext(666, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(746, 45, false);
#line 24 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(791, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1100, 77, true);
            WriteLiteral("                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1178, 47, false);
#line 31 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataCriacao));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1305, 54, false);
#line 34 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1439, 53, false);
#line 37 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.IdSetorNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1572, 52, false);
#line 40 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.IdTipoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 138, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th width=\"175\"></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1827, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1912, 45, false);
#line 50 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Patrimonio));

#line default
#line hidden
            EndContext();
            BeginContext(1957, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2049, 45, false);
#line 53 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ServiceTag));

#line default
#line hidden
            EndContext();
            BeginContext(2094, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2186, 44, false);
#line 56 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2230, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2322, 46, false);
#line 59 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataCriacao));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2460, 69, false);
#line 62 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdEstadoNavigation.DescricaoEstado));

#line default
#line hidden
            EndContext();
            BeginContext(2529, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2621, 62, false);
#line 65 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdSetorNavigation.NomeSetor));

#line default
#line hidden
            EndContext();
            BeginContext(2683, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2775, 65, false);
#line 68 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdTipoNavigation.DescricaoTipo));

#line default
#line hidden
            EndContext();
            BeginContext(2840, 124, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td align=\"right\">\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2964, "\"", 2992, 3);
            WriteAttributeValue("", 2974, "Edit(", 2974, 5, true);
#line 71 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
WriteAttributeValue("", 2979, item.IdItem, 2979, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2991, ")", 2991, 1, true);
            EndWriteAttribute();
            BeginContext(2993, 67, true);
            WriteLiteral(">Editar</button> |\r\n                            <button class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3060, "\"", 3091, 3);
            WriteAttributeValue("", 3070, "Details(", 3070, 8, true);
#line 72 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
WriteAttributeValue("", 3078, item.IdItem, 3078, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 3090, ")", 3090, 1, true);
            EndWriteAttribute();
            BeginContext(3092, 19, true);
            WriteLiteral(">Detalhes</button> ");
            EndContext();
            BeginContext(3213, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 76 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3292, 137, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script>\r\n    function onClickCriar() {\r\n        window.location.href = \"");
            EndContext();
            BeginContext(3430, 28, false);
#line 85 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                           Write(Url.Action("Create", "Item"));

#line default
#line hidden
            EndContext();
            BeginContext(3458, 72, true);
            WriteLiteral("\";\r\n    }\r\n    function Edit(ItemId) {\r\n        window.location.href = \"");
            EndContext();
            BeginContext(3531, 26, false);
#line 88 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                           Write(Url.Action("Edit", "Item"));

#line default
#line hidden
            EndContext();
            BeginContext(3557, 68, true);
            WriteLiteral("/\" + ItemId;\r\n    }\r\n    function Details(ItemId) {\r\n        $.get(\"");
            EndContext();
            BeginContext(3626, 29, false);
#line 91 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
          Write(Url.Action("Details", "Item"));

#line default
#line hidden
            EndContext();
            BeginContext(3655, 938, true);
            WriteLiteral(@""",
            {
                id: ItemId
            })
            .done(function (result) {
                if (result.success)
                    swal({
                        title: ""Detalhes"",
                        text:
                            ""Patrimonio: "" + result.message.patrimonio +
                            ""\nService Tag: "" + result.message.serviceTag +
                            ""\nDescrição: "" + result.message.descricao +
                            ""\nData da Criação: "" + result.message.dataCriacao +
                            ""\nDescrição do Estado: "" + result.message.descricaoEstado +
                            ""\nNome do Setor: "" + result.message.nomeSetor +
                            ""\nDescrição do Tipo: "" + result.message.descricaoTipo,
                        icon: ""success""
                    });
            });
    }
    function Delete(ItemId) {
        $.get(""");
            EndContext();
            BeginContext(4594, 42, false);
#line 112 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
          Write(Url.Action("GetDescricaoItemById", "Item"));

#line default
#line hidden
            EndContext();
            BeginContext(4636, 517, true);
            WriteLiteral(@""",
            {
                id: ItemId
            })
            .done(function (resultNomeItem) {
                swal({
                    title: ""Tem certeza?"",
                    text: ""Você irá excluir o Item: '"" + resultNomeItem.message + ""'"",
                    icon: ""warning"",
                    buttons: true,
                    dangerMode: true,
                })
                    .then((excluir) => {
                        if (excluir) {
                            $.post(""");
            EndContext();
            BeginContext(5154, 28, false);
#line 126 "C:\Users\Giovanne Prestes\Desktop\Pa6\ControlePatrimonios\ControlePatrimonios\Views\Item\Index.cshtml"
                               Write(Url.Action("Delete", "Item"));

#line default
#line hidden
            EndContext();
            BeginContext(5182, 1053, true);
            WriteLiteral(@""",
                                {
                                    id: ItemId
                                })
                                .done(function (result) {
                                    if (result.success)
                                        swal({
                                            title: ""Item '"" + result.message + ""' deletado com sucesso"",
                                            icon: ""success""
                                        }).then(() => {
                                            window.location.reload();
                                        });
                                })
                                .fail(function () {
                                    swal("""", ""Algo deu errado"", ""error"")
                                });
                        } else {
                            swal({ title: ""Item: '"" + resultNomeItem.message + ""' não deletado"" });
                        }
                    });
          ");
            WriteLiteral("  });\r\n\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControlePatrimonios.Models.TbItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
