#pragma checksum "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\Shop\Specials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38052b0fefa5f380e19691343d39d4f257519f73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Specials), @"mvc.1.0.view", @"/Views/Shop/Specials.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Specials.cshtml", typeof(AspNetCore.Views_Shop_Specials))]
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
#line 1 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\_ViewImports.cshtml"
using PlantATree.Models;

#line default
#line hidden
#line 2 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38052b0fefa5f380e19691343d39d4f257519f73", @"/Views/Shop/Specials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51ee112fc9347d22c2de1da510dd6357caaef7b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Specials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlantInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\Shop\Specials.cshtml"
  
    ViewBag.Title = "Specials";

#line default
#line hidden
            BeginContext(71, 226, true);
            WriteLiteral("\r\n<nav class=\"sticky-top\">\r\n    <div class=\"row\" style=\"background-color: darkgrey\">\r\n        <div class=\"col m-0 p-0\">\r\n            <h4>\r\n                START YOUR ORDER\r\n            </h4>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            EndContext();
            BeginContext(297, 468, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38052b0fefa5f380e19691343d39d4f257519f735219", async() => {
                BeginContext(303, 455, true);
                WriteLiteral(@"
        <div class=""row"" style=""background-color: grey"">
            <div class=""col p-0 m-0"">
                <button class=""btn btn-success btn-block"">
                    Delivery
                </button>
            </div>

            <div class=""col p-0 m-0"">
                <button class=""btn btn-secondary btn-block"" style=""color:white"">
                    Pick-Up
                </button>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(765, 560, true);
            WriteLiteral(@"
</nav>

<div id=""carouselExampleIndicators"" class=""carousel slide col-md-8 mt-2"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
    </ol>

    <!--foreach comment surrounds the divs that add items to the carosel (max 3 atm)-->
    <!--ADD FOREACH HERE-->
    <div class=""carousel-inner"">
");
            EndContext();
#line 42 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\Shop\Specials.cshtml"
         foreach (var v in Model)
        {

#line default
#line hidden
            BeginContext(1371, 104, true);
            WriteLiteral("            <div class=\"carousel-item active\">\r\n                <div class=\"card\">\r\n                    ");
            EndContext();
            BeginContext(1475, 520, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38052b0fefa5f380e19691343d39d4f257519f738108", async() => {
                BeginContext(1555, 118, true);
                WriteLiteral("\r\n                        <div class=\"card-img p-0 m-0\">\r\n                            <input type=\"hidden\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1673, "\"", 1688, 1);
#line 48 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\Shop\Specials.cshtml"
WriteAttributeValue("", 1681, v.Name, 1681, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1689, 61, true);
                WriteLiteral(" />\r\n                            <a href=\"javascript: void()\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1750, "\"", 1807, 3);
                WriteAttributeValue("", 1760, "document.getElementById(\'", 1760, 25, true);
                WriteAttributeValue("", 1785, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
                                                                                                                 
                    BeginContext(1788, 6, false);
#line 49 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\Shop\Specials.cshtml"
                                                                                        Write(v.Name);

#line default
#line hidden
                    EndContext();
                                                                                                                        
                    PopWriter();
                }
                ), 1785, 10, false);
                WriteAttributeValue("", 1795, "\').submit();", 1795, 12, true);
                EndWriteAttribute();
                BeginContext(1808, 35, true);
                WriteLiteral(">\r\n                                ");
                EndContext();
                BeginContext(1843, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38052b0fefa5f380e19691343d39d4f257519f7310401", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1853, "~/img/trees/", 1853, 12, true);
                AddHtmlAttributeValue("", 1865, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
                                                                            
#line 50 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\Shop\Specials.cshtml"
                                                   Write(v.Name);

#line default
#line hidden
                                                                                   
                    PopWriter();
                }
                ), 1865, 10, false);
                AddHtmlAttributeValue("", 1875, ".jpg", 1875, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1900, 88, true);
                WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 46 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\Shop\Specials.cshtml"
AddHtmlAttributeValue("", 1485, v.Name, 1485, 7, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1995, 108, true);
            WriteLiteral("\r\n\r\n                    <div class=\"card-title\">\r\n                        <h2>\r\n                            ");
            EndContext();
            BeginContext(2104, 6, false);
#line 57 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\Shop\Specials.cshtml"
                       Write(v.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2110, 222, true);
            WriteLiteral("\r\n                        </h2>\r\n                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n                        <div class=\"card-text\">\r\n                            <p>\r\n                                ");
            EndContext();
            BeginContext(2333, 13, false);
#line 64 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\Shop\Specials.cshtml"
                           Write(v.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2346, 140, true);
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 70 "C:\Users\James\Desktop\LocalCopy\swamp-treeWebApp\PlantATree\Views\Shop\Specials.cshtml"
        }

#line default
#line hidden
            BeginContext(2497, 571, true);
            WriteLiteral(@"    </div>
        <!--END FOREACH HERE-->


        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlantInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
