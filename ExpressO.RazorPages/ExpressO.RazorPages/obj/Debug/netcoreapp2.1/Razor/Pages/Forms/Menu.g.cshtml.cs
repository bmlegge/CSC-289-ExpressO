#pragma checksum "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f5a095082ed4b900605957770b2dd922f3223a1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f5a095082ed4b900605957770b2dd922f3223a1", @"/Pages/Forms/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0791cd5efdc779eff4aac70d080aeb9ed681424", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Forms_Menu : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/coffeeBeans.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
  
    ViewData["Title"] = "Menu";

#line default
#line hidden
            BeginContext(97, 197, true);
            WriteLiteral("<style>\r\n    img{\r\n        width:100%;\r\n        height:auto;\r\n    }\r\n</style>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\"></div>\r\n        <div class=\"col-md-4\">");
            EndContext();
            BeginContext(294, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91061406c72348e48f2eb8edd42483cf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(332, 86, true);
            WriteLiteral("</div>\r\n        <div class=\"col-md-4\"></div>\r\n    </div>\r\n</div>\r\n\r\n<center>\r\n    <h2>");
            EndContext();
            BeginContext(419, 15, false);
#line 22 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
   Write(Model.Menu.Name);

#line default
#line hidden
            EndContext();
            BeginContext(434, 448, true);
            WriteLiteral(@"</h2>
</center>

<div class=""container"">
    <div class=""col-md-6"">
        <table class=""table table-striped table-hover col-md-6"">
            <thead>
                <tr class=""success"">
                    <th><h4>Hot Drinks</h4></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Black Coffee</td>
                    <td align=""right"">");
            EndContext();
            BeginContext(883, 22, false);
#line 37 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
                                 Write(Model.Menu.CoffeeBlack);

#line default
#line hidden
            EndContext();
            BeginContext(905, 126, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Latte</td>\r\n                    <td align=\"right\">");
            EndContext();
            BeginContext(1032, 16, false);
#line 41 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
                                 Write(Model.Menu.Latte);

#line default
#line hidden
            EndContext();
            BeginContext(1048, 131, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Cappuccino</td>\r\n                    <td align=\"right\">");
            EndContext();
            BeginContext(1180, 21, false);
#line 45 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
                                 Write(Model.Menu.Cappuccino);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 129, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Expresso</td>\r\n                    <td align=\"right\">");
            EndContext();
            BeginContext(1331, 19, false);
#line 49 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
                                 Write(Model.Menu.Expresso);

#line default
#line hidden
            EndContext();
            BeginContext(1350, 130, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Macchiato</td>\r\n                    <td align=\"right\">");
            EndContext();
            BeginContext(1481, 20, false);
#line 53 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
                                 Write(Model.Menu.Macchiato);

#line default
#line hidden
            EndContext();
            BeginContext(1501, 126, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Mocha</td>\r\n                    <td align=\"right\">");
            EndContext();
            BeginContext(1628, 16, false);
#line 57 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
                                 Write(Model.Menu.Mocha);

#line default
#line hidden
            EndContext();
            BeginContext(1644, 485, true);
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class=""col-md-6"">
        <table class=""table table-striped table-hover col-md-6"">
            <thead>
                <tr class=""success"">
                    <th><h4>Cold Drinks</h4></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Iced Coffee</td>
                    <td align=""right"">");
            EndContext();
            BeginContext(2130, 21, false);
#line 73 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
                                 Write(Model.Menu.IcedCoffee);

#line default
#line hidden
            EndContext();
            BeginContext(2151, 134, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Iced Expresso</td>\r\n                    <td align=\"right\">");
            EndContext();
            BeginContext(2286, 23, false);
#line 77 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
                                 Write(Model.Menu.IcedExpresso);

#line default
#line hidden
            EndContext();
            BeginContext(2309, 130, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Cold Brew</td>\r\n                    <td align=\"right\">");
            EndContext();
            BeginContext(2440, 19, false);
#line 81 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
                                 Write(Model.Menu.ColdBrew);

#line default
#line hidden
            EndContext();
            BeginContext(2459, 132, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Frappuccino</td>\r\n                    <td align=\"right\">");
            EndContext();
            BeginContext(2592, 22, false);
#line 85 "E:\Ftcc\Spring20\CSC-289\Projects\CSC-289-ExpressO\ExpressO.RazorPages\ExpressO.RazorPages\Pages\Forms\Menu.cshtml"
                                 Write(Model.Menu.Frappuccino);

#line default
#line hidden
            EndContext();
            BeginContext(2614, 93, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n        </div>\r\n </div>");
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
