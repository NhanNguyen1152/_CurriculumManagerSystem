#pragma checksum "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20835c3d89bb33927784cc7b2aaa378c678d0ecf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_Getchuandaura_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_Getchuandaura/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20835c3d89bb33927784cc7b2aaa378c678d0ecf", @"/Views/Shared/Components/Pdf_Getchuandaura/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_Getchuandaura_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.Chuandaura_monhoc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
  
    string cdr_kt = "Kiến thức";
    string cdr_kn = "Kỹ năng";
    string cdr_tn = "Mức tự chủ và trách nhiệm";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>3. Chuẩn đầu ra của học phần</h2>\r\n<h2> 3.1 ");
#nullable restore
#line 8 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
    Write(cdr_kt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 9 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
         if (item.loai == cdr_kt)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>CLO ");
#nullable restore
#line 13 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
              Write(item.chisocio);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 13 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
                              Write(item.noidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
         
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2> 3.2 ");
#nullable restore
#line 17 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
    Write(cdr_kn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 18 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
     foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
             if (item.loai == cdr_kn)
                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <p>CLO ");
#nullable restore
#line 22 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
                     Write(item.chisocio);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 22 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
                                     Write(item.noidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n");
#nullable restore
#line 23 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
                 
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2> 3.3 ");
#nullable restore
#line 25 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
    Write(cdr_tn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 26 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
     foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
             if (item.loai == cdr_tn)
                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <p>CLO ");
#nullable restore
#line 30 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
                     Write(item.chisocio);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 30 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
                                     Write(item.noidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n");
#nullable restore
#line 31 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getchuandaura\Default.cshtml"
                 
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_CurriculumManagerSystem.Models.Chuandaura_monhoc>> Html { get; private set; }
    }
}
#pragma warning restore 1591