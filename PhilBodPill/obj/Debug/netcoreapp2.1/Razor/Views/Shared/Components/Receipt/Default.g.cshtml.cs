#pragma checksum "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\Components\Receipt\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2986525a90e03fdd43f76e5e3af1be9df55067a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Receipt_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Receipt/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Receipt/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Receipt_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2986525a90e03fdd43f76e5e3af1be9df55067a0", @"/Views/Shared/Components/Receipt/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Receipt_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PhilBodPill.Models.Basket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 11, true);
            WriteLiteral("\r\n<tbody>\r\n");
            EndContext();
#line 4 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\Components\Receipt\Default.cshtml"
       decimal total = 0; 

#line default
#line hidden
            BeginContext(80, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 5 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\Components\Receipt\Default.cshtml"
     foreach (var item in Model)
    {
        decimal subtotal = item.Product.Price * (decimal)item.Quantity;
        total += subtotal;

#line default
#line hidden
            BeginContext(222, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(271, 17, false);
#line 11 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\Components\Receipt\Default.cshtml"
           Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(288, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(344, 18, false);
#line 14 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\Components\Receipt\Default.cshtml"
           Write(item.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(362, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(418, 13, false);
#line 17 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\Components\Receipt\Default.cshtml"
           Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(431, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(487, 8, false);
#line 20 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\Components\Receipt\Default.cshtml"
           Write(subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(495, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 23 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\Components\Receipt\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(538, 141, true);
            WriteLiteral("</tbody>\r\n<tfoot>\r\n    <tr>\r\n        <td>\r\n            Total\r\n        </td>\r\n        <td></td>\r\n        <td></td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(680, 5, false);
#line 33 "C:\Users\nethw\Code\401\PhilBodPill\PhilBodPill\Views\Shared\Components\Receipt\Default.cshtml"
       Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(685, 38, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</tfoot>\r\n");
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
