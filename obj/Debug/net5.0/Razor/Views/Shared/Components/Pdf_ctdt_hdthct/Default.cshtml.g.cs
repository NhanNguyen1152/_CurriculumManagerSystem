#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e6440ce937390bb9eb0c77545f7420aa8b94473"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_ctdt_hdthct_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_ctdt_hdthct/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e6440ce937390bb9eb0c77545f7420aa8b94473", @"/Views/Shared/Components/Pdf_ctdt_hdthct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_ctdt_hdthct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.Decuong_Chuongtrinh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>10. Hướng dẫn thực hiện chương trình</h2>
<table cellspacing=""0"" cellpadding=""5"" style=""text-align:left;border-style: solid;"">
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
                                <th>
                                    Số tiết LT
                                </th>
                                ");
            WriteLiteral(@"<th>
                                    Số tiết TH
                                </th>
                                <th>
                                    Môn học tiên quyết / học trước
                                </th>
                            </tr>
                        </thead>
");
#nullable restore
#line 33 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                          
                            int stt = 0;
                            int tong_tc = 0;
                            int tong_sotiet_lt = 0;
                            int tong_sotiet_th = 0;
                            int tongcong_tc = 0;
                            int tongcong_bb = 0;
                            int tongcong_tuchon = 0;
                            string tuchon = "";
                            //string luanvan = "Luận văn tốt nghiệp";
							List<int> list_check = new List<int>();
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                         foreach (var dulieu_kkt in ((List<Decuong_Chuongtrinh>)TempData["listData"]).GroupBy(x =>
                        x.DeCuongchiTiet.Khoikienthuc.kkt_ten))
                        {
							tuchon = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th colspan=\"9\" style=\"color: black;\"><b>");
#nullable restore
#line 49 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                                Write(dulieu_kkt.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></th>\r\n");
            WriteLiteral("                            <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                             foreach (var dulieu_decuong in ((List<Decuong_Chuongtrinh>)TempData["listData"]).Where(x =>
                               x.DeCuongchiTiet.Khoikienthuc.kkt_ten == dulieu_kkt.Key && x.DeCuongchiTiet.yeucau_hocphan == "Bắt buộc"))
                                {
                                    stt = stt + 1;
                                    tong_sotiet_lt = dulieu_decuong.DeCuongchiTiet.sotc_lt * 15;
                                    tong_sotiet_th = dulieu_decuong.DeCuongchiTiet.sotc_th * 30;
                					 tong_tc = dulieu_decuong.DeCuongchiTiet.sotc_lt + dulieu_decuong.DeCuongchiTiet.sotc_th;
                                    
                                            if(dulieu_decuong.DeCuongchiTiet.yeucaukhacvoi_hocphan != "*")
												{
													tongcong_tc += tong_tc;
													tongcong_bb += tong_tc;
												}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<tr> \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 67 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 70 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.mahp_decuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 73 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 76 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 79 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td></td>\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 83 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_sotiet_lt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 86 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_sotiet_th);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n");
#nullable restore
#line 89 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                     if(@dulieu_decuong.DeCuongchiTiet.hp_tienquyet == "Không")
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 94 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
													}
													else
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 98 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                       Write(dulieu_decuong.DeCuongchiTiet.hp_tienquyet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 100 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
													}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 103 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
											
											}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 106 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                         foreach (var dulieu_decuong in ((List<Decuong_Chuongtrinh>)TempData["listData"]).Where(x => x.DeCuongchiTiet.Khoikienthuc.kkt_ten == dulieu_kkt.Key && x.DeCuongchiTiet.yeucau_hocphan == "Tự chọn"))
										{
											stt = stt + 1;
											tong_sotiet_lt = dulieu_decuong.DeCuongchiTiet.sotc_lt * 15;
											tong_sotiet_th = dulieu_decuong.DeCuongchiTiet.sotc_th * 30;
											tong_tc = dulieu_decuong.DeCuongchiTiet.sotc_lt + dulieu_decuong.DeCuongchiTiet.sotc_th;
											if (dulieu_decuong.DeCuongchiTiet.yeucau_hocphan != tuchon)
											{
												tuchon = dulieu_decuong.DeCuongchiTiet.yeucau_hocphan;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<td colspan=\"6\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<b>Học phần tự chọn</b>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 119 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                 foreach (var dulieu_thoigianhoc in @ViewBag.listtgh)
												{
													if(dulieu_thoigianhoc.mahp == dulieu_decuong.DeCuongchiTiet.mahp && !list_check.Contains(dulieu_thoigianhoc.mahk))
													{
														int tranfer = int.Parse(dulieu_thoigianhoc.yeucauhocphan);
														tongcong_tuchon += tranfer;
														list_check.Add(dulieu_thoigianhoc.mahk);
													}
												
												}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 130 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
												tongcong_tc += tong_tc;
												//tongcong_tuchon += tong_tc;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<tr> \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 134 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 137 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.mahp_decuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 140 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 143 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 149 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 152 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_sotiet_lt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 155 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_sotiet_th);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n");
#nullable restore
#line 158 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                     if(@dulieu_decuong.DeCuongchiTiet.hp_tienquyet == "Không")
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 163 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
													}
													else
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 167 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                       Write(dulieu_decuong.DeCuongchiTiet.hp_tienquyet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 169 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
													}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 171 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
											}
											else
											{
												tongcong_tc += tong_tc;
												

#line default
#line hidden
#nullable disable
#nullable restore
#line 175 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                 foreach (var dulieu_thoigianhoc in @ViewBag.listtgh)
												{
													if(dulieu_thoigianhoc.mahp == dulieu_decuong.DeCuongchiTiet.mahp && !list_check.Contains(dulieu_thoigianhoc.mahk))
													{
														int tranfer = int.Parse(dulieu_thoigianhoc.yeucauhocphan);
														tongcong_tuchon += tranfer;
														list_check.Add(dulieu_thoigianhoc.mahk);
													}
											
												}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<tr> \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 188 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 191 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.mahp_decuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 194 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(dulieu_decuong.DeCuongchiTiet.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 197 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 203 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 209 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_sotiet_lt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 212 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                   Write(tong_sotiet_th);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 215 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                     if(@dulieu_decuong.DeCuongchiTiet.hp_tienquyet == "Không")
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 220 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
													}
													else
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 224 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                                       Write(dulieu_decuong.DeCuongchiTiet.hp_tienquyet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 226 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
													}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 229 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                                            
											}	
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n");
#nullable restore
#line 234 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
							tongcong_tc = tongcong_bb + tongcong_tuchon;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td><b>Tổng cộng</b></td>\r\n                            <td><b>");
#nullable restore
#line 240 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                              Write(tongcong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td><b>");
#nullable restore
#line 241 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                              Write(tongcong_bb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td><b>");
#nullable restore
#line 242 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_hdthct\Default.cshtml"
                              Write(tongcong_tuchon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                        </tr>\r\n                    </table>");
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
