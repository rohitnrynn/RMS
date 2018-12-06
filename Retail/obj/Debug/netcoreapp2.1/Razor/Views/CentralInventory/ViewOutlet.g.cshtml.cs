#pragma checksum "D:\mvc\Retail\Retail\Views\CentralInventory\ViewOutlet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "962bf7364b00b0e178301371ff74855b4121cbd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CentralInventory_ViewOutlet), @"mvc.1.0.view", @"/Views/CentralInventory/ViewOutlet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CentralInventory/ViewOutlet.cshtml", typeof(AspNetCore.Views_CentralInventory_ViewOutlet))]
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
#line 1 "D:\mvc\Retail\Retail\Views\_ViewImports.cshtml"
using Retail;

#line default
#line hidden
#line 2 "D:\mvc\Retail\Retail\Views\_ViewImports.cshtml"
using Retail.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"962bf7364b00b0e178301371ff74855b4121cbd0", @"/Views/CentralInventory/ViewOutlet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7edaeb9e1a51bced53e5b0f5a956f538d590bcd5", @"/Views/_ViewImports.cshtml")]
    public class Views_CentralInventory_ViewOutlet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Retail.Models.DBModels.Outlet>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewOutlet.cshtml"
  
    ViewData["Title"] = "ViewOutlet";

#line default
#line hidden
            BeginContext(97, 409, true);
            WriteLiteral(@"

<h2>View Outlet</h2>

<div class=""table-responsive"">
    <table class=""table table-hover table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Outlet Id</th>
                <th>Outlet Location</th>
                <th>Outlet Address</th>
                <th>Outlet Phone</th>
                <th></th>
            </tr>
        </thead>
        <tbody>

");
            EndContext();
#line 22 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewOutlet.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(563, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(636, 43, false);
#line 26 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewOutlet.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OutletId));

#line default
#line hidden
            EndContext();
            BeginContext(679, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(759, 43, false);
#line 29 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewOutlet.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(802, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(882, 42, false);
#line 32 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewOutlet.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(924, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1004, 46, false);
#line 35 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewOutlet.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 38 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewOutlet.cshtml"
            }

#line default
#line hidden
            BeginContext(1117, 44, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Retail.Models.DBModels.Outlet>> Html { get; private set; }
    }
}
#pragma warning restore 1591