#pragma checksum "D:\1122\test\test\Views\Home\Multiply.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62a777d3b85c8276f0c2363144b4379826ce0522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Multiply), @"mvc.1.0.view", @"/Views/Home/Multiply.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Multiply.cshtml", typeof(AspNetCore.Views_Home_Multiply))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62a777d3b85c8276f0c2363144b4379826ce0522", @"/Views/Home/Multiply.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04aae2d41d7a1f2a1b7badf4f453e10febdd2915", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Multiply : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\1122\test\test\Views\Home\Multiply.cshtml"
  
    ViewData["Title"] = "Multiply";

#line default
#line hidden
            BeginContext(46, 23, true);
            WriteLiteral("\r\n<h1>Multiply</h1>\r\n\r\n");
            EndContext();
            BeginContext(70, 20, false);
#line 8 "D:\1122\test\test\Views\Home\Multiply.cshtml"
Write(ViewData["Multiply"]);

#line default
#line hidden
            EndContext();
            BeginContext(90, 1, true);
            WriteLiteral(".");
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
