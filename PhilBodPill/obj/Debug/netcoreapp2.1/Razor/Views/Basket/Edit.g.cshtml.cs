#pragma checksum "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Basket\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a1716618fda603f386526dcf0374ee713a96da2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Edit), @"mvc.1.0.view", @"/Views/Basket/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Basket/Edit.cshtml", typeof(AspNetCore.Views_Basket_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a1716618fda603f386526dcf0374ee713a96da2", @"/Views/Basket/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhilBodPill.Models.Basket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Basket\Edit.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(96, 27, true);
            WriteLiteral("\n<h2>Update Quantity</h2>\n\n");
            EndContext();
            BeginContext(123, 198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdb69fd7deaf46518d5390b955c46d39", async() => {
                BeginContext(161, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(166, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1fc074c356444f894146b072ec0edc2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 11 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Basket\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(202, 41, true);
                WriteLiteral("\n    <input type=\"number\" name=\"Quantity\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 243, "\"", 266, 1);
#line 12 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Basket\Edit.cshtml"
WriteAttributeValue("", 251, Model.Quantity, 251, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(267, 47, true);
                WriteLiteral(" />\n    <input type=\"submit\" value=\"Update\" />\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(321, 36, true);
            WriteLiteral("\n\n<div class=\"pillow-card\">\n    <h3>");
            EndContext();
            BeginContext(358, 48, false);
#line 17 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Basket\Edit.cshtml"
   Write(Html.DisplayFor(modelItem => Model.Product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(406, 21, true);
            WriteLiteral(" Pillow</h3>\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 427, "\"", 453, 1);
#line 18 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Basket\Edit.cshtml"
WriteAttributeValue("", 433, Model.Product.Image, 433, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(454, 11, true);
            WriteLiteral(" />\n    <p>");
            EndContext();
            BeginContext(466, 55, false);
#line 19 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Basket\Edit.cshtml"
  Write(Html.DisplayFor(modelItem => Model.Product.Description));

#line default
#line hidden
            EndContext();
            BeginContext(521, 46, true);
            WriteLiteral("</p>\n    <div class=\"item-price\">\n        <h5>");
            EndContext();
            BeginContext(568, 49, false);
#line 21 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Basket\Edit.cshtml"
       Write(Html.DisplayFor(modelItem => Model.Product.Price));

#line default
#line hidden
            EndContext();
            BeginContext(617, 25, true);
            WriteLiteral("</h5>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(660, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 26 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Basket\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhilBodPill.Models.Basket> Html { get; private set; }
    }
}
#pragma warning restore 1591
