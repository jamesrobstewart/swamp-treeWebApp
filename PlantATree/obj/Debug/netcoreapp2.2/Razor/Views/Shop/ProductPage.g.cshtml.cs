#pragma checksum "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1340b345fb7bc82f9f4f450b11077034116b572"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ProductPage), @"mvc.1.0.view", @"/Views/Shop/ProductPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/ProductPage.cshtml", typeof(AspNetCore.Views_Shop_ProductPage))]
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
#line 1 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\_ViewImports.cshtml"
using PlantATree.Models;

#line default
#line hidden
#line 2 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1340b345fb7bc82f9f4f450b11077034116b572", @"/Views/Shop/ProductPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51ee112fc9347d22c2de1da510dd6357caaef7b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ProductPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlantInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Responsive image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
  
    ViewBag.Title = "Product Page";

#line default
#line hidden
            BeginContext(62, 107, true);
            WriteLiteral("\r\n    <div class=\"card col-sm-auto col-md-6 mt-3 mb-3 p-3 shadow-lg\">\r\n        <div class=\"\">\r\n            ");
            EndContext();
            BeginContext(169, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1340b345fb7bc82f9f4f450b11077034116b5724225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 179, "~/img/trees/", 179, 12, true);
            AddHtmlAttributeValue("", 191, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                    
#line 8 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                               Write(Model.Name);

#line default
#line hidden
                                                               
                PopWriter();
            }
            ), 191, 14, false);
            AddHtmlAttributeValue("", 205, ".jpg", 205, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(252, 39, true);
            WriteLiteral("\r\n\r\n            <h1 class=\"card-title\">");
            EndContext();
            BeginContext(292, 10, false);
#line 10 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(302, 240, true);
            WriteLiteral("</h1>\r\n\r\n            <!--tabel for price max height and growth rate-->\r\n            <table class=\"table\">\r\n                <tbody>\r\n                    <tr>\r\n                        <th scope=\"row\">Price</th>\r\n                        <td> $");
            EndContext();
            BeginContext(543, 11, false);
#line 17 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                         Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(554, 146, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Max Height</th>\r\n                        <td> ");
            EndContext();
            BeginContext(701, 15, false);
#line 21 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                        Write(Model.MaxHeight);

#line default
#line hidden
            EndContext();
            BeginContext(716, 149, true);
            WriteLiteral(" m</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Growth Rate</th>\r\n                        <td> ");
            EndContext();
            BeginContext(866, 16, false);
#line 25 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                        Write(Model.GrowthRate);

#line default
#line hidden
            EndContext();
            BeginContext(882, 150, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Plant Category</th>\r\n                        <td> ");
            EndContext();
            BeginContext(1033, 14, false);
#line 29 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                        Write(Model.Category);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 155, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n            <b>Discription</b><br>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(1203, 17, false);
#line 37 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1220, 284, true);
            WriteLiteral(@"
            </p>

            <!--Using unorder list for printing condition of place to be planted-->
            <b>Conditions of Place to be planted:</b><br>
            <ul class=""list-group list-group-flush"">
                <li class=""list-group-item""><b>Sun:         </b>");
            EndContext();
            BeginContext(1505, 9, false);
#line 43 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                                                           Write(Model.Sun);

#line default
#line hidden
            EndContext();
            BeginContext(1514, 74, true);
            WriteLiteral("   </li>\r\n                <li class=\"list-group-item\"><b>Drainage:    </b>");
            EndContext();
            BeginContext(1589, 15, false);
#line 44 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                                                           Write(Model.SoilDrain);

#line default
#line hidden
            EndContext();
            BeginContext(1604, 156, true);
            WriteLiteral("  </li>\r\n            </ul>\r\n\r\n            <div class=\"card-body\">\r\n                <b>Maintenace Requirements</b>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(1761, 14, false);
#line 50 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
               Write(Model.MaintReq);

#line default
#line hidden
            EndContext();
            BeginContext(1775, 297, true);
            WriteLiteral(@"
                </p>
            </div>

            <!--buy or return buittons-->

            <button type=""button"" class=""btn btn-success btn-block"" onclick=""alert('Ima add this to the cart now')"">Buy</button>

            <button type=""button"" class=""btn btn-outline-danger btn-block""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2072, "\"", 2128, 3);
            WriteAttributeValue("", 2082, "location.href=\'", 2082, 15, true);
#line 58 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
WriteAttributeValue("", 2097, Url.Action("Catalog", "Shop"), 2097, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 2127, "\'", 2127, 1, true);
            EndWriteAttribute();
            BeginContext(2129, 77, true);
            WriteLiteral(" style=\"text-decoration : none\">Return</button>\r\n\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlantInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
