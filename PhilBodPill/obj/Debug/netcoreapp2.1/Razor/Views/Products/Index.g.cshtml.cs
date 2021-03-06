#pragma checksum "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75939412408872531b74cc481930b799f65546b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml"
using PhilBodPill.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75939412408872531b74cc481930b799f65546b6", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PhilBodPill.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Heading"] = "Our Products!";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(271, 30, true);
            WriteLiteral("\r\n<div class=\"pillow-cards\">\r\n");
            EndContext();
#line 14 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml"
     foreach (var item in Model)
    {
        string imagePath = $"{item.Image}";
        string linkPath = $"/Products/Details/{item.ID}";

#line default
#line hidden
            BeginContext(446, 30, true);
            WriteLiteral("        <a class=\"pillow-card\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 476, "\"", 492, 1);
#line 18 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml"
WriteAttributeValue("", 483, linkPath, 483, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(493, 19, true);
            WriteLiteral(">\r\n            <h3>");
            EndContext();
            BeginContext(513, 39, false);
#line 19 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(552, 30, true);
            WriteLiteral(" Pillow</h3>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 582, "\"", 598, 1);
#line 20 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml"
WriteAttributeValue("", 588, imagePath, 588, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(599, 20, true);
            WriteLiteral(" />\r\n            <p>");
            EndContext();
            BeginContext(620, 46, false);
#line 21 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml"
          Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(666, 64, true);
            WriteLiteral("</p>\r\n            <div class=\"item-price\">\r\n                <h5>");
            EndContext();
            BeginContext(731, 40, false);
#line 23 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(771, 41, true);
            WriteLiteral("</h5>\r\n            </div>\r\n        </a>\r\n");
            EndContext();
#line 26 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Products\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(819, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PhilBodPill.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
