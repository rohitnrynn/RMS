#pragma checksum "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7606988685fa994b808b9d77346a6129da1e994"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LocalStoreManager_PlaceOrder), @"mvc.1.0.view", @"/Views/LocalStoreManager/PlaceOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LocalStoreManager/PlaceOrder.cshtml", typeof(AspNetCore.Views_LocalStoreManager_PlaceOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7606988685fa994b808b9d77346a6129da1e994", @"/Views/LocalStoreManager/PlaceOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7edaeb9e1a51bced53e5b0f5a956f538d590bcd5", @"/Views/_ViewImports.cshtml")]
    public class Views_LocalStoreManager_PlaceOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Retail.Models.CustomModels.CustomOrder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dang er"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger field-validation-valid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Quantity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LocalStoreManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddtoOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 463, true);
            WriteLiteral(@"<div class=""table-responsive mt-3"">
  <table class=""table  table-hover table-bordered "" style=""text-align:center;"">
      <thead class=""thead-dark"">
          <tr>
              <th>Product ID</th>
              <th>Name</th>
              <th>Reorder Level</th>
              <th>Saftey Level</th>
              <th>Stock</th>
              <th>Price</th>
              <th>Description/Operation</th>
          </tr>
      </thead>
      <tbody>

");
            EndContext();
#line 17 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
       foreach (var j in ViewBag.LocalProducts)
      {
        

#line default
#line hidden
#line 19 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
         foreach (var b in ViewBag.Products)
        {
            if (j.ProductId == b.ProductId)
            {

#line default
#line hidden
            BeginContext(685, 60, true);
            WriteLiteral("              <tr>\r\n                <td>\r\n                  ");
            EndContext();
            BeginContext(746, 11, false);
#line 25 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
             Write(j.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(757, 65, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                  ");
            EndContext();
            BeginContext(823, 13, false);
#line 28 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
             Write(b.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(836, 65, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                  ");
            EndContext();
            BeginContext(902, 14, false);
#line 31 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
             Write(j.ReorderLevel);

#line default
#line hidden
            EndContext();
            BeginContext(916, 65, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                  ");
            EndContext();
            BeginContext(982, 13, false);
#line 34 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
             Write(j.SafetyLevel);

#line default
#line hidden
            EndContext();
            BeginContext(995, 45, true);
            WriteLiteral("\r\n                </td> \r\n                <td");
            EndContext();
            BeginWriteAttribute("style", " style=\'", 1040, "\'", 1139, 3);
            WriteAttributeValue("", 1048, "color:", 1048, 6, true);
#line 36 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
WriteAttributeValue("", 1054, j.CurrentStock<j.SafetyLevel ? j.CurrentStock<j.ReorderLevel?"red":"blue":"green", 1054, 84, false);

#line default
#line hidden
            WriteAttributeValue("", 1138, ";", 1138, 1, true);
            EndWriteAttribute();
            BeginContext(1140, 21, true);
            WriteLiteral(">\r\n                  ");
            EndContext();
            BeginContext(1162, 14, false);
#line 37 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
             Write(j.CurrentStock);

#line default
#line hidden
            EndContext();
            BeginContext(1176, 65, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                  ");
            EndContext();
            BeginContext(1242, 6, false);
#line 40 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
             Write(b.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(1248, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n\r\n                  ");
            EndContext();
            BeginContext(1335, 1577, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "befcf822874e4f50a6997191bc870867", async() => {
                BeginContext(1361, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
                      
                      int Id = j.ProductId;
                    

#line default
#line hidden
                BeginContext(1455, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1475, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b991ff5e52cb4eccb386ea552e325ae8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 48 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
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
                BeginContext(1512, 622, true);
                WriteLiteral(@"
                    <button type=""button"" style=""background-color:black; border-color:black;"" class=""btn btn-primary rounded-circle"" data-toggle=""dropdown"">
                      <i class=""fa fa-expand"">View</i>
                    </button>&emsp;
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
#line 61 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
                           foreach (var sp in ViewBag.Spec)
                          {
                            if (j.ProductId == sp.ProdId)
                            {

#line default
#line hidden
                BeginContext(2314, 75, true);
                WriteLiteral("                              <tr>\r\n                                <td><p>");
                EndContext();
                BeginContext(2390, 11, false);
#line 66 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
                                  Write(sp.SpecName);

#line default
#line hidden
                EndContext();
                BeginContext(2401, 50, true);
                WriteLiteral("</p></td>\r\n                                <td><p>");
                EndContext();
                BeginContext(2452, 12, false);
#line 67 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
                                  Write(sp.SpecValue);

#line default
#line hidden
                EndContext();
                BeginContext(2464, 48, true);
                WriteLiteral("</p></td>\r\n                              </tr>\r\n");
                EndContext();
#line 69 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
                            }

                          }

#line default
#line hidden
                BeginContext(2574, 257, true);
                WriteLiteral(@"                        </tbody>
                      </table>
                    </div>
                    <button type=""button"" style=""background-color:black; border-color:black;"" class=""btn btn-dark"" data-toggle=""collapse"" data-target=""#addProduct""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2831, "\"", 2860, 3);
                WriteAttributeValue("", 2841, "getId(", 2841, 6, true);
#line 75 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
WriteAttributeValue("", 2847, j.ProductId, 2847, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 2859, ")", 2859, 1, true);
                EndWriteAttribute();
                BeginContext(2861, 44, true);
                WriteLiteral(">Add Quantity</button>\r\n\r\n                  ");
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
            BeginContext(2912, 50, true);
            WriteLiteral("\r\n\r\n                </td>\r\n\r\n              </tr>\r\n");
            EndContext();
#line 82 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
            }

          }

#line default
#line hidden
#line 84 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
           
        }

#line default
#line hidden
            BeginContext(3003, 86, true);
            WriteLiteral("      \r\n\r\n    </tbody>\r\n  </table>\r\n</div>\r\n<div id=\"addProduct\" class=\"collapse\">\r\n  ");
            EndContext();
            BeginContext(3089, 802, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9b9ca9c31474177b755268574d943ff", async() => {
                BeginContext(3168, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3174, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd194cd33d0e47f297862e90557afef9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 93 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3241, 60, true);
                WriteLiteral("\r\n    <div class=\"form-group\" style=\"display:none;\">\r\n      ");
                EndContext();
                BeginContext(3301, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af17766abe4e4994b0f174af29c0707a", async() => {
                    BeginContext(3347, 10, true);
                    WriteLiteral("Product Id");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 95 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProdId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3365, 8, true);
                WriteLiteral("\r\n      ");
                EndContext();
                BeginContext(3373, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21f10debe9ff4f32885100c77812e824", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 96 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProdId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3437, 8, true);
                WriteLiteral("\r\n      ");
                EndContext();
                BeginContext(3445, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92a0526f04bc4724ae5969ccb63627bb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 97 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProdId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3529, 51, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\" >\r\n      ");
                EndContext();
                BeginContext(3580, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1cbffb145c93436588b4bb1f192e12f4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 100 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Qty);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3656, 8, true);
                WriteLiteral("\r\n      ");
                EndContext();
                BeginContext(3664, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58c92a45b9341b1b141ff8b39f7b76a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 101 "D:\mvc\Retail\Retail\Views\LocalStoreManager\PlaceOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Qty);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3745, 139, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n      <input type=\"submit\" value=\"Add to Cart\" class=\"btn btn-dark btn-info\" />\r\n    </div>\r\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3891, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3924, 243, true);
                WriteLiteral("\r\n  <script>\r\n\r\n    function OnProductSelect(cb, id) {\r\n      if (cb.clicked) {\r\n\r\n        $(\'#\' + id).show();\r\n      }\r\n      else {\r\n        $(\'#\' + id).hide();\r\n      }\r\n    }\r\n\r\n    $(document).ready(function () {\r\n\r\n    });\r\n  </script>\r\n");
                EndContext();
            }
            );
            BeginContext(4170, 103, true);
            WriteLiteral("\r\n<script>\r\n  function getId(str) {\r\n    document.getElementById(\"id\").value = str;\r\n  }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Retail.Models.CustomModels.CustomOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
