#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea3476d32f409a10d5d7dd5f7cd3bc8ffe73936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_ctdt_chuandaura_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_ctdt_chuandaura/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea3476d32f409a10d5d7dd5f7cd3bc8ffe73936", @"/Views/Shared/Components/Pdf_ctdt_chuandaura/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_ctdt_chuandaura_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.MoiquanhePLO_Muctieudaotao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
  

    string temp_tenloai_plo_kt = "Yêu cầu về kiến thức";
    string temp_tenloai_plo_kn = "Yêu cầu về kĩ năng";
    string temp_tenloai_plo_tn = "Yêu cầu về năng lực tự chủ và trách nhiệm";
    //string temp_chitietten_plo = "Kiến thức chuyên ngành";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>2. Chuẩn đầu ra</h2>\r\n<h2>2.1. Yêu cầu về kiến thức</h2>\r\n<h2>2.1.1 Kiến thức chuyên ngành</h2>\r\n<p>\r\n");
#nullable restore
#line 13 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
 foreach (var plo_item in ViewBag.listplo)
{
    bool flag = false ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
     foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
             foreach (var mt in ViewBag.listMuctieu_ct)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                 if (item.ma_mtdt == mt.ma_mtdt && plo_item.maplo == item.maplo)
                {
                    flag = true;
                    break;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
         
    if (flag)
        { 
            if(plo_item.tenloai_plo == temp_tenloai_plo_kt)
            {
                string str1 = (plo_item.chisoplo).Substring(1);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p> <b>Chuẩn đầu ra ");
#nullable restore
#line 32 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                               Write(str1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b> (");
#nullable restore
#line 32 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                                           Write(plo_item.chisoplo);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 32 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                                                               Write(plo_item.noidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
            }
        }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>2.2. Yêu cầu về kỹ năng</h2>\r\n");
#nullable restore
#line 37 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
 foreach (var plo_item in ViewBag.listplo)
{
    bool flag = false ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
     foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
             foreach (var mt in ViewBag.listMuctieu_ct)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                 if (item.ma_mtdt == mt.ma_mtdt && plo_item.maplo == item.maplo)
                {
                    flag = true;
                    break;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
         
    if (flag)
        { 
            if(plo_item.tenloai_plo == temp_tenloai_plo_kn)
            {
                 string str1 = (plo_item.chisoplo).Substring(1);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p> <b>Chuẩn đầu ra ");
#nullable restore
#line 56 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                               Write(str1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b> (");
#nullable restore
#line 56 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                                           Write(plo_item.chisoplo);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 56 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                                                               Write(plo_item.noidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 57 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
            }
        }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>2.2. Yêu cầu về năng lực tự chủ và trách nhiệm</h2>\r\n");
#nullable restore
#line 61 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
 foreach (var plo_item in ViewBag.listplo)
{
    bool flag = false ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
     foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
             foreach (var mt in ViewBag.listMuctieu_ct)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                 if (item.ma_mtdt == mt.ma_mtdt && plo_item.maplo == item.maplo)
                {
                    flag = true;
                    break;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
         
    if (flag)
        { 
            if(plo_item.tenloai_plo == temp_tenloai_plo_tn)
            {
                 string str1 = (plo_item.chisoplo).Substring(1);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p> <b>Chuẩn đầu ra ");
#nullable restore
#line 80 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                               Write(str1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b> (");
#nullable restore
#line 80 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                                           Write(plo_item.chisoplo);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 80 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                                                               Write(plo_item.noidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 81 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
            }
        }
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
<h2>Bảng 1. Mối quan hệ giữa chuẩn đầu ra và mục tiêu</h2>
<p>(Xem diễn giải nội dung từ MT1 đến MT7 trong phần mục tiêu đào tạo bên trên)</p>
<table cellspacing=""0"" cellpadding=""5"" style=""text-align:center;border-style: solid;border-bottom: 2px solid; color: black;"">
    <thead>
        <tr>
            <td style=""border-top: 2px solid black;text-align: center;border-bottom: 2px solid black"">Chuẩn đầu ra</td>
");
#nullable restore
#line 91 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
             foreach (var muctieu in ViewBag.listmuctieudaotao)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                 if (muctieu.mtdt_chiso != null)
                {
                    string str2 = (muctieu.mtdt_chiso).Substring(11);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"border-top: 2px solid black;text-align: center;border-bottom: 2px solid black\">\r\n                        ");
#nullable restore
#line 97 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                   Write(str2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 98 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 104 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
         foreach (var plo in ViewBag.listplo)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 107 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
               Write(plo.chisoplo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 108 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                 foreach (var muctieu in ViewBag.listmuctieudaotao)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                     if (muctieu.mtdt_chiso != null)
                    {
                        bool flag = false;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                         foreach (var item in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                             if (item.maplo == plo.maplo && item.ma_mtdt == muctieu.ma_mtdt)
                            {
                                flag = true;
                                break;
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                         
                        if (flag)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"background-color: darkgray;\">X</td>\r\n");
#nullable restore
#line 124 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td></td>\r\n");
#nullable restore
#line 128 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 133 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_chuandaura\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_CurriculumManagerSystem.Models.MoiquanhePLO_Muctieudaotao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
