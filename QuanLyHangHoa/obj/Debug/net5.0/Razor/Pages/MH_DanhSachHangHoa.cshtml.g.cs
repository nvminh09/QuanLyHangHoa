#pragma checksum "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ec6b907219521739799f70f9501714d17077fe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyHangHoa.Pages.Pages_MH_DanhSachHangHoa), @"mvc.1.0.razor-page", @"/Pages/MH_DanhSachHangHoa.cshtml")]
namespace QuanLyHangHoa.Pages
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
#line 1 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\_ViewImports.cshtml"
using QuanLyHangHoa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
using QuanLyHangHoa.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ec6b907219521739799f70f9501714d17077fe7", @"/Pages/MH_DanhSachHangHoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12380b1dc964092d1040fb30490bda5a38618019", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_MH_DanhSachHangHoa : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ec6b907219521739799f70f9501714d17077fe73723", async() => {
                WriteLiteral("\r\n    <label for=\"fname\">Nhap tu khoa:</label><br>\r\n    <input type=\"text\" name=\"tuKhoa\" value=\" \"><br>\r\n    <input type=\"submit\" value=\"Tìm kiếm\">\r\n    <input type=\"button\" onclick=\"window.location.href = \'MH_ThemHangHoa\'\" value=\"Thêm hàng hóa mới\"/>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table>\r\n    <tr>\r\n        <th>Mã hàng</th>\r\n        <th>Tên hàng</th>\r\n        <th>Loại hàng</th>\r\n        <th>Công ty sản xuất</th>\r\n        <th>Năm sản xuất</th>\r\n        <th>Hạn dùng</th>\r\n    </tr>    \r\n");
#nullable restore
#line 21 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
     foreach (HangHoa hh in Model.dsHangHoa)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
           Write(hh.maHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
           Write(hh.tenHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
           Write(hh.loaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
           Write(hh.congTySX);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
           Write(hh.namSX);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
           Write(hh.hanDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 890, "\"", 924, 2);
            WriteAttributeValue("", 897, "MH_XoaHangHoa?ID=", 897, 17, true);
#nullable restore
#line 31 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
WriteAttributeValue("", 914, hh.maHang, 914, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Xóa </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 955, "\"", 989, 2);
            WriteAttributeValue("", 962, "MH_SuaHangHoa?ID=", 962, 17, true);
#nullable restore
#line 32 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
WriteAttributeValue("", 979, hh.maHang, 979, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Sửa </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Minh\VB2 CNTT\Ky thuat lap trinh\KTLT_VisualStudio\QuanLyHangHoa\QuanLyHangHoa\Pages\MH_DanhSachHangHoa.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyHangHoa.Pages.MH_DanhSachHangHoaModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyHangHoa.Pages.MH_DanhSachHangHoaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyHangHoa.Pages.MH_DanhSachHangHoaModel>)PageContext?.ViewData;
        public QuanLyHangHoa.Pages.MH_DanhSachHangHoaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
