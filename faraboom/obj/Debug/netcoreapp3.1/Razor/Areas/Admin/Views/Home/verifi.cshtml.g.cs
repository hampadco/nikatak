#pragma checksum "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Admin\Views\Home\verifi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "219e4639998827ecf0e33c89441ba9f50c905d10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_verifi), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/verifi.cshtml")]
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
#line 1 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Admin\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Admin\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"219e4639998827ecf0e33c89441ba9f50c905d10", @"/Areas/Admin/Views/Home/verifi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_verifi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Admin\Views\Home\verifi.cshtml"
 if (ViewBag.msg == "پرداخت باموفقیت انجام شد")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("   <p class=\"alert alert-success\">");
#nullable restore
#line 3 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Admin\Views\Home\verifi.cshtml"
                             Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 4 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Admin\Views\Home\verifi.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(" <p class=\"alert alert-danger\">");
#nullable restore
#line 8 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Admin\Views\Home\verifi.cshtml"
                          Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 9 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Admin\Views\Home\verifi.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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