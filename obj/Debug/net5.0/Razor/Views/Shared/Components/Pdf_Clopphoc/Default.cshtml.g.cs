#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e926c28f090330dfb55f24ba2f4f5e3f0397537b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_Clopphoc_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_Clopphoc/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e926c28f090330dfb55f24ba2f4f5e3f0397537b", @"/Views/Shared/Components/Pdf_Clopphoc/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_Clopphoc_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.CLOPhuongphaphoc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>8. Phương pháp học</h2>\r\n");
#nullable restore
#line 5 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
 foreach (var item in ViewBag.listPphoc)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>- ");
#nullable restore
#line 7 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
    Write(item.tenpp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p>Ma trận giữa phương pháp học với CĐR</p>
<table cellspacing=""0"" cellpadding=""5"" style=""text-align:center;border-style: solid;"">
    <thead style=""text-align:center;"">
        <tr>
            <th rowspan=""2"" style=""text-align:center;"">
                Phương pháp học
            </th>
            <th colspan=""10"" style=""text-align:center;"">
                CLOs
            </th>
        </tr>

    </thead>
    <tbody>
");
            WriteLiteral("        <tr>\r\n            <td>\r\n");
#nullable restore
#line 26 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
                 foreach (var itemPLO in ViewBag.listPpday_cdr)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 28 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
               Write(itemPLO.chisocio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
         foreach (var items in ViewBag.listPphoc)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
           Write(items.tenpp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
                 foreach (var itemPLO in ViewBag.listPpday_cdr)
                {
                    bool flag = false;
                     

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
                      foreach (var item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
                         if (item.macdmon == itemPLO.macdmon && item.mapphoc == items.mapphoc)
                        {
                           flag = true;
                           break;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
                     
                    if(flag)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>X</td>\r\n");
#nullable restore
#line 50 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <td></td>\r\n");
#nullable restore
#line 54 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
                    }
                   
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Clopphoc\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_CurriculumManagerSystem.Models.CLOPhuongphaphoc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
