#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcc5215ee0aec53ffbf70eb4194e113f8acfd56e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GeneralViews_Settings), @"mvc.1.0.view", @"/Views/GeneralViews/Settings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GeneralViews/Settings.cshtml", typeof(AspNetCore.Views_GeneralViews_Settings))]
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
#line 1 "D:\Git\Internship\MyComplexApp\App.Web\Views\_ViewImports.cshtml"
using App.Web;

#line default
#line hidden
#line 2 "D:\Git\Internship\MyComplexApp\App.Web\Views\_ViewImports.cshtml"
using App.Web.Models;

#line default
#line hidden
#line 1 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcc5215ee0aec53ffbf70eb4194e113f8acfd56e", @"/Views/GeneralViews/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c602c57965ce5caca06038002963a0a362a30e", @"/Views/_ViewImports.cshtml")]
    public class Views_GeneralViews_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(115, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 3 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
      
        ViewData["Title"] = "Settings";
    

#line default
#line hidden
            BeginContext(171, 2300, true);
            WriteLiteral(@"
    <div class=""tab-pane fade"" id=""v-pills-settings"" role=""tabpanel"" aria-labelledby=""v-pills-settings-tab"">
        <div class=""container-fluid"">
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
                <div class=""row col-12 d-flex justify-content-center"">
                    <div class=""col-sm-8 text-center"">
                        <table class=""table"">
                            <tr>
                                <th>Personal Data</th>
                                <th>
                                    <div class=""modal fade"" id=""modalLoginForm"" tabindex=""-1"" role=""dialog"" ari");
            WriteLiteral(@"a-labelledby=""myModalLabel""
                                         aria-hidden=""true"">
                                        <div class=""modal-dialog"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header text-center"">
                                                    <h4 class=""modal-title w-100 font-weight-bold"">Sign in</h4>
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
                                                <div class=""modal-body mx-4"">
                                                    <div class=""md-form mb-5"">
                                                        <i class=""fas ");
            WriteLiteral("fa-envelope prefix grey-text\"></i><label data-error=\"wrong\" data-success=\"right\" for=\"defaultForm-email\">First Name</label>\r\n                                                        <input type=\"text\" id=\"defaultForm-email\" class=\"form-control validate\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2471, "", 2554, 1);
#line 38 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 2478, UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.FirstName, 2478, 76, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2554, 460, true);
            WriteLiteral(@">
                                                    </div>

                                                    <div class=""md-form mb-4"">
                                                        <i class=""fas fa-lock prefix grey-text""></i><label data-error=""wrong"" data-success=""right"" for=""defaultForm-pass"">Last Name</label>
                                                        <input type=""text"" id=""defaultForm-pass"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 3014, "", 3096, 1);
#line 43 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 3021, UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.LastName, 3021, 75, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3096, 460, true);
            WriteLiteral(@">
                                                    </div>

                                                    <div class=""md-form mb-4"">
                                                        <i class=""fas fa-lock prefix grey-text""></i><label data-error=""wrong"" data-success=""right"" for=""defaultForm-pass"">Last Name</label>
                                                        <input type=""text"" id=""defaultForm-pass"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 3556, "", 3641, 1);
#line 48 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 3563, UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.PhoneNumber, 3563, 78, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3641, 609, true);
            WriteLiteral(@">
                                                        <label data-error=""wrong"" data-success=""right"" for=""defaultForm-pass"">Your password</label>
                                                    </div>

                                                    <div class=""md-form mb-4"">
                                                        <i class=""fas fa-lock prefix grey-text""></i><label data-error=""wrong"" data-success=""right"" for=""defaultForm-pass"">Last Name</label>
                                                        <input type=""date"" id=""defaultForm-pass"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 4250, "", 4335, 1);
#line 54 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 4257, UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.DateOfBirth, 4257, 78, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4335, 1229, true);
            WriteLiteral(@">
                                                        <label data-error=""wrong"" data-success=""right"" for=""defaultForm-pass"">Your password</label>
                                                    </div>

                                                </div>
                                                <div class=""modal-footer d-flex justify-content-center"">
                                                    <button class=""btn btn-default"">Login</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""text-center"">
                                        <a class=""btn btn-outline-primary"" href="""" data-toggle=""modal"" data-target=""#modalLoginForm"">
                                            Change Personal Data
                                        </a>
                                    ");
            WriteLiteral("</div>\r\n                                </th>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>First Name</td>\r\n                                <td>");
            EndContext();
            BeginContext(5565, 75, false);
#line 75 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                               Write(UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(5640, 164, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Last Name</td>\r\n                                <td>");
            EndContext();
            BeginContext(5805, 74, false);
#line 79 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                               Write(UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(5879, 168, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Date of Birth</td>\r\n                                <td>");
            EndContext();
            BeginContext(6048, 82, false);
#line 83 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                               Write(UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.DateOfBirth.Date);

#line default
#line hidden
            EndContext();
            BeginContext(6130, 167, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Number Phone</td>\r\n                                <td>");
            EndContext();
            BeginContext(6298, 77, false);
#line 87 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                               Write(UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(6375, 160, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>EMail</td>\r\n                                <td>");
            EndContext();
            BeginContext(6536, 71, false);
#line 91 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                               Write(UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.Email);

#line default
#line hidden
            EndContext();
            BeginContext(6607, 1464, true);
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <th>Account Data</th>
                                <th>
                                    <div class=""modal fade"" id=""modalRegisterForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
                                         aria-hidden=""true"">
                                        <div class=""modal-dialog"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header text-center"">
                                                    <h4 class=""modal-title w-100 font-weight-bold"">Sign up</h4>
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
  ");
            WriteLiteral(@"                                              </div>
                                                <div class=""modal-body mx-3"">
                                                    <div class=""md-form mb-5"">
                                                        <i class=""fas fa-user prefix grey-text""></i>
                                                        <input type=""text"" id=""orangeForm-name"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 8071, "", 8150, 1);
#line 109 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 8078, UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.Email, 8078, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8150, 520, true);
            WriteLiteral(@">
                                                        <label data-error=""wrong"" data-success=""right"" for=""orangeForm-name"">Your name</label>
                                                    </div>
                                                    <div class=""md-form mb-5"">
                                                        <i class=""fas fa-envelope prefix grey-text""></i>
                                                        <input type=""email"" id=""orangeForm-email"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 8670, "", 8756, 1);
#line 114 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 8677, UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.PasswordHash, 8677, 79, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8756, 1227, true);
            WriteLiteral(@">
                                                        <label data-error=""wrong"" data-success=""right"" for=""orangeForm-email"">Your email</label>
                                                    </div>
                                                </div>
                                                <div class=""modal-footer d-flex justify-content-center"">
                                                    <button class=""btn btn-deep-orange"">Sign up</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""text-center"">
                                        <a href="""" class=""btn btn-outline-primary"" data-toggle=""modal"" data-target=""#modalRegisterForm"">
                                            Change Account Data
                                        </a>
                                 ");
            WriteLiteral("   </div>\r\n                                </th>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Login</td>\r\n                                <td>");
            EndContext();
            BeginContext(9984, 71, false);
#line 134 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                               Write(UserManager.FindByNameAsync(UserManager.GetUserName(User)).Result.Email);

#line default
#line hidden
            EndContext();
            BeginContext(10055, 628, true);
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td>Password</td>
                                <td>********</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>
                                    <button class=""btn btn-danger"">Delete Account</button>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<App.Data.Domain.DomainModels.Identity.User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
