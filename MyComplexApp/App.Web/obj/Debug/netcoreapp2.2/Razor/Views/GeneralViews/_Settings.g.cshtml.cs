#pragma checksum "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f8dabe4c60d24dd53cd82297d3d5e7255fb2e1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GeneralViews__Settings), @"mvc.1.0.view", @"/Views/GeneralViews/_Settings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GeneralViews/_Settings.cshtml", typeof(AspNetCore.Views_GeneralViews__Settings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8dabe4c60d24dd53cd82297d3d5e7255fb2e1a", @"/Views/GeneralViews/_Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e3f39db2ff1ae05875ff9df478f1dbb239071", @"/Views/_ViewImports.cshtml")]
    public class Views_GeneralViews__Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ViewModel.UserViewModel.UserDetailedViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
  
    ViewData["Title"] = "Settings";

#line default
#line hidden
            BeginContext(113, 1970, true);
            WriteLiteral(@"
<div class=""tab-pane fade"" id=""v-pills-settings"" role=""tabpanel"" aria-labelledby=""v-pills-settings-tab"">
    <div class=""row"">
        <div class=""col-12"" style=""padding:20px"">
            <img src=""https://w2w.fund/Content/img/default.png""
                 class=""rounded-circle mx-auto d-block"">
            <br>
            <button class=""btn btn-outline-primary mx-auto d-block"">
                Change Profile
                Photo
            </button>
        </div>
        <div class=""col-12 d-flex justify-content-center"">
            <div class=""col-sm-8 text-center"">
                <table class=""table"">
                    <tr>
                        <th>Personal Data</th>
                        <th>
                            <div class=""modal fade"" id=""modalLoginForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
                                 aria-hidden=""true"">
                                <div class=""modal-dialog"" role=""document"">
                        ");
            WriteLiteral(@"            <div class=""modal-content text-left"">
                                        <div class=""modal-header text-center"">
                                            <h4 class=""modal-title w-100 font-weight-bold"">Personal Data</h4>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                <span aria-hidden=""true"">&times;</span>
                                            </button>
                                        </div>
                                            <div class=""modal-body mx-4"">
                                                <div class=""md-form mb-4"">
                                                    <i class=""fas fa-file-signature indigo-text""></i><label>First Name</label>
                                                    <input type=""text"" id=""FName"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 2083, "", 2106, 1);
#line 36 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
WriteAttributeValue("", 2090, Model.FirstName, 2090, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2106, 388, true);
            WriteLiteral(@" required maxlength=""20"">
                                                </div>

                                                <div class=""md-form mb-4"">
                                                    <i class=""fas fa-file-signature""></i> <label>Last Name</label>
                                                    <input type=""text"" id=""LName"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 2494, "", 2516, 1);
#line 41 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
WriteAttributeValue("", 2501, Model.LastName, 2501, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2516, 393, true);
            WriteLiteral(@" required maxlength=""20"">
                                                </div>

                                                <div class=""md-form mb-4"">
                                                    <i class=""fas fa-mobile-alt""></i> <label>Phone Number</label>
                                                    <input type=""text"" id=""PhoneNumber"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 2909, "", 2934, 1);
#line 46 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
WriteAttributeValue("", 2916, Model.PhoneNumber, 2916, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2934, 383, true);
            WriteLiteral(@"  required maxlength=""20"">
                                                </div>

                                                <div class=""md-form mb-4"">
                                                    <i class=""fas fa-birthday-cake""></i> <label></label>
                                                    <input type=""date"" id=""DateBirth"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 3317, "", 3367, 1);
#line 51 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
WriteAttributeValue("", 3324, Model.DateOfBirth.ToString("yyyy-MM-dd"), 3324, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3367, 973, true);
            WriteLiteral(@" >
                                                </div>
                                            </div>
                                            <div class=""modal-footer d-flex justify-content-center"">
                                                <button id=""PersonalData"" class=""btn btn-default"" type=""submit"">Change Data</button>
                                            </div>
                                    </div>
                                </div>
                            </div>

                            <div>
                                <a class=""btn btn-outline-primary"" href="""" data-toggle=""modal"" data-target=""#modalLoginForm"">
                                    Change Personal Data
                                </a>
                            </div>
                        </th>
                    </tr>
                    <tr>
                        <td>First Name</td>
                        <td>");
            EndContext();
            BeginContext(4341, 15, false);
#line 70 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
                       Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(4356, 132, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Last Name</td>\r\n                        <td>");
            EndContext();
            BeginContext(4489, 14, false);
#line 74 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
                       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(4503, 136, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Date of Birth</td>\r\n                        <td>");
            EndContext();
            BeginContext(4640, 17, false);
#line 78 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
                       Write(Model.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(4657, 135, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Number Phone</td>\r\n                        <td>");
            EndContext();
            BeginContext(4793, 17, false);
#line 82 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
                       Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4810, 128, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>EMail</td>\r\n                        <td>");
            EndContext();
            BeginContext(4939, 11, false);
#line 86 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
                       Write(Model.EMail);

#line default
#line hidden
            EndContext();
            BeginContext(4950, 1317, true);
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th>Account Data</th>
                        <th>
                            <div class=""modal fade"" id=""modalRegisterForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
                                 aria-hidden=""true"">
                                <div class=""modal-dialog"" role=""document"">
                                    <div class=""modal-content text-left"">
                                        <div class=""modal-header"">
                                            <h4 class=""modal-title w-100 font-weight-bold"">Sign up</h4>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                <span aria-hidden=""true"">&times;</span>
                                            </button>
                                        </div>
                                        <div class=""modal-bo");
            WriteLiteral(@"dy mx-3"">
                                            <div class=""md-form mb-5"">
                                                <i class=""fas fa-user prefix grey-text""></i><label>EMail</label>
                                                <input type=""text"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 6267, "", 6286, 1);
#line 104 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
WriteAttributeValue("", 6274, Model.EMail, 6274, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6286, 345, true);
            WriteLiteral(@">
                                            </div>
                                            <div class=""md-form mb-5"">
                                                <i class=""fas fa-envelope prefix grey-text""></i><label>Password</label>
                                                <input type=""email"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 6631, "", 6650, 1);
#line 108 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
WriteAttributeValue("", 6638, Model.EMail, 6638, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6650, 917, true);
            WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""modal-footer d-flex justify-content-center"">
                                            <button class=""btn btn-deep-orange"">Sign up</button>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div>
                                <a href="""" class=""btn btn-outline-primary"" data-toggle=""modal"" data-target=""#modalRegisterForm"">
                                    Change Account Data
                                </a>
                            </div>
                        </th>
                    </tr>
                    <tr>
                        <td>Login</td>
                        <td>");
            EndContext();
            BeginContext(7568, 11, false);
#line 127 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Settings.cshtml"
                       Write(Model.EMail);

#line default
#line hidden
            EndContext();
            BeginContext(7579, 1666, true);
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <td>Password</td>
                        <td>********</td>
                    </tr>
                    <tr>
                        <td colspan=""2"">
                            <button class=""btn btn-danger"">Delete Account</button>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>
<script>
        //$(document).ready(function () {
        //    $(""#PersonalData"").bind(""click"", function () {
        //            alert(name);
        //            $.ajax({
        //                url: ""/Intern/EditData"",
        //                type: ""POST"",
        //                data: ({ fname: $(""#FName"").val(), lname: $(""#LName"").val(), phone: $(""#PhoneNumber"").val(), dbirth: $(""#DateBirth"").val() }),
        //                datatype: ""html"",
        //                success: function () { alert(""success""); }
        //    ");
            WriteLiteral(@"        });

        //    //$.post(""/Intern/EditData"", { name })
        //    //    .done(function () {
        //    //        alert(""succes"");
        //    //    })
        //    //    .fail(function () {
        //    //        alert(""error"");
        //    //    }).
        //    //    always(function () {
        //    //        alert(""Always"");
        //    //    });
        //    });
        //});

    //function myfunction(var fname) {
    //    var request = new XMLHttpRequest();
    //alert(fname);
    //    request.open('Post', 'Intern/EditData');
    //    request.send(fname);
    //}

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Web.Models.ViewModel.UserViewModel.UserDetailedViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
