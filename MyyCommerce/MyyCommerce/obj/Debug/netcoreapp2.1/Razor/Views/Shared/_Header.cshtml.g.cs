#pragma checksum "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "830f6167d4d3f7dc5c158ed0a5a88efb6b5ef646"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Header.cshtml", typeof(AspNetCore.Views_Shared__Header))]
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
#line 3 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
using MyyCommerce.Models;

#line default
#line hidden
#line 1 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
using MyyCommerce.Domain;

#line default
#line hidden
#line 4 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
using System.Security.Claims;

#line default
#line hidden
#line 5 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
using MyyCommerce.Data;

#line default
#line hidden
#line 6 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"830f6167d4d3f7dc5c158ed0a5a88efb6b5ef646", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66bd4f3ff0ca997768056c9cd15c2b635ebbf765", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Identity/Account/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(224, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(330, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 15 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
 if (!SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(377, 54, true);
            WriteLiteral("    <a href=\"/\" class=\"logo\"><h3>MyCommerce</h3></a>\r\n");
            EndContext();
#line 18 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
}
else {

#line default
#line hidden
            BeginContext(442, 86, true);
            WriteLiteral("    <div class=\"sidebar-toggle-box\">\r\n        <i class=\"fa fa-bars\"></i>\r\n    </div>\r\n");
            EndContext();
            BeginContext(530, 54, true);
            WriteLiteral("    <a href=\"/\" class=\"logo\"><h3>MyCommerce</h3></a>\r\n");
            EndContext();
            BeginContext(586, 106, true);
            WriteLiteral("    <div class=\"top-nav \">\r\n        <!--search & user info start-->\r\n\r\n        <ul class=\"nav top-menu\">\r\n");
            EndContext();
#line 30 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
             if (!User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(750, 64, true);
            WriteLiteral("                <li class=\"DesktopMenu\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 814, "\"", 851, 1);
#line 33 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
WriteAttributeValue("", 821, Url.Action("Index", "Pedido"), 821, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(852, 154, true);
            WriteLiteral(">\r\n                        Meus Pedidos\r\n                    </a>\r\n                </li>\r\n                <li class=\"DesktopMenu\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1006, "\"", 1044, 1);
#line 38 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
WriteAttributeValue("", 1013, Url.Action("Index", "Produto"), 1013, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1045, 86, true);
            WriteLiteral(">\r\n                        Produtos\r\n                    </a>\r\n                </li>\r\n");
            EndContext();
#line 42 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"

            }
            else
            {

#line default
#line hidden
            BeginContext(1181, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(1201, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e4b7c9dc7624bdaa5329515f980c375", async() => {
                BeginContext(1337, 8, true);
                WriteLiteral("Produtos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1211, "DesktopMenu", 1211, 11, true);
#line 46 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
AddHtmlAttributeValue(" ", 1222, Html.IsSelected(controller: "Produto", action: "Index"), 1223, 56, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1349, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(1376, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f157a93d5bc14f3088e2db182346c732", async() => {
                BeginContext(1493, 7, true);
                WriteLiteral("Pedidos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1386, "DesktopMenu", 1386, 11, true);
#line 47 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
AddHtmlAttributeValue(" ", 1397, Html.IsSelected(controller: "Pedido"), 1398, 38, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1504, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 48 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
            }

#line default
#line hidden
            BeginContext(1526, 61, true);
            WriteLiteral("        </ul>\r\n        <ul class=\"nav pull-right top-menu\">\r\n");
            EndContext();
#line 51 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
             if (!User.IsInRole("Slow"))
            {

#line default
#line hidden
            BeginContext(1644, 64, true);
            WriteLiteral("                <li class=\"DesktopMenu\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1708, "\"", 1747, 1);
#line 54 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
WriteAttributeValue("", 1715, Url.Action("Index", "Checkout"), 1715, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1748, 122, true);
            WriteLiteral(">\r\n                        <i class=\"fa fa-shopping-cart\"></i> Carrinho\r\n                    </a>\r\n                </li>\r\n");
            EndContext();
#line 58 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
            }

#line default
#line hidden
            BeginContext(1885, 55, true);
            WriteLiteral("            <li class=\"MobileMenu\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1940, "\"", 1979, 1);
#line 60 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
WriteAttributeValue("", 1947, Url.Action("Index", "Checkout"), 1947, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1980, 128, true);
            WriteLiteral(" style=\"font-size:1.2rem\">\r\n                    <i class=\"fa fa-shopping-cart\"></i>\r\n                </a>\r\n            </li>\r\n\r\n");
            EndContext();
#line 65 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
             if (SignInManager.IsSignedIn(User))
            {

#line default
#line hidden
            BeginContext(2173, 89, true);
            WriteLiteral("                <li class=\"DesktopMenu\" style=\"padding-top: 18px;\">\r\n                    ");
            EndContext();
            BeginContext(2262, 1532, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b76150faac71470798292374ab04b1e1", async() => {
                BeginContext(2436, 265, true);
                WriteLiteral(@"
                        <div class=""navbar-right"">
                            <div class=""user d-inline-block"">
                                <button class=""btn btn-empty p-0"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
");
                EndContext();
#line 72 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
                                     if (SignInManager.IsSignedIn(User))
                                    {

#line default
#line hidden
                BeginContext(2814, 59, true);
                WriteLiteral("                                        <span class=\"name\">");
                EndContext();
                BeginContext(2874, 29, false);
#line 74 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
                                                      Write(UserManager.GetUserName(User));

#line default
#line hidden
                EndContext();
                BeginContext(2903, 494, true);
                WriteLiteral(@"</span>
                                        <div class=""dropdown-menu dropdown-menu-right mt-3"">
                                            <a class=""dropdown-item"" href=""javascript:{}"" onclick=""document.location.href = '/Identity/Account/Manage/ChangePassword'"">Trocar Senha</a>
                                            <a class=""dropdown-item"" href=""javascript:{}"" onclick=""document.getElementById('logoutForm').submit();"">Sair</a>
                                        </div>
");
                EndContext();
#line 79 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                BeginContext(3517, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(3557, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da7976e6fa0a47deaca118b8ec211514", async() => {
                    BeginContext(3606, 5, true);
                    WriteLiteral("Login");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3615, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 83 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
                                    }

#line default
#line hidden
                BeginContext(3656, 131, true);
                WriteLiteral("                                </button>\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
                                                                                  WriteLiteral(Url.Action("Index", "Home", new { area = "" }));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3794, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 89 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3867, 62, true);
            WriteLiteral("                <li class=\"DesktopMenu\">\r\n                    ");
            EndContext();
            BeginContext(3929, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae3f7d3b627b4c8d9f4383cdc7707105", async() => {
                BeginContext(3964, 53, true);
                WriteLiteral("\r\n                        Login\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4021, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 97 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
            }

#line default
#line hidden
            BeginContext(4061, 27, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            EndContext();
#line 100 "/Users/kaliljoao/Projects/MyCommerce/MyyCommerce/MyyCommerce/Views/Shared/_Header.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext db { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
