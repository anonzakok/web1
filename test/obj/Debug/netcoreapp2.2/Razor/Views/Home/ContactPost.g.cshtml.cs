#pragma checksum "D:\1122\test\test\Views\Home\ContactPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f4220ee2672e250feff47f0f6511839908d9b72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactPost), @"mvc.1.0.view", @"/Views/Home/ContactPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactPost.cshtml", typeof(AspNetCore.Views_Home_ContactPost))]
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
#line 1 "D:\1122\test\test\Views\_ViewImports.cshtml"
using test;

#line default
#line hidden
#line 2 "D:\1122\test\test\Views\_ViewImports.cshtml"
using test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f4220ee2672e250feff47f0f6511839908d9b72", @"/Views/Home/ContactPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04aae2d41d7a1f2a1b7badf4f453e10febdd2915", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\1122\test\test\Views\Home\ContactPost.cshtml"
  
    ViewData["Title"] = "ContactPost";

#line default
#line hidden
            BeginContext(49, 55, true);
            WriteLiteral("\r\n<h1>ขอบคุณที่ติดต่อเรา</h1>\r\n<div>ทางเราขอขอบคุณ คุณ ");
            EndContext();
            BeginContext(105, 16, false);
#line 7 "D:\1122\test\test\Views\Home\ContactPost.cshtml"
                   Write(ViewData["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(121, 63, true);
            WriteLiteral(" เมื่อเจ้าหน้าที่รับเรื่องแล้วทางเราจะติดต่อกลับไปที่\r\n        ");
            EndContext();
            BeginContext(185, 17, false);
#line 8 "D:\1122\test\test\Views\Home\ContactPost.cshtml"
   Write(ViewData["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(202, 16, true);
            WriteLiteral(" โดยด่วน</div>\r\n");
            EndContext();
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