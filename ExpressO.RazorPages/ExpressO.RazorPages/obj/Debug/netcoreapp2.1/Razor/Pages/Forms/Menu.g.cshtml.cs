#pragma checksum "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26aba33d967fca5aec41764a0de4c9316ed8ebb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExpressO.RazorPages.Pages.Forms.Pages_Forms_Menu), @"mvc.1.0.razor-page", @"/Pages/Forms/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Forms/Menu.cshtml", typeof(ExpressO.RazorPages.Pages.Forms.Pages_Forms_Menu), null)]
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
#line 1 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\_ViewImports.cshtml"
using ExpressO.RazorPages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26aba33d967fca5aec41764a0de4c9316ed8ebb1", @"/Pages/Forms/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0791cd5efdc779eff4aac70d080aeb9ed681424", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Forms_Menu : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
  
    ViewData["Title"] = "Menu";

#line default
#line hidden
            BeginContext(97, 493, true);
            WriteLiteral(@"
<h2>Menu</h2>

<div>
    <div>
        <table>
            <tr>
                <th>Black Coffeee</th>
                <th>Latte</th>
                <th>Cappuccino</th>
                <th>Expresso</th>
                <th>Macchiato</th>
                <th>Mocha</th>
                <th>Iced Coffee</th>
                <th>Iced Expresso</th>
                <th>Cold Brew</th>
                <th>Frappuccino</th>
            </tr>
            <tr>
                <td>");
            EndContext();
            BeginContext(591, 22, false);
#line 25 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
               Write(Model.Menu.CoffeeBlack);

#line default
#line hidden
            EndContext();
            BeginContext(613, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(641, 16, false);
#line 26 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
               Write(Model.Menu.Latte);

#line default
#line hidden
            EndContext();
            BeginContext(657, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(685, 21, false);
#line 27 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
               Write(Model.Menu.Cappuccino);

#line default
#line hidden
            EndContext();
            BeginContext(706, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(734, 19, false);
#line 28 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
               Write(Model.Menu.Expresso);

#line default
#line hidden
            EndContext();
            BeginContext(753, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(781, 20, false);
#line 29 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
               Write(Model.Menu.Macchiato);

#line default
#line hidden
            EndContext();
            BeginContext(801, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(829, 16, false);
#line 30 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
               Write(Model.Menu.Mocha);

#line default
#line hidden
            EndContext();
            BeginContext(845, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(873, 21, false);
#line 31 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
               Write(Model.Menu.IcedCoffee);

#line default
#line hidden
            EndContext();
            BeginContext(894, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(922, 23, false);
#line 32 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
               Write(Model.Menu.IcedExpresso);

#line default
#line hidden
            EndContext();
            BeginContext(945, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(973, 19, false);
#line 33 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
               Write(Model.Menu.ColdBrew);

#line default
#line hidden
            EndContext();
            BeginContext(992, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1020, 22, false);
#line 34 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
               Write(Model.Menu.Frappuccino);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 62, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExpressO.RazorPages.Pages.Forms.MenuModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExpressO.RazorPages.Pages.Forms.MenuModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExpressO.RazorPages.Pages.Forms.MenuModel>)PageContext?.ViewData;
        public ExpressO.RazorPages.Pages.Forms.MenuModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591