#pragma checksum "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDFs\Extract.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afc9ec3deb670612c353f8c87c79635e2576224"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExtractPDFs_Extract), @"mvc.1.0.view", @"/Views/ExtractPDFs/Extract.cshtml")]
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
#line 1 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDFs\Extract.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDFs\Extract.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afc9ec3deb670612c353f8c87c79635e2576224", @"/Views/ExtractPDFs/Extract.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe3518de5120101b8a8d2697994fd329344901", @"/Views/_ViewImports.cshtml")]
    public class Views_ExtractPDFs_Extract : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 3 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDFs\Extract.cshtml"
  
  ViewData["Title"] = "Print";
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2afc9ec3deb670612c353f8c87c79635e25762245219", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2afc9ec3deb670612c353f8c87c79635e25762245877", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2afc9ec3deb670612c353f8c87c79635e25762247763", async() => {
                WriteLiteral(@"
  <div class=""container"">
    <div class=""header"">
      <div class=""header_top"">
        <div class=""header_left"">
          <h1>
            TRƯỜNG ĐẠI HỌC <br />
            KỸ THUẬT - CÔNG NGHỆ CẦN THƠ <br />
            <span>KHOA CÔNG NGHỆ THÔNG TIN</span>
          </h1>
        </div>
        <div class=""header_right"">
          <h1>
            CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM <br />
            <span>Độc lập - Tự do - Hạnh phúc</span>
          </h1>
        </div>
      </div>
      <div class=""header_bottom"">
        <h1>ĐỀ CƯƠNG CHI TIẾT HỌC PHẦN</h1>
        <span class=""title_descript"">
          (Ban hành kèm theo Quyết định số…./QĐ-ĐHKTCN ngày… tháng… năm 20….
          <br />
          của Hiệu trưởng Trường Đại học Kỹ thuật - Công nghệ Cần Thơ
        </span>
      </div>
    </div>
    <div class=""content"">
      <div class=""content_item"">
        ");
#nullable restore
#line 64 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDFs\Extract.cshtml"
   Write(await Component.InvokeAsync("Pdf_Thongtinchungvehocphan", new { id = @Context.Session.GetInt32("id_pdf")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\">\r\n        ");
#nullable restore
#line 67 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDFs\Extract.cshtml"
   Write(await Component.InvokeAsync("Pdf_Getmuctieu", new { id = @Context.Session.GetInt32("id_pdf")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\">\r\n        ");
#nullable restore
#line 70 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDFs\Extract.cshtml"
   Write(await Component.InvokeAsync("Pdf_Getclpo", new { id = @Context.Session.GetInt32("id_pdf")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\">\r\n        ");
#nullable restore
#line 73 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDFs\Extract.cshtml"
   Write(await Component.InvokeAsync("Pdf_Noidungchitiethp", new { id = @Context.Session.GetInt32("id_pdf")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      </div>\r\n      <div class=\"content_item\">\r\n        ");
#nullable restore
#line 76 "C:\Users\ADMIN\OneDrive\Documents\GitHub\_CurriculumManagerSystem\Views\ExtractPDFs\Extract.cshtml"
   Write(await Component.InvokeAsync("Pdf_Lichtrinhgiangday", new { id = @Context.Session.GetInt32("id_pdf")} ));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
      </div>
    </div>

    <div class=""footer"">
      <div class=""title_time"">Cần Thơ, ngày….. tháng…… năm ……</div>
      <div class=""col_title""></div>
    </div>
  </div>

  <!-- Optional JavaScript -->
  <!-- jQuery first, then Popper.js, then Bootstrap JS -->
  <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
    integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo""
    crossorigin=""anonymous""></script>
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""
    integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1""
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
