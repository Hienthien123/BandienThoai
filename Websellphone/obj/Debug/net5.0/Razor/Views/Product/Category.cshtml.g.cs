#pragma checksum "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f77404b0300833bac1a422c444c677a456f26a52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Category), @"mvc.1.0.view", @"/Views/Product/Category.cshtml")]
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
#line 1 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\_ViewImports.cshtml"
using Websellphone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\_ViewImports.cshtml"
using Websellphone.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f77404b0300833bac1a422c444c677a456f26a52", @"/Views/Product/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32003857c043d3e0eb4544862feb8f517a9cab8a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal span6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
  
    ViewData["Title"] = Model.Category.Name + (Model.Products.PageIndex == 1 ? "" : " - " + _loc["Page"] + " " + Model.Products.PageIndex);
    ViewData["Description"] = Model.Category.Name + (Model.Products.PageIndex == 1 ? "" : " - " + _loc["Page"] + " " + Model.Products.PageIndex);
    Layout = "~/Views/Shared/_Layout.cshtml";
    var culture = CultureInfo.CurrentCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <ul class=\"breadcrumb\">\r\n    <li><a href=\"index.html\">Home</a> <span class=\"divider\">/</span></li>\r\n    <li class=\"active\">Products Name</li>\r\n</ul>\r\n<h3> ");
#nullable restore
#line 16 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"pull-right\"> 40 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a525549", async() => {
                WriteLiteral("available products");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </small></h3>\r\n<hr class=\"soft\" />\r\n<p>\r\n    Mô tả của ứng dụng (hard)\r\n</p>\r\n<hr class=\"soft\" />\r\n\r\n    <div class=\"row\">\r\n      \r\n        <div class=\"col-md-3\">\r\n            <!-- Sidebar content -->\r\n            ");
#nullable restore
#line 27 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
       Write(await Component.InvokeAsync("SideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a527100", async() => {
                WriteLiteral("\r\n                <div class=\"control-group\">\r\n                    <label class=\"control-label alignL\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a527465", async() => {
                    WriteLiteral("Sort By");
                }
                );
                __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
                __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" </label>\r\n                    <select>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a528562", async() => {
                    WriteLiteral("Priduct name A - Z");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a529612", async() => {
                    WriteLiteral("Priduct name Z - A");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a5210662", async() => {
                    WriteLiteral("Priduct Stoke");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a5211708", async() => {
                    WriteLiteral("Price Lowest first");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"          
            <br class=""clr"" />
            <!-- Single product area content -->
            <div class=""single-product-area"">
                <!-- ... -->
                <div class=""tab-content"">
                    <div class=""tab-pane"" id=""listView"">
                        <div class=""row "">
");
#nullable restore
#line 48 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                         for (int i = 0; i < Model.Products.Items.Count; i++)
                        {
                            var item = Model.Products.Items[i];


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-md-3 col-sm-6\">\r\n                                <div class=\"span2\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2323, "\"", 2384, 2);
#nullable restore
#line 54 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
WriteAttributeValue("", 2329, Configuration["BaseAddress"] + @item.ThumbnailImage, 2329, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2383, "", 2384, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2385, "\"", 2401, 1);
#nullable restore
#line 54 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
WriteAttributeValue("", 2391, item.Name, 2391, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </div>\r\n                                <div class=\"span4\">\r\n                                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a5215675", async() => {
                WriteLiteral("New | Available");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                                    <hr class=\"soft\" />\r\n                                    <h5>");
#nullable restore
#line 59 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 61 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <a class=\"btn btn-small pull-right\" href=\"product_details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a5217521", async() => {
                WriteLiteral("Xem chi tiết");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                    <br class=\"clr\" />\r\n                                </div>\r\n                                <div class=\"span3 alignR\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a5218709", async() => {
                WriteLiteral("\r\n                                        <h3> ");
#nullable restore
#line 68 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                                        Write(item.Price.ToString("C", culture));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                                        <label class=""checkbox"">
                                            <input type=""checkbox"">  Adds product to compair
                                        </label><br />

                                            <a class=""btn btn-add-cart"" data-id=""");
#nullable restore
#line 73 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" href=\"#\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a5219921", async() => {
                    WriteLiteral("Add to cart");
                }
                );
                __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
                __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <i class=\"icon-shopping-cart\"></i></a>\r\n                                        <a href=\"product_details.html\" class=\"btn btn-large\"><i class=\"icon-zoom-in\"></i></a>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>                               \r\n                            <hr class=\"soft\" />\r\n");
#nullable restore
#line 79 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"tab-pane active\" id=\"blockView\">\r\n                        <ul class=\"thumbnails\">\r\n");
#nullable restore
#line 85 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                             for (int i = 0; i < Model.Products.Items.Count; i += 3)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"row\">\r\n");
#nullable restore
#line 88 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                                     for (int j = i; j < i + 3 && j < Model.Products.Items.Count; j++)
                                    {
                                        var item = Model.Products.Items[j];

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-4\">\r\n                                            <div class=\"thumbnail\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4789, "\"", 4837, 6);
            WriteAttributeValue("", 4796, "/", 4796, 1, true);
#nullable restore
#line 93 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
WriteAttributeValue("", 4797, culture.Name, 4797, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4810, "/", 4810, 1, true);
#nullable restore
#line 93 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
WriteAttributeValue("", 4811, _loc["products"], 4811, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4828, "/", 4828, 1, true);
#nullable restore
#line 93 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
WriteAttributeValue("", 4829, item.Id, 4829, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <img");
            BeginWriteAttribute("src", " src=\"", 4897, "\"", 4957, 1);
#nullable restore
#line 94 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
WriteAttributeValue("", 4903, Configuration["BaseAddress"] + @item.ThumbnailImage, 4903, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4958, "\"", 4974, 1);
#nullable restore
#line 94 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
WriteAttributeValue("", 4964, item.Name, 4964, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                </a>\r\n                                                <div class=\"caption\">\r\n                                                    <h5 class=\"text-center\">");
#nullable restore
#line 97 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                    <p class=\"text-center\">");
#nullable restore
#line 98 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                                                                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <h4 style=\"text-align:center\">\r\n                                                        <a class=\"btn btn-add-cart\" data-id=\"");
#nullable restore
#line 100 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77404b0300833bac1a422c444c677a456f26a5227003", async() => {
                WriteLiteral("Add to cart");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <i class=\"icon-shopping-cart\"></i></a>\r\n                                                        <a class=\"btn btn-primary\" href=\"#\">");
#nullable restore
#line 101 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                                                                                       Write(item.Price.ToString("C", culture));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                    </h4>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 106 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 108 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <hr class=\"soft\" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 118 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Product\Category.cshtml"
Write(await Component.InvokeAsync("Pager", Model.Products));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br class=\"clr\" />\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategoryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
