#pragma checksum "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\financial\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6774be90fbdd971f681a5cedc92479285b5edccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Adminsite_Views_financial_List), @"mvc.1.0.view", @"/Areas/Adminsite/Views/financial/List.cshtml")]
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
#line 1 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6774be90fbdd971f681a5cedc92479285b5edccd", @"/Areas/Adminsite/Views/financial/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5478c08d3cbdf2640418b2815a52ce99bbedf9", @"/Areas/Adminsite/Views/_ViewImports.cshtml")]
    public class Areas_Adminsite_Views_financial_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- BEGIN: Content-->
<section id=""data-list-view"" class=""data-list-view-header"">
  <!-- DataTable starts -->
  <div class=""table-responsive row"">
    <section class=""basic-select2"">
      <div class=""row"">
        <div class=""col-12"">
          <div class=""card"">
            <div class=""card-header"">

              <div class=""col-sm-6 col-12"">
                <fieldset class=""form-group"">
                  <p> مبلغ کل:

                    <strong> 1995822255 </strong>
                  </p>
                </fieldset>
              </div>

                  <div style=""float: right;"" class=""col-md-3 col-12 mb-1"">
                    <h5 class=""text-bold-500"">از تاریخ</h5>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6774be90fbdd971f681a5cedc92479285b5edccd4089", async() => {
                WriteLiteral("\r\n                      <input type=\'text\' class=\"form-control pickadate\">\r\n                    ");
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
            WriteLiteral("\r\n                  </div>\r\n\r\n                  <div style=\"float: right;\" class=\"col-md-3 col-12 mb-1\">\r\n                    <h5 class=\"text-bold-500\">تا تاریخ</h5>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6774be90fbdd971f681a5cedc92479285b5edccd5619", async() => {
                WriteLiteral("\r\n                      <input type=\'text\' class=\"form-control pickadate\">\r\n                    ");
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
            WriteLiteral(@"
                  </div>

            </div>
          </div>
        </div>
      </div>

      <table class=""table data-list-view"">
        <thead>
          <tr>
            <th></th>
            <th>ردیف</th>
            <th> نام کاربری </th>
            <th> شماره تماس </th>
            <th> واریزی </th>
            <th> برداشت </th>
            <th> تاریخ </th>
            <th> زبان</th>
            <th> عملیات</th>
          </tr>
        </thead>
        <tbody>

          <tr>
            <td></td>
            <td class=""product-category""> 1</td>
            <td class=""product-name"">Altec Lansing</td>
            <td class=""product-category""> 090074774587 </td>
            <td class=""product-category""> 95,000,584 </td>
            <td class=""product-category""> 45,000,584 </td>
            <td class=""product-category""> 99/02/85 </td>
            <td class=""product-category"">فارسی </td>
            <td class=""product-action"">
              <div class=""col-lg-3 col-md-");
            WriteLiteral(@"3 mb-1"">
                <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                  <button type=""button"" class=""btn btn-primary btn-sm"">مشاهده</button>
                  <button type=""button"" class=""btn btn-danger btn-sm"">حذف</button>
");
            WriteLiteral(@"                </div>
              </div>
            </td>
          </tr>

          <tr>
            <td></td>
            <td class=""product-category""> 2</td>
            <td class=""product-name"">Altec Lansing</td>
            <td class=""product-category""> 090074774587 </td>
            <td class=""product-category""> 95,000,584 </td>
            <td class=""product-category""> 45,000,584 </td>
            <td class=""product-category""> 99/02/85 </td>

            <td class=""product-category"">انگلیسی </td>
            <td class=""product-action"">
              <div class=""col-lg-3 col-md-3 mb-1"">
                <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                  <button type=""button"" class=""btn btn-primary btn-sm"">مشاهده</button>
                  <button type=""button"" class=""btn btn-danger btn-sm"">حذف</button>
");
            WriteLiteral(@"                </div>
              </div>
            </td>
          </tr>

        </tbody>
      </table>
  </div>
  <!-- DataTable ends -->

  <!-- add new sidebar starts -->

  <!-- add new sidebar ends -->
</section>
<!-- Data list view end -->");
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
