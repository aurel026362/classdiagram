#pragma checksum "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Menthor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a4ef4bd9abe6b0dae3cc9527431956a6930d3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menthor_Index), @"mvc.1.0.view", @"/Views/Menthor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menthor/Index.cshtml", typeof(AspNetCore.Views_Menthor_Index))]
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
#line 1 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\_ViewImports.cshtml"
using App.Web;

#line default
#line hidden
#line 2 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\_ViewImports.cshtml"
using App.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a4ef4bd9abe6b0dae3cc9527431956a6930d3d", @"/Views/Menthor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e3f39db2ff1ae05875ff9df478f1dbb239071", @"/Views/_ViewImports.cshtml")]
    public class Views_Menthor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ComplexViewModel.General.CurrentUserDataViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Calendar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Ajaxs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Menthor\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(114, 42, true);
            WriteLiteral("<div class=\"row\" style=\"width:100%\">\r\n    ");
            EndContext();
            BeginContext(157, 48, false);
#line 6 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Menthor\Index.cshtml"
Write(await Html.PartialAsync("../GeneralViews/_Menu"));

#line default
#line hidden
            EndContext();
            BeginContext(205, 99, true);
            WriteLiteral("\r\n    <div class=\"col-10\">\r\n        <div class=\"tab-content\" id=\"v-pills-tabContent\">\r\n            ");
            EndContext();
            BeginContext(305, 71, false);
#line 9 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Menthor\Index.cshtml"
       Write(await Html.PartialAsync("../GeneralViews/_Profile", Model.PersonalData));

#line default
#line hidden
            EndContext();
            BeginContext(376, 1151, true);
            WriteLiteral(@"
            <div class=""tab-pane fade"" id=""v-pills-profile"" role=""tabpanel"" aria-labelledby=""v-pills-profile-tab"">
                <nav>
                    <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                        <a class=""nav-item nav-link active"" id=""nav-home-tab"" data-toggle=""tab"" href=""#divTMarks"" role=""tab"" aria-controls=""nav-home"" aria-selected=""true"">Theme Marks</a>
                        <a class=""nav-item nav-link"" id=""nav-profile-tab"" data-toggle=""tab"" href=""#divEMarks"" role=""tab"" aria-controls=""nav-profile"" aria-selected=""false"">Exam Marks</a>
                    </div>
                </nav>
                <div class=""container-fluid text-center"">
                    <div class=""row bg-first"">
                        <p>
                            My problem is that after translating up the image, the div that contains it remains
                            unchanged, and has lots of white space in the place where the image used to be.
                      ");
            WriteLiteral("  </p>\r\n                    </div>\r\n                    <div class=\"tab-content\" id=\"nav-tabContent\">\r\n                        ");
            EndContext();
            BeginContext(1528, 40, false);
#line 25 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Menthor\Index.cshtml"
                   Write(await Html.PartialAsync("_Marks", Model));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 86, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(1655, 59, false);
#line 29 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Menthor\Index.cshtml"
       Write(await Html.PartialAsync("../GeneralViews/_Comments", Model));

#line default
#line hidden
            EndContext();
            BeginContext(1714, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1729, 72, false);
#line 30 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Menthor\Index.cshtml"
       Write(await Html.PartialAsync("../GeneralViews/_Settings", Model.PersonalData));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1841, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a4ef4bd9abe6b0dae3cc9527431956a6930d3d7589", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1881, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1883, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a4ef4bd9abe6b0dae3cc9527431956a6930d3d8768", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Web.Models.ComplexViewModel.General.CurrentUserDataViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
