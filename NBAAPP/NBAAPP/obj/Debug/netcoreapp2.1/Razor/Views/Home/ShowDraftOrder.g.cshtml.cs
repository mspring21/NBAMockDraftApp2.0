#pragma checksum "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24006cb2031da8445646411087bc83dd49842c18"
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
#line 1 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\_ViewImports.cshtml"
using NBAAPP;

#line default
#line hidden
#line 2 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\_ViewImports.cshtml"
using NBAAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24006cb2031da8445646411087bc83dd49842c18", @"/Views/Home/ShowDraftOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d4d445d003d93e9d15c68cff22aa8fc0b3088c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowDraftOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Team>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("TeamLogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
  
    ViewData["Title"] = "ShowDraftOrder";

#line default
#line hidden
            BeginContext(70, 230, true);
            WriteLiteral("\r\n<h1>Draft Lottery Results</h1>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>Team Name</th>\r\n            <th>Team Needs</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
         foreach(Team t in Model)
        {

#line default
#line hidden
            BeginContext(346, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(384, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "806fe8b84b2e4319849c40f72aa51c97", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 411, "~/images/", 411, 9, true);
#line 20 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
AddHtmlAttributeValue("", 420, t.TeamPicture, 420, 16, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 436, ".png", 436, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(444, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(472, 10, false);
#line 21 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
               Write(t.TeamName);

#line default
#line hidden
            EndContext();
            BeginContext(482, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(510, 11, false);
#line 22 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
               Write(t.TeamNeeds);

#line default
#line hidden
            EndContext();
            BeginContext(521, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Mark\Desktop\git\NBAMockDraftApp2.0\NBAAPP\NBAAPP\Views\Home\ShowDraftOrder.cshtml"
        }

#line default
#line hidden
            BeginContext(558, 24, true);
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
