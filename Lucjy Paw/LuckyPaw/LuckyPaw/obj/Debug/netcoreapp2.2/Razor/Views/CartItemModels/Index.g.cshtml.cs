#pragma checksum "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1683a6ba18fe173084bc93dba8826349aecd5c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CartItemModels_Index), @"mvc.1.0.view", @"/Views/CartItemModels/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CartItemModels/Index.cshtml", typeof(AspNetCore.Views_CartItemModels_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1683a6ba18fe173084bc93dba8826349aecd5c2", @"/Views/CartItemModels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5865033075ecc615c9fcac009b74edc81f157570", @"/Views/_ViewImports.cshtml")]
    public class Views_CartItemModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LuckyPaw.Models.CartItemModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemovePuppy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PricingPuppyModels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOneToTrainingServicesCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveOneFromTrainingServicesCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveTrainingService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TrainingServicesPriceModels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
  
    ViewData["Title"] = "Index";

    var count = 0;

#line default
#line hidden
            BeginContext(116, 134, true);
            WriteLiteral("\r\n<h1>Shopping Cart Items</h1>\r\n<h2>Puppies</h2>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 50, false);
#line 15 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PricePuppyDesc));

#line default
#line hidden
            EndContext();
            BeginContext(301, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(357, 46, false);
#line 18 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PricePuppy));

#line default
#line hidden
            EndContext();
            BeginContext(403, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(459, 43, false);
#line 21 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CartQty));

#line default
#line hidden
            EndContext();
            BeginContext(502, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(614, 218, true);
            WriteLiteral("            <!--If and variable code from https://www.w3schools.com/asp/razor_cs_logic.asp-->\r\n            <!--A puppy has a training services price id of -1, so we check for that and display the puppy information-->\r\n");
            EndContext();
#line 30 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
             if (item.TrainingServicesPriceID == -1)
            {
                count++;

#line default
#line hidden
            BeginContext(927, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1000, 49, false);
#line 35 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PricePuppyDesc));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 80, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        $");
            EndContext();
            BeginContext(1130, 45, false);
#line 38 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.PricePuppy));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1255, 42, false);
#line 41 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CartQty));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1376, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1683a6ba18fe173084bc93dba8826349aecd5c29799", async() => {
                BeginContext(1438, 12, true);
                WriteLiteral("Remove Puppy");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                                                      WriteLiteral(item.PricePuppyID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1454, 87, true);
            WriteLiteral("\r\n                        <!--\r\n                    <a asp-action=\"Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(1542, 11, false);
#line 46 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                                                  Write(item.CartId);

#line default
#line hidden
            EndContext();
            BeginContext(1553, 72, true);
            WriteLiteral("\">Edit</a> |\r\n                    <a asp-action=\"Details\" asp-route-id=\"");
            EndContext();
            BeginContext(1626, 11, false);
#line 47 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                                                     Write(item.CartId);

#line default
#line hidden
            EndContext();
            BeginContext(1637, 74, true);
            WriteLiteral("\">Details</a> |\r\n                    <a asp-action=\"Delete\" asp-route-id=\"");
            EndContext();
            BeginContext(1712, 11, false);
#line 48 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                                                    Write(item.CartId);

#line default
#line hidden
            EndContext();
            BeginContext(1723, 67, true);
            WriteLiteral("\">Delete</a>-->\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 51 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
            }

#line default
#line hidden
#line 51 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1816, 33, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1849, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1683a6ba18fe173084bc93dba8826349aecd5c214048", async() => {
                BeginContext(1907, 29, true);
                WriteLiteral("Continue Shopping for Puppies");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1940, 122, true);
            WriteLiteral("\r\n</p>\r\n\r\n<h2>Training Services</h2>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2063, 48, false);
#line 64 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TrainingName));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2167, 49, false);
#line 67 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PriceTraining));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2272, 43, false);
#line 70 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CartQty));

#line default
#line hidden
            EndContext();
            BeginContext(2315, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 75 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2427, 223, true);
            WriteLiteral("            <!--If and variable code from https://www.w3schools.com/asp/razor_cs_logic.asp-->\r\n            <!--A training service has a puppy id of -1, so we check for that and display the training services information-->\r\n");
            EndContext();
#line 79 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
             if (item.PricePuppyID == -1)
            {
                count++;

#line default
#line hidden
            BeginContext(2734, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2807, 47, false);
#line 84 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TrainingName));

#line default
#line hidden
            EndContext();
            BeginContext(2854, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2934, 48, false);
#line 87 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PriceTraining));

#line default
#line hidden
            EndContext();
            BeginContext(2982, 198, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <!--Text box code from https://www.tutorialsteacher.com/mvc/htmlhelper-textbox-textboxfor -->\r\n                        ");
            EndContext();
            BeginContext(3181, 44, false);
#line 91 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                   Write(Html.TextBox("cartQty", @item.CartQty, null));

#line default
#line hidden
            EndContext();
            BeginContext(3225, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3251, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1683a6ba18fe173084bc93dba8826349aecd5c219437", async() => {
                BeginContext(3341, 9, true);
                WriteLiteral("Add one |");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                                                                       WriteLiteral(item.TrainingServicesPriceID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3354, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3380, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1683a6ba18fe173084bc93dba8826349aecd5c221854", async() => {
                BeginContext(3475, 12, true);
                WriteLiteral("Remove one |");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                                                                            WriteLiteral(item.TrainingServicesPriceID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3491, 30, true);
            WriteLiteral("\r\n                        <!--");
            EndContext();
            BeginContext(3522, 42, false);
#line 94 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CartQty));

#line default
#line hidden
            EndContext();
            BeginContext(3564, 29, true);
            WriteLiteral("-->\r\n                        ");
            EndContext();
            BeginContext(3593, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1683a6ba18fe173084bc93dba8826349aecd5c224691", async() => {
                BeginContext(3676, 23, true);
                WriteLiteral("Remove Training Service");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                                                                WriteLiteral(item.TrainingServicesPriceID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3703, 118, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <!--<a asp-action=\"Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(3822, 11, false);
#line 98 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                                                          Write(item.CartId);

#line default
#line hidden
            EndContext();
            BeginContext(3833, 72, true);
            WriteLiteral("\">Edit</a> |\r\n                    <a asp-action=\"Details\" asp-route-id=\"");
            EndContext();
            BeginContext(3906, 11, false);
#line 99 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                                                     Write(item.CartId);

#line default
#line hidden
            EndContext();
            BeginContext(3917, 74, true);
            WriteLiteral("\">Details</a> |\r\n                    <a asp-action=\"Delete\" asp-route-id=\"");
            EndContext();
            BeginContext(3992, 11, false);
#line 100 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
                                                    Write(item.CartId);

#line default
#line hidden
            EndContext();
            BeginContext(4003, 67, true);
            WriteLiteral("\">Delete</a>-->\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 103 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
            }

#line default
#line hidden
#line 103 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(4096, 33, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(4129, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1683a6ba18fe173084bc93dba8826349aecd5c229019", async() => {
                BeginContext(4196, 39, true);
                WriteLiteral("Continue Shopping for Training Services");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4239, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
#line 111 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
 if (count > 0) {

#line default
#line hidden
            BeginContext(4268, 9, true);
            WriteLiteral("<p>\r\n    ");
            EndContext();
            BeginContext(4277, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1683a6ba18fe173084bc93dba8826349aecd5c230905", async() => {
                BeginContext(4302, 8, true);
                WriteLiteral("CheckOut");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4314, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
#line 115 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\CartItemModels\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LuckyPaw.Models.CartItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
