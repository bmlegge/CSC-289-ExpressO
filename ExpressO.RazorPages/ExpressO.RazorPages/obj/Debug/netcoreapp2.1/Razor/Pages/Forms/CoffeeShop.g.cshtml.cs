#pragma checksum "E:\Ftcc\Spring20\CSC-289\Projects\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\CoffeeShop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c376e10ba9a3275f754cde6d05948f893709d0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExpressO.RazorPages.Pages.Forms.Pages_Forms_CoffeeShop), @"mvc.1.0.razor-page", @"/Pages/Forms/CoffeeShop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Forms/CoffeeShop.cshtml", typeof(ExpressO.RazorPages.Pages.Forms.Pages_Forms_CoffeeShop), null)]
namespace ExpressO.RazorPages.Pages.Forms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Ftcc\Spring20\CSC-289\Projects\ExpressO.RazorPages\ExpressO.RazorPages\Pages\_ViewImports.cshtml"
using ExpressO.RazorPages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c376e10ba9a3275f754cde6d05948f893709d0f", @"/Pages/Forms/CoffeeShop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0791cd5efdc779eff4aac70d080aeb9ed681424", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Forms_CoffeeShop : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Ftcc\Spring20\CSC-289\Projects\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\CoffeeShop.cshtml"
  
    ViewData["Title"] = "CoffeeShops";

#line default
#line hidden
            BeginContext(111, 83, true);
            WriteLiteral("\r\n<h2>CoffeeShop</h2>\r\n\r\n\r\n<div>\r\n    <div>\r\n        <table>\r\n            <tbody>\r\n");
            EndContext();
#line 14 "E:\Ftcc\Spring20\CSC-289\Projects\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\CoffeeShop.cshtml"
                 foreach (var i in Model.CoffeeShopList)
                {

#line default
#line hidden
            BeginContext(271, 46, true);
            WriteLiteral("                <tr>\r\n                    <th>");
            EndContext();
            BeginContext(318, 6, false);
#line 17 "E:\Ftcc\Spring20\CSC-289\Projects\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\CoffeeShop.cshtml"
                   Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(324, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(356, 9, false);
#line 18 "E:\Ftcc\Spring20\CSC-289\Projects\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\CoffeeShop.cshtml"
                   Write(i.Address);

#line default
#line hidden
            EndContext();
            BeginContext(365, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(368, 6, false);
#line 18 "E:\Ftcc\Spring20\CSC-289\Projects\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\CoffeeShop.cshtml"
                               Write(i.City);

#line default
#line hidden
            EndContext();
            BeginContext(374, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(406, 7, false);
#line 19 "E:\Ftcc\Spring20\CSC-289\Projects\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\CoffeeShop.cshtml"
                   Write(i.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(413, 30, true);
            WriteLiteral("</th>\r\n                </tr>\r\n");
            EndContext();
#line 21 "E:\Ftcc\Spring20\CSC-289\Projects\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\CoffeeShop.cshtml"
                }

#line default
#line hidden
            BeginContext(462, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExpressO.RazorPages.Pages.Forms.CoffeeShopsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExpressO.RazorPages.Pages.Forms.CoffeeShopsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExpressO.RazorPages.Pages.Forms.CoffeeShopsModel>)PageContext?.ViewData;
        public ExpressO.RazorPages.Pages.Forms.CoffeeShopsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
