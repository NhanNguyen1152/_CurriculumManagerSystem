#pragma checksum "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5059ba4b745960acb5a8c691741765a3173c7f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeCuongchiTiets_getDecuongchitiet), @"mvc.1.0.view", @"/Views/DeCuongchiTiets/getDecuongchitiet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5059ba4b745960acb5a8c691741765a3173c7f2f", @"/Views/DeCuongchiTiets/getDecuongchitiet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_DeCuongchiTiets_getDecuongchitiet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.DeCuongchiTiet>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
  
    ViewData["Title"] = "Đề cương chi tiết";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row clearfix"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""card"">
            <div class=""header"">
                <h3 class=""titile-table"">BẢNG TÓM TẮT NỘI DUNG CHƯƠNG TRÌNH ĐÀO TẠO
                </h3>
            </div>
            <div class=""body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered table-striped table-hover js-basic-example dataTable"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>
                                    ");
#nullable restore
#line 21 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                               Write(Html.DisplayNameFor(model => model.mahp_decuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 24 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                               Write(Html.DisplayNameFor(model => model.tenhp_tviet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 27 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                               Write(Html.DisplayNameFor(model => model.tomtat_noidunghocphan));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </th>
                                <th>
                                    Khối lượng kiến thức
                                </th>
                                <th>
                                    Ghi chú
                                </th>

                            </tr>
                        </thead>
");
#nullable restore
#line 38 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                          
                            int stt = 0;
                            int tong_tc = 0;
                            int tong_sotiet_lt = 0;
                            int tong_sotiet_th = 0;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                         foreach (var dulieu_kkt in ((List<DeCuongchiTiet>)TempData["listData"]).GroupBy(x => x.Khoikienthuc.kkt_ten))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th colspan=\"5\" style=\"background-color: #84c7c1; color: black;\"><b>");
#nullable restore
#line 46 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                                                                                           Write(dulieu_kkt.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></th>\r\n");
            WriteLiteral("                            <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                                 foreach (var dulieu_decuong in ((List<DeCuongchiTiet>)TempData["listData"]).Where(x => x.Khoikienthuc.kkt_ten == dulieu_kkt.Key))
                                {
                                    stt = stt + 1;
                                    tong_tc = dulieu_decuong.sotc_lt + dulieu_decuong.sotc_th;
                                    tong_sotiet_lt = dulieu_decuong.sotc_lt * 15;
                                    tong_sotiet_th = dulieu_decuong.sotc_th * 30;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 57 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                                       Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            WriteLiteral("                                            ");
#nullable restore
#line 61 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                                       Write(dulieu_decuong.mahp_decuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            WriteLiteral("                                            ");
#nullable restore
#line 65 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                                       Write(dulieu_decuong.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            WriteLiteral("                                            ");
#nullable restore
#line 69 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                                       Write(dulieu_decuong.tomtat_noidunghocphan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 72 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                                       Write(tong_tc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TC (");
#nullable restore
#line 72 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                                                    Write(tong_sotiet_lt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" LT, ");
#nullable restore
#line 72 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                                                                        Write(tong_sotiet_th);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TH)\r\n                                        </td>\r\n                                        <td>\r\n                                            \r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 78 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n");
#nullable restore
#line 81 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\getDecuongchitiet.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
