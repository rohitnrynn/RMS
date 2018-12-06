#pragma checksum "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a3558cf22420853152c1ce7c08af09eefdd8747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LocalStoreManager_ManageOrder), @"mvc.1.0.view", @"/Views/LocalStoreManager/ManageOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LocalStoreManager/ManageOrder.cshtml", typeof(AspNetCore.Views_LocalStoreManager_ManageOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3558cf22420853152c1ce7c08af09eefdd8747", @"/Views/LocalStoreManager/ManageOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7edaeb9e1a51bced53e5b0f5a956f538d590bcd5", @"/Views/_ViewImports.cshtml")]
    public class Views_LocalStoreManager_ManageOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LocalStoreManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 577, true);
            WriteLiteral(@"<div class=""accordion mt-5"" id=""accordionExample"">
  <div class=""card"">
    <div class=""card-header"" style=""background-color:rgb(52, 58, 64)"" id=""headingOne"">
      <h5 class=""mb-0"">
        <button class=""btn btn-link"" type=""button"" style=""align-self:center; font-weight:600; color:white;"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
          Pending Orders
        </button>
      </h5>
    </div>
    <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
");
            EndContext();
#line 11 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
       foreach (var odr in ViewBag.Pending)
      {
        

#line default
#line hidden
#line 13 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
         if (Enumerable.Count(ViewBag.Pending) > 0)
        {

#line default
#line hidden
            BeginContext(695, 89, true);
            WriteLiteral("          <div class=\"card-body\">\r\n            <p class=\"btn btn-dark\"><strong>Order Id: ");
            EndContext();
            BeginContext(785, 11, false);
#line 16 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                                                 Write(odr.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(796, 49, true);
            WriteLiteral("</strong></p>\r\n            <p><strong>Placed On: ");
            EndContext();
            BeginContext(846, 13, false);
#line 17 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                             Write(odr.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(859, 15, true);
            WriteLiteral("</strong></p>\r\n");
            EndContext();
#line 18 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
             foreach (var pending in ViewBag.Pending)
            {
              if (odr.OrderId == pending.OrderId)
              {
                

#line default
#line hidden
#line 22 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                 foreach (var prod in ViewBag.Prod)
                {
                  

#line default
#line hidden
#line 24 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                   foreach (var det in ViewBag.OrderDetails)
                  {
                    if (prod.ProductId == det.ProductId && pending.OrderId == det.OrderId)
                    {

#line default
#line hidden
            BeginContext(1282, 69, true);
            WriteLiteral("                      <hr />\r\n                      <p>Product Name: ");
            EndContext();
            BeginContext(1352, 16, false);
#line 29 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                                  Write(prod.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1368, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 30 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                       foreach (var det1 in ViewBag.OrderDetails)
                      {
                        if (det1.OrderId == odr.OrderId && prod.ProductId == det1.ProductId)
                        {

#line default
#line hidden
            BeginContext(1587, 39, true);
            WriteLiteral("                          <p>Quantity: ");
            EndContext();
            BeginContext(1627, 12, false);
#line 34 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                                  Write(det.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1639, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 35 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                        }
                      }

#line default
#line hidden
#line 36 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                       
                    }
                  }

#line default
#line hidden
#line 38 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                   

                }

#line default
#line hidden
#line 40 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                 


              }

            }

#line default
#line hidden
            BeginContext(1800, 20, true);
            WriteLiteral("\r\n          </div>\r\n");
            EndContext();
#line 48 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
        }

#line default
#line hidden
#line 48 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
         

      }

#line default
#line hidden
            BeginContext(1842, 537, true);
            WriteLiteral(@"    </div>
  </div>
  <div class=""card"">
    <div class=""card-header"" style=""background-color:rgb(52, 58, 64)"" id=""headingTwo"">
      <h5 class=""mb-0"">
        <button class=""btn btn-link collapsed"" style=""font-weight:600; color:white;"" type=""button"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
          Dispatched Orders
        </button>
      </h5>
    </div>
    <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
");
            EndContext();
#line 62 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
       foreach (var odr in ViewBag.Dispatched)
      {
        

#line default
#line hidden
#line 64 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
         if (Enumerable.Count(ViewBag.Dispatched) > 0)
        {

#line default
#line hidden
            BeginContext(2503, 81, true);
            WriteLiteral("      <div class=\"card-body\">\r\n        <p class=\"btn btn-dark\"><strong>Order Id: ");
            EndContext();
            BeginContext(2585, 11, false);
#line 67 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                                             Write(odr.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(2596, 45, true);
            WriteLiteral("</strong></p>\r\n        <p><strong>Placed On: ");
            EndContext();
            BeginContext(2642, 13, false);
#line 68 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                         Write(odr.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(2655, 23, true);
            WriteLiteral("</strong></p>\r\n        ");
            EndContext();
            BeginContext(2678, 365, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb243612f01446c08e713cd817881477", async() => {
                BeginContext(2786, 207, true);
                WriteLiteral("\r\n          <input type=\"submit\" value=\"Accept Order\" class=\"btn btn-success\" />\r\n          <!-- <a class=\"btn btn-success\" asp-controller=\"CentralInventoryController\" asp-action=\"VerifyOrder\" asp-route-id=\"");
                EndContext();
                BeginContext(2994, 11, false);
#line 71 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                                                                                                                        Write(odr.OrderId);

#line default
#line hidden
                EndContext();
                BeginContext(3005, 31, true);
                WriteLiteral("\">Verify Order</a>-->\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                                                                            WriteLiteral(odr.OrderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3043, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 73 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
         foreach (var pending in ViewBag.Dispatched)
        {
          if (odr.OrderId == pending.OrderId)
          {
            

#line default
#line hidden
#line 77 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
             foreach (var prod in ViewBag.Prod)
            {
              

#line default
#line hidden
#line 79 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
               foreach (var detail in ViewBag.OrderDetails)
              {
                if (prod.ProductId == detail.ProductId && pending.OrderId == detail.OrderId)
                {

#line default
#line hidden
            BeginContext(3425, 61, true);
            WriteLiteral("                  <hr />\r\n                  <p>Product Name: ");
            EndContext();
            BeginContext(3487, 16, false);
#line 84 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                              Write(prod.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3503, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 85 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                   foreach (var det in ViewBag.OrderDetails)
                  {
                    if (det.OrderId == odr.OrderId && prod.ProductId == det.ProductId)
                    {

#line default
#line hidden
            BeginContext(3703, 35, true);
            WriteLiteral("                      <p>Quantity: ");
            EndContext();
            BeginContext(3739, 12, false);
#line 89 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                              Write(det.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3751, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 90 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                    }
                  }

#line default
#line hidden
#line 91 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                   
                }



              }

#line default
#line hidden
#line 96 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
               

            }

#line default
#line hidden
#line 98 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
             


          }

        }

#line default
#line hidden
            BeginContext(3890, 16, true);
            WriteLiteral("\r\n      </div>\r\n");
            EndContext();
#line 106 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
        }

#line default
#line hidden
#line 106 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
         
      }

#line default
#line hidden
            BeginContext(3926, 546, true);
            WriteLiteral(@"
    </div>
  </div>
  <div class=""card"">
    <div class=""card-header"" style=""background-color:rgb(52, 58, 64)"" id=""headingTwo"">
      <h5 class=""mb-0"">
        <button class=""btn btn-link collapsed"" style=""font-weight:600; color:white;"" type=""button"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
          Completed Orders
        </button>
      </h5>
    </div>
    <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordionExample"">
");
            EndContext();
#line 120 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
       foreach (var odr in ViewBag.Completed)
      {
        

#line default
#line hidden
#line 122 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
         if (Enumerable.Count(ViewBag.Completed) > 0)
        {

#line default
#line hidden
            BeginContext(4594, 89, true);
            WriteLiteral("          <div class=\"card-body\">\r\n            <p class=\"btn btn-dark\"><strong>Order Id: ");
            EndContext();
            BeginContext(4684, 11, false);
#line 125 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                                                 Write(odr.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(4695, 49, true);
            WriteLiteral("</strong></p>\r\n            <p><strong>Placed On: ");
            EndContext();
            BeginContext(4745, 13, false);
#line 126 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                             Write(odr.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(4758, 52, true);
            WriteLiteral("</strong></p>\r\n            <p><strong>Delivered On: ");
            EndContext();
            BeginContext(4811, 16, false);
#line 127 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                                Write(odr.DeliveryDate);

#line default
#line hidden
            EndContext();
            BeginContext(4827, 15, true);
            WriteLiteral("</strong></p>\r\n");
            EndContext();
#line 128 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
             foreach (var pending in ViewBag.Completed)
            {
              if (odr.OrderId == pending.OrderId)
              {
                

#line default
#line hidden
#line 132 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                 foreach (var prod in ViewBag.Prod)
                {
                  

#line default
#line hidden
#line 134 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                   foreach (var detail in ViewBag.OrderDetails)
                  {
                    if (prod.ProductId == detail.ProductId && pending.OrderId == detail.OrderId)
                    {

#line default
#line hidden
            BeginContext(5261, 69, true);
            WriteLiteral("                      <hr />\r\n                      <p>Product Name: ");
            EndContext();
            BeginContext(5331, 16, false);
#line 139 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                                  Write(prod.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(5347, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 140 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                       foreach (var det in ViewBag.OrderDetails)
                      {
                        if (det.OrderId == odr.OrderId && prod.ProductId == det.ProductId)
                        {

#line default
#line hidden
            BeginContext(5563, 39, true);
            WriteLiteral("                          <p>Quantity: ");
            EndContext();
            BeginContext(5603, 12, false);
#line 144 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                                  Write(det.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(5615, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 145 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                        }
                      }

#line default
#line hidden
#line 146 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                       
                    }



                  }

#line default
#line hidden
#line 151 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                   

                }

#line default
#line hidden
#line 153 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
                 


              }

            }

#line default
#line hidden
            BeginContext(5782, 20, true);
            WriteLiteral("\r\n          </div>\r\n");
            EndContext();
#line 161 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
        }

#line default
#line hidden
#line 161 "D:\mvc\Retail\Retail\Views\LocalStoreManager\ManageOrder.cshtml"
         
      }

#line default
#line hidden
            BeginContext(5822, 32, true);
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n</div>\r\n");
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