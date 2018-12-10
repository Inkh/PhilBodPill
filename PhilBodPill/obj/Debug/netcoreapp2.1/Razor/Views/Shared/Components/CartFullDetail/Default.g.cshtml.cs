#pragma checksum "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f2dc7b27a1a149e53b74bfa766aa6a1c5eaba83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartFullDetail_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartFullDetail/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartFullDetail/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CartFullDetail_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2dc7b27a1a149e53b74bfa766aa6a1c5eaba83", @"/Views/Shared/Components/CartFullDetail/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartFullDetail_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PhilBodPill.Models.Basket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml"
   
    decimal total = 0;
    foreach (var item in Model)
    {
        total += (item.Product.Price * (decimal)item.Quantity);
    }

#line default
#line hidden
            BeginContext(186, 13, true);
            WriteLiteral("\r\n<h4>Total: ");
            EndContext();
            BeginContext(200, 5, false);
#line 11 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml"
      Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(205, 39, true);
            WriteLiteral("</h4>\r\n\r\n\r\n<div class=\"pillow-cards\">\r\n");
            EndContext();
#line 15 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml"
     foreach (var item in Model)
    {
        string imagePath = $"{item.Product.Image}";

#line default
#line hidden
            BeginContext(338, 51, true);
            WriteLiteral("        <div class=\"pillow-card\">\r\n            <h3>");
            EndContext();
            BeginContext(390, 47, false);
#line 19 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(437, 50, true);
            WriteLiteral(" Pillow</h3>\r\n            <h2 class=\"info-text\">X ");
            EndContext();
            BeginContext(488, 13, false);
#line 20 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(501, 23, true);
            WriteLiteral("</h2>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 524, "\"", 540, 1);
#line 21 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml"
WriteAttributeValue("", 530, imagePath, 530, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(541, 63, true);
            WriteLiteral(" />\r\n            <div class=\"item-price\">\r\n                <h5>");
            EndContext();
            BeginContext(605, 48, false);
#line 23 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Product.Price));

#line default
#line hidden
            EndContext();
            BeginContext(653, 62, true);
            WriteLiteral("</h5>\r\n            </div>\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(715, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b657c8696e8949eeae19cc6c1997f7f8", async() => {
                BeginContext(760, 15, true);
                WriteLiteral("Update Quantity");
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
#line 26 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml"
                                       WriteLiteral(item.ID);

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
            BeginContext(779, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(797, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b3fbfb672bf453cb62f401702bbd8c5", async() => {
                BeginContext(861, 88, true);
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Remove From Cart\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml"
                                            WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(956, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 32 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Shared\Components\CartFullDetail\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(1001, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PhilBodPill.Models.Basket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
