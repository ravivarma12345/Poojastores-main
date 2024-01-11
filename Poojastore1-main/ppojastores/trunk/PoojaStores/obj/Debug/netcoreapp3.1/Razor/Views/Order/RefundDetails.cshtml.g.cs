#pragma checksum "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/RefundDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0f18979f1cbe861d403cf5b8802330e065d3346"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_RefundDetails), @"mvc.1.0.view", @"/Views/Order/RefundDetails.cshtml")]
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
#nullable restore
#line 1 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/_ViewImports.cshtml"
using PoojaStores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/_ViewImports.cshtml"
using PoojaStores.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0f18979f1cbe861d403cf5b8802330e065d3346", @"/Views/Order/RefundDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986f9477a1b535c92b3f32da28b3e1ee3bcdb34e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_RefundDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoojaStores.Models.ModelClasses.RefundDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/RefundDetails.cshtml"
   
    Layout = "~/Views/Shared/AdminMaster.cshtml";
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <div class=""row"">
        <div class=""col-md-3""></div>
        <div class=""col-md-6"">
            <div class=""refundDetails"">
                <ul class=""refundAlign"">
                    <li>
                        <h3>Refund Details</h3>
                    </li>
                    <li>Transaction Id : - ");
#nullable restore
#line 15 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/RefundDetails.cshtml"
                                      Write(Model.TransId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                    <li>Order Id : - ");
#nullable restore
#line 16 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/RefundDetails.cshtml"
                                Write(Model.order_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 17 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/RefundDetails.cshtml"
                      
                        DateTime co = Convert.ToDateTime(Model.orderedOn);
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>Order Date : - ");
#nullable restore
#line 20 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/RefundDetails.cshtml"
                                  Write(co.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                    <li>\n                        <p>Paid : - ");
#nullable restore
#line 22 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/RefundDetails.cshtml"
                                Write(String.Format(Indian,"{0:N}",Model.PaidAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </li>\n                    <li>\n                        cancelation Charges : - ");
#nullable restore
#line 25 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/RefundDetails.cshtml"
                                            Write(String.Format(Indian,"{0:N}",Model.CancelationCharges));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </li>\n                    <li>\n                        To Be Paid : - ");
#nullable restore
#line 28 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/RefundDetails.cshtml"
                                   Write(String.Format(Indian,"{0:N}",(Model.PaidAmount-Model.CancelationCharges)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </li>\n                </ul>\n                <div>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f18979f1cbe861d403cf5b8802330e065d33466548", async() => {
                WriteLiteral("Refund");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1372, "~/Order/RefundedAmount?id=", 1372, 26, true);
#nullable restore
#line 32 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/RefundDetails.cshtml"
AddHtmlAttributeValue("", 1398, ViewBag.detailsId, 1398, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <div class=\"col-md-3\"></div>\n    </div>\n    \n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoojaStores.Models.ModelClasses.RefundDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
