#pragma checksum "D:\Visual Studio projects\MovieInfo\Views\Title\Movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3a0e8eeebd1130d1e9329fab2fb255019601923"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Title_Movies), @"mvc.1.0.view", @"/Views/Title/Movies.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Title/Movies.cshtml", typeof(AspNetCore.Views_Title_Movies))]
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
#line 1 "D:\Visual Studio projects\MovieInfo\Views\_ViewImports.cshtml"
using MovieInfo;

#line default
#line hidden
#line 2 "D:\Visual Studio projects\MovieInfo\Views\_ViewImports.cshtml"
using MovieInfo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3a0e8eeebd1130d1e9329fab2fb255019601923", @"/Views/Title/Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313297b5cbabc59bcf3d35b1600627325bdbbdc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Title_Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieInfo.Models.Title>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Visual Studio projects\MovieInfo\Views\Title\Movies.cshtml"
  
    ViewData["Title"] = "Movies";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(120, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(127, 10, false);
#line 7 "D:\Visual Studio projects\MovieInfo\Views\Title\Movies.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(137, 7, true);
            WriteLiteral("</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieInfo.Models.Title> Html { get; private set; }
    }
}
#pragma warning restore 1591
