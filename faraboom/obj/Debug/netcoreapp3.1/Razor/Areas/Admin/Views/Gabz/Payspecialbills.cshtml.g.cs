#pragma checksum "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Gabz\Payspecialbills.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89ad18b5082ae4966eb54ab59001d9631cae3aa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gabz_Payspecialbills), @"mvc.1.0.view", @"/Areas/Admin/Views/Gabz/Payspecialbills.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ad18b5082ae4966eb54ab59001d9631cae3aa3", @"/Areas/Admin/Views/Gabz/Payspecialbills.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Gabz_Payspecialbills : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card shadow"">
	<div class=""card-header"">
		<h2 class=""mb-0"">پرداخت قبوض خاص با کارت</h2>
	</div>
	<div class=""card-body"">
		<div class=""row"">
			<div class=""col-md-6"">
				<div class=""form-group"">
					<h2 class=""mb-0""> شناسه پرداخت :</h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder=""  شناسه پرداخت "">
				</div>

				<div class=""form-group"">
					<h2 class=""mb-0""> شناسه قبض : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder="" شناسه قبض"">
				</div>

				<div class=""form-group"">
					<h2 class=""mb-0""> مبلغ قبض : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder="" مبلغ قبض"">
				</div>
			</div>
			<div class=""col-md-6"">

				<div class=""form-group"">
					<h2 class=""mb-0""> شماره کارت : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder=""شماره کارت"">
				</div>

				<div class=""form-group"">
					<h2 class=""mb-0""> نوع رمز کارت : </h2>
					<input type=""text"" class=""for");
            WriteLiteral(@"m-control"" name=""input"" placeholder="" نوع رمز کارت "">
				</div>

				<div class=""form-group"">
					<h2 class=""mb-0""> رمز کارت : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder="" رمز کارت "">
				</div>

				<div class=""form-group"">
					<h2 class=""mb-0""> کد cvv2 کارت : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder="" کد cvv2 کارت "">
				</div>

				<div class=""form-group"">
					<h2 class=""mb-0""> تاریخ انقضای کارت : </h2>
					<input type=""text"" class=""form-control"" name=""input"" placeholder="" تاریخ انقضای کارت "">
				</div>
			</div>
			<button type=""button"" class=""btn btn-success  mt-1 mb-1"" style=""width: min-content;""> پرداخت قبض
			</button>
		</div>
	</div>
</div>");
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
