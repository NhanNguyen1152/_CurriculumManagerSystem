#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8155c61666646eab44d52a68faa677460a9f3f73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExtractPDF_CTDT_Extract_ctdt), @"mvc.1.0.view", @"/Views/ExtractPDF_CTDT/Extract_ctdt.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8155c61666646eab44d52a68faa677460a9f3f73", @"/Views/ExtractPDF_CTDT/Extract_ctdt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_ExtractPDF_CTDT_Extract_ctdt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("window.print()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
  
  ViewData["Title"] = "Print";
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8155c61666646eab44d52a68faa677460a9f3f735291", async() => {
                WriteLiteral(@"
  <!-- Required meta tags -->
  <meta charset=""utf-8"" />
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"" />
  <style>
    body {
      height: 842px;
      width: 595px;
      /* to centre page on screen*/
      margin-left: auto;
      margin-right: auto;
    }
  </style>

  <!-- Bootstrap CSS -->
");
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8155c61666646eab44d52a68faa677460a9f3f735949", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8155c61666646eab44d52a68faa677460a9f3f737835", async() => {
                WriteLiteral(@"
  <div class=""container"">
    <div class=""header"">
      <div class=""header_top"">
        <div class=""header_left"">
          <h1>UBND THÀNH PHỐ CẦN THƠ</h1>
          <h1>
            <b>TRƯỜNG ĐẠI HỌC</b> <br />
            <span style="" text-decoration: underline;"">KỸ THUẬT - CÔNG NGHỆ CẦN THƠ</span>
          </h1>
        </div>
        <div class=""header_right"">
          <h1>
            <b>CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM</b> <br />
            <span style="" text-decoration: underline;"">Độc lập - Tự do - Hạnh phúc</span>
          </h1>
        </div>
      </div>
      <div class=""header_bottom"">
        <h1>CHƯƠNG TRÌNH ĐÀO TẠO</h1>
        <span class=""title_descript"">
          (Ban hành kèm theo Quyết định số…./QĐ-ĐHKTCN ngày… tháng… năm 20….
          <br />
          của Hiệu trưởng Trường Đại học Kỹ thuật - Công nghệ Cần Thơ)
        </span>
      </div>
    </div>
    <div class=""content"">
      <div class=""content_item"" id=""0"">
        ");
#nullable restore
#line 64 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_thongtinvectdt", new { id = @Context.Session.GetInt32("id_pdf_ctdt")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\" id=\"1\">\r\n        ");
#nullable restore
#line 67 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_muctieudaotao", new { id = @Context.Session.GetInt32("id_pdf_ctdt")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\" id=\"2\">\r\n      ");
#nullable restore
#line 70 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
 Write(await Component.InvokeAsync("Pdf_ctdt_chuandaura", new { id = @Context.Session.GetInt32("id_pdf_ctdt")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n");
                WriteLiteral("      <div class=\"content_item\" id=\"3\">\r\n        ");
#nullable restore
#line 76 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_khoiluongkienthuc", new { id = @Context.Session.GetInt32("id_pdf_ctdt")}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\" id=\"4\">\r\n        ");
#nullable restore
#line 79 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_doituongtuyensinh"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\" id=\"5\">\r\n        ");
#nullable restore
#line 82 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_qtdt_dktn"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\" id=\"6\">\r\n        ");
#nullable restore
#line 85 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_cachthucdanhgia"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\" id=\"7\">\r\n        ");
#nullable restore
#line 88 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_kkttoankhoa", new { id = @Context.Session.GetInt32("id_pdf_ctdt")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      \r\n      <div class=\"content_item\" id=\"8\">\r\n        ");
#nullable restore
#line 92 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_quydinh"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 93 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_noidung_ctdt", new { id = @Context.Session.GetInt32("id_pdf_ctdt")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\" id=\"9\">\r\n        ");
#nullable restore
#line 96 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_kehoachgiangday", new { id = @Context.Session.GetInt32("id_pdf_ctdt")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\" id=\"10\">\r\n        ");
#nullable restore
#line 99 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_ctdt_hdthct", new { id = @Context.Session.GetInt32("id_pdf_ctdt")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <br />\r\n      <div class=\"content_item\" id=\"11\">\r\n        ");
#nullable restore
#line 103 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDF_CTDT\Extract_ctdt.cshtml"
   Write(await Component.InvokeAsync("Pdf_Thoikhoabieu", new { ten = @Context.Session.GetString("ten_pdf_ctdt")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n");
                WriteLiteral(@"
      <div class=""footer"">
        <div class=""title_time"">Cần Thơ, ngày ... tháng ... năm ... </div>
        <div class=""col_title"">
          <div class=""content-title"">
            <h1>Hiệu trưởng</h1>
          </div>
          <div class=""content-title"">
            <h1>Trưởng Khoa</h1>
          </div>
          <div class=""content-title"">
            <h1>Trưởng bộ môn</h1>
          </div>
          <div class=""content-title"">
            <h1>Người biên soạn</h1>
          </div>
        </div>
      </div>
    </div>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
      integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo""
      crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""
      integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIH");
                WriteLiteral(@"NDz0W1""
      crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""
      integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM""
      crossorigin=""anonymous""></script>
    <script src=""./main.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
