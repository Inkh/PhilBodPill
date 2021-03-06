#pragma checksum "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Basket\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "160a279b50c7b93d1f80d705b5e0825f569132e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Checkout), @"mvc.1.0.view", @"/Views/Basket/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Basket/Checkout.cshtml", typeof(AspNetCore.Views_Basket_Checkout))]
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
#line 1 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Basket\Checkout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Basket\Checkout.cshtml"
using PhilBodPill.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"160a279b50c7b93d1f80d705b5e0825f569132e4", @"/Views/Basket/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PhilBodPill.Models.Basket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(154, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Basket\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    ViewData["Heading"] = "Your Order Has Been Placed";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(282, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Basket\Checkout.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    string uid = User.Claims.First(id => id.Type == "userID").Value;
    string email = User.Claims.First(x => x.Type == "userEmail").Value;
    object userData = new
    {
        uid = uid,
        email = email
    };


#line default
#line hidden
            BeginContext(555, 134, true);
            WriteLiteral("    <h3>Well Done! You are now the proud owner some sweet philosopher body pillows.</h3>\r\n    <h5>You\'ll never be lonely again.</h5>\r\n");
            EndContext();
            BeginContext(691, 70, true);
            WriteLiteral("    <p>This is your reciept. Please keep a copy for your records</p>\r\n");
            EndContext();
            BeginContext(763, 394, true);
            WriteLiteral(@"    <table>
        <thead>
            <tr>
                <td>
                    Product
                </td>
                <td>
                    Unit Price
                </td>
                <td>
                    Quantity
                </td>
                <td>
                    Subtotal
                </td>
            </tr>
        </thead>
        ");
            EndContext();
            BeginContext(1158, 48, false);
#line 46 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Basket\Checkout.cshtml"
   Write(await Component.InvokeAsync("Receipt", userData));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 48 "C:\Users\Jeff\source\repos\PhilosopherBodyPillow\PhilBodPill\Views\Basket\Checkout.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PhilBodPill.Models.Basket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
