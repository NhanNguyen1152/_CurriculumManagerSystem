#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3089ee11e942a3c6f2c41230ab39d5579ecf3e8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_ctdt_kehoachgiangday_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_ctdt_kehoachgiangday/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089ee11e942a3c6f2c41230ab39d5579ecf3e8f", @"/Views/Shared/Components/Pdf_ctdt_kehoachgiangday/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_ctdt_kehoachgiangday_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.Decuong_Chuongtrinh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                          
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
            WriteLiteral("                        <h2>9. Kế hoạch giảng dạy</h2>\r\n");
#nullable restore
#line 15 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                         foreach (var dulieu_kkt in ((List<Decuong_Chuongtrinh>)TempData["listData"]).GroupBy(x =>
                        x.DeCuongchiTiet.Khoikienthuc.kkt_ten))
                        {
                            


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
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
#line 28 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                                     if(dulieu_decuong.DeCuongchiTiet.tenhp_tviet.Contains(luanvan))
                                            {
                                            }
                                        else
                                            { 
                                               

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                                                if(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != null && dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != tuchon)
													{ 
														tongcong_tuchon += int.Parse(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_mota);
														tuchon = dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon;
														
													}

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                                                     
												
															
															{
																tong_tc = dulieu_decuong.DeCuongchiTiet.sotc_lt + dulieu_decuong.DeCuongchiTiet.sotc_th;
															}
															

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                                                             if(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon != null && dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_mota != null)
																{  
																	
																	
																	tongcong_tc += tong_tc;
															
																		
																	
																}
															else
																{
																	tongcong_bb += tong_tc;
																	tongcong_tc += tong_tc;
																	
																}

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                                                                 
												
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                                             
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n");
#nullable restore
#line 64 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Tổng số tín chỉ: ");
#nullable restore
#line 65 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                                       Write(tongcong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tín chỉ</p>\r\n                        <p>\r\n                            - Tổng số tín chỉ bắt buộc: ");
#nullable restore
#line 67 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                                                   Write(tongcong_bb);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tín chỉ <br />\r\n                            - Tổng số tín chỉ tự chọn: ");
#nullable restore
#line 68 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_kehoachgiangday\Default.cshtml"
                                                  Write(tongcong_tuchon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" tín chỉ
                        </p>
                        <p style=""text-indent: 30px;"">
                            Tất cả các môn học được phân bố giảng dạy trong mỗi học kỳ. Sinh viên sẽ đăng 
                            ký môn học cho riêng mình vào đầu mỗi học kỳ tùy theo kế hoạch học tập của mỗi 
                            sinh viên. <br />
                                Thời gian học chính thức 4 học kỳ chính và 1 học kỳ hè. Sinh viên được cấp bằng 
                            kỹ sư khi hoàn tất chương trình học.<br />
                            Học phí được tính theo số tín chỉ đăng ký (theo quy định hiện hành).
                        </p>
                       
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_CurriculumManagerSystem.Models.Decuong_Chuongtrinh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
