#pragma checksum "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "694440d1ee781d04f2a62b80afcf99a091a2952f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694440d1ee781d04f2a62b80afcf99a091a2952f", @"/Views/Shop/ProductPage.cshtml")]
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
    string PlantImage = "~/img/trees/" + Model.Name + ".jpg";

#line default
#line hidden
            BeginContext(125, 107, true);
            WriteLiteral("\r\n    <div class=\"card col-sm-auto col-md-6 mt-3 mb-3 p-3 shadow-lg\">\r\n        <div class=\"\">\r\n            ");
            EndContext();
            BeginContext(232, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "694440d1ee781d04f2a62b80afcf99a091a2952f4289", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 242, "~/img/trees/", 242, 12, true);
            AddHtmlAttributeValue("", 254, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                    
#line 9 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                               Write(Model.Name);

#line default
#line hidden
                                                               
                PopWriter();
            }
            ), 254, 14, false);
            AddHtmlAttributeValue("", 268, ".jpg", 268, 4, true);
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
            BeginContext(315, 39, true);
            WriteLiteral("\r\n\r\n            <h1 class=\"card-title\">");
            EndContext();
            BeginContext(355, 10, false);
#line 11 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(365, 240, true);
            WriteLiteral("</h1>\r\n\r\n            <!--tabel for price max height and growth rate-->\r\n            <table class=\"table\">\r\n                <tbody>\r\n                    <tr>\r\n                        <th scope=\"row\">Price</th>\r\n                        <td> $");
            EndContext();
            BeginContext(606, 11, false);
#line 18 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                         Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(617, 146, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Max Height</th>\r\n                        <td> ");
            EndContext();
            BeginContext(764, 15, false);
#line 22 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                        Write(Model.MaxHeight);

#line default
#line hidden
            EndContext();
            BeginContext(779, 149, true);
            WriteLiteral(" m</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Growth Rate</th>\r\n                        <td> ");
            EndContext();
            BeginContext(929, 16, false);
#line 26 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                        Write(Model.GrowthRate);

#line default
#line hidden
            EndContext();
            BeginContext(945, 150, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Plant Category</th>\r\n                        <td> ");
            EndContext();
            BeginContext(1096, 14, false);
#line 30 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                        Write(Model.Category);

#line default
#line hidden
            EndContext();
            BeginContext(1110, 155, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n            <b>Discription</b><br>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(1266, 17, false);
#line 38 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1283, 284, true);
            WriteLiteral(@"
            </p>

            <!--Using unorder list for printing condition of place to be planted-->
            <b>Conditions of Place to be planted:</b><br>
            <ul class=""list-group list-group-flush"">
                <li class=""list-group-item""><b>Sun:         </b>");
            EndContext();
            BeginContext(1568, 9, false);
#line 44 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                                                           Write(Model.Sun);

#line default
#line hidden
            EndContext();
            BeginContext(1577, 74, true);
            WriteLiteral("   </li>\r\n                <li class=\"list-group-item\"><b>Drainage:    </b>");
            EndContext();
            BeginContext(1652, 15, false);
#line 45 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                                                           Write(Model.SoilDrain);

#line default
#line hidden
            EndContext();
            BeginContext(1667, 156, true);
            WriteLiteral("  </li>\r\n            </ul>\r\n\r\n            <div class=\"card-body\">\r\n                <b>Maintenace Requirements</b>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(1824, 14, false);
#line 51 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
               Write(Model.MaintReq);

#line default
#line hidden
            EndContext();
            BeginContext(1838, 158, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <!--buy or return buittons-->\r\n\r\n            <button type=\"button\" class=\"btn btn-success btn-block\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1996, "\"", 2045, 3);
            WriteAttributeValue("", 2006, "alert(\'~/img/Trees/", 2006, 19, true);
            WriteAttributeValue("", 2025, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                                                                  
                BeginContext(2028, 10, false);
#line 57 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                                                                                             Write(Model.Name);

#line default
#line hidden
                EndContext();
                                                                                                                             
                PopWriter();
            }
            ), 2025, 14, false);
            WriteAttributeValue("", 2039, ".jpg\')", 2039, 6, true);
            EndWriteAttribute();
            BeginContext(2046, 91, true);
            WriteLiteral(">Buy</button>\r\n\r\n            <button type=\"button\" class=\"btn btn-outline-danger btn-block\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2137, "\"", 2193, 3);
            WriteAttributeValue("", 2147, "location.href=\'", 2147, 15, true);
#line 59 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
WriteAttributeValue("", 2162, Url.Action("Catalog", "Shop"), 2162, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 2192, "\'", 2192, 1, true);
            EndWriteAttribute();
            BeginContext(2194, 77, true);
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
