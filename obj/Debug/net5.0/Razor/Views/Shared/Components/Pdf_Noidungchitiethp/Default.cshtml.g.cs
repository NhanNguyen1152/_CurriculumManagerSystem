#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8071a0ade6c009e3dca983ccaa22fa1ffded6852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_Noidungchitiethp_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_Noidungchitiethp/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8071a0ade6c009e3dca983ccaa22fa1ffded6852", @"/Views/Shared/Components/Pdf_Noidungchitiethp/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_Noidungchitiethp_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.Chitiet_Chuong>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>6. Nội dung chi tiết học phần</h2>
<table cellspacing=""0"" cellpadding=""5"" style=""text-align:center;border-style: solid;"">
    <thead style=""text-align:center;"">
        <tr>
            <th rowspan=""2"" style=""text-align:center;"">
                Nội dung
            </th>
            <th colspan=""2"" style=""text-align:center;"">
                Số Tiết
            </th>
        </tr>
        <tr>
            <th>
                Lý thuyết
            </th>
            <th>
                Thực Hành
            </th>
        </tr>
    </thead>
");
#nullable restore
#line 23 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
      
        string temp = "";
        int temp_stlt = 0;
        int temp_stth = 0;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
         foreach (var item in Model.GroupBy(x => x.Chitietmonhoc.tenchuong))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
             foreach (var item2 in item)
            {
                int numofitem = item.Count();
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                     if (item.Key != temp)
                    {
                        temp = item.Key;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td style=\"text-align: left;\">Chương ");
#nullable restore
#line 40 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                                                            Write(item2.Chitietmonhoc.chiso);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 40 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                                                                                        Write(temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 41 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                             if((item2.Chitietmonhoc.tietlt != temp_stlt && item2.Chitietmonhoc.tietth == temp_stth)
                                || (item2.Chitietmonhoc.tietlt == temp_stlt && item2.Chitietmonhoc.tietth != temp_stth)
                            )
                            {
                                temp_stlt = item2.Chitietmonhoc.tietlt;
                                temp_stth = item2.Chitietmonhoc.tietth;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 47 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                               Write(temp_stlt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                               Write(temp_stth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n");
#nullable restore
#line 49 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 52 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                               Write(temp_stlt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                               Write(temp_stth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("rowspan", " rowspan=\"", 2132, "\"", 2152, 1);
#nullable restore
#line 58 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
WriteAttributeValue("", 2142, numofitem, 2142, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td style=\"margin-left: 10px;\">");
#nullable restore
#line 59 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                                              Write(item2.Chitietmonhoc.chiso);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 59 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                                                                         Write(item2.chiso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 59 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
                                                                                      Write(item2.tentieumuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Noidungchitiethp\Default.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_CurriculumManagerSystem.Models.Chitiet_Chuong>> Html { get; private set; }
    }
}
#pragma warning restore 1591
