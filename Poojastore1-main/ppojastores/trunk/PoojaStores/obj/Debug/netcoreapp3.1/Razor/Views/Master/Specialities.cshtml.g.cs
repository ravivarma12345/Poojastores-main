#pragma checksum "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/Specialities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "567f7863580fe686ffb3bce54576f05a611801de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_Specialities), @"mvc.1.0.view", @"/Views/Master/Specialities.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567f7863580fe686ffb3bce54576f05a611801de", @"/Views/Master/Specialities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986f9477a1b535c92b3f32da28b3e1ee3bcdb34e", @"/Views/_ViewImports.cshtml")]
    public class Views_Master_Specialities : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PoojaStores.Models.Repositories.Entity.SpecialMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Master/SpecialityData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/Specialities.cshtml"
  
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
            <h1>All Specialities</h1>
            <small>Master Data management.</small>
        </div>
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-lg-12 pinpin"">
                <div class=""card"" data-sortable=""true"">
                    <div class=""card-header"">
                        <div class=""row"">
                            <div class=""col-md-9"">
                                <div class=""card-title custom_title"">
                                    <div class=""row"">
                                        <h4 class=""col-md-8"">Speciality List</h4>
                                      
                                    </div>
                                </div>
                          ");
            WriteLiteral(@"  </div>

                            <div class=""col-md-3"">
                                <div class=""btn-group float-right"" role=""group"">
                                    <div class=""buttonexport"" id=""buttonlist"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "567f7863580fe686ffb3bce54576f05a611801de5830", async() => {
                WriteLiteral("\n                                            <i class=\"fa fa-plus\"></i> Add New\n                                        ");
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
                    </div>
                    <div class=""card-body"">
                        <div id=""no-more-tables"">
                            <table class=""col-md-12 table-bordered table-striped table-condensed cf"">
                                <thead class=""cf"">
                                    <tr>
                                        <th>S.no</th>
                                        <th>Speciality Name</th>

                                        <th>Edit</th>
                                        <th>Delete</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 58 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/Specialities.cshtml"
                                     foreach (var u in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td data-title=\"S.no\">");
#nullable restore
#line 61 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/Specialities.cshtml"
                                                              Write(rCnt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td data-title=\"Item Name\">");
#nullable restore
#line 62 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/Specialities.cshtml"
                                                                  Write(u.SpecialityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                            <td data-title=\"Edit\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "567f7863580fe686ffb3bce54576f05a611801de9030", async() => {
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2823, "~/Master/SpecialityData?id=", 2823, 27, true);
#nullable restore
#line 64 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/Specialities.cshtml"
AddHtmlAttributeValue("", 2850, u.PrId, 2850, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                                            <td data-title=\"Edit\">\n                                                <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3069, "\"", 3098, 3);
            WriteAttributeValue("", 3079, "ShowDelete(", 3079, 11, true);
#nullable restore
#line 66 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/Specialities.cshtml"
WriteAttributeValue("", 3090, u.PrId, 3090, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3097, ")", 3097, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <button type=""button"" class=""btn btn-danger btn-sm"" data-toggle=""modal"">
                                                        <i class=""fa fa-trash""></i>
                                                    </button>
                                                </a>
                                            </td>
                                        </tr>
");
#nullable restore
#line 73 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/Specialities.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </section>
    <!-- /.content -->
</div>

<script>
    function ShowDelete(id) {
        swal(""Are you sure?"", {
            buttons: {
                yes: {
                    text: ""Yes"",
                    value: ""yes""
                },
                no: {
                    text: ""No"",
                    value: ""no""
                }
            }
        }).then((value) => {
            if (value === ""yes"") {
                $.ajax({
                    url: GlobalUrl + ""Master/DeleteSpecialities?id="" + id,
                    type: 'post',
                    data: '{}',
                    success: function (result) {
                        toastr[""success""](""Successuflly deleted!"");
                        window.location.href = window.location.href;
                    }
                });
      ");
            WriteLiteral("      }\n            else {\n                toastr[\"error\"](\"Delete cancelled!\")\n            }\n            return false;\n        });\n\n\n    }\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PoojaStores.Models.Repositories.Entity.SpecialMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
