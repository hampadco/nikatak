#pragma checksum "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showelectricitybillinquiry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb4d265cda156f04a25a9381e23bf439e95bafe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gabz_Showelectricitybillinquiry), @"mvc.1.0.view", @"/Areas/Admin/Views/Gabz/Showelectricitybillinquiry.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4d265cda156f04a25a9381e23bf439e95bafe5", @"/Areas/Admin/Views/Gabz/Showelectricitybillinquiry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Gabz_Showelectricitybillinquiry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.AdminViewModel.Gabz.Vm_Gabz>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "برق", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Gabz_Charge/Estelam"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mt-1 mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: min-content;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Gabz/PardakhtTe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"card shadow\" id=\"myDiv\">\r\n\t<div class=\"card-header\">\r\n\t\t<h2 class=\"mb-0\"> نمایش استعلام قبض برق </h2>\r\n\t</div>\r\n\t<div class=\"card-body\">\r\n");
            WriteLiteral("\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb4d265cda156f04a25a9381e23bf439e95bafe56296", async() => {
                WriteLiteral("\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb4d265cda156f04a25a9381e23bf439e95bafe56560", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 9 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showelectricitybillinquiry.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.amount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb4d265cda156f04a25a9381e23bf439e95bafe58161", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 10 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showelectricitybillinquiry.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.bill_id2);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb4d265cda156f04a25a9381e23bf439e95bafe59765", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 11 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showelectricitybillinquiry.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.pay_id2);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb4d265cda156f04a25a9381e23bf439e95bafe511368", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showelectricitybillinquiry.cshtml"
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
                WriteLiteral("\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"table-responsive\">\r\n\t\t\t\t\t<div class=\"form-group justify-content-center \">\r\n\t\t\t\t\t\t<p style=\"direction: ltr; display: none;\" id=\"Electricity\">");
#nullable restore
#line 16 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showelectricitybillinquiry.cshtml"
                                                                              Write(ViewBag.result);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showelectricitybillinquiry.cshtml"
                         if (ViewBag.Msg != null)
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t  \t\t\t\t\t<div class=\"text-center\">\r\n\t\t  \t\t\t\t\t <p class=\"alert alert-danger\">");
#nullable restore
#line 20 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showelectricitybillinquiry.cshtml"
                                                        Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\t\t  \t\t\t\t\t</div>\r\n");
#nullable restore
#line 22 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\Showelectricitybillinquiry.cshtml"
						}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"	  <table class=""table table-hover"">
	   <thead class=""bg-primary"">
		<tr>
		 <th> شناسه قبض</th>
		 <th> شناسه پرداخت </th>
		 <th> مبلغ </th>
		 <th> تاریخ</th>
		 <th> تاریخ صدور صورتحساب</th>
		 <th> تاریخ قرائت قبلی </th>
		 <th> تاریخ قرائت فعلی </th>
		</tr>
	   </thead>
	   <tbody class=""bg-white"">
		<tr>
		 <th id=""bill_id""> </th>
		 <th id=""pay_id""> </th>
		 <th id=""amount2""> </th>
		 <th id=""date""> </th>
		 <th id=""bill_exportation_date""> </th>
		 <th id=""previous_reading_date""> </th>
		 <th id=""current_reading_date""> </th>
		</tr>
	   </tbody>

	   <thead class=""bg-primary"">
		<tr>
		 <th>مصرف عادی </th>
		 <th>مصرف اوج بار</th>
		 <th>مصرف کم بار</th>
		 <th> قرائت کنتور </th>
		 <th> میانگین مصرف </th>
		 <th> مبلغ قابل پرداخت صورتحساب </th>
		 <th> مقدار دوره </th>
		</tr>
	   </thead>
	   <tbody class=""bg-white"">
		<tr>
		 <th id=""normal_consumption""> </th>
		 <th id=""peak_consumption""></th>
		 <th id=""low_consumption""></th>
		 <th id=""demand_read""> </th");
                WriteLiteral(@">
		 <th id=""average_consumption""> </th>
		 <th id=""bill_payable_amount""> </th>
		 <th id=""period_amount""> </th>
		</tr>
	   </tbody>

	   <thead class=""bg-primary"">
		<tr>
		 <th> مبلغ بیمه </th>
		 <th> مالیات </th>
		 <th> مقدار مالیات برق </th>
		 <th>بدهی قبلی </th>
		 <th> مقدار انزژی </th>
		 <th>مجموع روزها</th>
		 <th> نام شرکت </th>
		</tr>
	   </thead>

	   <tbody class=""bg-white"">
		<tr>
		 <th id=""insurance_amount""> </th>
		 <th id=""tax_amount""> </th>
		 <th id=""electricity_tax_amount""> </th>
		 <th id=""previous_debt""> </th>
		 <th id=""energy_amount""> </th>
		 <th id=""total_days_count""></th>
		 <th id=""company_name""> </th>
		</tr>
	   </tbody>

	   <thead class=""bg-primary"">
		<tr>
		 <th>فاز </th>
		 <th> نوع ولتاژ</th>
		 <th> آمپر</th>
		 <th> تقاضای قرارداد</th>
		 <th>نوع مشتری </th>
		 <th>نام مشتری </th>
		 <th>آدرس </th>
		</tr>
	   </thead>

	   <tbody class=""bg-white"">
		<tr>
		 <th id=""phase""> </th>
		 <th id=""voltage_type""> </th>
		 <th i");
                WriteLiteral(@"d=""amper""> </th>
		 <th id=""contract_demand""> </th>
		 <th id=""customer_type""> </th>
		 <th id=""customer_name""> </th>
		 <th id=""address""> </th>

		</tr>
	   </tbody>

	   <thead class=""bg-primary"">
		<tr>
		 <th> کد پستی </th>
		 <th> شماره شناسایی </th>
		 <th> دوره</th>
		 <th> سال</th>
		</tr>
	   </thead>
	   <tbody class=""bg-white"">
		<tr>
		 <th id=""postal_code""> </th>
		 <th id=""identification_number""> </th>
		 <th id=""period""> </th>
		 <th id=""year""> </th>
		</tr>
	   </tbody>
	  </table>
	 </div>
	</div>
   </div>
   <div class=""d-flex justify-content-end "">
");
                WriteLiteral("\t<a href=\"https://bill.bpm.bankmellat.ir/bpgwchannel/\" class=\"btn btn-success mt-1 mb-1\" style=\"width: min-content;\">\r\n\t پرداخت\r\n\t</a>\r\n\t<a onclick=\"print();\" class=\"btn btn-success  mt-1 mb-1\" style=\"width: min-content;\"> چاپ\r\n\t</a>\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb4d265cda156f04a25a9381e23bf439e95bafe517759", async() => {
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

 debugger
 var str = document.getElementById('Electricity').innerText.replace(""{"", """").replace(' \"" ', '').replace(""}"", """").split('""').join('');
 var res = str.split("","");

 var bill_id = res[1].split("":"");
 document.getElementById('bill_id2').value = """" + bill_id[1];////////////// شناسه قبض
 var bill_id = res[1].split("":"");
 document.getElementById('bill_id').innerText = """" + bill_id[1];////////////// شناسه قبض

 var pay_id = res[2].split("":"");
 document.getElementById('pay_id2').value = "" "" + pay_id[1];//////////// شناسه پرداخت
 var pay_id = res[2].split("":"");
 document.getElementById('pay_id').innerText = "" "" + pay_id[1];//////////// شناسه پرداخت

 var amount = res[3].split("":"");
 document.getElementById('amount').value = "" "" + amount[1];//////////// مبلغ
 var amount = res[3].split("":"");
 document.getElementById('amount2').innerText = "" "" + amount[1];//////////// مبلغ

 var date = res[4].split("":"");
 var timestamp = parseInt(date[1]);
 let mydate = new ");
            WriteLiteral(@"Date(timestamp);
 let mypersiandate = mydate.toLocaleDateString('fa-IR');
 document.getElementById('date').innerText = "" "" + mypersiandate;/////////////// تاریخ

 var bill_exportation_date = res[5].split("":"");
 var timestamp1 = parseInt(bill_exportation_date[1]);
 let mydate1 = new Date(timestamp1);
 let mypersiandate1 = mydate1.toLocaleDateString('fa-IR');
 document.getElementById('bill_exportation_date').innerText = "" "" + mypersiandate1;//////////// تاریخ صدور صورتحساب

 var previous_reading_date = res[6].split("":"");
 var timestamp2 = parseInt(previous_reading_date[1]);
 let mydate2 = new Date(timestamp2);
 let mypersiandate2 = mydate2.toLocaleDateString('fa-IR');
 document.getElementById('previous_reading_date').innerText = "" "" + mypersiandate2;/////////// تاریخ قرائت قبلی

 var current_reading_date = res[7].split("":"");
 var timestamp3 = parseInt(current_reading_date[1]);
 let mydate3 = new Date(timestamp3);
 let mypersiandate3 = mydate3.toLocaleDateString('fa-IR');
 document.getElement");
            WriteLiteral(@"ById('current_reading_date').innerText = "" "" + mypersiandate3;/////////// تاریخ قرائت فعلی

 var normal_consumption = res[8].split("":"");
 document.getElementById('normal_consumption').innerText = "" "" + normal_consumption[1];///////////// مصرف عادی

 var peak_consumption = res[9].split("":"");
 document.getElementById('peak_consumption').innerText = "" "" + peak_consumption[1];//////////// مصرف اوج بار

 var low_consumption = res[10].split("":"");
 document.getElementById('low_consumption').innerText = "" "" + low_consumption[1];/////////////مصرف کم بار

 var demand_read = res[11].split("":"");
 document.getElementById('demand_read').innerText = "" "" + demand_read[1];////////////////// قرائت کنتور 

 var average_consumption = res[12].split("":"");
 document.getElementById('average_consumption').innerText = "" "" + average_consumption[1]; //////////////// میانگین مصرف

 var bill_payable_amount = res[13].split("":"");
 document.getElementById('bill_payable_amount').innerText = "" "" + bill_payable_amount[1];/////");
            WriteLiteral(@"/////////////////////// مبلغ قابل پرداخت صورتحساب

 var period_amount = res[14].split("":"");
 document.getElementById('period_amount').innerText = "" "" + period_amount[1];//////////// مقدار دوره

 var insurance_amount = res[15].split("":"");
 document.getElementById('insurance_amount').innerText = "" "" + insurance_amount[1];////////////مبلغ بیمه

 var tax_amount = res[16].split("":"");
 document.getElementById('tax_amount').innerText = "" "" + tax_amount[1];///////////مالیات

 var electricity_tax_amount = res[17].split("":"");
 document.getElementById('electricity_tax_amount').innerText = "" "" + electricity_tax_amount[1];//////////////مقدار مالیات برق

 var previous_debt = res[18].split("":"");
 document.getElementById('previous_debt').innerText = "" "" + previous_debt[1];////////////بدهی قبلی

 var energy_amount = res[19].split("":"");
 document.getElementById('energy_amount').innerText = "" "" + energy_amount[1];///////////مقدار انزژی

 var total_days_count = res[20].split("":"");
 document.getElementById('t");
            WriteLiteral(@"otal_days_count').innerText = "" "" + total_days_count[1];/////////// مجموع روزها

 var company_name = res[21].split("":"");
 document.getElementById('company_name').innerText = "" "" + company_name[1];//////////نام شرکت

 var phase = res[22].split("":"");
 document.getElementById('phase').innerText = "" "" + phase[1];///////////فاز

 var voltage_type = res[23].split("":"");
 document.getElementById('voltage_type').innerText = "" "" + voltage_type[1];/////////نوع ولتاژ

 var amper = res[24].split("":"");
 document.getElementById('amper').innerText = "" "" + amper[1];///////////آمپر

 var contract_demand = res[25].split("":"");
 document.getElementById('contract_demand').innerText = "" "" + contract_demand[1];///////////تقاضای قرارداد

 var customer_type = res[26].split("":"");
 document.getElementById('customer_type').innerText = "" "" + customer_type[1];//////////////نوع مشتری

 var customer_name = res[27].split("":"");
 document.getElementById('customer_name').innerText = "" "" + customer_name[1];//////////////نام م");
            WriteLiteral(@"شتری

 var address = res[28].split("":"");
 document.getElementById('address').innerText = "" "" + address[1];//////////آدرس

 var postal_code = res[29].split("":"");
 document.getElementById('postal_code').innerText = "" "" + postal_code[1];////////// کد پستی

 var identification_number = res[30].split("":"");
 document.getElementById('identification_number').innerText = "" "" + identification_number[1];///////////// شماره شناسایی

 var period = res[31].split("":"");
 document.getElementById('period').innerText = "" "" + period[1];//////////////دوره

 var year = res[32].split("":"");
 document.getElementById('year').innerText = "" "" + year[1];////////////سال

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
