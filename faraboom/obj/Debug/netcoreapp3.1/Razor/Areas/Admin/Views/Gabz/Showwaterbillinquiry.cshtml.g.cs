#pragma checksum "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showwaterbillinquiry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9e2720871fc938d0bcd9c625ab71b605a27d839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gabz_Showwaterbillinquiry), @"mvc.1.0.view", @"/Areas/Admin/Views/Gabz/Showwaterbillinquiry.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e2720871fc938d0bcd9c625ab71b605a27d839", @"/Areas/Admin/Views/Gabz/Showwaterbillinquiry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Gabz_Showwaterbillinquiry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.AdminViewModel.Gabz.Vm_Gabz>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "آب", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Gabz_Charge/Estelam"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mt-1 mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: min-content;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Gabz/Pardakht"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card shadow\" id=\"myDiv\">\r\n\t<div class=\"card-header\">\r\n\t\t<h2 class=\"mb-0\"> نمایش استعلام قبض آب</h2>\r\n\t</div>\r\n\t<div class=\"card-body\">\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9e2720871fc938d0bcd9c625ab71b605a27d8396239", async() => {
                WriteLiteral("\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"table-responsive\">\r\n\t\t\t\t\t<div class=\"form-group justify-content-center \">\r\n\t\t\t\t\t\t<p style=\"direction: ltr; display: none;\" id=\"Water\">");
#nullable restore
#line 11 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showwaterbillinquiry.cshtml"
                                                                        Write(ViewBag.result);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showwaterbillinquiry.cshtml"
                         if (ViewBag.Msg != null)
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t<div class=\"text-center\">\r\n\t\t\t\t\t\t\t <p class=\"alert alert-danger\">");
#nullable restore
#line 15 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showwaterbillinquiry.cshtml"
                                                      Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 17 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showwaterbillinquiry.cshtml"
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t \r\n\t  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e9e2720871fc938d0bcd9c625ab71b605a27d8397950", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 19 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showwaterbillinquiry.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.bill_id2);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e9e2720871fc938d0bcd9c625ab71b605a27d8399549", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 20 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showwaterbillinquiry.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.pay_id2);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e9e2720871fc938d0bcd9c625ab71b605a27d83911147", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 21 "c:\Users\ms\Desktop\nikatak_git\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showwaterbillinquiry.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Titel);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
	  <table class=""table table-hover"">
	   <thead class=""bg-primary"">
		<tr>
		 <th> شناسه قبض: </th>
		 <th> شناسه پرداخت: </th>
		 <th>مبلغ : </th>
		 <th> شماره پرونده :</th>
		 <th> نام مالک :</th>
		 <th> استان : </th>
		 <th> تعداد واحد :</th>
		 <th> کل مصرف : </th>
		</tr>
	   </thead>
	   <tbody class=""bg-white"">
		<tr>

		 <th id=""bill_id""> </th>
		 <th id=""pay_id""> </th>
		 <th id=""amount""> </th>
		 <th id=""file_number""> </th>
		 <th id=""owner_name""> </th>
		 <th id=""province""> </th>
		 <th id=""unit_count""> </th>
		 <th id=""total_consumption""> </th>
		</tr>
	   </tbody>
	   <thead class=""bg-primary"">
		<tr>
		 <th> تاریخ قبلی :</th>
		 <th> تاریخ فعلی : </th>
		 <th> شماره قبلی : </th>
		 <th> شماره فعلی :</th>
		 <th> بدهی قبلی : </th>
		 <th> مدت به روز:</th>
		 <th> تاریخ صورت حساب : </th>
		</tr>
	   </thead>
	   <tbody class=""bg-white"">
		<tr>
		 <th id=""previous_date""> </th>
		 <th id=""current_date""> </th>
		 <th id=""previous_number""> </th>
		 <th id=");
                WriteLiteral(@"""current_number""> </th>
		 <th id=""previous_debt""> </th>
		 <th id=""total_day""> </th>
		 <th id=""bill_exportation_date""> </th>
		</tr>
	   </tbody>
	  </table>
	 </div>
	</div>
   </div>
   <div class=""d-flex justify-content-end "">
	 <button type=""submit"" class=""btn btn-success  mt-1 mb-1"" style=""width: min-content;""> پرداخت
	</button>
");
                WriteLiteral("\t<a onclick=\"print();\" class=\"btn btn-success  mt-1 mb-1\" style=\"width: min-content;\"> چاپ\r\n\t</a>\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9e2720871fc938d0bcd9c625ab71b605a27d83914552", async() => {
                    WriteLiteral("\r\n\t بازگشت\r\n\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n   </div>\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
 
<script>

 var str = document.getElementById('Water').innerText.replace(""{"", """").replace(' \"" ', '').replace(""}"", """").split('""').join('');
 var res = str.split("","");

 var bill_id = res[1].split("":"");
 document.getElementById('bill_id2').value = """" + bill_id[1];
 var bill_id = res[1].split("":"");
 document.getElementById('bill_id').innerText = """" + bill_id[1];


 var pay_id = res[2].split("":"");
 document.getElementById('pay_id2').value = """" + pay_id[1];
 var pay_id = res[2].split("":"");
 document.getElementById('pay_id').innerText = """" + pay_id[1];

 var amount = res[3].split("":"");
 document.getElementById('amount').innerText = """" + amount[1];

 var file_number = res[4].split("":"");
 document.getElementById('file_number').innerText = """" + file_number[1];

 var owner_name = res[5].split("":"");
 document.getElementById('owner_name').innerText = """" + owner_name[1];

 var province = res[6].split("":"");
 document.getElementById('province').innerText = """" + province[1];
");
            WriteLiteral(@"
 var unit_count = res[7].split("":"");
 document.getElementById('unit_count').innerText = """" + unit_count[1];

 var previous_date = res[8].split("":"");
 var timestamp = parseInt(previous_date[1]);
 let mydate = new Date(timestamp);
 let mypersiandate = mydate.toLocaleDateString('fa-IR');
 document.getElementById('previous_date').innerText = """" + mypersiandate;

 var current_date = res[9].split("":"");
 var timestamp1 = parseInt(current_date[1]);
 let mydate1 = new Date(timestamp1);
 let mypersiandate1 = mydate1.toLocaleDateString('fa-IR');

 document.getElementById('current_date').innerText = """" + mypersiandate1;

 var previous_number = res[10].split("":"");
 document.getElementById('previous_number').innerText = """" + previous_number[1];


 var current_number = res[11].split("":"");
 document.getElementById('current_number').innerText = """" + current_number[1];

 var total_consumption = res[12].split("":"");
 document.getElementById('total_consumption').innerText = """" + total_consumption[1];

 ");
            WriteLiteral(@"var previous_debt = res[13].split("":"");
 document.getElementById('previous_debt').innerText = """" + previous_debt[1];

 var total_day = res[14].split("":"");
 document.getElementById('total_day').innerText = "" "" + total_day[1];

 var bill_exportation_date = res[15].split("":"");
 var timestamp2 = parseInt(bill_exportation_date[1]);
 let mydate2 = new Date(timestamp2);
 let mypersiandate2 = mydate2.toLocaleDateString('fa-IR');
 document.getElementById('bill_exportation_date').innerText = "" "" + mypersiandate2;

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.AdminViewModel.Gabz.Vm_Gabz> Html { get; private set; }
    }
}
#pragma warning restore 1591
