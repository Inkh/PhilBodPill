#pragma checksum "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86133e9624154464bdf137425c7928c19ee8426e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
#line 1 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
using PhilBodPill.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86133e9624154464bdf137425c7928c19ee8426e", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhilBodPill.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(148, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "_Layout";
    string imagePath = $"{Model.Image}";

#line default
#line hidden
            BeginContext(260, 107, true);
            WriteLiteral("<h1>Product Details</h1>\r\n\r\n<div class=\"product-details-area\">\r\n    <div class=\"pillow-card\">\r\n        <h2>");
            EndContext();
            BeginContext(368, 10, false);
#line 17 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(378, 26, true);
            WriteLiteral(" Pillow</h2>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 404, "\"", 420, 1);
#line 18 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
WriteAttributeValue("", 410, imagePath, 410, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(421, 16, true);
            WriteLiteral(" />\r\n        <p>");
            EndContext();
            BeginContext(438, 17, false);
#line 19 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(455, 56, true);
            WriteLiteral("</p>\r\n        <div class=\"item-price\">\r\n            <h5>");
            EndContext();
            BeginContext(512, 11, false);
#line 21 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
           Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(523, 85, true);
            WriteLiteral("</h5>\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n        <div class=\"order-section\">\r\n");
            EndContext();
#line 27 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
             if (SignInManager.IsSignedIn(User))
            {
                

#line default
#line hidden
#line 29 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
                 if (User.IsInRole(UserRoles.Admin))
                {

#line default
#line hidden
            BeginContext(746, 118, true);
            WriteLiteral("                    <h2>Admin Controlls</h2>\r\n                    <div class=\"fancy-button\">\r\n                        ");
            EndContext();
            BeginContext(864, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f28e928eab714df390d0f6b0c275e3bc", async() => {
                BeginContext(910, 4, true);
                WriteLiteral("Edit");
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
#line 33 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
                                               WriteLiteral(Model.ID);

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
            BeginContext(918, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 35 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
                }

#line default
#line hidden
#line 35 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(982, 75, true);
            WriteLiteral("        </div>\r\n        <div class=\"order-section\">\r\n            <h2>Order ");
            EndContext();
            BeginContext(1058, 10, false);
#line 39 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1068, 16, true);
            WriteLiteral(" Pillows!</h2>\r\n");
            EndContext();
#line 40 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
             if (SignInManager.IsSignedIn(User))
            {
                if (User.Claims.First(n => n.Type == "firstNameLower").Value == "chet")
                {

#line default
#line hidden
            BeginContext(1257, 83, true);
            WriteLiteral("                    <h3 class=\"danger-text\">Go Away, Chet! Nobody likes you!</h3>\r\n");
            EndContext();
#line 45 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1400, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1420, 490, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eca47a6e0f4402ea73d76edfa22f619", async() => {
                BeginContext(1466, 60, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"UserID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1526, "\"", 1585, 1);
#line 49 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
WriteAttributeValue("", 1534, User.Claims.First(id => id.Type == "userID").Value, 1534, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1586, 66, true);
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"ProductID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1652, "\"", 1669, 1);
#line 50 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
WriteAttributeValue("", 1660, Model.ID, 1660, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1670, 233, true);
                WriteLiteral(" />\r\n                        <label for=\"Quantity\">Quantity</label>\r\n                        <input type=\"number\" name=\"Quantity\" value=\"1\" />\r\n                        <input type=\"submit\" value=\"Add To Cart\" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1910, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(1979, 58, true);
            WriteLiteral("                <h3>You must be signed in to order!</h3>\r\n");
            EndContext();
#line 60 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Products\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(2052, 35, true);
            WriteLiteral("            <div>\r\n                ");
            EndContext();
            BeginContext(2087, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee50abeae3374a788aedc78c3a0c46f8", async() => {
                BeginContext(2109, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2125, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhilBodPill.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
