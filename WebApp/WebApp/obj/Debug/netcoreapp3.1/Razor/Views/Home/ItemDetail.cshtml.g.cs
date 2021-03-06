#pragma checksum "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e6fd9bf6061375c2d95589f21495ebd66d08b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ItemDetail), @"mvc.1.0.view", @"/Views/Home/ItemDetail.cshtml")]
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
#nullable restore
#line 1 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\_ViewImports.cshtml"
using WebApp_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
using WebApp_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e6fd9bf6061375c2d95589f21495ebd66d08b2", @"/Views/Home/ItemDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e586b046cf11980a80c37d4e6b43f7989c0eea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ItemDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eshop>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
  
    ViewData["Title"] = "Detail položky";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container d-flex justify-content-center\">\r\n    <div class=\"row\">\r\n        <div class=\"card\" style=\"width: 33rem; margin-top:2%;\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">Pneumatiky ");
#nullable restore
#line 13 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                                             Write(Html.DisplayFor(x => x.znacka));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <ul class=\"list-group list-group-flush\">\r\n                <li class=\"list-group-item\" style=\"font-weight:bold\">Cena: ");
#nullable restore
#line 16 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                                                                      Write(Html.DisplayFor(x => x.cena));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Kč</li>\r\n                <li class=\"list-group-item\">Značka a model: ");
#nullable restore
#line 17 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                                                       Write(Html.DisplayFor(x => x.znacka));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">Rozměry: ");
#nullable restore
#line 18 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                                                Write(Html.DisplayFor(x => x.rozmery));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                 if (Model.typ == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">Typ pneumatik: Letní</li>\r\n");
#nullable restore
#line 22 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                }
                else if (Model.typ == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">Typ pneumatik: Zimní</li>\r\n");
#nullable restore
#line 26 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                }
                else if (Model.typ == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">Typ pneumatik: Celoroční</li>\r\n");
#nullable restore
#line 30 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                }
                else if (Model.typ == 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">Typ pneumatik: Autobus</li>\r\n");
#nullable restore
#line 34 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                }
                else if (Model.typ == 4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">Typ pneumatik: Traktor</li>\r\n");
#nullable restore
#line 38 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                }
                else if (Model.typ == 5)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">Typ pneumatik: Nakladní auto</li>\r\n");
#nullable restore
#line 42 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">Počet skladem: ");
#nullable restore
#line 43 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                                                      Write(Html.DisplayFor(x => x.pocet));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">");
#nullable restore
#line 44 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Home\ItemDetail.cshtml"
                                       Write(Html.DisplayFor(x => x.poznamka));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eshop> Html { get; private set; }
    }
}
#pragma warning restore 1591
