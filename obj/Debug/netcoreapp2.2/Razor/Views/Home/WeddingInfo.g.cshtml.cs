#pragma checksum "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\WeddingInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c68fce9a21c21f8b4ae35789ad2e24370e96914"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WeddingInfo), @"mvc.1.0.view", @"/Views/Home/WeddingInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/WeddingInfo.cshtml", typeof(AspNetCore.Views_Home_WeddingInfo))]
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
#line 1 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c68fce9a21c21f8b4ae35789ad2e24370e96914", @"/Views/Home/WeddingInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WeddingInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c68fce9a21c21f8b4ae35789ad2e24370e969143474", async() => {
                BeginContext(41, 194, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>Document</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(242, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(244, 469, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c68fce9a21c21f8b4ae35789ad2e24370e969144866", async() => {
                BeginContext(250, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(272, 23, true);
                WriteLiteral("    <div>\r\n        <h1>");
                EndContext();
                BeginContext(296, 12, false);
#line 12 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\WeddingInfo.cshtml"
       Write(Model.WedOne);

#line default
#line hidden
                EndContext();
                BeginContext(308, 5, true);
                WriteLiteral(" and ");
                EndContext();
                BeginContext(314, 12, false);
#line 12 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\WeddingInfo.cshtml"
                         Write(Model.WedTwo);

#line default
#line hidden
                EndContext();
                BeginContext(326, 25, true);
                WriteLiteral(" wedding</h1>\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 351, "\"", 380, 2);
                WriteAttributeValue("", 358, "/dashboard/", 358, 11, true);
#line 13 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\WeddingInfo.cshtml"
WriteAttributeValue("", 369, ViewBag.id, 369, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(381, 96, true);
                WriteLiteral(">Dashboard</a>\r\n        <a href=\"/logout\">Log Out</a>\r\n    </div>\r\n    <div>\r\n        <h3>Date: ");
                EndContext();
                BeginContext(478, 10, false);
#line 17 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\WeddingInfo.cshtml"
             Write(Model.Date);

#line default
#line hidden
                EndContext();
                BeginContext(488, 47, true);
                WriteLiteral("</h3>\r\n    </div>\r\n    <div>\r\n        Guests:\r\n");
                EndContext();
#line 21 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\WeddingInfo.cshtml"
         for(int i =0; i< @Model.Guests.Count; i++)
        {

#line default
#line hidden
                BeginContext(599, 30, true);
                WriteLiteral("        <ul>\r\n            <li>");
                EndContext();
                BeginContext(630, 31, false);
#line 24 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\WeddingInfo.cshtml"
           Write(Model.Guests[i].Guest.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(661, 22, true);
                WriteLiteral("</li>\r\n        </ul>\r\n");
                EndContext();
#line 26 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\WeddingInfo.cshtml"
        }

#line default
#line hidden
                BeginContext(694, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(713, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591