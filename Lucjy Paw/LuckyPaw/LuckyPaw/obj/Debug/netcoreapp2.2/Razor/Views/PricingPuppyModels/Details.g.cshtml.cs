#pragma checksum "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc3df3e0a4dfe26795a1d92adee2ae99794a0ce9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PricingPuppyModels_Details), @"mvc.1.0.view", @"/Views/PricingPuppyModels/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PricingPuppyModels/Details.cshtml", typeof(AspNetCore.Views_PricingPuppyModels_Details))]
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
#line 1 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\_ViewImports.cshtml"
using LuckyPaw;

#line default
#line hidden
#line 2 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\_ViewImports.cshtml"
using LuckyPaw.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3df3e0a4dfe26795a1d92adee2ae99794a0ce9", @"/Views/PricingPuppyModels/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5865033075ecc615c9fcac009b74edc81f157570", @"/Views/_ViewImports.cshtml")]
    public class Views_PricingPuppyModels_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LuckyPaw.Models.PricingPuppyModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 138, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>PricingPuppyModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(226, 50, false);
#line 14 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePuppyDesc));

#line default
#line hidden
            EndContext();
            BeginContext(276, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(338, 46, false);
#line 17 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.PricePuppyDesc));

#line default
#line hidden
            EndContext();
            BeginContext(384, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(445, 46, false);
#line 20 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePuppy));

#line default
#line hidden
            EndContext();
            BeginContext(491, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(553, 42, false);
#line 23 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.PricePuppy));

#line default
#line hidden
            EndContext();
            BeginContext(595, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(656, 54, false);
#line 26 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePuppyImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(710, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(772, 50, false);
#line 29 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.PricePuppyImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(822, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(883, 44, false);
#line 32 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PuppyQty));

#line default
#line hidden
            EndContext();
            BeginContext(927, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(989, 40, false);
#line 35 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.PuppyQty));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 92, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <!--\r\n    <a asp-action=\"Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(1122, 18, false);
#line 41 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\PricingPuppyModels\Details.cshtml"
                                  Write(Model.PricePuppyID);

#line default
#line hidden
            EndContext();
            BeginContext(1140, 21, true);
            WriteLiteral("\">Edit</a> |-->\r\n    ");
            EndContext();
            BeginContext(1161, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc3df3e0a4dfe26795a1d92adee2ae99794a0ce97957", async() => {
                BeginContext(1183, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1199, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LuckyPaw.Models.PricingPuppyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
