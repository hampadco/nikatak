#pragma checksum "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\ShwoDirectchargerequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e51081b9d4b6b2f1a47085fe8c905072f874329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gabz_ShwoDirectchargerequest), @"mvc.1.0.view", @"/Areas/Admin/Views/Gabz/ShwoDirectchargerequest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e51081b9d4b6b2f1a47085fe8c905072f874329", @"/Areas/Admin/Views/Gabz/ShwoDirectchargerequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Gabz_ShwoDirectchargerequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card shadow"" id=""myDiv"">
	<div class=""card-header"">
		<h2 class=""mb-0""> درخواست شارژ مستقیم</h2>
		<div class=""card-body"">
			<div class=""row"">
				<div class=""table-responsive"">
					<div class=""form-group justify-content-center "">
						<p style=""direction: ltr; display: ;"" id=""Charge"">");
#nullable restore
#line 8 "c:\Users\MS\Desktop\nika4-15\Nikatak\faraboom\Areas\Admin\Views\Gabz\ShwoDirectchargerequest.cshtml"
                                                                     Write(ViewBag.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
            WriteLiteral(@"		</div>
	</div>
</div>

<script>

	debugger
	var str = document.getElementById('Charge').innerText.replace(""{"", """").replace(' \"" ', '').replace(""}"", """");
	var res = str.split("","");

	var bill_id = res[1].split("":"");
	document.getElementById('bill_id').innerText = """" + bill_id[1];

</script>

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
