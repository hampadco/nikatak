#pragma checksum "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Sepordeh\Openaccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31cae8f68fc1b0ee218291f8ca0bd9ab19b5708d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sepordeh_Openaccount), @"mvc.1.0.view", @"/Areas/Admin/Views/Sepordeh/Openaccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31cae8f68fc1b0ee218291f8ca0bd9ab19b5708d", @"/Areas/Admin/Views/Sepordeh/Openaccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sepordeh_Openaccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card shadow"">
										<div class=""card-header"">
											<h2 class=""mb-2""> افتتاح سپرده</h2>
										</div>
										<div class=""card-body"">
											<div class=""row"">
												<div class=""col-md-6"">
													<div class=""form-group"">
                                                        	<h2 class=""mb-0""> نام و نام خانوادگی</h2>
														<input type=""text"" class=""form-control"" name=""input"" placeholder=""نام ونام خانوادگی خود را وارد کنید""  >
													</div>

                                                    <div class=""form-group"">
                                                        <h2 class=""mb-0"">  کدملی  </h2>
														<input type=""text"" class=""form-control"" name=""input"" placeholder=""کدملی  خود را وارد کنید""  >
													</div>

                                                    <div class=""form-group"">
                                                           <h2 class=""mb-0"">  آدرس  </h2>
														<input type=""text"" class=""for");
            WriteLiteral(@"m-control"" name=""input"" placeholder=""آدرس خود را وارد کنید""  >
													</div>

                                                       <div class=""form-group"">
                                                                <h2 class=""mb-0"">  واحد پول  </h2>
														<input type=""text"" class=""form-control"" name=""input"" placeholder=""واحد پول سپرده افتتاحی""  >
													</div>
                                                    


													
													
												</div>
												<div class=""col-md-6"">
												
															<div class=""form-group"">
                                                                     <h2 class=""mb-0"">  شماره موبایل  </h2>
														<input type=""text"" class=""form-control"" name=""input"" placeholder=""شماره موبایل خود را وارد کنید""  >
													</div>

                                                    <div class=""form-group"">
                                                             <h2 class=""mb-0"">  ایمیل  </h2>
									");
            WriteLiteral(@"					<input type=""text"" class=""form-control"" name=""input"" placeholder=""ایمیل خود را وارد کنید""  >
													</div>

                                                    <div class=""form-group"">
                                                             <h2 class=""mb-0"">  کد پستی  </h2>
														<input type=""text"" class=""form-control"" name=""input"" placeholder="" کد پستی خود را وارد کنید""  >
													</div>

                                                    <div class=""form-group"">
                                                             <h2 class=""mb-0"">  مبلغ دریافتی  </h2>
														<input type=""text"" class=""form-control"" name=""input"" placeholder=""مبلغ دریافتی برای افتتاح سپرده""  >
													</div>
                                                     <div class=""col-sm-6 col-12"">
                    <label for=""file"" class=""btn btn-default""> نمونه امضاء صاحب سپرده  </label>
                    <input  type=""file"" accept=""image/*"" onchange=""preview_image(event)"">
      ");
            WriteLiteral(@"            </div>
                </fieldset>




													
												</div>
												 <button type=""button"" class=""btn btn-success  mt-1 mb-1"" style=""width: min-content;"">دریافت
            اطلاعات حساب
        </button>
											</div>
										</div>
									</div>

                                    <script>
  function preview_image(event) {
    var reader = new FileReader();
    reader.onload = function () {
      var output = document.getElementById('output_image');
      output.src = reader.result;
    }
    reader.readAsDataURL(event.target.files[0]);
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
