#pragma checksum "D:\mvc\Retail\Retail\Views\POS\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21b4e5d9b5aa924ce8b94b85011fb94ab8c8705f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_POS_Index), @"mvc.1.0.view", @"/Views/POS/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/POS/Index.cshtml", typeof(AspNetCore.Views_POS_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b4e5d9b5aa924ce8b94b85011fb94ab8c8705f", @"/Views/POS/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7edaeb9e1a51bced53e5b0f5a956f538d590bcd5", @"/Views/_ViewImports.cshtml")]
    public class Views_POS_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Retail.Models.ViewModel.CustomModelBag>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-dark mr-sm-2 ml-lg-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label mr-lg-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label ml-lg-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Quantity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-dark mr-sm-2 ml-lg-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToBill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 305, true);
            WriteLiteral(@"
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<div class=""card mt-1"">
    <div class=""card-body"">
        <h2 class=""card-title"" style=""text-align:center;""><strong>Billing</strong> </h2>
        ");
            EndContext();
            BeginContext(393, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a38cfcbc3cb42dfa13ffa71b53d7f6c", async() => {
                BeginContext(399, 69, true);
                WriteLiteral("\r\n            <div class=\"form-inline float-right\">\r\n                ");
                EndContext();
                BeginContext(468, 132, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65b4f8d367b4769b47690d499ef204c", async() => {
                    BeginContext(581, 10, true);
                    WriteLiteral("Print Bill");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(600, 30, true);
                WriteLiteral("\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(637, 52, true);
            WriteLiteral("<br /><br />\r\n\r\n        <div class=\"\">\r\n            ");
            EndContext();
            BeginContext(689, 789, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71de9aec15884c4783bb1c606e413b28", async() => {
                BeginContext(695, 65, true);
                WriteLiteral("\r\n                <div class=\"form-inline\">\r\n                    ");
                EndContext();
                BeginContext(760, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c41e1592b97c40089589a8998bbed3eb", async() => {
                    BeginContext(829, 27, true);
                    WriteLiteral("<strong>Product Id</strong>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 20 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BillDetails.ProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(864, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(886, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35ef77b694b84ead8c3480a4226811e6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 21 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BillDetails.ProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 21 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.ProductId;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1006, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1028, 114, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc073332e4ee46a6970bf01db175ff1e", async() => {
                    BeginContext(1096, 38, true);
                    WriteLiteral("<strong>Quantity</strong> &nbsp;&nbsp;");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 22 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BillDetails.Quantity);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1142, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1164, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a88fd9680b44ad5830f989b63cd3d4d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 23 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BillDetails.Quantity);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1274, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1296, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5821df03fec547f1808bac9b8b99a447", async() => {
                    BeginContext(1411, 11, true);
                    WriteLiteral("Add To Bill");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1431, 40, true);
                WriteLiteral("\r\n\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1478, 771, true);
            WriteLiteral(@"
            <br /><br />
            <h5 class=""text-center""><strong>Bill Details</strong></h5>
            <br />
            <div class=""row clearfix"">
                <div class=""col-md-12"">
                    <table class=""table table-bordered table-hover"" id=""tab_logic"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th class=""text-center""> Product </th>
                                <th class=""text-center""> Quantity </th>
                                <th class=""text-center""> Unit Price(₹) </th>
                                <th class=""text-center""> Amount(₹) </th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 43 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
                             foreach (var bill in ViewBag.BillDetails)
                            {
                                

#line default
#line hidden
#line 45 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
                                 foreach (var prod in ViewBag.Products)
                                {
                                    if (bill.ProductId == prod.ProductId)
                                    {

#line default
#line hidden
            BeginContext(2574, 197, true);
            WriteLiteral("                                        <tr id=\'addr0\'>\r\n                                            <td><input type=\"text\" name=\'product[]\' placeholder=\'Product Name\' class=\"form-control\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2771, "\"", 2814, 1);
#line 50 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
WriteAttributeValue("", 2779, prod.ProductName ?? String.Empty, 2779, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2815, 165, true);
            WriteLiteral(" /></td>\r\n                                            <td><input type=\"number\" name=\'qty[]\' placeholder=\'Quantity\' class=\"form-control qty\" step=\"0\" min=\"0\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2980, "\"", 3020, 1);
#line 51 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
WriteAttributeValue("", 2988, bill.Quantity ?? String.Empty, 2988, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3021, 174, true);
            WriteLiteral(" /></td>\r\n                                            <td><input type=\"number\" name=\'price[]\' placeholder=\'Unit Price\' class=\"form-control price\" step=\"0.00\" min=\"0\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3195, "\"", 3231, 1);
#line 52 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
WriteAttributeValue("", 3203, prod.Rate ?? String.Empty, 3203, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3232, 148, true);
            WriteLiteral(" /></td>\r\n                                            <td><input type=\"number\" name=\'total[]\' placeholder=\'0.00\' class=\"form-control total\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3380, "\"", 3418, 1);
#line 53 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
WriteAttributeValue("", 3388, bill.Amount ?? String.Empty, 3388, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3419, 57, true);
            WriteLiteral(" /></td>\r\n                                        </tr>\r\n");
            EndContext();
#line 55 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#line 56 "D:\mvc\Retail\Retail\Views\POS\Index.cshtml"
                                 
                            }

#line default
#line hidden
            BeginContext(3581, 4204, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""row clearfix  pull-left"" style=""margin-top:20px;"">
                <div class=""pull-right mr-lg-2"">
                    <table class=""table table-bordered table-hover"" id=""tab_logic_total"">
                        <tbody>
                            <tr "">
                                <th class=""text-center"">Sub Total</th>
                                <td class=""text-center""><input type=""number"" name='sub_total' placeholder='0.00' class=""form-control"" id=""sub_total"" readonly /></td>
                            </tr>
                            <tr>
                                <th class=""text-center"">Discount</th>
                                <td class=""text-center"">
                                    <div class=""input-group mb-2 mb-sm-0"">
                                        <input type=""number"" class=""form-control"" id=""tax"" name=""tax"" placeholder=""0""");
            WriteLiteral(@">
                                        <div class=""input-group-addon"">%</div>
                                    </div>
                                </td>
                                <th class=""text-center"">Discount Amount</th>
                                <td class=""text-center""><input type=""number"" asp-for=""Bill.TotalDiscount"" name='tax_amount' id=""tax_amount"" placeholder='0.00' class=""form-control"" readonly /></td>

                            </tr>
                            <tr></tr>
                            <tr>
                                <th class=""text-center"">GST</th>
                                <td class=""text-center"">
                                    <div class=""input-group mb-2 mb-sm-0"">
                                        <input type=""number"" class=""form-control"" id=""gst"" name=""gst"" placeholder=""0"" readonly value=""5"">
                                        <div class=""input-group-addon"">%</div>
                                    </div>
         ");
            WriteLiteral(@"                       </td>
                                <th class=""text-center"">GST Amount</th>
                                <td class=""text-center""><input type=""number"" name='gst_amount' id=""gst_amount"" placeholder='0.00' class=""form-control"" readonly /></td>

                            </tr>
                            <tr></tr>
                            <tr>
                                <th class=""text-right"">Grand Total(₹)</th>
                                <td class=""text-right"" style=""background-color:black;""><input type=""number"" asp-for=""Bill.TotalPayable"" name='total_amount' id=""total_amount"" placeholder='0.00' class=""form-control"" readonly /></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>

        </div>

    </div>

</div>





<script>
    $(document).ready(function () {
        //$('#tab_logic tbody').on('keyup change', function () {
        calc();
        /");
            WriteLiteral(@"/});
        $('#tax').on('keyup change', function () {
            calc_total();
        });
        $('#gst').on('keyup change', function () {
            calc_total();
        });
    });

    function calc() {
        $('#tab_logic tbody tr').each(function (i, element) {
            var html = $(this).html();
            if (html != '') {
                var qty = $(this).find('.qty').val();
                var price = $(this).find('.price').val();
                $(this).find('.total').val(qty * price);

                calc_total();
            }
        });
    }

    function calc_total() {
        total = 0;
        $('.total').each(function () {
            total += parseInt($(this).val());
        });
        $('#sub_total').val(total.toFixed(2));
        gst_sum = total / 100 * $('#gst').val();
        totalamount = total + gst_sum;
        tax_sum = totalamount / 100 * $('#tax').val();
        $('#gst_amount').val(gst_sum.toFixed(2));
        $('#tax_amount').val(t");
            WriteLiteral("ax_sum.toFixed(2));\r\n        $(\'#total_amount\').val((totalamount - tax_sum).toFixed(2));\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Retail.Models.ViewModel.CustomModelBag> Html { get; private set; }
    }
}
#pragma warning restore 1591