#pragma checksum "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f9e5c97d5795b53b3971df208a7440fc180a31e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Edit), @"mvc.1.0.view", @"/Views/User/Edit.cshtml")]
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
#line 1 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\_ViewImports.cshtml"
using HealthyDuty.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\_ViewImports.cshtml"
using HealthyDuty.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
using HealthyDuty.Web.Business.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
using HealthyDuty.Web.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f9e5c97d5795b53b3971df208a7440fc180a31e", @"/Views/User/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51073bfce0c006a10793f9531a5fe23a33242194", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthyDuty.Web.Models.User.AddViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/List"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
  
    ViewData["Title"] = "User Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <strong> User Edit </strong>\r\n            </div>\r\n            <div class=\"card-body\">\r\n\r\n");
#nullable restore
#line 17 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                 using (Html.BeginForm("Edit", "User", FormMethod.Post, new { @class = "form-horizontal input-sm" }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
               Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-2 col-form-label\">Name</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 23 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Name, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <label class=\"col-md-2 col-form-label\">Last Name</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 28 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 29 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.LastName, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-2 col-form-label\">Phone</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 36 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Phone, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 37 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Phone, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <label class=\"col-md-2 col-form-label\">Age</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Age, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 42 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Age, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-2 col-form-label\">Email</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 49 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 50 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Email, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <label class=\"col-md-2 col-form-label\">Sex</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.DropDownListFor(m => m.SexId, Model.SexSelectList, "Select", new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 55 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.SexId, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-2 col-form-label\">User Name</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 62 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 63 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.UserName, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <label class=\"col-md-2 col-form-label\">Password</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 67 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 68 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Password, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-2 col-form-label\">Blood Group</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 75 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.DropDownListFor(m => m.BloodGroupId, Model.BloodGroupSelectList, "Select", new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 76 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.BloodGroupId, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <label class=\"col-md-2 col-form-label\">City</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 80 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.DropDownListFor(m => m.CityCode, Model.CitySelectList, "Select", new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 81 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.CityCode, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral(@"                    <div class=""form-group row"">
                        <div class=""col-md-12"">
                            <button class=""btn btn-sm btn-primary"" type=""submit"" id=""btnSubmit"" name=""SubmitType"" value=""Edit"">
                                <i class=""fa fa-dot-circle-o""></i>Save
                            </button>
                            &nbsp;
");
            WriteLiteral("                            &nbsp;\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f9e5c97d5795b53b3971df208a7440fc180a31e15053", async() => {
                WriteLiteral("\r\n                                <i class=\"fa fa-ban\"></i> Cancel\r\n                            ");
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
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-md-12\">\r\n\r\n");
#nullable restore
#line 109 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                             if (ViewBag.ErrorMessage != null && !string.IsNullOrEmpty(ViewBag.ErrorMessage))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"text-danger\">\r\n                                    ");
#nullable restore
#line 112 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                               Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 114 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                             if (ViewBag.ErrorMessageList != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"text-danger\">\r\n");
#nullable restore
#line 118 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                                     foreach (var item in ViewBag.ErrorMessageList)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>");
#nullable restore
#line 120 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                                         Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <br />\r\n");
#nullable restore
#line 122 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 124 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 128 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\User\Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <!-- /.col-->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthyDuty.Web.Models.User.AddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
