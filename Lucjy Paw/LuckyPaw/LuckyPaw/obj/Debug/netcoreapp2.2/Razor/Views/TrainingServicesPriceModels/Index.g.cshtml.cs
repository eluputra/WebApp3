#pragma checksum "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2044f3926599b7bc57a86ce03eeeb9169cdaf019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrainingServicesPriceModels_Index), @"mvc.1.0.view", @"/Views/TrainingServicesPriceModels/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TrainingServicesPriceModels/Index.cshtml", typeof(AspNetCore.Views_TrainingServicesPriceModels_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2044f3926599b7bc57a86ce03eeeb9169cdaf019", @"/Views/TrainingServicesPriceModels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5865033075ecc615c9fcac009b74edc81f157570", @"/Views/_ViewImports.cshtml")]
    public class Views_TrainingServicesPriceModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LuckyPaw.Models.TrainingServicesPriceModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CartItemModels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuyTrainingService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
            BeginContext(109, 18, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
            EndContext();
#line 9 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{
    if (User.IsInRole("Admin"))
    {

#line default
#line hidden
            BeginContext(207, 18, true);
            WriteLiteral("     <p>\r\n        ");
            EndContext();
            BeginContext(225, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2044f3926599b7bc57a86ce03eeeb9169cdaf0195839", async() => {
                BeginContext(248, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(262, 13, true);
            WriteLiteral("\r\n     </p>\r\n");
            EndContext();
#line 16 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
    }
}

#line default
#line hidden
            BeginContext(285, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(372, 48, false);
#line 23 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TrainingName));

#line default
#line hidden
            EndContext();
            BeginContext(420, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(476, 49, false);
#line 26 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PriceTraining));

#line default
#line hidden
            EndContext();
            BeginContext(525, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(581, 48, false);
#line 29 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TrainingDesc));

#line default
#line hidden
            EndContext();
            BeginContext(629, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(747, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(796, 47, false);
#line 38 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TrainingName));

#line default
#line hidden
            EndContext();
            BeginContext(843, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(899, 48, false);
#line 41 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PriceTraining));

#line default
#line hidden
            EndContext();
            BeginContext(947, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1003, 47, false);
#line 44 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TrainingDesc));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1105, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2044f3926599b7bc57a86ce03eeeb9169cdaf01910595", async() => {
                BeginContext(1217, 20, true);
                WriteLiteral("Buy Training Service");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
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
            BeginContext(1241, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 49 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    

#line default
#line hidden
#line 51 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
                     if (User.IsInRole("User"))
                    {


#line default
#line hidden
            BeginContext(1391, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1415, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2044f3926599b7bc57a86ce03eeeb9169cdaf01913812", async() => {
                BeginContext(1484, 9, true);
                WriteLiteral("| Details");
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
#line 54 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
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
            BeginContext(1497, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
                    }
                    else if (User.IsInRole("Manager"))
                    {

#line default
#line hidden
            BeginContext(1601, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1625, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2044f3926599b7bc57a86ce03eeeb9169cdaf01916564", async() => {
                BeginContext(1691, 8, true);
                WriteLiteral("| Edit |");
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
#line 58 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
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
            BeginContext(1703, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1729, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2044f3926599b7bc57a86ce03eeeb9169cdaf01918968", async() => {
                BeginContext(1798, 7, true);
                WriteLiteral("Details");
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
#line 59 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
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
            BeginContext(1809, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 60 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
                    }
                    else if (User.IsInRole("Admin"))
                    {

#line default
#line hidden
            BeginContext(1911, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1935, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2044f3926599b7bc57a86ce03eeeb9169cdaf01921716", async() => {
                BeginContext(2001, 8, true);
                WriteLiteral("| Edit |");
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
#line 63 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
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
            BeginContext(2013, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2039, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2044f3926599b7bc57a86ce03eeeb9169cdaf01924120", async() => {
                BeginContext(2108, 9, true);
                WriteLiteral("Details |");
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
#line 64 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
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
            BeginContext(2121, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2147, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2044f3926599b7bc57a86ce03eeeb9169cdaf01926528", async() => {
                BeginContext(2215, 6, true);
                WriteLiteral("Delete");
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
#line 65 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
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
            BeginContext(2225, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
                    }

#line default
#line hidden
#line 66 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
                     
                }
                else
                {

#line default
#line hidden
            BeginContext(2310, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2334, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2044f3926599b7bc57a86ce03eeeb9169cdaf01929422", async() => {
                BeginContext(2403, 9, true);
                WriteLiteral("| Details");
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
#line 70 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
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
            BeginContext(2416, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 71 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2437, 63, true);
            WriteLiteral("\r\n                <!--\r\n    <a asp-action=\"Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(2501, 28, false);
#line 74 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
                                  Write(item.TrainingServicesPriceID);

#line default
#line hidden
            EndContext();
            BeginContext(2529, 56, true);
            WriteLiteral("\">Edit</a> |\r\n    <a asp-action=\"Details\" asp-route-id=\"");
            EndContext();
            BeginContext(2586, 28, false);
#line 75 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
                                     Write(item.TrainingServicesPriceID);

#line default
#line hidden
            EndContext();
            BeginContext(2614, 58, true);
            WriteLiteral("\">Details</a> |\r\n    <a asp-action=\"Delete\" asp-route-id=\"");
            EndContext();
            BeginContext(2673, 28, false);
#line 76 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
                                    Write(item.TrainingServicesPriceID);

#line default
#line hidden
            EndContext();
            BeginContext(2701, 52, true);
            WriteLiteral("\">Delete</a> -->\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 79 "E:\GITHUB TINFO\WebApp3\Lucjy Paw\LuckyPaw\LuckyPaw\Views\TrainingServicesPriceModels\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2756, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LuckyPaw.Models.TrainingServicesPriceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
