#pragma checksum "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7290b9f71a3fd57e7683ffd094b70155cf77a516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CentralInventory_ViewStaff), @"mvc.1.0.view", @"/Views/CentralInventory/ViewStaff.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CentralInventory/ViewStaff.cshtml", typeof(AspNetCore.Views_CentralInventory_ViewStaff))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7290b9f71a3fd57e7683ffd094b70155cf77a516", @"/Views/CentralInventory/ViewStaff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7edaeb9e1a51bced53e5b0f5a956f538d590bcd5", @"/Views/_ViewImports.cshtml")]
    public class Views_CentralInventory_ViewStaff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Retail.Models.DBModels.Staff>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 618, true);
            WriteLiteral(@"    <h2>ViewStaff</h2>

    <div class=""table-responsive table-bordered table-hover"">
        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Staff Id</th>
                    <th>Staff Name</th>
                    <th>Staff Address</th>
                    <th>Staff Dob</th>
                    <th>Staff Phone</th>
                    <th>Staff Role</th>
                    <th>Staff Username</th>
                    <th>Staff Password</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>

");
            EndContext();
#line 21 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
            BeginContext(732, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(817, 37, false);
#line 25 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(854, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(946, 39, false);
#line 28 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(985, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1077, 42, false);
#line 31 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1211, 38, false);
#line 34 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1341, 46, false);
#line 37 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1479, 39, false);
#line 40 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1610, 43, false);
#line 43 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1653, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1745, 43, false);
#line 46 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 58, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 50 "D:\mvc\Retail\Retail\Views\CentralInventory\ViewStaff.cshtml"
            }

#line default
#line hidden
            BeginContext(1861, 69, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<!--Confirmation Modal-->\r\n");
            EndContext();
            BeginContext(6877, 28, true);
            WriteLiteral("<!--Update Details Ends-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Retail.Models.DBModels.Staff>> Html { get; private set; }
    }
}
#pragma warning restore 1591
