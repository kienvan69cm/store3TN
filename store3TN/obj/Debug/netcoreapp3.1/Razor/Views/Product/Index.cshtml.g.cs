#pragma checksum "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf3fc6c44fc9dac7e1a825fd8f68a1ddec7e0ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\_ViewImports.cshtml"
using store3TN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\_ViewImports.cshtml"
using store3TN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3fc6c44fc9dac7e1a825fd8f68a1ddec7e0ae4", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18757d06e88ab735ae329cda8741fd8e1c1cd8f6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row contact_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("contact_process.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("contact_process.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
  
	Layout = "~/Views/Shared/_Layout.cshtml";
	string htmlStr = Model.ChiTiet;
	// replace \" with " to avoid escaping in the string literal
	htmlStr = htmlStr.Replace("\\\"", "\"");
	// fix \r\n
	htmlStr = htmlStr.Replace("\\r\\n", "\r\n");
	List<BinhLuan> BLSP = ViewBag.BLSP;
	List<BinhLuan> AllTLBL = ViewBag.AllTLBL;
	Dictionary<int, List<BinhLuan>> TLBL = ViewBag.TLBL;
	Dictionary<int, string> TenND = ViewBag.TenND;
	List<DanhGia> DanhGia = ViewBag.DanhGia;
	Dictionary<int, Dictionary<int, int>> SLDanhGia = ViewBag.SLDanhGia;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Start Banner Area -->
<section class=""banner-area organic-breadcrumb"">
	<div class=""container"">
		<div class=""breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end"">
			<div class=""col-first"">
				<h1>Chi tiết sản phẩm</h1>
				<nav class=""d-flex align-items-center"">
					<a href=""index.html"">Trang chủ<span class=""lnr lnr-arrow-right""></span></a>
					<a href=""category.html"">Shop<span class=""lnr lnr-arrow-right""></span></a>
					<a href=""#"">Chi tiết</a>
				</nav>
			</div>
		</div>
	</div>
</section>
<!-- End Banner Area -->

<!--================Single Product Area =================-->
<div class=""product_image_area"">
	<div class=""container"">
		<div class=""row s_product_inner"">
			<div class=""col-lg-6"">
				<div class=""s_Product_carousel"">
					<div class=""single-prd-item"">
						<img class=""img-fluid""");
            BeginWriteAttribute("src", " src=", 1415, "", 1434, 1);
#nullable restore
#line 39 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
WriteAttributeValue("", 1420, Model.HinhAnh, 1420, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1434, "\"", 1440, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"single-prd-item\">\r\n\t\t\t\t\t\t<img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 1521, "", 1540, 1);
#nullable restore
#line 42 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
WriteAttributeValue("", 1526, Model.HinhAnh, 1526, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1540, "\"", 1546, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"single-prd-item\">\r\n\t\t\t\t\t\t<img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 1627, "", 1646, 1);
#nullable restore
#line 45 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
WriteAttributeValue("", 1632, Model.HinhAnh, 1632, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1646, "\"", 1652, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-lg-5 offset-lg-1\">\r\n\t\t\t\t<div class=\"s_product_text\">\r\n\t\t\t\t\t<h3>");
#nullable restore
#line 51 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                   Write(Model.TenSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t\t<h2>");
#nullable restore
#line 52 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                   Write(Model.GiaBan.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</h2>\r\n\t\t\t\t\t<ul class=\"list\">\r\n\t\t\t\t\t\t<li><a class=\"active\" href=\"#\"><span>Phân loại</span> : ");
#nullable restore
#line 54 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                                                           Write(Model.TenSeries);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#\"><span>Tình trạng</span> : Còn hàng</a></li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 57 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                  Write(Model.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
					<ul>
						<li><span class='lnr lnr-sync p-1'></span> Đổi trả trong vòng <strong>12 tháng</strong> tại 30
							siêu
							thị toàn quốc (miễn phí tháng đầu)</li>
						<li><span class='lnr lnr-checkmark-circle p-1'></span> Bảo hành chính hãng <strong>1
								năm</strong> tại các trung tâm bảo hành hãng</li>
						<li><span class='lnr lnr-inbox p-1'></span> Bộ sản phẩm gồm: <strong>Hộp, Sách hướng dẫn, Cáp
								Lightning - Type C, ...</strong></li>
					</ul>
					<div class=""mt-5 product_count"">
						<label for=""qty"">Quantity:</label>
						<input type=""text"" name=""qty"" id=""sst"" maxlength=""12"" value=""1"" title=""Quantity:""
							class=""input-text qty"">
						<button class=""increase items-count"" type=""button""><i class=""lnr lnr-chevron-up""></i></button>
						<button class=""reduced items-count"" type=""button""><i class=""lnr lnr-chevron-down""></i></button>
					</div>
					<div class=""card_area d-flex align-items-center"">
						<a class=""primary-btn"" href=""#"">Thêm vào giỏ hàng</");
            WriteLiteral(@"a>
						<a class=""icon_btn"" href=""#""><i class=""lnr lnr lnr-heart""></i></a>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
<!--================End Single Product Area =================-->

<!--================Product Description Area =================-->
<section class=""product_description_area"">
	<div class=""container"">
		<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
			<li class=""nav-item"">
				<a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home""
					aria-selected=""true"">Mô tả</a>
			</li>
			<li class=""nav-item"">
				<a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab""
					aria-controls=""profile"" aria-selected=""false"">Cấu hình</a>
			</li>
			<li class=""nav-item"">
				<a class=""nav-link"" id=""contact-tab"" data-toggle=""tab"" href=""#contact"" role=""tab""
					aria-controls=""contact"" aria-selected=""false"">Bình luận</a>
			</li>
			<li class=""nav-item"">
				<a class=""nav-link"" id=""review-tab");
            WriteLiteral(@""" data-toggle=""tab"" href=""#review"" role=""tab"" aria-controls=""review""
					aria-selected=""false"">Đánh giá</a>
			</li>
		</ul>
		<div class=""tab-content"" id=""myTabContent"">
			<div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
				<p>");
#nullable restore
#line 108 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
              Write(Model.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"tab-pane fade\" id=\"profile\" role=\"tabpanel\" aria-labelledby=\"profile-tab\">\r\n\t\t\t\t<div class=\"table-responsive\">\r\n\t\t\t\t\t");
#nullable restore
#line 112 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
               Write(Html.Raw(htmlStr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"tab-pane fade\" id=\"contact\" role=\"tabpanel\" aria-labelledby=\"contact-tab\">\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-lg-6\">\r\n\t\t\t\t\t\t<div class=\"comment_list\">\r\n");
#nullable restore
#line 119 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                             foreach (var item in BLSP)
							{
								if (item.MaSP == Model.MaSP)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"review_item\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"media\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"d-flex\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<img src=\"img/product/review-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5003, "\"", 5009, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"media-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h4>");
#nullable restore
#line 129 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                               Write(TenND[item.MaND]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h5>");
#nullable restore
#line 130 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                               Write(item.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<a class=\"reply_btn\" href=\"#\">Trả lời</a>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 134 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                      Write(item.BLuan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 136 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
									if (TLBL.ContainsKey(item.MaBL))
									{
										foreach (var item1 in TLBL[item.MaBL])
										{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<div class=\"review_item reply\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"media\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"d-flex\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<img src=\"img/product/review-2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5563, "\"", 5569, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"media-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<h4>");
#nullable restore
#line 146 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                                       Write(TenND[item1.MaND]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<h5>");
#nullable restore
#line 147 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                                       Write(item1.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a class=\"reply_btn\" href=\"#\">Trả lời</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 151 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                              Write(item1.BLuan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 153 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
										}
									}
								}
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-lg-6\">\r\n\t\t\t\t\t\t<div class=\"review_box\">\r\n\t\t\t\t\t\t\t<h4>Để lại bình luận</h4>\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf3fc6c44fc9dac7e1a825fd8f68a1ddec7e0ae417569", async() => {
                WriteLiteral(@"
								<div class=""col-md-12"">
									<div class=""form-group"">
										<input type=""text"" class=""form-control"" id=""name"" name=""name""
											placeholder=""Tên của bạn"">
									</div>
								</div>
								<div class=""col-md-12"">
									<div class=""form-group"">
										<input type=""email"" class=""form-control"" id=""email"" name=""email""
											placeholder=""Email"">
									</div>
								</div>
								<div class=""col-md-12"">
									<div class=""form-group"">
										<input type=""text"" class=""form-control"" id=""number"" name=""number""
											placeholder=""Số điện thoại"">
									</div>
								</div>
								<div class=""col-md-12"">
									<div class=""form-group"">
										<textarea class=""form-control"" name=""message"" id=""message"" rows=""1""
											placeholder=""Bình luận""></textarea>
									</div>
								</div>
								<div class=""col-md-12 text-right"">
									<button type=""submit"" value=""submit"" class=""btn primary-btn"">Gửi ngay</button>
								</div>
			");
                WriteLiteral("\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
			<div class=""tab-pane fade"" id=""review"" role=""tabpanel"" aria-labelledby=""review-tab"">
				<div class=""row"">
					<div class=""col-lg-6"">
						<div class=""row total_rate"">
							<div class=""col-6"">
");
#nullable restore
#line 201 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                  
									int sldg = 0;
									int five = 0;
									int four = 0;
									int three = 0;
									int two = 0;
									int one = 0;
									// calc sum of value of SLDanhGia[Model.MaSP]
									if (SLDanhGia.ContainsKey(Model.MaSP))
									{
										foreach (var item in SLDanhGia[Model.MaSP])
										{
											sldg += item.Value;
										}
										five = SLDanhGia[Model.MaSP][5];
										four = SLDanhGia[Model.MaSP][4];
										three = SLDanhGia[Model.MaSP][3];
										two = SLDanhGia[Model.MaSP][2];
										one = SLDanhGia[Model.MaSP][1];
									}

								

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"box_total\">\r\n\t\t\t\t\t\t\t\t\t<h5>Tổng quan</h5>\r\n\t\t\t\t\t\t\t\t\t<h4>");
#nullable restore
#line 225 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                   Write(Model.SoSao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t\t<h6>(");
#nullable restore
#line 226 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                    Write(sldg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đánh giá)</h6>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-6\">\r\n\t\t\t\t\t\t\t\t<div class=\"rating_list\">\r\n\t\t\t\t\t\t\t\t\t<h3>Dựa trên ");
#nullable restore
#line 231 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                            Write(sldg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đánh giá</h3>\r\n\t\t\t\t\t\t\t\t\t<ul class=\"list\">\r\n\t\t\t\t\t\t\t\t\t\t<li><a href=\"#\">5 Star <i class=\"fa fa-star\"></i><i class=\"fa fa-star\"></i><i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"fa fa-star\"></i><i class=\"fa fa-star\"></i><i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"fa fa-star\"></i> ");
#nullable restore
#line 235 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                                                       Write(five);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li><a href=\"#\">4 Star <i class=\"fa fa-star\"></i><i class=\"fa fa-star\"></i><i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"fa fa-star\"></i><i class=\"fa fa-star\"></i><i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"fa fa-star-o\"></i> ");
#nullable restore
#line 238 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                                                         Write(four);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li><a href=\"#\">3 Star <i class=\"fa fa-star\"></i><i class=\"fa fa-star\"></i><i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"fa fa-star\"></i><i class=\"fa fa-star-o\"></i><i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"fa fa-star-o\"></i> ");
#nullable restore
#line 241 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                                                         Write(three);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li><a href=\"#\">2 Star <i class=\"fa fa-star\"></i><i class=\"fa fa-star\"></i><i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"fa fa-star-o\"></i><i class=\"fa fa-star-o\"></i><i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"fa fa-star-o\"></i> ");
#nullable restore
#line 244 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                                                         Write(two);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li><a href=\"#\">1 Star <i class=\"fa fa-star\"></i><i class=\"fa fa-star-o\"></i><i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"fa fa-star-o\"></i><i class=\"fa fa-star-o\"></i><i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"fa fa-star-o\"></i> ");
#nullable restore
#line 247 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                                                         Write(one);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"review_list\">\r\n");
#nullable restore
#line 253 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                             foreach (var item in DanhGia)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 255 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                 if (item.MaSP == Model.MaSP)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"review_item\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"media\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"d-flex\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<img src=\"img/product/review-3.png\"");
            BeginWriteAttribute("alt", " alt=\"", 9781, "\"", 9787, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"media-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h4>");
#nullable restore
#line 263 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                               Write(TenND[item.MaND]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div>\r\n");
#nullable restore
#line 265 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                                     for (int i = 0; i < item.SoSao; i++)
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-star star-rv\"></i>\r\n");
#nullable restore
#line 268 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
													}

