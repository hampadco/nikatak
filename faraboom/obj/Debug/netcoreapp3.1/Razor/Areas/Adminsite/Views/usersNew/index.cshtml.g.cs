#pragma checksum "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "836313438935a573b38fcdbaa0e5cdfbb49da6ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Adminsite_Views_usersNew_index), @"mvc.1.0.view", @"/Areas/Adminsite/Views/usersNew/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"836313438935a573b38fcdbaa0e5cdfbb49da6ae", @"/Areas/Adminsite/Views/usersNew/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5478c08d3cbdf2640418b2815a52ce99bbedf9", @"/Areas/Adminsite/Views/_ViewImports.cshtml")]
    public class Areas_Adminsite_Views_usersNew_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n");
#nullable restore
#line 3 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
   if (ViewBag.er != null)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 5 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                              Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 6 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th>نام </th>
          <th> نام خانوادگی</th>
          <th> کد ملی </th>
          <th> کد معرف : </th>
          <th> ایمیل </th>
          <th> تلفن ثابت</th>
          <th> تلفن همراه :</th>
          <th>استان</th>
          <th>شهر</th>
          <th>کد پستی </th>
          <th>عکس کارت ملی</th>
          <th>عکس شناسنامه</th>
          <th>عکس مدرک تحصیلی</th>
          <th> عکس پایان خدمت</th>
          <th>جرییات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 32 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
         if (ViewBag.list != null)
        {
          int i = 1;
          foreach (var item in ViewBag.list)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n              <td></td>\r\n              <td class=\"product-category\"> ");
#nullable restore
#line 39 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td class=\"product-category\"> ");
#nullable restore
#line 40 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                       Write(item.Nameper);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td class=\"product-name\">");
#nullable restore
#line 41 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                  Write(item.Familyper);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td class=\"product-category\">");
#nullable restore
#line 42 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                      Write(item.NationalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n              <td class=\"product-category\">");
#nullable restore
#line 43 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                      Write(item.code);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n              <td class=\"product-category\">");
#nullable restore
#line 44 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                      Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n              <td class=\"product-category\">");
#nullable restore
#line 45 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                      Write(item.PhoneHome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n              <td class=\"product-category\">");
#nullable restore
#line 46 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                      Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n              <td class=\"product-category\">");
#nullable restore
#line 47 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                      Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td class=\"product-category\">");
#nullable restore
#line 48 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                      Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td class=\"product-category\">");
#nullable restore
#line 49 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
                                      Write(item.Postalcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td class=\"product-category\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1777, "\"", 1814, 2);
            WriteAttributeValue("", 1784, "/fileupload/", 1784, 12, true);
#nullable restore
#line 51 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
WriteAttributeValue("", 1796, item.Nationalcard, 1796, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"blank\">مشاهده</a>\r\n              </td>\r\n              <td class=\"product-category\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1927, "\"", 1963, 2);
            WriteAttributeValue("", 1934, "/fileupload/", 1934, 12, true);
#nullable restore
#line 54 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
WriteAttributeValue("", 1946, item.Certificate, 1946, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"blank\">مشاهده</a>\r\n              </td>\r\n              <td class=\"product-category\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2076, "\"", 2116, 2);
            WriteAttributeValue("", 2083, "/fileupload/", 2083, 12, true);
#nullable restore
#line 57 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
WriteAttributeValue("", 2095, item.Degreeeducation, 2095, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"blank\">مشاهده</a>\r\n              </td>\r\n              <td class=\"product-category\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2229, "\"", 2262, 2);
            WriteAttributeValue("", 2236, "/fileupload/", 2236, 12, true);
#nullable restore
#line 60 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
WriteAttributeValue("", 2248, item.Document, 2248, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"blank\">مشاهده</a>\r\n              </td>\r\n              <td class=\"product-action\">\r\n                <div class=\"mb-1\">\r\n                  <div class=\"btn-group \" role=\"group\" aria-label=\"Basic example\">\r\n\r\n");
            WriteLiteral(@"                      <a  class=""btn btn-success btn-sm""
                    >تایید</a>

                    <a  class=""btn btn-info btn-sm"">
                    احراز هویت</a>
                    <a h class=""btn btn-warning btn-sm""
                    >عدم  تایید</a>
");
            WriteLiteral("                  </div>\r\n                </div>\r\n              </td>\r\n            </tr>\r\n");
#nullable restore
#line 81 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Adminsite\Views\usersNew\index.cshtml"
            i++;
          }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n    </table>\r\n  </div>\r\n<!-- DataTable ends -->\r\n<!-- add new sidebar starts -->\r\n<!-- add new sidebar ends -->\r\n</section>\r\n<!-- Data list view end -->\r\n");
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