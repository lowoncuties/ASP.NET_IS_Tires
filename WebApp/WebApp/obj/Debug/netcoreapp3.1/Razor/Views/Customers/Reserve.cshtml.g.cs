#pragma checksum "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55da8c45be1df4c5598953381a4d8d7362eaca25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Reserve), @"mvc.1.0.view", @"/Views/Customers/Reserve.cshtml")]
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
#line 2 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
using WebApp_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55da8c45be1df4c5598953381a4d8d7362eaca25", @"/Views/Customers/Reserve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e586b046cf11980a80c37d4e6b43f7989c0eea", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Reserve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Defekt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Vyvážení", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Osobní auto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Motocykl", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Autobus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Traktor(bagr)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Nákladní auto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
  
    ViewData["Title"] = "Online rezervace";
    Layout = "~/Views/Customers/CLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center\">");
#nullable restore
#line 8 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n");
#nullable restore
#line 14 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
           Write(Html.Raw(TempData["msg"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-2\">\r\n        </div>\r\n        <div class=\"col-sm-8\">\r\n\r\n");
#nullable restore
#line 23 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
             using (Html.BeginForm())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""accordion accordion-flush"" id=""accordionFlushExample"">
                    <div class=""accordion-item"">
                        <h2 class=""accordion-header"" id=""flush-headingOne"">
                            <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#flush-collapseOne"" aria-expanded=""true"" aria-controls=""flush-collapseOne"">
                                Osobní informace
                            </button>
                        </h2>
                        <div id=""flush-collapseOne"" class=""accordion-collapse collapse"" aria-labelledby=""flush-headingOne"" data-bs-parent=""#accordionFlushExample"">
                            <div class=""accordion-body"">
                                <div class=""mb-3 row"">
                                    ");
#nullable restore
#line 35 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                               Write(Html.LabelFor(x => x.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 37 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                   Write(Html.TextBoxFor(x => x.name, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div style=\"color:red;margin-top:5px;\">");
#nullable restore
#line 38 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                                                          Write(Html.ValidationMessageFor(x => x.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"mb-3 row\">\r\n                                    ");
#nullable restore
#line 43 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                               Write(Html.LabelFor(x => x.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 45 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                   Write(Html.TextBoxFor(x => x.lastName, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div style=\"color:red;margin-top:5px;\">");
#nullable restore
#line 46 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                                                          Write(Html.ValidationMessageFor(x => x.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"mb-3 row\">\r\n                                    ");
#nullable restore
#line 51 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                               Write(Html.LabelFor(x => x.telephoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 53 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                   Write(Html.TextBoxFor(x => x.telephoneNum, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div style=\"color:red;margin-top:5px;\">");
#nullable restore
#line 54 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                                                          Write(Html.ValidationMessageFor(x => x.telephoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""accordion-item"">
                        <h2 class=""accordion-header"" id=""flush-headingTwo"">
                            <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#flush-collapseTwo"" aria-expanded=""false"" aria-controls=""flush-collapseTwo"">
                                Car information
                            </button>
                        </h2>
                        <div id=""flush-collapseTwo"" class=""accordion-collapse collapse"" aria-labelledby=""flush-headingTwo"" data-bs-parent=""#accordionFlushExample"">
                            <div class=""accordion-body"">
                                <div class=""mb-3 row"">
                                    ");
#nullable restore
#line 69 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                               Write(Html.LabelFor(x => x.brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 71 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                   Write(Html.DropDownListFor(x => x.brand, (List<SelectListItem>)ViewBag.Cars, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div style=\"color:red;margin-top:5px;\">");
#nullable restore
#line 72 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                                                          Write(Html.ValidationMessageFor(x => x.brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>                               \r\n\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 77 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                               Write(Html.LabelFor(x => x.serviceType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55da8c45be1df4c5598953381a4d8d7362eaca2513835", async() => {
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55da8c45be1df4c5598953381a4d8d7362eaca2514136", async() => {
                    WriteLiteral("Defekt");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55da8c45be1df4c5598953381a4d8d7362eaca2515400", async() => {
                    WriteLiteral("Vyvážení");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 78 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.serviceType);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 84 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                               Write(Html.LabelFor(x => x.vehicleType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55da8c45be1df4c5598953381a4d8d7362eaca2518335", async() => {
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55da8c45be1df4c5598953381a4d8d7362eaca2518636", async() => {
                    WriteLiteral("Osobní auto");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55da8c45be1df4c5598953381a4d8d7362eaca2519905", async() => {
                    WriteLiteral("Motocykl");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55da8c45be1df4c5598953381a4d8d7362eaca2521171", async() => {
                    WriteLiteral("Autobus");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55da8c45be1df4c5598953381a4d8d7362eaca2522436", async() => {
                    WriteLiteral("Traktor(bagr)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55da8c45be1df4c5598953381a4d8d7362eaca2523707", async() => {
                    WriteLiteral("Nákladní auto");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 85 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.vehicleType);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""accordion-item"">
                        <h2 class=""accordion-header"" id=""flush-headingThree"">
                            <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#flush-collapseThree"" aria-expanded=""false"" aria-controls=""flush-collapseThree"">
                                Time slot
                            </button>
                        </h2>
                        <div id=""flush-collapseThree"" class=""accordion-collapse collapse"" aria-labelledby=""flush-headingThree"" data-bs-parent=""#accordionFlushExample"">
                            <div class=""accordion-body"">
                                <div class=""mb-3 row"">
                                    ");
#nullable restore
#line 105 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                               Write(Html.LabelFor(x => x.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 107 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                   Write(Html.TextBoxFor(x => x.date, new { @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div style=\"color:red;margin-top:5px;\">");
#nullable restore
#line 108 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                                                          Write(Html.ValidationMessageFor(x => x.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"mb-3 row\">\r\n                                    ");
#nullable restore
#line 113 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                               Write(Html.LabelFor(x => x.time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 115 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                   Write(Html.TextBoxFor(x => x.time, new { @type = "time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div style=\"color:red;margin-top:5px;\">");
#nullable restore
#line 116 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
                                                                          Write(Html.ValidationMessageFor(x => x.time));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <button type=""submit"" class=""btn btn-success"">Rezervovat </button>
");
#nullable restore
#line 125 "E:\Programming\C# 2\WebApp_project\WebApp_project\Views\Customers\Reserve.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-sm-2\"></div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
