#pragma checksum "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1820b12762c8abe23772fbd10f402aa72bf64dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Adminsite_Views_comment_index), @"mvc.1.0.view", @"/Areas/Adminsite/Views/comment/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1820b12762c8abe23772fbd10f402aa72bf64dc", @"/Areas/Adminsite/Views/comment/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5478c08d3cbdf2640418b2815a52ce99bbedf9", @"/Areas/Adminsite/Views/_ViewImports.cshtml")]
    public class Areas_Adminsite_Views_comment_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n");
#nullable restore
#line 5 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
   if (ViewBag.suc != null)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <span class=\"alert alert-success\">");
#nullable restore
#line 7 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
                                   Write(ViewBag.suc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 8 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th>  ایمیل </th>
           <th>  شماره موبایل</th>
         
          <th> سرتیتر پیام</th>
           <th> متن پیام</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 25 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
 if (ViewBag.List != null)
{
  int i=0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
     foreach (var item in ViewBag.List)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n          <td>\r\n          \r\n          </td>\r\n\r\n          <td class=\"product-category\">");
#nullable restore
#line 36 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td class=\"product-category\">");
#nullable restore
#line 37 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
                                  Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n         \r\n");
            WriteLiteral("\r\n                        <td class=\"product-category\">");
#nullable restore
#line 41 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
                                                Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td class=\"product-category\">");
#nullable restore
#line 42 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                         <td class=\"product-category\"><a");
            BeginWriteAttribute("href", " href=\"", 1166, "\"", 1208, 2);
            WriteAttributeValue("", 1173, "/Adminsite/comment/details/", 1173, 27, true);
#nullable restore
#line 43 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
WriteAttributeValue("", 1200, item.Id, 1200, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">مشاهده</a></td>\r\n           <td class=\"product-action\">\r\n             <div class=\" mb-1\">\r\n                <div class=\"btn-group\"  aria-label=\"Basic example\">\r\n                  \r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 1410, "\"", 1448, 2);
            WriteAttributeValue("", 1417, "/adminsite/comment/del/", 1417, 23, true);
#nullable restore
#line 48 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
WriteAttributeValue("", 1440, item.Id, 1440, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمئن هستید\')\">حذف</a>\r\n                  \r\n                 \r\n                </div>\r\n              </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
        i++;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Adminsite\Views\comment\index.cshtml"
 
   
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
     
<script>
  function a()
  {
    debugger
    var msg=document.getElementById(""comment"").value;
   alert(msg);
  }
</script>




      </tbody>
    </table>
  </div>
  <!-- DataTable ends -->

  <!-- add new sidebar starts -->
 
  <!-- add new sidebar ends -->
</section>
<!-- Data list view end -->
");
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
