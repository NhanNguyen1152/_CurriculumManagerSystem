#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81eab41234528eb33a921d8f7b39bfe79af6c82f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_ctdt_noidung_ctdt_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_ctdt_noidung_ctdt/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81eab41234528eb33a921d8f7b39bfe79af6c82f", @"/Views/Shared/Components/Pdf_ctdt_noidung_ctdt/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_ctdt_noidung_ctdt_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.Decuong_Chuongtrinh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>8. Nội dung chương trình đào tạo</h2>\r\n<p>Chương trình đào tạo ngành Hệ thống thông tin văn bằng 2 được xây dựng trên cơ\r\nsở tham khảo các quy định về đào tạo bao gồm:\r\n</p>\r\n<p>\r\n//quydinh\r\n</p>\r\n<h2>Bảng 4. Nội dung chương trình đào tạo</h2>\r\n");
            WriteLiteral(@"<table cellspacing=""0"" cellpadding=""5"" style=""border-style: solid;"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>
                                    Mã học phần
                                </th>
                                <th>
                                    Tên môn học
                                </th>
                                <th>
                                    Số tín chỉ
                                </th>
                                <th>
                                    Bắt buộc
                                </th>
                                <th>
                                    Tự chọn
                                </th>
                            </tr>
                        </thead>
");
#nullable restore
#line 31 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                          
                            int stt = 0;
                            int tong_tc = 0;
                            int tong_sotiet_lt = 0;
                            int tong_sotiet_th = 0;
                            int tongcong_tc = 0;
                            int tongcong_bb = 0;
                            int tongcong_tuchon = 0;
                            string tuchon = "";
                            string luanvan = "Luận văn tốt nghiệp";
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                         foreach (var dulieu_kkt in ((List<Decuong_Chuongtrinh>)TempData["listData"]).GroupBy(x =>
                        x.DeCuongchiTiet.Khoikienthuc.kkt_ten))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th colspan=\"9\" style=\"color: black;\"><b>");
#nullable restore
#line 45 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                Write(dulieu_kkt.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></th>\r\n");
            WriteLiteral("                            <tbody>\r\n");
#nullable restore
#line 48 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                 foreach (var dulieu_decuong in ((List<Decuong_Chuongtrinh>)TempData["listData"]).Where(x =>
                               x.DeCuongchiTiet.Khoikienthuc.kkt_ten == dulieu_kkt.Key))
                                {
                                    stt = stt + 1;
                                    tong_sotiet_lt = dulieu_decuong.DeCuongchiTiet.sotc_lt * 15;
                                    tong_sotiet_th = dulieu_decuong.DeCuongchiTiet.sotc_th * 30;
                 
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                     if(dulieu_decuong.DeCuongchiTiet.tenhp_tviet.Contains(luanvan))
                                            {
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<tr> \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 60 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                   Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 63 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.mahp_decuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 66 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 75 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_mota);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 78 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                            }
                                        else
                                            { 
                                               

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                if(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != null && dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != tuchon)
													{ 
														tongcong_tuchon += int.Parse(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_mota);
														tuchon = dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<th rowspan=\"1\"></th>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<th colspan=\"4\" ><b>");
#nullable restore
#line 87 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                           Write(tuchon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></th>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<th><b>");
#nullable restore
#line 88 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                              Write(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_mota);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></th>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 90 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
													}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<tr> \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 93 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                   Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 96 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.mahp_decuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 99 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\r\n\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n");
