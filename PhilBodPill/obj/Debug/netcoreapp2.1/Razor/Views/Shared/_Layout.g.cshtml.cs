#pragma checksum "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0143503533b6919d29defaba5fdec6c53e10ad24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
using PhilBodPill.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0143503533b6919d29defaba5fdec6c53e10ad24", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(111, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(138, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e379aca2a2a4978be8a094ef0b3f2c2", async() => {
                BeginContext(144, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(217, 13, false);
#line 10 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(230, 14, true);
                WriteLiteral("</title>\r\n    ");
                EndContext();
                BeginContext(244, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e13d03ec2684e2ab3dc50a00fb76c36", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(307, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(316, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(318, 1669, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c842a3a9c254a0793daf311908ec63c", async() => {
                BeginContext(324, 45, true);
                WriteLiteral("\r\n    <nav>\r\n        <ul class=\"nav-items\">\r\n");
                EndContext();
#line 16 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
             if (SignInManager.IsSignedIn(User))
            {

#line default
#line hidden
                BeginContext(434, 34, true);
                WriteLiteral("            <li>\r\n                ");
                EndContext();
                BeginContext(469, 56, false);
#line 19 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
           Write(User.Claims.First(name => name.Type == "greeting").Value);

#line default
#line hidden
                EndContext();
                BeginContext(525, 55, true);
                WriteLiteral("\r\n            </li>\r\n            <li>\r\n                ");
                EndContext();
                BeginContext(580, 168, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f4fa6773b04abdb5716a0017fc6d04", async() => {
                    BeginContext(642, 99, true);
                    WriteLiteral("\r\n                    <input class=\"fancy-button\" type=\"submit\" value=\"Logout\" />\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(748, 21, true);
                WriteLiteral("\r\n            </li>\r\n");
                EndContext();
#line 26 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(817, 42, true);
                WriteLiteral("                <li>\r\n                    ");
                EndContext();
                BeginContext(860, 47, false);
#line 30 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
               Write(Html.ActionLink("Register", "Register", "User"));

#line default
#line hidden
                EndContext();
                BeginContext(907, 67, true);
                WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
                EndContext();
                BeginContext(975, 42, false);
#line 33 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
               Write(Html.ActionLink("Log In", "Login", "User"));

#line default
#line hidden
                EndContext();
                BeginContext(1017, 25, true);
                WriteLiteral("\r\n                </li>\r\n");
                EndContext();
#line 35 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
            }

#line default
#line hidden
                BeginContext(1057, 30, true);
                WriteLiteral("            <li>\r\n            ");
                EndContext();
                BeginContext(1088, 52, false);
#line 37 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
       Write(Html.ActionLink("Our Products", "Index", "Products"));

#line default
#line hidden
                EndContext();
                BeginContext(1140, 145, true);
                WriteLiteral("\r\n            </li>\r\n        </ul>\r\n        \r\n    </nav>\r\n    <main>\r\n        <div class=\"main-container\">\r\n            <h2 class=\"page-heading\">");
                EndContext();
                BeginContext(1286, 15, false);
#line 44 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
                                Write(ViewBag.Heading);

#line default
#line hidden
                EndContext();
                BeginContext(1301, 19, true);
                WriteLiteral("</h2>\r\n            ");
                EndContext();
                BeginContext(1321, 12, false);
#line 45 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1333, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1348, 41, false);
#line 46 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
       Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1389, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 48 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
                BeginContext(1464, 38, true);
                WriteLiteral("        <div class=\"cart-container\">\r\n");
                EndContext();
#line 51 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
             if (User.Claims.First(n => n.Type == "firstNameLower").Value == "chet")
            {

#line default
#line hidden
                BeginContext(1603, 60, true);
                WriteLiteral("                <h4>Chet is not allowed to shop here.</h4>\r\n");
                EndContext();
#line 54 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(1711, 104, true);
                WriteLiteral("                <a href=\"/Basket/Index\">\r\n                    <h2>Your Cart</h2>\r\n                </a>\r\n");
                EndContext();
                BeginContext(1832, 91, false);
#line 60 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
           Write(await Component.InvokeAsync("Cart", User.Claims.First(name => name.Type == "userID").Value));

#line default
#line hidden
                EndContext();
#line 60 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
                                                                                                            
            }

#line default
#line hidden
                BeginContext(1940, 16, true);
                WriteLiteral("        </div>\r\n");
                EndContext();
#line 63 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\_Layout.cshtml"
        }

#line default
#line hidden
                BeginContext(1967, 13, true);
                WriteLiteral("    </main>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1987, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
