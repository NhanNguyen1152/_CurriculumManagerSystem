#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44e12dfaa0a8c6472146696cc81e7998b881abcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Thoigianhocs_getThoikhoabieu), @"mvc.1.0.view", @"/Views/Thoigianhocs/getThoikhoabieu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e12dfaa0a8c6472146696cc81e7998b881abcc", @"/Views/Thoigianhocs/getThoikhoabieu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Thoigianhocs_getThoikhoabieu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.Thoigianhoc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
  
    ViewData["Title"] = "Thời gian học";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row clearfix\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"card\">\r\n            <div class=\"header\">\r\n                <h3 class=\"titile-table\">THỜI KHÓA NIỂU CỦA ");
#nullable restore
#line 11 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                                             if (ViewBag.kk != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <b>\r\n                            <h4>- ");
#nullable restore
#line 14 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                             Write(ViewBag.kk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </b>\r\n");
#nullable restore
#line 16 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </h3>\r\n            </div>\r\n            <div class=\"body\">\r\n");
#nullable restore
#line 20 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                  
                    int tongtc = 0;
                    int tongcong = 0;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <table class=\"table table-bordered table-striped table-hover js-basic-example dataTable\">\r\n                    <thead>\r\n");
#nullable restore
#line 29 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                         foreach (var dulieu_hocky in ((List<Thoigianhoc>)TempData["listData"]).GroupBy(x => x.Hockys.tenhk))
                        {
                            tongcong = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th style=\"background-color: #84c7c1; color: black;\"><b>");
#nullable restore
#line 33 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                                                                   Write(dulieu_hocky.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></th>\r\n                                <th style=\"background-color: #84c7c1; color: black;\">TC</th>\r\n                                <th>Khoi kien thuc</th>\r\n                            </tr>\r\n                            <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                     foreach (var dulieu_decuong in ((List<Thoigianhoc>)TempData["listData"]).Where(x => x.Hockys.tenhk == dulieu_hocky.Key))
                                    {
                                        tongtc = dulieu_decuong.DeCuongchiTiet.sotc_lt + dulieu_decuong.DeCuongchiTiet.sotc_th;
                                        tongcong = tongcong + tongtc;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n");
#nullable restore
#line 43 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                             if(@dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon == null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>\r\n                                                    ");
#nullable restore
#line 46 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                               Write(dulieu_decuong.DeCuongchiTiet.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n");
#nullable restore
#line 48 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>\r\n                                                    ");
#nullable restore
#line 52 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                               Write(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n");
#nullable restore
#line 59 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                                    
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>\r\n                                                ");
#nullable restore
#line 62 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                           Write(tongtc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 65 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                           Write(dulieu_decuong.DeCuongchiTiet.Khoikienthuc.kkt_tuchon);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 68 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                            <tr>           
                                <td style=""background-color: #c63939; color: white;""><b>Tổng cộng</b></td>          
                                <td style=""background-color: #c63939; color: white;"">");
#nullable restore
#line 72 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                                                                                Write(tongcong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr> \r\n");
#nullable restore
#line 74 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Thoigianhocs\getThoikhoabieu.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </thead>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_CurriculumManagerSystem.Models.Thoigianhoc>> Html { get; private set; }
    }
}
#pragma warning restore 1591