#pragma checksum "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showphonebillsdebtinquiry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58f4b09c3f765954307fd288824c896a68269c17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gabz_Showphonebillsdebtinquiry), @"mvc.1.0.view", @"/Areas/Admin/Views/Gabz/Showphonebillsdebtinquiry.cshtml")]
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
#line 1 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f4b09c3f765954307fd288824c896a68269c17", @"/Areas/Admin/Views/Gabz/Showphonebillsdebtinquiry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Gabz_Showphonebillsdebtinquiry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Gabz_Charge/Estelam"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mt-1 mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""card shadow"" id=""myDiv"">
	<div class=""card-header"">
		<h2 class=""mb-0""> نمایش استعلام دسته ای بدهی قبض تلفن</h2>
		<div class=""card-body"">
			<div class=""row"">
				<div class=""table-responsive"">
					<div class=""form-group justify-content-center "">
						<p style=""direction: ltr; display: none;"" id=""G_P"">");
#nullable restore
#line 8 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showphonebillsdebtinquiry.cshtml"
                                                                      Write(ViewBag.result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
						<table class=""table table-hover"">
							<thead class=""bg-primary "">
								<tr>
									<th>ردیف</th>
									<th> شناسه قبض:</th>
									<th> شناسه پرداخت: </th>
									<th>مبلغ :</th>
								</tr>
							</thead>
							<tbody class=""bg-white"">
								<tr>
									<th>1</th>
									<th id=""bill_id""> </th>
									<th id=""pay_id""> </th>
									<th id=""amount""> </th>
								</tr>
							</tbody>
						</table> 
					</div>
				</div>
			</div>
			<div class=""d-flex justify-content-end "">
				<button type=""submit"" class=""btn btn-success  mt-1 mb-1"" style=""width: min-content;""> پرداخت
				</button>
				<a onclick=""print();"" class=""btn btn-success  mt-1 mb-1"" style=""width: min-content;""> چاپ
				</a>
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58f4b09c3f765954307fd288824c896a68269c175787", async() => {
                WriteLiteral("\r\n\t\t\t\t\tبازگشت\r\n\t\t\t\t");
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
            WriteLiteral(@"
			</div>
		</div>
	</div>
</div>

<script>

	debugger
	var str = document.getElementById('G_P').innerText.replace(""{"", """").replace(' \"" ', '').replace(""}"", """").replace(""}"", """").replace(""}"", """").split('""').join('').replace(""]"", """");
	var res = str.split("","");

	var bill_id = res[2].split("":"");
	document.getElementById('bill_id').innerText = """" + bill_id[1];

	var pay_id = res[3].split("":"");
	document.getElementById('pay_id').innerText = """" + pay_id[1];

	var amount = res[4].split("":"");
	document.getElementById('amount').innerText = """" + amount[1];

</script>

<script>
	function print() {
		var printContents = document.getElementById('myDiv').innerHTML;
		var originalContents = document.body.innerHTML;

		document.body.innerHTML = printContents;

		window.print();

		document.body.innerHTML = originalContents;
	}
</script>");
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
