#pragma checksum "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b98aa4d76662aab946c9b8dc1240d50f6d87eab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faq_SSS), @"mvc.1.0.view", @"/Views/Faq/SSS.cshtml")]
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
#line 1 "C:\projelerim\grantor-project\Grantor\Views\_ViewImports.cshtml"
using Grantor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projelerim\grantor-project\Grantor\Views\_ViewImports.cshtml"
using Grantor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projelerim\grantor-project\Grantor\Views\_ViewImports.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b98aa4d76662aab946c9b8dc1240d50f6d87eab5", @"/Views/Faq/SSS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf8a05e9bcc82dbd7a2e74fecf44d61955d8c08", @"/Views/_ViewImports.cshtml")]
    public class Views_Faq_SSS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Faq>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Faq.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml"
  
    ViewData["Title"] = "SSS";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b98aa4d76662aab946c9b8dc1240d50f6d87eab54119", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""container-xxl py-5 bg-primary hero-header"" style=""margin-bottom:0px;"">

    <div class=""row g-5 py-5"" style=""margin-bottom:0px"">
        <div class=""col-12 text-center"">

        </div>
    </div>

</div>

<div class=""container-xxl py-5"" style=""margin-top:0px;"">

    <div class=""faq_area section_padding_130"" id=""faq"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-12 col-sm-8 col-lg-6"">
                    <!-- Section Heading-->
                    <div class=""section_heading text-center wow fadeInUp"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
                        <h3><span>Sıkça </span> Sorulan Sorular</h3>

                        <div class=""border-bottom""></div>
                    </div>
                </div>
            </div>
            <div class=""row justify-content-center"">
");
#nullable restore
#line 34 "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml"
                  int counter = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 37 "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml"
                 foreach (var item in Model)
                {
                    counter++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- FAQ Area-->\r\n                    <div class=\"col-12 col-sm-10 col-lg-8\">\r\n\r\n\r\n");
#nullable restore
#line 45 "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml"
                           string modalvalue = "a" + counter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml"
                           string modelclass = "b" + counter;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""accordion faq-accordian"" id=""faqAccordion"">
                            <div class=""card border-0 wow fadeInUp"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
                                <div class=""card-header"" id=""headingOne"">
                                    <h6 class=""mb-0 collapsed"" data-toggle=""collapse"" data-target=""#");
#nullable restore
#line 51 "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml"
                                                                                               Write(modelclass);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\" aria-controls=\"collapseOne\">");
#nullable restore
#line 51 "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml"
                                                                                                                                                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"lni-chevron-up\"></span></h6>\r\n                                </div>\r\n                                <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 2134, "\"", 2150, 1);
#nullable restore
#line 53 "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml"
WriteAttributeValue("", 2139, modelclass, 2139, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-labelledby=\"headingOne\" data-parent=\"#faqAccordion\">\r\n                                    <div class=\"card-body\">\r\n                                        <p>");
#nullable restore
#line 55 "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml"
                                      Write(item.Explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                     \r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 63 "C:\projelerim\grantor-project\Grantor\Views\Faq\SSS.cshtml"
                                counter++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
       
                <!-- Support Button-->
                <div class=""support-button text-center d-flex align-items-center justify-content-center mt-4 wow fadeInUp"" data-wow-delay=""0.5s"" style=""visibility: visible; animation-delay: 0.5s; animation-name: fadeInUp;"">
                    <i class=""lni-emoji-sad""></i>
                    <p class=""mb-0 px-2"">Bu cevaplar size yardımcı olmadı mı?</p>
                    <a href=""/Contact/Index""> Bizimle İletişim Geç</a>
                </div>
            </div>

   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Faq>> Html { get; private set; }
    }
}
#pragma warning restore 1591
