#pragma checksum "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22144158a4099db42e3f3d34dc95be620e8d07d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeCuongchiTiets_Edit), @"mvc.1.0.view", @"/Views/DeCuongchiTiets/Edit.cshtml")]
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
#nullable restore
#line 2 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22144158a4099db42e3f3d34dc95be620e8d07d5", @"/Views/DeCuongchiTiets/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_DeCuongchiTiets_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_CurriculumManagerSystem.Models.DeCuongchiTiet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row clearfix\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"card\">\r\n            <div class=\"header\">\r\n                <h2 class=\"titile-table\">CẬP NHẬT ĐỀ CƯƠNG CHI TIẾT - <b>");
#nullable restore
#line 13 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                    Write(TempData["name_dccht"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h2>
            </div>
            <div class=""body"">
                <!-- Nav tabs -->
                <ul id=""myTab"" class=""nav nav-tabs tab-nav-right"" role=""tablist"">
                    <li role=""presentation"" class=""active""><a role=""tab"" href=""#decuongchitiet"" data-toggle=""tab"">ĐỀ CƯƠNG CHI TIẾT</a></li>
                    <li role=""presentation""><a role=""tab"" href=""#muctieu"" data-toggle=""tab"">MỤC TIÊU</a></li>
                    <li role=""presentation""><a role=""tab"" href=""#decuongnhiemvu"" data-toggle=""tab"">NHIỆM VỤ</a></li>
                    <li role=""presentation""><a role=""tab"" href=""#decuongquydinh"" data-toggle=""tab"">QUY ĐỊNH</a></li>
                    <li role=""presentation""><a role=""tab"" href=""#decuonghinhthuc"" data-toggle=""tab"">HÌNH THỨC</a></li>
                    <li role=""presentation""><a role=""tab"" href=""#chitietmonhoc"" data-toggle=""tab"">CHI TIẾT MÔN HỌC</a></li>
                    <li role=""presentation""><a role=""tab"" href=""#chitietchuong"" data-toggle=""tab"">CHi TIẾT CH");
            WriteLiteral(@"ƯƠNG</a></li>
                    <li role=""presentation""><a role=""tab"" href=""#phutrach"" data-toggle=""tab"">PHỤ TRÁCH</a></li>
                    <li role=""presentation""><a role=""tab"" href=""#thoigianhoc"" data-toggle=""tab"">THỜI GIAN HỌC</a></li>
                    <li role=""presentation""><a role=""tab"" href=""#chuandauramonhoc"" data-toggle=""tab"">CHUẨN ĐẦU RA MÔN HỌC</a></li>
");
            WriteLiteral(@"                    <li role=""presentation""><a role=""tab"" href=""#decuongtailieu"" data-toggle=""tab"">TÀI LIỆU</a></li>
                    

                </ul>

                <!-- Tab panes -->
                <div class=""tab-content"">
                    <div role=""tabpanel"" class=""tab-pane fade in active"" id=""decuongchitiet"">
");
#nullable restore
#line 37 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        if(@Context.Session.GetInt32("id_edit_dccht_after") == null)
                       {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        Write(await Component.InvokeAsync("Edit_Decuongchitiet", new {id = @Context.Session.GetInt32("id_edit_dccht")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                       
                       }
                       else
                       {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        Write(await Component.InvokeAsync("Edit_Decuongchitiet" , new {id = @Context.Session.GetInt32("id_edit_dccht_after")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                              ;
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"muctieu\">\r\n");
#nullable restore
#line 47 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                          if(@Context.Session.GetInt32("id_edit_dccht_after") == null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("GetMucTieu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                      
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("GetMucTieu", new {id = @Context.Session.GetInt32("id_edit_dccht_after")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                   
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n");
#nullable restore
#line 56 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                         if(@Context.Session.GetInt32("id_edit_mt") == null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Edit_MucTieu", new {id = 0}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                      ;
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Edit_MucTieu", new {id = @Context.Session.GetInt32("id_edit_dccht")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                               ;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"decuongnhiemvu\">\r\n                       ");
#nullable restore
#line 66 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                  Write(await Component.InvokeAsync("Create_Nhiemvu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                       ");
#nullable restore
#line 67 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                  Write(await Component.InvokeAsync("Edit_Nhiemvu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        if (@Context.Session.GetInt32("id_edit_dccht_after") == null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Get_Nhiemvu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                       
                        }
                        else
                        {
                           

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                      Write(await Component.InvokeAsync("Get_Nhiemvu", new {id = @Context.Session.GetInt32("id_edit_dccht_after")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                   
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                    </div>\r\n                    <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"decuongquydinh\">\r\n                        ");
#nullable restore
#line 79 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                   Write(await Component.InvokeAsync("Create_Quydinh_checkbox"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                       \r\n");
#nullable restore
#line 81 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                         if (@Context.Session.GetInt32("id_edit_dccht_after") == null)
                        {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        Write(await Component.InvokeAsync("Get_Quydinh"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                        
                        }
                        else
                        {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        Write(await Component.InvokeAsync("Get_Quydinh", new {id = @Context.Session.GetInt32("id_edit_dccht_after")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                     
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"decuonghinhthuc\">\r\n                        ");
#nullable restore
#line 91 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                   Write(await Component.InvokeAsync("Create_Hinhthuc"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                       \r\n");
#nullable restore
#line 93 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                         if (@Context.Session.GetInt32("id_edit_dccht_after") == null)
                        {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        Write(await Component.InvokeAsync("Get_Hinhthuc"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                         
                        }
                        else
                        {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        Write(await Component.InvokeAsync("Get_Hinhthuc", new {id = @Context.Session.GetInt32("id_edit_dccht_after")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                      
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"chitietmonhoc\">\r\n                        \r\n");
#nullable restore
#line 104 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                         if (@Context.Session.GetInt32("id_edit_dccht_after") == null)
                        {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        Write(await Component.InvokeAsync("Get_Chitietmonhoc"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                              
                        }
                        else
                        {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        Write(await Component.InvokeAsync("Get_Chitietmonhoc", new {id = @Context.Session.GetInt32("id_edit_dccht_after")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                           
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n");
#nullable restore
#line 113 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                         if(@Context.Session.GetInt32("id_edit_chtmh") == null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Create_Chitietmonhoc"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Create_Chitietmonhoc", new {id = @Context.Session.GetInt32("id_edit_dccht")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                       
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                    </div>\r\n                    <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"chitietchuong\">\r\n\r\n                        ");
#nullable restore
#line 125 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                   Write(await Component.InvokeAsync("Get_Chitietchuong"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 127 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                         if(@Context.Session.GetInt32("id_edit_Chitietchuong") == null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Edit_Chitietchuong", new {id =0}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                           
                        }
                        else
                        {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                        Write(await Component.InvokeAsync("Edit_Chitietchuong", new {id = @Context.Session.GetInt32("id_edit_dccht")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                      
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                        \r\n                            \r\n\r\n                    </div>\r\n                    \r\n                    <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"phutrach\">\r\n");
#nullable restore
#line 150 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                         if (@Context.Session.GetInt32("id_edit_dccht_after") == null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Get_Phutrach"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                        
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Get_Phutrach", new {id = @Context.Session.GetInt32("id_edit_dccht_after")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                     
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"thoigianhoc\">\r\n");
#nullable restore
#line 168 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                         if (@Context.Session.GetInt32("id_edit_dccht_after") == null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Get_Thoigianhoc"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                           
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Get_Thoigianhoc", new {id = @Context.Session.GetInt32("id_edit_dccht_after")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                                        
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"chuandauramonhoc\">\r\n");
            WriteLiteral("                    </div>\r\n                    \r\n                    <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"decuongtailieu\">\r\n");
            WriteLiteral("                      \r\n");
#nullable restore
#line 185 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                         if (@Context.Session.GetInt32("id_edit_dccht") == null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                       Write(await Component.InvokeAsync("Get_Tailieu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                       
                        }
                        else
                        {
                           

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                      Write(await Component.InvokeAsync("Get_Tailieu", new {id = @Context.Session.GetInt32("id_edit_dccht")}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "C:\Users\F570Z-PC\OneDrive\Tài liệu\GitHub\_CurriculumManagerSystem\Views\DeCuongchiTiets\Edit.cshtml"
                                                                                                                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_CurriculumManagerSystem.Models.DeCuongchiTiet> Html { get; private set; }
    }
}
#pragma warning restore 1591
