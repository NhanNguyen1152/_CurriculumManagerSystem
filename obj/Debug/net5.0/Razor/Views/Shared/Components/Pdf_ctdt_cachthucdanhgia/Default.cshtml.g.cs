#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_cachthucdanhgia\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa80f0998872091799aada3ca9ce30254fc70930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_ctdt_cachthucdanhgia_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_ctdt_cachthucdanhgia/Default.cshtml")]
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
#line 1 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\_ViewImports.cshtml"
using _CurriculumManagerSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\_ViewImports.cshtml"
using _CurriculumManagerSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa80f0998872091799aada3ca9ce30254fc70930", @"/Views/Shared/Components/Pdf_ctdt_cachthucdanhgia/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_ctdt_cachthucdanhgia_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/congthuc.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<h2>6. Cách thức đánh giá</h2>
<p>Kết quả học phần được tính theo thang điểm A+, A, B+,B, C+,C, D+, D, F và 
quy về thang điểm 4.</p>
<h2>Bảng 2. Điểm quy đổi giữa các hệ số</h2>
<table style=""text-align: center;"">
  <tr>
    <th rowspan=""2"">Điểm từng phần ( Hệ số 10)</th>
    <th colspan=""2"">Điểm quy đổi</th>
  </tr>
  <tr>
    <td>Điểm chữ</td>
    <td>Điểm số 4</td>
  </tr>
  <tr>
    <td>9,5 - 10</td>
    <td>A<sup>+</sup></td>
    <td>4,0</td>
  </tr>
  <tr>
    <td>8,5 - 9,5</td>
    <td>A</td>
    <td>3,8</td>
  </tr>
  <tr>
    <td>8,0 - 8,4</td>
    <td>B<sup>+</sup></td>
    <td>3,5</td>
  </tr>
  <tr>
    <td>7,0 - 7,9</td>
    <td>B</td>
    <td>3,0</td>
  </tr>
  <tr>
    <td>6,5 - 6,9</td>
    <td>C<sup>+</sup></td>
    <td>2,5</td>
  </tr>
  <tr>
    <td>5,5 - 6,4</td>
    <td>C</td>
    <td>2,0</td>
  </tr>
  <tr>
    <td>5,0 - 5,4</td>
    <td>D<sup>+</sup></td>
    <td>1,5</td>
  </tr>
  <tr>
    <td>4,0 - 4,9</td>
    <td>D</td>
    <td>1,0");
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <td>0,0 - 3,9</td>\r\n    <td>F</td>\r\n    <td>0,0</td>\r\n  </tr>\r\n</table>\r\n<p>Điểm trung bình chung học kỳ và điểm trung bình chung tích lũy được tính \r\ntheo công thức sau và được làm tròn đến 2 chữ số thập phân:</p> \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fa80f0998872091799aada3ca9ce30254fc709305375", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<p>Trong đó: </p>\r\n<ul>\r\n");
            WriteLiteral(@"    <li>A là điểm trung bình chung học kỳ và điểm trung bình chung tích lũy</li>
    <li>a<sub>i</sub> là điểm của học phần thứ i</li>
    <li>n<sub>i</sub> là số tín chỉ của học phần thứ i</li>
    <li>n là tổng số học phần</li>
</ul>
<p>Xếp loại tốt nghiệp được xác định theo điểm trung bình chung tích lũy của 
toàn khóa học như sau:</p>
<table style=""text-align: center;"">
    <tr>
        <th><b>Xếp loại tốt nghiệp</b></th>
        <th><b>Thang điểm hệ 4</b></th>
    </tr>
    <tr>
        <td>Xuất sắc</td>
        <td>3,60 đến 4,00</td>
    </tr>
    <tr>
        <td>Giỏi</td>
        <td>3,20 đến 3,59</td>
    </tr>
    <tr>
        <td>Khá</td>
        <td>2,50 đến 3,19</td>
    </tr>
    <tr>
        <td>Trung bình</td>
        <td>2,00 đến 2,49</td>
    </tr>
</table>");
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
