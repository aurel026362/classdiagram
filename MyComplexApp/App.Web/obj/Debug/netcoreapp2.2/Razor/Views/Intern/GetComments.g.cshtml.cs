#pragma checksum "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Intern\GetComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dee5c5a30b128c1107e02fd7db5a36558c8e240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Intern_GetComments), @"mvc.1.0.view", @"/Views/Intern/GetComments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Intern/GetComments.cshtml", typeof(AspNetCore.Views_Intern_GetComments))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dee5c5a30b128c1107e02fd7db5a36558c8e240", @"/Views/Intern/GetComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c602c57965ce5caca06038002963a0a362a30e", @"/Views/_ViewImports.cshtml")]
    public class Views_Intern_GetComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ComplexViewModel.Intern.CurrentDataInternViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/about.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30px; height:30px; border-radius:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(74, 944, true);
            WriteLiteral(@"<style>
    .my-comment {
        margin: 10px;
        padding: 5px;
        border-radius: 20px;
        background-color: #3399ff;
        color: #fff;
        height: auto;
        width: 500px;
        float: left;
    }

    .other-comment {
        margin: 10px;
        padding: 5px;
        border-radius: 20px;
        background-color: #d9d9d9;
        color: #fff;
        height: auto;
        width: 500px;
        float: right;
    }
</style>
<div class=""col-md-9 col-xs-7 content-div"">
    <div class=""row content-input-div"">
        <input class=""form-control"" id=""myComment"" />
        <button class=""btn btn-primary"" id=""submitComment"">Add Comment</button>
    </div>
    <div class=""row content-comment-div"">
        <div class=""row"">
            <div class=""form-group col-12"">
                <p>Comments</p>
                <hr />
                <div class=""col-12"" id=""allcomments"">

");
            EndContext();
#line 37 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Intern\GetComments.cshtml"
                     foreach (var item in Model.Comments)
                    {
                        // @:

#line default
#line hidden
            BeginContext(1131, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1159, "\"", 1247, 2);
#line 40 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Intern\GetComments.cshtml"
WriteAttributeValue("", 1167, Model.PersonalData.EMail.Equals(item.EMail) ? "my-comment" : "other-comment", 1167, 79, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1246, "", 1247, 1, true);
            EndWriteAttribute();
            BeginContext(1248, 35, true);
            WriteLiteral(">\r\n                                ");
            EndContext();
            BeginContext(1283, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7dee5c5a30b128c1107e02fd7db5a36558c8e2405971", async() => {
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
            EndContext();
            BeginContext(1367, 4, true);
            WriteLiteral(" <b>");
            EndContext();
            BeginContext(1372, 10, false);
#line 41 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Intern\GetComments.cshtml"
                                                                                                                   Write(item.EMail);

#line default
#line hidden
            EndContext();
            BeginContext(1382, 31, true);
            WriteLiteral("</b><span class=\"text-body\"> : ");
            EndContext();
            BeginContext(1414, 12, false);
#line 41 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Intern\GetComments.cshtml"
                                                                                                                                                             Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 46, true);
            WriteLiteral("</span> <small class=\"text-muted text-right\">(");
            EndContext();
            BeginContext(1473, 16, false);
#line 41 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Intern\GetComments.cshtml"
                                                                                                                                                                                                                        Write(item.DateComment);

#line default
#line hidden
            EndContext();
            BeginContext(1489, 47, true);
            WriteLiteral(")</small>\r\n                            </div>\r\n");
            EndContext();
#line 43 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Intern\GetComments.cshtml"
                    }

#line default
#line hidden
            BeginContext(1559, 767, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div id=""bottom-div"" class=""row"" style=""margin:20px"">
            <button id=""MoreComments"" class=""btn btn-outline-primary btn-sm"">Show more comments...</button>
        </div>
    </div>
</div>
<script>

    $(""#submitComment"").click(function () {
        $.ajax({
            url: ""/Intern/SubmitComment"",
            type: ""POST"",
            data: ({ comment: $(""#myComment"").val(), themeId: $(""#theme"").val() }),
            datatype: ""html"",
            success: function () {
                $(""#allcomments"").prepend(""<div class='my-comment'>""+
                    ""<img src='~/imgs/about.jpg' style='width:30px;height:30px;border-radius:200px;'/> ""+
                    ""<b>");
            EndContext();
            BeginContext(2327, 24, false);
#line 63 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Intern\GetComments.cshtml"
                   Write(Model.PersonalData.EMail);

#line default
#line hidden
            EndContext();
            BeginContext(2351, 116, true);
            WriteLiteral("</b><span class=\'text-body\'> : \" + $(\"#myComment\").val() +\r\n                    \" </span><small class=\'text-muted\'>(");
            EndContext();
            BeginContext(2468, 23, false);
#line 64 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\Intern\GetComments.cshtml"
                                                   Write(DateTime.Now.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2491, 1167, true);
            WriteLiteral(@")</span></div>"");
                $(""#myComment"").val("""");
            },
            error: function () {
                alert(""Choose a theme!"");
            }
        });
    });
    var pageNr = 0;

    $(""#MoreComments"").click(function () {
        pageNr++;
        //if(pageNr != -1)
        $.ajax({
            url: ""/Intern/GetMoreComments"",
            type: ""GET"",
            data: ({ themeId: $(""#theme"").val() , pageNr: pageNr}),
            datatype: ""application/json"",
            success: function (data) {
                if (data.length < 10) {
                    $(""#bottom-div"").prepend(""<span class='text-danger'>Don't exist more comments!</span>"");
                    $(""#MoreComments"").hide();
                    //$(""#allcomments"").append(""<br/><span class='text-danger text-sm'>Don't exist more comments</span>"");
                }
                $.each(data, function (i, item) {
                    $('#allcomments').append(""<b>"" + item.EMail+""</b> : "" + item.Comm");
            WriteLiteral("ent + \" <small class=\'text-muted\'>(\" + item.DateComment+\")</span><br/>\");\r\n                });\r\n             }\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Web.Models.ComplexViewModel.Intern.CurrentDataInternViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
