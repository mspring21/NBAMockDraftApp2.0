#pragma checksum "C:\Users\MSpring\Desktop\NBAappMVC\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bb7349ef52d60ad3dd02053141e45def13989cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowDraftOrder), @"mvc.1.0.view", @"/Views/Home/ShowDraftOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowDraftOrder.cshtml", typeof(AspNetCore.Views_Home_ShowDraftOrder))]
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
#line 1 "C:\Users\MSpring\Desktop\NBAappMVC\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\_ViewImports.cshtml"
using NBAAPP;

#line default
#line hidden
#line 2 "C:\Users\MSpring\Desktop\NBAappMVC\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\_ViewImports.cshtml"
using NBAAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb7349ef52d60ad3dd02053141e45def13989cf", @"/Views/Home/ShowDraftOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d4d445d003d93e9d15c68cff22aa8fc0b3088c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowDraftOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Team>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MSpring\Desktop\NBAappMVC\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
  
    ViewData["Title"] = "ShowDraftOrder";

#line default
#line hidden
            BeginContext(70, 207, true);
            WriteLiteral("\r\n<h1>Draft Lottery Results</h1>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>Team Name</th>\r\n            <th>Team Needs</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 16 "C:\Users\MSpring\Desktop\NBAappMVC\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
         foreach(Team t in Model)
        {

#line default
#line hidden
            BeginContext(323, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(362, 10, false);
#line 19 "C:\Users\MSpring\Desktop\NBAappMVC\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
               Write(t.TeamName);

#line default
#line hidden
            EndContext();
            BeginContext(372, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(400, 11, false);
#line 20 "C:\Users\MSpring\Desktop\NBAappMVC\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
               Write(t.TeamNeeds);

#line default
#line hidden
            EndContext();
            BeginContext(411, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 22 "C:\Users\MSpring\Desktop\NBAappMVC\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
        }

#line default
#line hidden
            BeginContext(448, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591
