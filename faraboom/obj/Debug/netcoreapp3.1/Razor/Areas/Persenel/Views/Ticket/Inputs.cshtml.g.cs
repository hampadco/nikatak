#pragma checksum "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Persenel\Views\Ticket\Inputs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42ad852c570ee3e95fae936abb8fe03cebddbf2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Persenel_Views_Ticket_Inputs), @"mvc.1.0.view", @"/Areas/Persenel/Views/Ticket/Inputs.cshtml")]
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
#line 1 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Persenel\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\MS\Desktop\Nikatak\faraboom\Areas\Persenel\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42ad852c570ee3e95fae936abb8fe03cebddbf2c", @"/Areas/Persenel/Views/Ticket/Inputs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Areas/Persenel/Views/_ViewImports.cshtml")]
    public class Areas_Persenel_Views_Ticket_Inputs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Page content -->

    <div class=""page-header mt-0 shadow p-3"">
        <ol class=""breadcrumb mb-sm-0"">
            <li class=""breadcrumb-item""><a href=""#"">صفحات</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">صندوق دریافت ایمیل</li>
        </ol>
        <div class=""btn-group mb-0"">
            <button type=""button"" class=""btn btn-primary btn-sm dropdown-toggle"" data-toggle=""dropdown""
                aria-haspopup=""true"" aria-expanded=""false"">اقدامات</button>
            <div class=""dropdown-menu"" x-placement=""bottom-start""
                style=""position: absolute; transform: translate3d(-65px, 27px, 0px); top: 0px; left: 0px; will-change: transform;"">
                <a class=""dropdown-item"" href=""#""><i class=""fas fa-plus mr-2""></i>افزودن صفحه
                    جدید</a>
                <a class=""dropdown-item"" href=""#""><i class=""fas fa-eye mr-2""></i>مشاهده جزئیات
                    صفحه</a>
                <a class=""dropdown-item"" href=""#""><i class=""fas f");
            WriteLiteral(@"a-edit mr-2""></i>ویرایش
                    صفحه</a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""#""><i class=""fas fa-cog mr-2""></i> تنظیمات</a>
            </div>
        </div>
    </div>
    <div class=""email-app card shadow"">
        <nav class=""p-0"">
            <div class=""card-body"">
                <a href=""/Persenel/Ticket/send"" class=""btn btn-primary btn-block  btn-sm mt-1 mb-1"">ارسال تیکت</a>
            </div>
             <ul class=""nav"">
                <li class=""nav-item"">
                    <a class=""nav-link mr-0 border-top"" href=""#""><i class=""fa fa-inbox""></i>
                        صندوق دریافت <span class=""badge badge-primary"">14</span></a>
                </li>
");
            WriteLiteral(@"            </ul> 
        </nav>
        <div class=""inbox p-0"">
            <div class=""card-body d-none d-lg-block"">

                <div class=""toolbar "">
                    <div class=""btn-group mt-1 mb-1"">
                        <button type=""button"" class=""btn btn-sm btn-light"" title=""صندوق دریافت"">
                            <span class=""fas fa-envelope""></span>
                        </button>
                        <button type=""button"" class=""btn btn-sm btn-light"" title=""پیام های مهم"">
                            <span class=""fas fa-star""></span>
                        </button>
                        <button type=""button"" class=""btn btn-sm btn-light"" title=""دخیره ایمیل ها"">
                            <span class=""fas fa-bookmark""></span>
                        </button>
                    </div>
                    <div class=""btn-group mt-1 mb-1"">
                        <button type=""button"" class=""btn btn-sm btn-light"" title=""پاسخ"">
                            <spa");
            WriteLiteral(@"n class=""fas fa-reply""></span>
                        </button>
                        <button type=""button"" class=""btn btn-sm btn-light"" title=""پاسخ به همه"">
                            <span class=""fas fa-reply-all""></span>
                        </button>

                    </div>
                    <button type=""button"" class=""mt-1 mb-1 btn btn-sm btn-light"" title=""حذف"">
                        <span class=""fas fa-trash""></span>
                    </button>
                    <div class=""btn-group mt-1 mb-1"">
                        <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle"" data-toggle=""dropdown""
                            title=""برچسب"">
                            <span class=""fas fa-tags""></span>
                            <span class=""caret""></span>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">افزودن برچسب <span class=""badge badge-danger"">
         ");
            WriteLiteral(@"                           خانه</span></a>
                            <a class=""dropdown-item"" href=""#"">افزودن برچسب <span class=""badge badge-info"">
                                    شغل</span></a>
                            <a class=""dropdown-item"" href=""#"">افزودن برچسب <span class=""badge badge-success"">
                                    کاربران</span></a>
                            <a class=""dropdown-item"" href=""#"">افزودن برچسب <span class=""badge badge-warning"">
                                    اخبار</span></a>
                        </div>
                    </div>
                    <div class=""btn-group float-left mt-1 mb-1"">
                        <button type=""button"" class=""btn btn-sm btn-light"">
                            <span class=""fas fa-chevron-right""></span>
                        </button>
                        <button type=""button"" class=""btn btn-sm btn-light"">
                            <span class=""fas fa-chevron-left""></span>
                        </butt");
            WriteLiteral(@"on>
                    </div>
                </div>
            </div>
            <ul class=""mail_list list-group list-unstyled"">
                <li class=""list-group-item"">
                    <div class=""media"">
                        <div class=""pull-left"">
                            <div class=""controls"">
                                <div class=""checkbox"">
                                    <input type=""checkbox"" id=""basic_checkbox_1"">
                                    <label for=""basic_checkbox_1""></label>
                                </div>
                                <a href=""javascript:void(0);"" class=""favourite text-muted hidden-sm-down""
                                    data-toggle=""active""><i class=""zmdi zmdi-star-outline""></i></a>
                            </div>
                        </div>
");
            WriteLiteral(@"                    </div>
                </li>
             
            </ul>
        </div>
    </div>

    <!-- Footer -->
    <!-- <footer class=""footer"">
								<div class=""row align-items-center justify-content-xl-between"">
									<div class=""col-xl-6"">
										<div class=""copyright text-center text-xl-right text-muted"">
											<p class=""text-sm font-weight-500"">Copyright 2018 © تمامی حقوق محفوظ است</p>
										</div>
									</div>
									<div class=""col-xl-6"">

									</div>
								</div>
							</footer> -->
    <!-- Footer -->

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
