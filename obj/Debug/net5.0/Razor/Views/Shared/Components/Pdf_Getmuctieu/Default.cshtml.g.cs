#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1e3f7effdd540728fda938c7387ab366a79fdeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_Getmuctieu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_Getmuctieu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1e3f7effdd540728fda938c7387ab366a79fdeb", @"/Views/Shared/Components/Pdf_Getmuctieu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_Getmuctieu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.Muctieu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
  
    string mtchung = "Mục tiêu chung";
    string mtcuthe = "Mục tiêu cụ thể";
    string mtphu_kt = "Kiến thức";
    string mtphu_kn = "Kỹ năng";
    string mtphu_tn = "Mức tự chủ và trách nhiệm";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>2. Mục tiêu của học phần</h2>\r\n<h2> 2.1 ");
#nullable restore
#line 10 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
    Write(mtchung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<p>\r\n");
#nullable restore
#line 13 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
         if (item.mtchinh == mtchung) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                                 Write(item.noidung);

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                                                   
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n</p>\r\n<h2> 2.1 ");
#nullable restore
#line 19 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
    Write(mtcuthe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>\r\n- ");
#nullable restore
#line 21 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
Write(mtphu_kt);

#line default
#line hidden
#nullable disable
            WriteLiteral(":<br>\r\n");
#nullable restore
#line 22 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
     foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
             if (item.mtchinh == mtcuthe && item.mtphu == mtphu_kt)
                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <p>   + ");
#nullable restore
#line 26 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                      Write(item.noidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n");
#nullable restore
#line 27 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                 
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>\r\n- ");
#nullable restore
#line 31 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
Write(mtphu_kn);

#line default
#line hidden
#nullable disable
            WriteLiteral(":<br>\r\n");
#nullable restore
#line 32 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
     foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
             if (item.mtchinh == mtcuthe && item.mtphu == mtphu_kn)
                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <p>   + ");
#nullable restore
#line 36 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                     Write(item.noidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n");
#nullable restore
#line 37 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                 
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>\r\n- ");
#nullable restore
#line 41 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
Write(mtphu_tn);

#line default
#line hidden
#nullable disable
            WriteLiteral(":<br>\r\n");
#nullable restore
#line 42 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
     foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
             if (item.mtchinh == mtcuthe && item.mtphu == mtphu_tn)
                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>   + ");
#nullable restore
#line 46 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                       Write(item.noidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n");
#nullable restore
#line 47 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Getmuctieu\Default.cshtml"
                 
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_CurriculumManagerSystem.Models.Muctieu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
