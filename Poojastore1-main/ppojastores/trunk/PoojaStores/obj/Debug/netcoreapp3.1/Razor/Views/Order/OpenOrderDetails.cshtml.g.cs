#pragma checksum "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32edb273483e6182b173703a6cb51a22f106c214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OpenOrderDetails), @"mvc.1.0.view", @"/Views/Order/OpenOrderDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32edb273483e6182b173703a6cb51a22f106c214", @"/Views/Order/OpenOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986f9477a1b535c92b3f32da28b3e1ee3bcdb34e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OpenOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoojaStores.Models.ModelClasses.OrderDetailPage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Order/OpenOrders"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
  
    int rCnt = 1;
    Layout = "~/Views/Shared/AdminMaster.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-book""></i>
        </div>
        <div class=""header-title"">
            <h1>Open Order Details</h1>
            <small>Order management.</small>
        </div>
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-lg-12 pinpin"">
                <div class=""card"" data-sortable=""true"">                   
                    <div class=""card-header"">
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <div class=""card-title custom_title"">
                                    <h4>Open Order Details List</h4>
                                </div>
                            </div>

                            <div class=""col-md-8"">
                                <div class=""btn-group float-right"" role=""");
            WriteLiteral("group\">\n                                    <div class=\"buttonexport\" id=\"buttonlist\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32edb273483e6182b173703a6cb51a22f106c2146341", async() => {
                WriteLiteral("\n                                            <i class=\"fa fa-reply mr-2\"></i>Back\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-md-3"">
                                        Full Name 
                                        <br />
                                        Address 1 
                                        <br />
");
#nullable restore
#line 49 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                         if (Model.Address2 != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>Address 2 </span>\n                                            <br />\n");
#nullable restore
#line 53 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        Street   
                                        <br />
                                        LandMark 
                                    </div>
                                    <div class=""col-md-1"">
                                        :
                                        <br />
                                        :
                                        <br />
");
#nullable restore
#line 63 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                         if (Model.Address2 != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>: </span>\n                                            <br />\n");
#nullable restore
#line 67 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        :
                                        <br />
                                        :
                                    </div>
                                    <div class=""col-md-8"">
                                        ");
#nullable restore
#line 73 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        <br />\n                                        ");
#nullable restore
#line 75 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                   Write(Model.Address1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        <br />\n");
#nullable restore
#line 77 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                         if (Model.Address2 != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 79 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                             Write(Model.Address2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                            <br />\n");
#nullable restore
#line 81 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
#nullable restore
#line 82 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                   Write(Model.LocationStreet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        <br />\n                                        ");
#nullable restore
#line 84 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                   Write(Model.LandMark);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-md-3"">                                        
                                        City     
                                        <br />
                                        State    
                                        <br />
                                        Country  
                                        <br />
                                        Zipcode  
                                    </div>
                                    <div class=""col-md-1"">
                                        :
                                        <br />
                                        :
                                        <br />
                                        :
                                        <br");
            WriteLiteral(" />\n                                        :\n                                    </div>\n                                    <div class=\"col-md-8\">\n                                        ");
#nullable restore
#line 109 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                   Write(Model.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        <br />\n                                        ");
#nullable restore
#line 111 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                   Write(Model.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        <br />\n                                        ");
#nullable restore
#line 113 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                   Write(Model.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        <br />\n                                        ");
#nullable restore
#line 115 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                   Write(Model.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div id=""no-more-tables"">
                            <table class=""col-md-12 table-bordered table-striped table-condensed cf"">
                                <thead class=""cf"">
                                    <tr>
                                        <th>S.no</th>
                                        <th>Order Id</th>
                                        <th>Product Code</th>
                                        <th>Product</th>
                                        <th>No Of Items Ordered</th>
                                        <th>Dispatch</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 135 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                     foreach (var u in Model.odetails)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td data-title=\"S.no\">");
#nullable restore
#line 138 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                                              Write(rCnt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td data-title=\"Category Name\">");
#nullable restore
#line 139 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                                                      Write(u.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td data-title=\"Category Name\">");
#nullable restore
#line 140 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                                                      Write(u.ProductCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td data-title=\"Category Name\">\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "32edb273483e6182b173703a6cb51a22f106c21417472", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6884, "~/ProductImages/", 6884, 16, true);
#nullable restore
#line 142 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
AddHtmlAttributeValue("", 6900, u.Image, 6900, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            </td>\n                                            <td data-title=\"Category Name\">");
#nullable restore
#line 144 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                                                      Write(u.NumberOfItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td data-title=\"Dispatch\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32edb273483e6182b173703a6cb51a22f106c21419606", async() => {
                WriteLiteral("Dispatch");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7162, "~/Order/DispatchDetails?id=", 7162, 27, true);
#nullable restore
#line 145 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
AddHtmlAttributeValue("", 7189, u.PODetailId, 7189, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 147 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/OpenOrderDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\n                            </table>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n\n    </section>\n    <!-- /.content -->\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoojaStores.Models.ModelClasses.OrderDetailPage> Html { get; private set; }
    }
}
#pragma warning restore 1591
