#pragma checksum "c:\Users\MS\Desktop\Nikatak\faraboom\Views\Expert\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fcf24dfc639dae9ecaf423bfe45180697ffb020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expert_index), @"mvc.1.0.view", @"/Views/Expert/index.cshtml")]
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
#line 1 "c:\Users\MS\Desktop\Nikatak\faraboom\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\MS\Desktop\Nikatak\faraboom\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fcf24dfc639dae9ecaf423bfe45180697ffb020", @"/Views/Expert/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Views/_ViewImports.cshtml")]
    public class Views_Expert_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"









    <section class=""container-fluid mt-3"">
        <div class=""container p-md-5 box p-4"">
            <h5 class=""mb-4 bt-color IRANSansWeb_Medium"">   معرفی مدیران  </h5>
            
            
<p style=""text-align: center;display:none"" >در حال بروزرسانی ...</p>
            <div class=""row"" >
");
#nullable restore
#line 18 "c:\Users\MS\Desktop\Nikatak\faraboom\Views\Expert\index.cshtml"
           if (ViewBag.expert != null)
    {
        foreach (var item in ViewBag.expert)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-lg-3 col-sm-6\">\r\n                    <div class=\"card\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3fcf24dfc639dae9ecaf423bfe45180697ffb0204104", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 544, "~/fileupload/", 544, 13, true);
#nullable restore
#line 24 "c:\Users\MS\Desktop\Nikatak\faraboom\Views\Expert\index.cshtml"
AddHtmlAttributeValue("", 557, item.ImageEx, 557, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"data\">\r\n                            <h6 class=\"IRANSansWeb_Medium\"> ");
#nullable restore
#line 26 "c:\Users\MS\Desktop\Nikatak\faraboom\Views\Expert\index.cshtml"
                                                       Write(item.NameEx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <span>نیکاتک</span>\r\n                            <hr>\r\n");
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 906, "\"", 937, 2);
            WriteAttributeValue("", 913, "/expert/details/", 913, 16, true);
#nullable restore
#line 30 "c:\Users\MS\Desktop\Nikatak\faraboom\Views\Expert\index.cshtml"
WriteAttributeValue("", 929, item.Id, 929, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-2x fa-whatsapp rounded text-success\"></i>مشاهده اطلاعات کامل </a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1053, "\"", 1084, 2);
            WriteAttributeValue("", 1060, "/expert/details/", 1060, 16, true);
#nullable restore
#line 31 "c:\Users\MS\Desktop\Nikatak\faraboom\Views\Expert\index.cshtml"
WriteAttributeValue("", 1076, item.Id, 1076, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-2x fa-telegram rounded text-info\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 35 "c:\Users\MS\Desktop\Nikatak\faraboom\Views\Expert\index.cshtml"
              
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n              \r\n             \r\n\r\n\r\n\r\n            </div>\r\n       \r\n         </div>\r\n    </section>\r\n\r\n\r\n");
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