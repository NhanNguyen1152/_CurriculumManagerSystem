#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c86b7565f5b9766bcd63afdda8403acb293de76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pdf_Lichtrinhgiangday_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pdf_Lichtrinhgiangday/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c86b7565f5b9766bcd63afdda8403acb293de76", @"/Views/Shared/Components/Pdf_Lichtrinhgiangday/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pdf_Lichtrinhgiangday_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_CurriculumManagerSystem.Models.Chitiet_Chuong>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>10. Lịch trình giảng dạy</h2>
<table cellspacing=""0"" cellpadding=""5"" style=""text-align:center;border-style: solid;"">
    <thead style=""text-align:center;"">
        <tr>
            <th rowspan=""2"" style=""text-align:center;"">
                Tuần học
            </th>
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
#line 27 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
      
        int temp = 0;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
         foreach (var item in Model.GroupBy(x => x.tuanhoc))
        {
            int numofitem = item.Count();
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
             foreach (var item2 in item)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 39 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
                     if (item.Key != temp)
                    {
                        temp = item.Key;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("rowspan", " rowspan=\"", 1179, "\"", 1199, 1);
#nullable restore
#line 42 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
WriteAttributeValue("", 1189, numofitem, 1189, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
                                            Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"text-align: left; padding-left: 5px\">Chương ");
#nullable restore
#line 44 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
                                                                      Write(item2.Chitietmonhoc.chiso);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 44 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
                                                                                                  Write(item2.Chitietmonhoc.tenchuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
                   Write(item2.Chitietmonhoc.tietlt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
                   Write(item2.Chitietmonhoc.tietth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 48 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\Shared\Components\Pdf_Lichtrinhgiangday\Default.cshtml"
             
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
