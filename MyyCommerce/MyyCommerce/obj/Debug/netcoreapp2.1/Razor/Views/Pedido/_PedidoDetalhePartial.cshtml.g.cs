#pragma checksum "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5104d4f130718a551db9e58b7720eca9757cbdf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido__PedidoDetalhePartial), @"mvc.1.0.view", @"/Views/Pedido/_PedidoDetalhePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/_PedidoDetalhePartial.cshtml", typeof(AspNetCore.Views_Pedido__PedidoDetalhePartial))]
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
#line 1 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/_ViewImports.cshtml"
using MyyCommerce;

#line default
#line hidden
#line 2 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/_ViewImports.cshtml"
using MyyCommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5104d4f130718a551db9e58b7720eca9757cbdf9", @"/Views/Pedido/_PedidoDetalhePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66bd4f3ff0ca997768056c9cd15c2b635ebbf765", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido__PedidoDetalhePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyyCommerce.Domain.Pedido>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
  
    ViewData["Title"] = "_ProdutoFormPartial";

#line default
#line hidden
            BeginContext(90, 271, true);
            WriteLiteral(@"
<div class=""modal-header"">
    <h4 class=""modal-title"">Detalhar Pedido</h4>
</div>

<div class=""modal-body"">
    <div class=""form-group enderecoGroup"">
        <label for=""exampleInputEmail1"">Número</label>
        <input class=""form-control"" readonly=""readonly""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 361, "\"", 378, 1);
#line 13 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
WriteAttributeValue("", 369, Model.Id, 369, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(379, 171, true);
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group enderecoGroup\">\r\n        <label for=\"exampleInputEmail1\">Cliente</label>\r\n        <input class=\"form-control\" readonly=\"readonly\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 550, "\"", 669, 1);
#line 17 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
WriteAttributeValue("", 558, Model.ApplicationUser.Nome != null ? Model.ApplicationUser.Nome + " " + Model.ApplicationUser.Sobrenome : "", 558, 111, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(670, 175, true);
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group enderecoGroup\">\r\n        <label for=\"exampleInputEmail1\">Data Pedido</label>\r\n        <input class=\"form-control\" readonly=\"readonly\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 845, "\"", 893, 1);
#line 21 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
WriteAttributeValue("", 853, Model.DataPedido.ToString("dd/MM/yyyy"), 853, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(894, 156, true);
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group enderecoGroup\">\r\n        <label for=\"exampleInputEmail1\">Data Entrega</label>\r\n        <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1050, "\"", 1099, 1);
#line 25 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
WriteAttributeValue("", 1058, Model.DataEntrega.ToString("dd/MM/yyyy"), 1058, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1100, 170, true);
            WriteLiteral(" readonly=\"readonly\">\r\n    </div>\r\n    <div class=\"form-group enderecoGroup\">\r\n        <label for=\"exampleInputEmail1\">Status</label>\r\n        <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1270, "\"", 1308, 1);
#line 29 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
WriteAttributeValue("", 1278, Model.StatusPedido.ToString(), 1278, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1309, 191, true);
            WriteLiteral(" readonly=\"readonly\">\r\n    </div>\r\n    <div class=\"form-group enderecoGroup\">\r\n        <label for=\"exampleInputEmail1\">Entrega</label>\r\n        <input class=\"form-control\" readonly=\"readonly\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1500, "\"", 1537, 1);
#line 33 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
WriteAttributeValue("", 1508, Model.TipoEntrega.ToString(), 1508, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1538, 15, true);
            WriteLiteral(">\r\n    </div>\r\n");
            EndContext();
            BeginContext(2514, 266, true);
            WriteLiteral(@"    <div class=""form-group enderecoGroup"">
        <label for=""exampleInputEmail1"" class=""bold"">Produtos</label>
        <table class=""table tablecenter"">
            <tr>
                <th>Produto</th>
                <th>Quantidade</th>
            </tr>
");
            EndContext();
#line 61 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
             foreach (var item in Model.Produtos)
            {

#line default
#line hidden
            BeginContext(2846, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(2893, 17, false);
#line 64 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
                   Write(item.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2910, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2942, 15, false);
#line 65 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
                   Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(2957, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 67 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Pedido/_PedidoDetalhePartial.cshtml"
            }

#line default
#line hidden
            BeginContext(3002, 260, true);
            WriteLiteral(@"        </table>
    </div>


</div>

<div class=""modal-footer"">
    <button type=""button"" class=""btn btn-white btnCloseSlow"" data-dismiss=""modal"">Fechar</button>
    <button type=""submit"" class=""btn btn-primary btnSaveSlow"">Salvar</button>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyyCommerce.Domain.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
