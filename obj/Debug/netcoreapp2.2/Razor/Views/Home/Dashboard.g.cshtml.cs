#pragma checksum "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ce8d070fed8276e7ef262b03e8dbbf3c2c12def"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ce8d070fed8276e7ef262b03e8dbbf3c2c12def", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ce8d070fed8276e7ef262b03e8dbbf3c2c12def3466", async() => {
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
            BeginContext(244, 1450, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ce8d070fed8276e7ef262b03e8dbbf3c2c12def4859", async() => {
                BeginContext(250, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(278, 423, true);
                WriteLiteral(@"    <div>
        <h1>Welcome to Wedding Planner</h1>
        <a href=""/logout"">Log Out</a>
    </div>
    <div>
        <table>
            <th>
                <tr>
                    <td><h4>Weddings</h4></td>
                    <td><h4>Date</h4></td>
                    <td><h4>Guests</h4></td>
                    <td><h4>Actions</h4></td>
                </tr>
            </th>
            <tbody>
");
                EndContext();
#line 26 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
                 foreach(var item in @Model)
                {

#line default
#line hidden
                BeginContext(766, 48, true);
                WriteLiteral("                <tr>\r\n                    <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 814, "\"", 845, 2);
                WriteAttributeValue("", 821, "/wedding/", 821, 9, true);
#line 29 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 830, item.WeddingId, 830, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(846, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(848, 11, false);
#line 29 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                      Write(item.WedOne);

#line default
#line hidden
                EndContext();
                BeginContext(859, 3, true);
                WriteLiteral(" & ");
                EndContext();
                BeginContext(863, 11, false);
#line 29 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                                     Write(item.WedTwo);

#line default
#line hidden
                EndContext();
                BeginContext(874, 35, true);
                WriteLiteral("</a></td>\r\n                    <td>");
                EndContext();
                BeginContext(910, 9, false);
#line 30 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
                   Write(item.Date);

#line default
#line hidden
                EndContext();
                BeginContext(919, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(951, 17, false);
#line 31 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
                   Write(item.Guests.Count);

#line default
#line hidden
                EndContext();
                BeginContext(968, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
#line 32 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
                         if(ViewBag.id == item.UserId)
                        {

#line default
#line hidden
                BeginContext(1058, 30, true);
                WriteLiteral("                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1088, "\"", 1118, 2);
                WriteAttributeValue("", 1095, "/delete/", 1095, 8, true);
#line 34 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1103, item.WeddingId, 1103, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1119, 13, true);
                WriteLiteral(">Delete</a>\r\n");
                EndContext();
#line 35 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
                        }
                        else if(item.Guests.Any(a => a.UserId == ViewBag.id))
                        {

#line default
#line hidden
                BeginContext(1265, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1299, "\"", 1329, 2);
                WriteAttributeValue("", 1306, "/unrsvp/", 1306, 8, true);
#line 38 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1314, item.WeddingId, 1314, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1330, 14, true);
                WriteLiteral(">Un-RSVP</a>\r\n");
                EndContext();
#line 39 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
                            
                        }
                        else{

#line default
#line hidden
                BeginContext(1432, 30, true);
                WriteLiteral("                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1462, "\"", 1490, 2);
                WriteAttributeValue("", 1469, "/rsvp/", 1469, 6, true);
#line 42 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1475, item.WeddingId, 1475, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1491, 12, true);
                WriteLiteral(">RSVP</a> \r\n");
                EndContext();
#line 43 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
                        }

#line default
#line hidden
                BeginContext(1530, 50, true);
                WriteLiteral("                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 46 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\WeddingPlanner\Views\Home\Dashboard.cshtml"
                }

#line default
#line hidden
                BeginContext(1599, 88, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <a href=\"/new\">New Wedding</a>\r\n");
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
            BeginContext(1694, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
