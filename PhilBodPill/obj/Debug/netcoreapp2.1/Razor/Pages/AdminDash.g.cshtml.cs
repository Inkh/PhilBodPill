#pragma checksum "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b7b736aacc2ab46f696afec305670dc75123691"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminDash), @"mvc.1.0.razor-page", @"/Pages/AdminDash.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminDash.cshtml", typeof(AspNetCore.Pages_AdminDash), null)]
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
#line 3 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
using PhilBodPill.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b7b736aacc2ab46f696afec305670dc75123691", @"/Pages/AdminDash.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminDash : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ProductManagement/CreateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ProductManagement/ListProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(118, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
  
    ViewData["Title"] = "Admin Dashboard";
    ViewData["Heading"] = "Administrator Dashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(315, 27, true);
            WriteLiteral("\r\n<div class=\"info-text\">\r\n");
            EndContext();
#line 16 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
            BeginContext(391, 13, true);
            WriteLiteral("        <h3> ");
            EndContext();
            BeginContext(405, 56, false);
#line 18 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
        Write(User.Claims.First(name => name.Type == "greeting").Value);

#line default
#line hidden
            EndContext();
            BeginContext(461, 8, true);
            WriteLiteral(" </h3>\r\n");
            EndContext();
            BeginContext(471, 49, true);
            WriteLiteral("        <ul class=\"admin-menu\">\r\n            <li>");
            EndContext();
            BeginContext(520, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02fb2f31b7e6445f9b495eced7a29ed2", async() => {
                BeginContext(567, 17, true);
                WriteLiteral("Add A New Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(588, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(611, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c003d615b9461e84322078fe0e1f0d", async() => {
                BeginContext(657, 20, true);
                WriteLiteral("Edit/Delete Products");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(681, 22, true);
            WriteLiteral("</li>\r\n        </ul>\r\n");
            EndContext();
            BeginContext(705, 32, true);
            WriteLiteral("        <h4>Recent Orders</h4>\r\n");
            EndContext();
#line 26 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
         if (Model.Orders.Count() == 0)
        {

#line default
#line hidden
            BeginContext(789, 52, true);
            WriteLiteral("            <p>There are no orders to display.</p>\r\n");
            EndContext();
#line 29 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(877, 18, true);
            WriteLiteral("            <ul>\r\n");
            EndContext();
#line 33 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
                 foreach (var item in Model.Orders)
                {
                    

#line default
#line hidden
            BeginContext(988, 50, false);
#line 35 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
               Write(await Component.InvokeAsync("OrderListItem", item));

#line default
#line hidden
            EndContext();
#line 35 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
                                                                       
                }

#line default
#line hidden
            BeginContext(1059, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
#line 38 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
        }

#line default
#line hidden
#line 38 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
         

    }
    else
    {

#line default
#line hidden
            BeginContext(1115, 52, true);
            WriteLiteral("        <p>What? How are you even seeing this?</p>\r\n");
            EndContext();
#line 44 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Pages\AdminDash.cshtml"
    }

#line default
#line hidden
            BeginContext(1174, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhilBodPill.Pages.AdminDashModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PhilBodPill.Pages.AdminDashModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PhilBodPill.Pages.AdminDashModel>)PageContext?.ViewData;
        public PhilBodPill.Pages.AdminDashModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
