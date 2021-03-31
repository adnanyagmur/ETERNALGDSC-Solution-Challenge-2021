#pragma checksum "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b2ac5874ed0d52c925a98f440ac0a2e6fefca83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personnel_Add), @"mvc.1.0.view", @"/Views/Personnel/Add.cshtml")]
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
#line 1 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
using HealthyDuty.Web.Business.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
using HealthyDuty.Web.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b2ac5874ed0d52c925a98f440ac0a2e6fefca83", @"/Views/Personnel/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51073bfce0c006a10793f9531a5fe23a33242194", @"/Views/_ViewImports.cshtml")]
    public class Views_Personnel_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthyDuty.Web.Models.Personnel.AddViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Personnel/List"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
  
    ViewData["Title"] = "Personnel Add";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <strong>Personnel Add</strong>\r\n            </div>\r\n            <div class=\"card-body\">\r\n\r\n");
#nullable restore
#line 18 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                 using (Html.BeginForm("Add", "Personnel", FormMethod.Post, new { @class = "form-horizontal input-sm" }))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-2 col-form-label\">Hospital</label>\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.DropDownListFor(m => m.HospitalId, Model.HospitalSelectList, "Select", new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 25 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.ValidationMessageFor(m => m.HospitalId, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-2 col-form-label\">TC</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 32 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.TextBoxFor(m => m.TC, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 33 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.ValidationMessageFor(m => m.TC, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <label class=\"col-md-2 col-form-label\">Phone</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 38 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.TextBoxFor(m => m.Phone, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 39 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Phone, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-2 col-form-label\">Name</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 46 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 47 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Name, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <label class=\"col-md-2 col-form-label\">Last Name</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 52 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 53 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.ValidationMessageFor(m => m.LastName, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-2 col-form-label\">User Name</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 60 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 61 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.ValidationMessageFor(m => m.UserName, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <label class=\"col-md-2 col-form-label\">Password</label>\r\n                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 66 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 67 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Password, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-2 col-form-label\">Address</label>\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 74 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.TextAreaFor(m => m.Address, 5, 20, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 75 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Address, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral(@"                    <div class=""form-group row"">
                        <div class=""col-md-12"">
                            <button class=""btn btn-sm btn-primary"" type=""submit"" id=""btnSubmit"">
                                <i class=""fa fa-dot-circle-o""></i> Save
                            </button>
                            &nbsp;
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b2ac5874ed0d52c925a98f440ac0a2e6fefca8313098", async() => {
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
#line 94 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                             if (ViewBag.ErrorMessage != null && !string.IsNullOrEmpty(ViewBag.ErrorMessage))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"text-danger\">\r\n                                    ");
#nullable restore
#line 97 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                               Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 99 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                             if (ViewBag.ErrorMessageList != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"text-danger\">\r\n");
#nullable restore
#line 103 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                                     foreach (var item in ViewBag.ErrorMessageList)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>");
#nullable restore
#line 105 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                                         Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <br />\r\n");
#nullable restore
#line 107 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 109 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 113 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Personnel\Add.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <!-- /.col-->\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthyDuty.Web.Models.Personnel.AddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
