#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c6284ce7de78f6a6f866b1f5b814b73023cc4c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_ctdt_chuandaura_decuonghocphan_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_ctdt_chuandaura_decuonghocphan/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c6284ce7de78f6a6f866b1f5b814b73023cc4c6", @"/Views/Shared/Components/Pdf_ctdt_chuandaura_decuonghocphan/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_ctdt_chuandaura_decuonghocphan_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.Decuong_Chuongtrinh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
  
    var i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Bảng 5: Ma trận mối quan hệ giữa chuẩn đầu ra ngành nghề và chuẩn đầu ra của từng học phần.</h2>
<table cellspacing=""0"" cellpadding=""5"" style=""text-align:left;border-style: solid;border-bottom: 2px solid; color: black;"">
    <thead>
        <tr>
            <td colspan=""2"" rowspan=""2"" style=""width: 40%;border-top: 2px solid black;border-bottom: 2px solid black;text-align: center;"";> <b>CÁC HỌC PHẦN TRONG <br>
                CHƯƠNG TRÌNH ĐÀO TẠO</b></td>
            <td colspan=""10"" style=""border-top: 2px solid black;text-align: center;""> <b>Chuẩn đầu ra</b></td>
            
        </tr>
        <tr>
");
#nullable restore
#line 15 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
             foreach (var cdr in ViewBag.listplo)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                 if (cdr.chisoplo != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"border-bottom: 2px solid black;\"><b>");
#nullable restore
#line 19 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                                                              Write(cdr.chisoplo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 20 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
         foreach (var decuonghocphan in Model)
        {
            i++;

            bool flag = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"text-align: center;\">");
#nullable restore
#line 32 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
               Write(decuonghocphan.DeCuongchiTiet.tenhp_tviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
             foreach (var clpo in ViewBag.listClpo)
                {
                    
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                     foreach (var plo in ViewBag.listplo)
                    {
                        if(clpo.maplo == plo.maplo)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                             foreach (var cdr in ViewBag.listchuandaura)
                                {
                                    if(clpo.macdmon == cdr.macdmon && decuonghocphan.mahp == cdr.mahp)
                                    {
                                        flag = true;
                                        break;
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                                 
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                     
                    if(flag)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"text-algin: center;\">");
#nullable restore
#line 53 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                                                   Write(clpo.PLO.chisoplo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td></td>\r\n");
#nullable restore
#line 58 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura_decuonghocphan\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody style=\"border-bottom: 2px solid;\r\n    color: black;\">\r\n</table>\r\n");
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
