#pragma checksum "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Actor\DeleteConnection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "733e8ab41291375384648feb2e8243cc144d8a9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actor_DeleteConnection), @"mvc.1.0.view", @"/Views/Actor/DeleteConnection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Actor/DeleteConnection.cshtml", typeof(AspNetCore.Views_Actor_DeleteConnection))]
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
#line 1 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\_ViewImports.cshtml"
using Laboration3;

#line default
#line hidden
#line 2 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\_ViewImports.cshtml"
using Laboration3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"733e8ab41291375384648feb2e8243cc144d8a9b", @"/Views/Actor/DeleteConnection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ddee5f10f90f35adeeb029d0519e436d8fdd58", @"/Views/_ViewImports.cshtml")]
    public class Views_Actor_DeleteConnection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Actor\DeleteConnection.cshtml"
  
    ViewData["Title"] = "DeleteConnection";

#line default
#line hidden
            BeginContext(54, 38, true);
            WriteLiteral("\r\n<h2>DeleteConnection</h2>\r\n\r\n<p>Id: ");
            EndContext();
            BeginContext(93, 13, false);
#line 8 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Actor\DeleteConnection.cshtml"
  Write(ViewBag.actor);

#line default
#line hidden
            EndContext();
            BeginContext(106, 4, true);
            WriteLiteral("</p>");
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
