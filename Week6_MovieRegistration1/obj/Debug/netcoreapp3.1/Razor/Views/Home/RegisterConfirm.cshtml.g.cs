#pragma checksum "C:\Users\CFlynn3\source\repos\Week6_MovieRegistration1\Week6_MovieRegistration1\Views\Home\RegisterConfirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00e9edfe64bb98b195666c256855bac28cfaf36f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterConfirm), @"mvc.1.0.view", @"/Views/Home/RegisterConfirm.cshtml")]
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
#line 1 "C:\Users\CFlynn3\source\repos\Week6_MovieRegistration1\Week6_MovieRegistration1\Views\_ViewImports.cshtml"
using Week6_MovieRegistration1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CFlynn3\source\repos\Week6_MovieRegistration1\Week6_MovieRegistration1\Views\_ViewImports.cshtml"
using Week6_MovieRegistration1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00e9edfe64bb98b195666c256855bac28cfaf36f", @"/Views/Home/RegisterConfirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e826d09f472be5297aa424befab8804344970e73", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegisterConfirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"SuccessfulRegistration\">\r\n    <h2>Successful Registration!</h2>\r\n</div>\r\n<p>Thanks for registering ");
#nullable restore
#line 5 "C:\Users\CFlynn3\source\repos\Week6_MovieRegistration1\Week6_MovieRegistration1\Views\Home\RegisterConfirm.cshtml"
                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("! </p>\r\n<p>Genre: ");
#nullable restore
#line 6 "C:\Users\CFlynn3\source\repos\Week6_MovieRegistration1\Week6_MovieRegistration1\Views\Home\RegisterConfirm.cshtml"
     Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n<p>Runtime: ");
#nullable restore
#line 7 "C:\Users\CFlynn3\source\repos\Week6_MovieRegistration1\Week6_MovieRegistration1\Views\Home\RegisterConfirm.cshtml"
       Write(Model.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n<p>\r\n    Year: ");
#nullable restore
#line 9 "C:\Users\CFlynn3\source\repos\Week6_MovieRegistration1\Week6_MovieRegistration1\Views\Home\RegisterConfirm.cshtml"
     Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
