#pragma checksum "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e83d81eb2b820180e0b8a39050f32e50fe532c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Adminsite_Views_Wallet_index), @"mvc.1.0.view", @"/Areas/Adminsite/Views/Wallet/index.cshtml")]
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
#line 1 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51e83d81eb2b820180e0b8a39050f32e50fe532c", @"/Areas/Adminsite/Views/Wallet/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5478c08d3cbdf2640418b2815a52ce99bbedf9", @"/Areas/Adminsite/Views/_ViewImports.cshtml")]
    public class Areas_Adminsite_Views_Wallet_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t \r\n\r\n    <!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n");
#nullable restore
#line 99 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
    if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"alert alert-success\">");
#nullable restore
#line 101 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
                          Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 102 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
			<tr>
				<th>  </th>
				<th> ردیف: </th>
				<th> نام و نام خانوادگی </th>
				<th> مبلغ پرداخت: </th>
				<th>تاریخ پرداخت : </th>
			</tr>
        </thead>
        <tbody>
");
#nullable restore
#line 116 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
         if (ViewBag.list2!=null)
		{
		int i=1;
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
         foreach (var item in ViewBag.list2)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td ></td>\r\n\t\t\t\t<td >");
#nullable restore
#line 123 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t\t<td >");
#nullable restore
#line 124 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
                Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td >");
#nullable restore
#line 125 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
                Write(item.Pay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 126 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
               Write(item.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 128 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
		i++;
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\Wallet\index.cshtml"
         
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("     \t</tbody>\r\n");
            WriteLiteral("    </table>\r\n  </div>\r\n  <!-- DataTable ends -->\r\n\r\n  <!-- add new sidebar starts -->\r\n \r\n  <!-- add new sidebar ends -->\r\n</section>\r\n<!-- Data list view end -->\r\n");
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