#line default
#line hidden
#nullable disable
#nullable restore
#line 269 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                                     for (int i = 0; i < 5 - item.SoSao; i++)
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-star-o star-rv\"></i>\r\n");
#nullable restore
#line 272 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
													}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h5>");
#nullable restore
#line 274 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                               Write(item.NgayDanhGia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 277 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                      Write(item.NoiDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 279 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
								}

#line default
#line hidden
#nullable disable
#nullable restore
#line 279 "C:\Users\kienv\Desktop\store3TN\store3TN\store3TN\Views\Product\Index.cshtml"
                                 
							}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						</div>
					</div>
					<div class=""col-lg-6"">
						<div class=""review_box"">
							<h4>Để lại đánh giá</h4>
							<p>Đánh giá của bạn:</p>
							<ul class=""list"">
								<li><a href=""#""><i class=""fa fa-star""></i></a></li>
								<li><a href=""#""><i class=""fa fa-star""></i></a></li>
								<li><a href=""#""><i class=""fa fa-star""></i></a></li>
								<li><a href=""#""><i class=""fa fa-star""></i></a></li>
								<li><a href=""#""><i class=""fa fa-star""></i></a></li>
							</ul>
							<p>Quá tuyệt vời</p>
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf3fc6c44fc9dac7e1a825fd8f68a1ddec7e0ae429576", async() => {
                WriteLiteral(@"
								<div class=""col-md-12"">
									<div class=""form-group"">
										<input type=""text"" class=""form-control"" id=""name"" name=""name""
											placeholder=""Tên của bạn"" onfocus=""this.placeholder = ''""
											onblur=""this.placeholder = 'Your Full name'"">
									</div>
								</div>
								<div class=""col-md-12"">
									<div class=""form-group"">
										<input type=""email"" class=""form-control"" id=""email"" name=""email""
											placeholder=""Email"" onfocus=""this.placeholder = ''""
											onblur=""this.placeholder = 'Email Address'"">
									</div>
								</div>
								<div class=""col-md-12"">
									<div class=""form-group"">
										<input type=""text"" class=""form-control"" id=""number"" name=""number""
											placeholder=""Số điện thoại"" onfocus=""this.placeholder = ''""
											onblur=""this.placeholder = 'Phone Number'"">
									</div>
								</div>
								<div class=""col-md-12"">
									<div class=""form-group"">
										<textarea class=""form-control"" name=""m");
                WriteLiteral(@"essage"" id=""message"" rows=""1""
											placeholder=""Đánh giá"" onfocus=""this.placeholder = ''""
											onblur=""this.placeholder = 'Review'""></textarea></textarea>
									</div>
								</div>
								<div class=""col-md-12 text-right"">
									<button type=""submit"" value=""submit"" class=""primary-btn"">Gửi ngay</button>
								</div>
							");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
		</div>
	</div>
</section>
<!--================End Product Description Area =================-->

<!-- Start related-product Area -->
<section class=""related-product-area section_gap_bottom"">
	<div class=""container"">
		<div class=""row justify-content-center"">
			<div class=""col-lg-6 text-center"">
				<div class=""section-title"">
					<h1>Các sản phẩm tương tự</h1>
					<p>Khám phá các sản phẩm tương tự của cửa hàng chúng tôi.</p>
				</div>
			</div>
		</div>
		<div class=""row"">
			<div class=""col-lg-9"">
				<div class=""row"">
					<div class=""col-lg-4 col-md-4 col-sm-6 mb-20"">
						<div class=""single-related-product d-flex"">
							<a href=""#""><img src=""img/product/macbook-pro.jpg"" width=""80"" height=""60""");
            BeginWriteAttribute("alt", " alt=\"", 13179, "\"", 13185, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
							<div class=""desc"">
								<a href=""#"" class=""title"">MacBook Pro 2021</a>
								<div class=""price"">
									<h6>$189.00</h6>
									<h6 class=""l-through"">$210.00</h6>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-lg-4 col-md-4 col-sm-6 mb-20"">
						<div class=""single-related-product d-flex"">
							<a href=""#""><img src=""img/product/macbook-pro.jpg"" width=""80"" height=""60""");
            BeginWriteAttribute("alt", " alt=\"", 13619, "\"", 13625, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
							<div class=""desc"">
								<a href=""#"" class=""title"">MacBook Pro 2021</a>
								<div class=""price"">
									<h6>$189.00</h6>
									<h6 class=""l-through"">$210.00</h6>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-lg-4 col-md-4 col-sm-6 mb-20"">
						<div class=""single-related-product d-flex"">
							<a href=""#""><img src=""img/product/macbook-pro.jpg"" width=""80"" height=""60""");
            BeginWriteAttribute("alt", " alt=\"", 14059, "\"", 14065, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
							<div class=""desc"">
								<a href=""#"" class=""title"">MacBook Pro 2021</a>
								<div class=""price"">
									<h6>$189.00</h6>
									<h6 class=""l-through"">$210.00</h6>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-lg-4 col-md-4 col-sm-6 mb-20"">
						<div class=""single-related-product d-flex"">
							<a href=""#""><img src=""img/product/macbook-pro.jpg"" width=""80"" height=""60""");
            BeginWriteAttribute("alt", " alt=\"", 14499, "\"", 14505, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
							<div class=""desc"">
								<a href=""#"" class=""title"">MacBook Pro 2021</a>
								<div class=""price"">
									<h6>$189.00</h6>
									<h6 class=""l-through"">$210.00</h6>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-lg-4 col-md-4 col-sm-6 mb-20"">
						<div class=""single-related-product d-flex"">
							<a href=""#""><img src=""img/product/macbook-pro.jpg"" width=""80"" height=""60""");
            BeginWriteAttribute("alt", " alt=\"", 14939, "\"", 14945, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
							<div class=""desc"">
								<a href=""#"" class=""title"">MacBook Pro 2021</a>
								<div class=""price"">
									<h6>$189.00</h6>
									<h6 class=""l-through"">$210.00</h6>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-lg-4 col-md-4 col-sm-6 mb-20"">
						<div class=""single-related-product d-flex"">
							<a href=""#""><img src=""img/product/macbook-pro.jpg"" width=""80"" height=""60""");
            BeginWriteAttribute("alt", " alt=\"", 15379, "\"", 15385, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
							<div class=""desc"">
								<a href=""#"" class=""title"">MacBook Pro 2021</a>
								<div class=""price"">
									<h6>$189.00</h6>
									<h6 class=""l-through"">$210.00</h6>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-lg-4 col-md-4 col-sm-6"">
						<div class=""single-related-product d-flex"">
							<a href=""#""><img src=""img/product/macbook-pro.jpg"" width=""80"" height=""60""");
            BeginWriteAttribute("alt", " alt=\"", 15813, "\"", 15819, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
							<div class=""desc"">
								<a href=""#"" class=""title"">MacBook Pro 2021</a>
								<div class=""price"">
									<h6>$189.00</h6>
									<h6 class=""l-through"">$210.00</h6>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-lg-4 col-md-4 col-sm-6"">
						<div class=""single-related-product d-flex"">
							<a href=""#""><img src=""img/product/macbook-pro.jpg"" width=""80"" height=""60""");
            BeginWriteAttribute("alt", " alt=\"", 16247, "\"", 16253, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
							<div class=""desc"">
								<a href=""#"" class=""title"">MacBook Pro 2021</a>
								<div class=""price"">
									<h6>$189.00</h6>
									<h6 class=""l-through"">$210.00</h6>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-lg-4 col-md-4 col-sm-6"">
						<div class=""single-related-product d-flex"">
							<a href=""#""><img src=""img/product/macbook-pro.jpg"" width=""80"" height=""60""");
            BeginWriteAttribute("alt", " alt=\"", 16681, "\"", 16687, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
							<div class=""desc"">
								<a href=""#"" class=""title"">MacBook Pro 2021</a>
								<div class=""price"">
									<h6>$189.00</h6>
									<h6 class=""l-through"">$210.00</h6>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
			<div class=""col-lg-3"">
				<div class=""ctg-right"">
					<a href=""#"" target=""_blank"">
						<img class=""img-fluid d-block mx-auto"" src=""img/category/c5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17121, "\"", 17127, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t</a>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n<!-- End related-product Area -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
