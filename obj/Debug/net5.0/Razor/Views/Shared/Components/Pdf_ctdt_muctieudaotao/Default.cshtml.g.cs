#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a020ec43d6c6e9b57c7bcde820470ff9283cfabf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_ctdt_muctieudaotao_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_ctdt_muctieudaotao/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a020ec43d6c6e9b57c7bcde820470ff9283cfabf", @"/Views/Shared/Components/Pdf_ctdt_muctieudaotao/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_ctdt_muctieudaotao_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.CTDT_Muctieudaotao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
  
    int a = 1;
    int b = 1;
    int c = 1;
    string temp_phu = "";
    string temp_chiso = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 9 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral(". Mục tiêu đào tạo</h2>\r\n");
#nullable restore
#line 10 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
     foreach (var item in Model.GroupBy(m => m.Muctieu_Daotao.mtdt_chinh))
    {   
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 13 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
       Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 13 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
          Write(b);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 13 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
              Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 15 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
         foreach(var item2 in Model.Where(m => m.Muctieu_Daotao.mtdt_chinh == item.Key))
        {
            if(item2.Muctieu_Daotao.mtdt_phu != null && item2.Muctieu_Daotao.mtdt_chiso != null)
            {
                if(item2.Muctieu_Daotao.mtdt_phu != temp_phu)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2>");
#nullable restore
#line 21 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                   Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 21 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                      Write(b);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 21 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                         Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 21 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                             Write(item2.Muctieu_Daotao.mtdt_phu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 22 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                    temp_phu = item2.Muctieu_Daotao.mtdt_phu;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p><b>");
#nullable restore
#line 23 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                     Write(item2.Muctieu_Daotao.mtdt_chiso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>: ");
#nullable restore
#line 23 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                                                           Write(item2.Muctieu_Daotao.noi_dung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                    c++;
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p><b>");
#nullable restore
#line 28 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                     Write(item2.Muctieu_Daotao.mtdt_chiso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>: ");
#nullable restore
#line 28 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                                                           Write(item2.Muctieu_Daotao.noi_dung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>- ");
#nullable restore
#line 33 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
                Write(item2.Muctieu_Daotao.noi_dung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_ctdt_muctieudaotao\Default.cshtml"
             
        b++;   
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_CurriculumManagerSystem.Models.CTDT_Muctieudaotao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
