#pragma checksum "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbcc41092a704a59092eff825bc748eafa7f7502"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbcc41092a704a59092eff825bc748eafa7f7502", @"/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32003857c043d3e0eb4544862feb8f517a9cab8a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SellPhoneVIewModel.Catalog.Categories.CategoryViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
  
    var culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"sidebar\">\r\n    <!-- ... -->\r\n    <div class=\"sidebar_section\">\r\n        <div class=\"sidebar_title\">\r\n            <h5>Product Category</h5>\r\n        </div>\r\n        <ul class=\"sidebar_categories\">\r\n");
#nullable restore
#line 14 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
              
                var parents = Model.Where(x => x.ParentId == null);

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
             for(int index = 0; index < parents.Count(); index++)
            {
                var parent = parents.ElementAt(index);
                var children = Model.Where(x => x.ParentId == parent.Id);
                if(children.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"subMenu open\">\r\n                        <a>");
#nullable restore
#line 25 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
                      Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <ul>\r\n");
#nullable restore
#line 27 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
                            foreach(var item in children)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 1041, "\"", 1087, 6);
            WriteAttributeValue("", 1048, "/", 1048, 1, true);
#nullable restore
#line 29 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1049, culture, 1049, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1057, "/", 1057, 1, true);
#nullable restore
#line 29 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1058, _loc["categoryUrl"], 1058, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1078, "/", 1078, 1, true);
#nullable restore
#line 29 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1079, item.Id, 1079, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span><i class=\"fa fa-angle-double-right\" aria-hidden=\"true\"></i></span>");
#nullable restore
#line 29 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
                                                                                                                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 30 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </li>\r\n");
#nullable restore
#line 33 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
                    
                }
                else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1408, 6);
            WriteAttributeValue("", 1367, "/", 1367, 1, true);
#nullable restore
#line 36 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1368, culture, 1368, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1376, "/", 1376, 1, true);
#nullable restore
#line 36 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1377, _loc["categoryUrl"], 1377, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1397, "/", 1397, 1, true);
#nullable restore
#line 36 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1398, parent.Id, 1398, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
                                                                       Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 37 "E:\.net core API\Websellphone\Websellphone\Websellphone\Views\Shared\Components\SideBar\Default.cshtml"
                }
                
            }           

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>

    <!-- Price Range Filtering -->
    <div class=""sidebar_section"">
        <div class=""sidebar_title"">
            <h5>Filter by Price</h5>
        </div>
        <p>
            <input type=""text"" id=""amount"" readonly style=""border:0; color:#f6931f; font-weight:bold;"">
        </p>
        <div id=""slider-range""></div>
        <div class=""filter_button""><span>filter</span></div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SellPhoneVIewModel.Catalog.Categories.CategoryViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