#nullable restore
#line 106 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                              
																tong_tc = dulieu_decuong.DeCuongchiTiet.sotc_lt + dulieu_decuong.DeCuongchiTiet.sotc_th;
															

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                             if(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != null && dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_mota != null)
																{  
																	

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                                                                          
																	
																	tongcong_tc += tong_tc;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 115 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                   Write(tong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 123 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
																}
															else
																{
																	tongcong_bb += tong_tc;
																	tongcong_tc += tong_tc;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 129 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                   Write(tong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 132 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                   Write(tong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 137 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
																}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 139 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                             
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n");
#nullable restore
#line 143 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td><b>Tổng cộng</b></td>\r\n                            <td><b>");
#nullable restore
#line 148 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                              Write(tongcong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td><b>");
#nullable restore
#line 149 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                              Write(tongcong_bb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td><b>");
#nullable restore
#line 150 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                              Write(tongcong_tuchon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></td>
    </tr>
</table>
<h2>Bảng 5: Ma trận mối quan hệ giữa chuẩn đầu ra ngành nghề và chuẩn đầu ra của từng học phần.</h2>
<h2>Bảng 6: Bảng tóm tắt nội dung chương trình</h2>
<table cellspacing=""0"" cellpadding=""5"" style=""border-style: solid;"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>
                                   Mã học phần
                                </th>
                                <th>
                                    Tên học phần
                                </th>
                                <th>
                                    Nội dung cần đạt được của học phần
                                </th>
                                <th>
                                    Khối lượng kiến thức
                                </th>
                                <th>
                                    Ghi chú
                                </t");
            WriteLiteral("h>\r\n\r\n                            </tr>\r\n                        </thead>\r\n");
#nullable restore
#line 177 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                          
                            int stts = 0;
                            int tong_tcs = 0;
                            int tong_sotiet_lts = 0;
                            int tong_sotiet_ths = 0;
                            string tuchons = "";
                            string luanvans = "Luận văn tốt nghiệp";
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 185 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                         foreach (var dulieu_kkt in ((List<Decuong_Chuongtrinh>)TempData["listData"]).GroupBy(x => x.DeCuongchiTiet.Khoikienthuc.kkt_ten))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th colspan=\"6\" style=\"color: black;\"><b>");
#nullable restore
#line 187 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                Write(dulieu_kkt.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></th>\r\n");
            WriteLiteral("                            <tbody>\r\n");
#nullable restore
#line 190 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                 foreach (var dulieu_decuong in ((List<Decuong_Chuongtrinh>)TempData["listData"]).Where(x => x.DeCuongchiTiet.Khoikienthuc.kkt_ten == dulieu_kkt.Key))
                                {
                                    stts = stts + 1;
                                    tong_tcs = dulieu_decuong.DeCuongchiTiet.sotc_lt + dulieu_decuong.DeCuongchiTiet.sotc_th;
                                    tong_sotiet_lts = dulieu_decuong.DeCuongchiTiet.sotc_lt * 15;
                                    tong_sotiet_ths = dulieu_decuong.DeCuongchiTiet.sotc_th * 30;

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 197 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                     if(dulieu_decuong.DeCuongchiTiet.tenhp_tviet.Contains(luanvans))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr> \r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 201 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                               Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 204 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                               Write(dulieu_decuong.DeCuongchiTiet.mahp_decuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 207 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                               Write(dulieu_decuong.DeCuongchiTiet.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 210 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                               Write(dulieu_decuong.DeCuongchiTiet.tomtat_noidunghocphan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 213 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                               Write(tong_tcs);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TC (");
#nullable restore
#line 213 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                             Write(tong_sotiet_lts);

#line default
#line hidden
#nullable disable
            WriteLiteral(" LT, ");
#nullable restore
#line 213 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                                  Write(tong_sotiet_ths);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TH)
                                                </td>
                                                <td>
                                                    
                                                </td>
                                            </tr>
");
#nullable restore
#line 219 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                        }
                                    else
                                        { 
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 222 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                             if(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != null && dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != tuchon)
                                                { 
                                                    tuchons = dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <th rowspan=\"1\"></th>\r\n                                                        <th colspan=\"5\" ><b>");
#nullable restore
#line 227 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                       Write(tuchon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></th>\t\t\t\t\t\t\t\t\t\t\t\r\n                                                    </tr>\r\n");
#nullable restore
#line 229 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr> \r\n        \r\n");
#nullable restore
#line 232 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                 if(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != null && dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_mota != null)
                                                    {  

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>\r\n                                                            ");
#nullable restore
#line 235 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                       Write(stts);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 238 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                       Write(dulieu_decuong.DeCuongchiTiet.mahp_decuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 241 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                       Write(dulieu_decuong.DeCuongchiTiet.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 244 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                       Write(dulieu_decuong.DeCuongchiTiet.tomtat_noidunghocphan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 247 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                       Write(tong_tcs);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TC (");
#nullable restore
#line 247 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                     Write(tong_sotiet_lt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" LT, ");
#nullable restore
#line 247 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                                         Write(tong_sotiet_ths);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TH)
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
");
#nullable restore
#line 252 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                    }
                                                else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>\r\n                                                            ");
#nullable restore
#line 256 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                       Write(stts);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 259 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                       Write(dulieu_decuong.DeCuongchiTiet.mahp_decuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 262 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                       Write(dulieu_decuong.DeCuongchiTiet.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 265 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                       Write(dulieu_decuong.DeCuongchiTiet.tomtat_noidunghocphan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 268 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                       Write(tong_tcs);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TC (");
#nullable restore
#line 268 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                     Write(tong_sotiet_lts);

#line default
#line hidden
#nullable disable
            WriteLiteral(" LT, ");
#nullable restore
#line 268 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                                                          Write(tong_sotiet_ths);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TH)
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
");
#nullable restore
#line 273 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                                    }													

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tr>\r\n");
#nullable restore
#line 275 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 275 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                                         
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n");
#nullable restore
#line 278 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_noidung_ctdt\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
