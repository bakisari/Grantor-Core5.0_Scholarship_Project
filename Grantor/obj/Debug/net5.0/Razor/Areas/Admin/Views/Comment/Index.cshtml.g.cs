#pragma checksum "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e980acdc2a42b1a77e6e285fd051367921930cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\_ViewImports.cshtml"
using Grantor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\_ViewImports.cshtml"
using Grantor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e980acdc2a42b1a77e6e285fd051367921930cd", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2515251ad49f67c4174f565cabbaa60bf8492923", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar rounded-circle mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""content"">
        <h3 class=""text-center"">Yorumlar</h3>
        <table class=""table table-dark table-responsive"">
            <thead>
                <tr>
                    <th>Kullanıcı</th>
                    <th>Yorum</th>
                    <th>Durum</th>
                </tr>
               
            </thead>
            <tbody>


");
#nullable restore
#line 20 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">\r\n                        <div class=\"media align-items-center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7e980acdc2a42b1a77e6e285fd051367921930cd5098", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 777, "~/UserImages/", 777, 13, true);
#nullable restore
#line 25 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"
AddHtmlAttributeValue("", 790, item.user.Image, 790, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            <div class=\"media-body\">\r\n\r\n                                <span class=\"mb-0 text-sm\">");
#nullable restore
#line 29 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"
                                                      Write(item.user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"
                                                                           Write(item.user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </th>\r\n                    <td>");
#nullable restore
#line 33 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"
                   Write(item.CommentValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"
                     if (item.Status == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1220, "\"", 1271, 2);
            WriteAttributeValue("", 1227, "/Admin/Comment/UpdateComment/", 1227, 29, true);
#nullable restore
#line 36 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1256, item.CommentId, 1256, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Yayından Kaldır</a></td>\r\n");
#nullable restore
#line 37 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1452, "\"", 1503, 2);
            WriteAttributeValue("", 1459, "/Admin/Comment/UpdateComment/", 1459, 29, true);
#nullable restore
#line 40 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1488, item.CommentId, 1488, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><i class=\"fa fa-pencil\"></i> Sitede Yayınla</a></td>\r\n");
#nullable restore
#line 41 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\projelerim\grantor-project\Grantor\Areas\Admin\Views\Comment\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
