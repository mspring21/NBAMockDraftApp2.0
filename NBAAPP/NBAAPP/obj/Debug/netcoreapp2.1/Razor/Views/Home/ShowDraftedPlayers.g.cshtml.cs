#pragma checksum "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e739115f09bfa5d826a50e49afab70a91a50893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowDraftedPlayers), @"mvc.1.0.view", @"/Views/Home/ShowDraftedPlayers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowDraftedPlayers.cshtml", typeof(AspNetCore.Views_Home_ShowDraftedPlayers))]
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
#line 1 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\_ViewImports.cshtml"
using NBAAPP;

#line default
#line hidden
#line 2 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\_ViewImports.cshtml"
using NBAAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e739115f09bfa5d826a50e49afab70a91a50893", @"/Views/Home/ShowDraftedPlayers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d4d445d003d93e9d15c68cff22aa8fc0b3088c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowDraftedPlayers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DraftVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
  
    ViewData["Title"] = "ShowDraftedPlayers";

#line default
#line hidden
            BeginContext(71, 553, true);
            WriteLiteral(@"
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Name</th>
                <th>School</th>
                <th>Team Drafted By</th>
                <th>Age</th>
                <th>Height</th>
                <th>Weight</th>
                <th>Position</th>
                <th>Points</th>
                <th>Rebounds</th>
                <th>Assists</th>
                <th>Blocks</th>
                <th>Steals</th>
                <th>Rating</th>
            </tr>
        </thead>
");
            EndContext();
#line 24 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
         foreach (Prospect p in Model.DraftedProspects)
        {

#line default
#line hidden
            BeginContext(692, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(731, 14, false);
#line 27 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.ProspectName);

#line default
#line hidden
            EndContext();
            BeginContext(745, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(773, 8, false);
#line 28 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.School);

#line default
#line hidden
            EndContext();
            BeginContext(781, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(809, 13, false);
#line 29 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.TeamDrafted);

#line default
#line hidden
            EndContext();
            BeginContext(822, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(850, 5, false);
#line 30 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.Age);

#line default
#line hidden
            EndContext();
            BeginContext(855, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(883, 8, false);
#line 31 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.Height);

#line default
#line hidden
            EndContext();
            BeginContext(891, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(919, 8, false);
#line 32 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(927, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(955, 10, false);
#line 33 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.Position);

#line default
#line hidden
            EndContext();
            BeginContext(965, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(993, 8, false);
#line 34 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.Points);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1029, 10, false);
#line 35 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.Rebounds);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1067, 9, false);
#line 36 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.Assists);

#line default
#line hidden
            EndContext();
            BeginContext(1076, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1104, 8, false);
#line 37 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.Blocks);

#line default
#line hidden
            EndContext();
            BeginContext(1112, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1140, 8, false);
#line 38 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.Steals);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1176, 8, false);
#line 39 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
               Write(p.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(1184, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 41 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftedPlayers.cshtml"
        }

#line default
#line hidden
            BeginContext(1221, 16, true);
            WriteLiteral("    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DraftVM> Html { get; private set; }
    }
}
#pragma warning restore 1591