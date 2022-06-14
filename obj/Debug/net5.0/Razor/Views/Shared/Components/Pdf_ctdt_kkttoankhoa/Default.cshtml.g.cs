#pragma checksum "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eb5daf5ebcee0479a131e66a6fd2cd30558696f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_ctdt_kkttoankhoa_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_ctdt_kkttoankhoa/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eb5daf5ebcee0479a131e66a6fd2cd30558696f", @"/Views/Shared/Components/Pdf_ctdt_kkttoankhoa/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_ctdt_kkttoankhoa_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.Decuong_Chuongtrinh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>7. Khối lượng kiến thức toàn khóa</h2>
<div class=""row clearfix"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""card"">
            <div class=""header"">
                <p>Tổng số tín chỉ 80 tín chỉ, trong đó phân bổ kiến thức như sau:</p>
                <h2 class=""titile-table"">Bảng 3. Phân bổ khối lượng các khối kiến thức</h2>
            </div>
            <div class=""body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered table-striped table-hover js-basic-example dataTable"">
                        <thead>
                            <tr>
                                <th rowspan=""2"">STT</th>
                                <th rowspan=""2"">
                                    Các khối kiến thức
                                </th>
                                <th colspan=""2"">
                                    Khối lượng
                                </th>
                            </tr");
            WriteLiteral(@">
                            <tr>
                                <td style=""text-align: center;"">Số tín chỉ</td>
                                <td style=""text-align: center;"">Tỉ lệ %</td>
                            </tr>
                        </thead>
");
#nullable restore
#line 28 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                          
                            int stt = 0;
                            int tong_tc = 0;
                            int tong_sotiet_lt = 0;
                            int tong_sotiet_th = 0;
                            int tongcong_tc = 0;
                            int tongcong_bb = 0;
                            int tongcong_tuchon = 0;
                            int temp = 0;
                            string tuchon = "";
                            string luanvan = "Luận văn tốt nghiệp";
                            int sophantram = 0;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody style=\"text-align: center;\">\r\n");
#nullable restore
#line 42 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                         foreach (var dulieu_kkt in ((List<Decuong_Chuongtrinh>)TempData["listData"]).GroupBy(x =>
                        x.DeCuongchiTiet.Khoikienthuc.kkt_ten))
                        {
                            stt = stt + 1;
                            temp *= 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                               Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                               Write(dulieu_kkt.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 50 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                                 foreach (var dulieu_decuong in ((List<Decuong_Chuongtrinh>)TempData["listData"]).Where(x =>
                               x.DeCuongchiTiet.Khoikienthuc.kkt_ten == dulieu_kkt.Key))
                                {
                                    
                                    tong_sotiet_lt = dulieu_decuong.DeCuongchiTiet.sotc_lt * 15;
                                    tong_sotiet_th = dulieu_decuong.DeCuongchiTiet.sotc_th * 30;
                 
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                                     if(dulieu_decuong.DeCuongchiTiet.tenhp_tviet.Contains(luanvan))
                                            {
                                                
                                            }
                                        else
                                            { 
                                               

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                                                if(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != null && dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != tuchon)
													{ 
														tongcong_tuchon += int.Parse(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_mota);
														tuchon = dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon;
                                                        temp += int.Parse(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_mota);
													}

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                                                     
                                                    tong_tc = dulieu_decuong.DeCuongchiTiet.sotc_lt + dulieu_decuong.DeCuongchiTiet.sotc_th;
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                                                 if(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != null && dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_mota != null)
                                                    {  
                                                        tuchon = dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon;
                                                        if(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != tuchon)
                                                        {
                                                            temp += tong_tc;
                                                        }
                                                    }
                                                else
                                                    {
                                                        tongcong_bb += tong_tc;
                                                        temp += tong_tc;
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                                                     												
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                                              
                                    tongcong_tc = tongcong_bb + tongcong_tuchon;
                                    
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                                  
                                    //bi dung cho nay
                                    sophantram = (temp * 100) / tongcong_tc;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \r\n                                <td>");
#nullable restore
#line 92 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                               Write(temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 93 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                               Write(sophantram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>                 \r\n");
#nullable restore
#line 95 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                        <tr style=\"text-align: center;\">\r\n                            <td></td>\r\n                            <td><b>Tổng cộng</b></td>\r\n                            <td><b>");
#nullable restore
#line 100 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kkttoankhoa\Default.cshtml"
                              Write(tongcong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td></td>\r\n                        </tr>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_CurriculumManagerSystem.Models.Decuong_Chuongtrinh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
