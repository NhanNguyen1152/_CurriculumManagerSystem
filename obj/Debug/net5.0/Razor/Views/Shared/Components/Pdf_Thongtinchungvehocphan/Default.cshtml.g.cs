#pragma checksum "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4bc35d3b6ca4db888ce7b7d65d54ded087b086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_Thongtinchungvehocphan_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_Thongtinchungvehocphan/Default.cshtml")]
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
#line 1 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\_ViewImports.cshtml"
using _CurriculumManagerSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\_ViewImports.cshtml"
using _CurriculumManagerSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4bc35d3b6ca4db888ce7b7d65d54ded087b086", @"/Views/Shared/Components/Pdf_Thongtinchungvehocphan/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_Thongtinchungvehocphan_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.DeCuongchiTiet>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>1. Thông tin chung về học phần</h2>\r\n    <p>Tên học phần bằng tiếng Việt: ");
#nullable restore
#line 5 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                                Write(item.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br></p>\r\n    <p>Tên học phần bằng tiếng Anh: ");
#nullable restore
#line 6 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                               Write(item.tenhp_tanh);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></p>\r\n    <p>Mã học phần: ");
#nullable restore
#line 7 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
               Write(item.mahp_decuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></p>\r\n    <p>Loại học phần: ");
#nullable restore
#line 8 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                 Write(item.Khoikienthuc.kkt_ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></p>\r\n    <p>Số tín chỉ: 03 tín chỉ (30 tiết lý thuyết, 30 tiết thực hành)<br></p>\r\n    <p>Số tiết học: 60 tiết<br></p>\r\n    <p>Yêu cầu của học phần: bắt buộc<br></p>\r\n    <p>Học phần học trước: ");
#nullable restore
#line 12 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                      Write(item.hp_tienquyet);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></p>\r\n");
#nullable restore
#line 13 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
 foreach (var items in ViewBag.listtgh)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Thời gian học: ");
#nullable restore
#line 16 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                 Write(items.Hockys.tenhk);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></p>\r\n");
#nullable restore
#line 17 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Các yêu cầu khác đối với học phần: ");
#nullable restore
#line 20 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                                     Write(item.yeucaukhacvoi_hocphan);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></p>\r\n");
#nullable restore
#line 21 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Đơn vị phụ trách: \r\n");
#nullable restore
#line 23 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
 foreach(var item in ViewBag.listkhoa)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
       Write(item.Bomon.Khoa.tenkh);

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                                  
            break;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
 foreach (var item in ViewBag.listpt)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Người phụ trách: ");
#nullable restore
#line 32 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                   Write(item.GiangVien.hoten);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></p>\r\n    <p>Chức danh/Học hàm/Học vị: ");
#nullable restore
#line 33 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                            Write(item.GiangVien.chucdanh);

#line default
#line hidden
#nullable disable
            WriteLiteral("/ ");
#nullable restore
#line 33 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                                                      Write(item.GiangVien.hocham);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                                                                             Write(item.GiangVien.hocvi);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></p>\r\n    <p>Địa chỉ liên hệ: ");
#nullable restore
#line 34 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                   Write(item.GiangVien.diachilienhe);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></p>\r\n    <p>Điện thoại: &emsp; Email: ");
#nullable restore
#line 35 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                            Write(item.GiangVien.diachilienhe);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></p>\r\n");
#nullable restore
#line 36 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Các giảng viên tham gia giảng dạy cùng:\r\n");
#nullable restore
#line 40 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
     foreach (var gvp in ViewBag.listptc)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
   Write(gvp.GiangVien.hoten);

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Thongtinchungvehocphan\Default.cshtml"
                            
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_CurriculumManagerSystem.Models.DeCuongchiTiet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
