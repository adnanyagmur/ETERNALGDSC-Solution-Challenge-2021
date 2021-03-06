#pragma checksum "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9b0c2227da5c7fcafb59c6f2f7612b23378d416"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_List), @"mvc.1.0.view", @"/Views/Profile/List.cshtml")]
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
#line 1 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
using HealthyDuty.Web.Business.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
using HealthyDuty.Web.Business.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
using HealthyDuty.Web.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9b0c2227da5c7fcafb59c6f2f7612b23378d416", @"/Views/Profile/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51073bfce0c006a10793f9531a5fe23a33242194", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthyDuty.Web.Models.Profile.ListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Profile/Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
  
    ViewData["Title"] = "Profile List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <i class=\"fa fa-align-justify\"></i> Profile List\r\n\r\n");
#nullable restore
#line 17 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                 if (SessionHelper.CheckAuthForCurrentUser(AuthCodeStatic.PAGE_PROFILE_ADD))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>- </span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b0c2227da5c7fcafb59c6f2f7612b23378d4165690", async() => {
                WriteLiteral(" New Record");
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
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"card-body\">\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12\">\r\n\r\n");
#nullable restore
#line 27 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                         using (Html.BeginForm("List", "Profile", FormMethod.Post, new { @class = "form-horizontal input-sm", @id = "filterForm" }))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!-- form get\'te submit yapilirken page bilgisi ve siralama bilgisinin tutulmasi icin -->\r\n");
#nullable restore
#line 30 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                       Write(Html.HiddenFor(m => m.PageSize, new { @id = "hiddenPageSize" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                                                                            ;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                       Write(Html.HiddenFor(m => m.CurrentPage, new { @id = "hiddenCurrentPage" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                                                                                  ;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                       Write(Html.HiddenFor(m => m.SortOn, new { @id = "hiddenSortOn" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                       Write(Html.HiddenFor(m => m.SortDirection, new { @id = "hiddenSortDirection" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-group row\">\r\n                                <label class=\"col-md-2 col-form-label\">Code</label>\r\n                                <div class=\"col-md-4\">\r\n                                    ");
#nullable restore
#line 38 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                               Write(Html.TextBoxFor(m => m.Filter.Filter_Code, new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 39 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Filter.Filter_Code, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <label class=\"col-md-2 col-form-label\">Name</label>\r\n                                <div class=\"col-md-4\">\r\n                                    ");
#nullable restore
#line 44 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                               Write(Html.TextBoxFor(m => m.Filter.Filter_Name, new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 45 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Filter.Filter_Name, null, new { @class = "help-block text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
            WriteLiteral(@"                            <div class=""form-group row"">
                                <div class=""col-md-12"">
                                    <button class=""btn btn-sm btn-primary"" type=""submit"" name=""SubmitType"" value=""List"">
                                        <i class=""fa fa-search""></i> List
                                    </button>
                                    <hr />
                                </div>
                            </div>
");
#nullable restore
#line 57 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"text-left small\">\r\n                    Total Count: ");
#nullable restore
#line 63 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                            Write(Model.DataList.TotalCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Displaying Records: ");
#nullable restore
#line 63 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                                                           Write(Model.DataList.From);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 63 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                                                                                  Write(Model.DataList.To);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"float-right\">\r\n                        <span>Page Size:</span> ");
#nullable restore
#line 65 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                           Write(Html.TextBox("txtPageSize", "", new { @class = "form-control form-control-sm d-inline-block onlyNumberEntry", @id = "txtPageSize", @style = " width:50px; height:calc(1.5em + 0.5rem - 2px);" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""table-responsive"">
                    <table class=""table table-responsive-sm table-bordered table-striped table-sm"">
                        <thead>
                            <tr>
");
#nullable restore
#line 73 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                 if (SessionHelper.CheckAuthForCurrentUser(AuthCodeStatic.PAGE_PROFILE_EDIT))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <th>*</th>\r\n");
#nullable restore
#line 76 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th>\r\n                                    <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4096, "\"", 4186, 3);
            WriteAttributeValue("", 4106, "ClickSorting(\'Code\',\'", 4106, 21, true);
#nullable restore
#line 78 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
WriteAttributeValue("", 4127, Model.DataList.SortDirection == "ASC" ? "DESC" : "ASC", 4127, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4184, "\')", 4184, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        Code\r\n");
#nullable restore
#line 80 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                         if (Model.DataList.SortOn == "Code")
                                        {
                                            if (Model.DataList.SortDirection == "ASC")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fa fa-angle-up\"></i> ");
#nullable restore
#line 83 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-angle-down\"></i>");
#nullable restore
#line 85 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                                                              }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </a>\r\n                                </th>\r\n\r\n                                <th>\r\n                                    <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4884, "\"", 4974, 3);
            WriteAttributeValue("", 4894, "ClickSorting(\'Name\',\'", 4894, 21, true);
#nullable restore
#line 91 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
WriteAttributeValue("", 4915, Model.DataList.SortDirection == "ASC" ? "DESC" : "ASC", 4915, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4972, "\')", 4972, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        Name\r\n");
#nullable restore
#line 93 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                         if (Model.DataList.SortOn == "Name")
                                        {
                                            if (Model.DataList.SortDirection == "ASC")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fa fa-angle-up\"></i> ");
#nullable restore
#line 96 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-angle-down\"></i>");
#nullable restore
#line 98 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                                                              }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </a>\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n\r\n");
#nullable restore
#line 106 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                             foreach (var item in Model.DataList.Items)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n");
#nullable restore
#line 110 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                     if (SessionHelper.CheckAuthForCurrentUser(AuthCodeStatic.PAGE_PROFILE_EDIT))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b0c2227da5c7fcafb59c6f2f7612b23378d41619662", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6099, "~/Profile/Edit/", 6099, 15, true);
#nullable restore
#line 113 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
AddHtmlAttributeValue("", 6114, item.Id, 6114, 8, false);

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
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 115 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <td>");
#nullable restore
#line 117 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                   Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 118 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 120 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n\r\n\r\n                <nav>\r\n\r\n                    ");
#nullable restore
#line 130 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
               Write(await Html.PartialAsync("_PagingPartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </nav>\r\n\r\n");
#nullable restore
#line 133 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                 if (ViewBag.ErrorMessage != null && !string.IsNullOrEmpty(ViewBag.ErrorMessage))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"text-danger\">\r\n                        ");
#nullable restore
#line 136 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                   Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 138 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                 if (ViewBag.ErrorMessageList != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"text-danger\">\r\n");
#nullable restore
#line 142 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                         foreach (var item in ViewBag.ErrorMessageList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 144 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                             Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <br />\r\n");
#nullable restore
#line 146 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 148 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- /.col-->\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <!-- pagesize ve current page js  -->
    <script>
        $(document).ready(function(){
            $('#txtPageSize').keyup(function () {
                $('#hiddenPageSize').val($('#txtPageSize').val());
            });

            $('#txtPageSize').val(");
#nullable restore
#line 164 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                              Write((Model.PageSize));

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n\r\n            $(\'#txtCurrentPage\').keyup(function () {\r\n                $(\'#hiddenCurrentPage\').val($(\'#txtCurrentPage\').val());\r\n            });\r\n\r\n            $(\'#txtCurrentPage\').val(");
#nullable restore
#line 170 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Profile\List.cshtml"
                                 Write((Model.CurrentPage));

#line default
#line hidden
#nullable disable
                WriteLiteral(@");

            $("".onlyNumberEntry"").keypress(function (e) {
                if (e.which == 13) {
                    $('#filterForm').submit();
                }
                if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                return false;
                }
            });
        }); // end of $(document).ready


        function ClickSorting(sortOn, sortDirection) {
            $('#hiddenSortOn').val(sortOn);
            $('#hiddenSortDirection').val(sortDirection);
            //$(""#btnSorting"").click();
            $('#filterForm').submit();
        }

        function ClickPaging(currentPage, pageSize) {
            $('#hiddenCurrentPage').val(currentPage);
            $('#hiddenPageSize').val(pageSize);
            //$(""#btnPaging"").click();
            $('#filterForm').submit();
        }
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthyDuty.Web.Models.Profile.ListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
