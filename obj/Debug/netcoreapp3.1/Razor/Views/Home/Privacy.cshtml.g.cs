#pragma checksum "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "153e4c67bf730d6d2d6881d47b5065e5c4d54bde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Views\_ViewImports.cshtml"
using CongThongTin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Views\_ViewImports.cshtml"
using CongThongTin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Views\Home\Privacy.cshtml"
using CongThongTin.App_Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"153e4c67bf730d6d2d6881d47b5065e5c4d54bde", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d1f1c5d68e91bf30a27e974c6107355c4d69fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";
    var listException = ViewBag.listException as List<TbException>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s privacy policy 1.</p>\r\n");
#nullable restore
#line 9 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Views\Home\Privacy.cshtml"
 foreach(var item in listException)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 11 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Views\Home\Privacy.cshtml"
  Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
