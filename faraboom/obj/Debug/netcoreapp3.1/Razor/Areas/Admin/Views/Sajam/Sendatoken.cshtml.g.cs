#pragma checksum "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Sajam\Sendatoken.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8828964b710c6aeef0f58939d3d25b9e11642aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sajam_Sendatoken), @"mvc.1.0.view", @"/Areas/Admin/Views/Sajam/Sendatoken.cshtml")]
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
#line 1 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8828964b710c6aeef0f58939d3d25b9e11642aa", @"/Areas/Admin/Views/Sajam/Sendatoken.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sajam_Sendatoken : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Sajam/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mt-3 mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: min-content;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Sajam\Sendatoken.cshtml"
  
    Layout = "_Layout4" ;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card shadow"">
	<div class=""card-header"">
		<h2 class=""mb-0""> توکن پرداخت سمت احراز هویت کننده </h2>
	</div>
	<div class=""card-body"">
		<div class=""row"">
			<div class=""col-md-6"">
				<div class=""form-group"">
					<h2 class=""mb-0""> نام کاربری :</h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder="" نام کاربری  "">
				</div>
				<div class=""form-group"">
					<h2 class=""mb-0""> رمزعبور : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder=""رمزعبور "">
				</div>

				<div class=""form-group"">
					<h2 class=""mb-0""> شناسه خدمات : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder=""شناسه خدمات "">
				</div>
				<div class=""form-group"">
					<h2 class=""mb-0""> مقدار : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder="" مقدار "">
				</div>
				<div class=""form-group"">
					<h2 class=""mb-0""> مقدار محاسبه شده : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder="" م");
            WriteLiteral(@"قدار محاسبه شده "">
				</div>
			</div>
			<div class=""col-md-6"">
				<div class=""form-group"">
					<h2 class=""mb-0""> شناسه سفارشی : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder=""شناسه سفارشی "">
				</div>
				<div class=""form-group"">
					<h2 class=""mb-0""> شناسه پاسخگویی : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder=""شناسه پاسخگویی "">
				</div>
				<div class=""form-group"">
					<h2 class=""mb-0""> امضا داده : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder=""امضا داده  "">
				</div>
				<div class=""form-group"">
					<h2 class=""mb-0""> شناسه : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder=""شناسه  "">
				</div>
			</div>
			<button type=""button"" class=""btn btn-success  mt-3 mb-1"" style=""width: min-content;""> پرداخت توکن
			</button>
			");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8828964b710c6aeef0f58939d3d25b9e11642aa6580", async() => {
                WriteLiteral("\r\n\t\t\t\tبازگشت\r\n\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
