#pragma checksum "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ea0f97f1daa139929424574924e63ece94d1150"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LocalStoreInCharge_InventoryCatalogue), @"mvc.1.0.view", @"/Views/LocalStoreInCharge/InventoryCatalogue.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LocalStoreInCharge/InventoryCatalogue.cshtml", typeof(AspNetCore.Views_LocalStoreInCharge_InventoryCatalogue))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea0f97f1daa139929424574924e63ece94d1150", @"/Views/LocalStoreInCharge/InventoryCatalogue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7edaeb9e1a51bced53e5b0f5a956f538d590bcd5", @"/Views/_ViewImports.cshtml")]
    public class Views_LocalStoreInCharge_InventoryCatalogue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(16, 378, true);
            WriteLiteral(@"<div class=""table-responsive mt-3"">
    <table class=""table"">
        <thead class=""thead-dark"">
        <tr>
            <th>Product ID</th>
            <th>Name</th>
            <th>Reorder Level</th>
            <th>Saftey Level</th>
            <th>Stock</th>
            <th>Price(₹)</th>
            <th>Description</th>
        </tr></thead>
        <tbody>
");
            EndContext();
#line 15 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
             foreach (var j in Model.local)
            {
                

#line default
#line hidden
#line 17 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                 foreach (var b in Model.prod)
                {
                    if (j.ProductId == b.ProductId)
                    {

#line default
#line hidden
            BeginContext(597, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(694, 11, false);
#line 23 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                           Write(j.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(705, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(809, 13, false);
#line 26 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                           Write(b.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(822, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(926, 14, false);
#line 29 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                           Write(j.ReorderLevel);

#line default
#line hidden
            EndContext();
            BeginContext(940, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1044, 13, false);
#line 32 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                           Write(j.SafetyLevel);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1161, 14, false);
#line 35 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                           Write(j.CurrentStock);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1279, 6, false);
#line 38 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                           Write(b.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(1285, 125, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n\r\n                                ");
            EndContext();
            BeginContext(1410, 1955, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac3d38d8f7594031975e4424ec5cbae4", async() => {
                BeginContext(1425, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                                      
                                        int Id = j.ProductId;
                                    

#line default
#line hidden
                BeginContext(1569, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1605, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6fce2dadc7f34a8ea85edf8e7f743ec3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 46 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Id);

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
                BeginContext(1642, 852, true);
                WriteLiteral(@"
                                    <button type=""button"" style=""background-color:black; border-color:black;"" class=""btn btn-primary rounded-circle"" data-toggle=""dropdown"">
                                        <i class=""fa fa-expand"">View</i>
                                    </button>
                                    <div class=""dropdown-menu"">
                                        <table class="""">
                                            <thead class=""thead-dark"">
                                                <tr>
                                                    <th>Specification</th>
                                                    <th>Value</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
                EndContext();
#line 59 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                                                 foreach (var sp in Model.spec)
                                                {
                                                    if (j.ProductId == sp.ProdId)
                                                    {

#line default
#line hidden
                BeginContext(2764, 129, true);
                WriteLiteral("                                                        <tr>\r\n                                                            <td><p>");
                EndContext();
                BeginContext(2894, 11, false);
#line 64 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                                                              Write(sp.SpecName);

#line default
#line hidden
                EndContext();
                BeginContext(2905, 78, true);
                WriteLiteral("</p></td>\r\n                                                            <td><p>");
                EndContext();
                BeginContext(2984, 12, false);
#line 65 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                                                              Write(sp.SpecValue);

#line default
#line hidden
                EndContext();
                BeginContext(2996, 74, true);
                WriteLiteral("</p></td>\r\n                                                        </tr>\r\n");
                EndContext();
#line 67 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                                                    }

                                                }

#line default
#line hidden
                BeginContext(3178, 180, true);
                WriteLiteral("                                            </tbody>\r\n                                        </table>\r\n                                    </div>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3365, 70, true);
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 77 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                    }
                }

#line default
#line hidden
#line 78 "D:\mvc\Retail\Retail\Views\LocalStoreInCharge\InventoryCatalogue.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(3492, 42, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
