#pragma checksum "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d228cc277bb5f62ed1dce48cfe63c263627ae83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProfilePersonnel__PagingPartialPersonnelList), @"mvc.1.0.view", @"/Views/ProfilePersonnel/_PagingPartialPersonnelList.cshtml")]
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
#line 2 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
using HealthyDuty.Web.Business.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d228cc277bb5f62ed1dce48cfe63c263627ae83", @"/Views/ProfilePersonnel/_PagingPartialPersonnelList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51073bfce0c006a10793f9531a5fe23a33242194", @"/Views/_ViewImports.cshtml")]
    public class Views_ProfilePersonnel__PagingPartialPersonnelList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthyDuty.Web.Models.ProfilePersonnel.BatchEditViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul class=\"pagination pagination-sm\">\r\n");
#nullable restore
#line 6 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
     if (Model.PersonnelList.DataList.HasPreviousPage)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link btn-info\" href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 312, "\"", 432, 5);
            WriteAttributeValue("", 322, "ClickPagingPersonnel(\'", 322, 22, true);
#nullable restore
#line 9 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
WriteAttributeValue("", 344, Model.PersonnelList.DataList.CurrentPage-1, 344, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 389, "\',\'", 389, 3, true);
#nullable restore
#line 9 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
WriteAttributeValue("", 392, Model.PersonnelList.DataList.PageSize, 392, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 430, "\')", 430, 2, true);
            EndWriteAttribute();
            WriteLiteral("> Previous </a>\r\n        </li>\r\n");
#nullable restore
#line 11 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
     for (int paginationIndex = Model.PersonnelList.DataList.CurrentPage - 3; paginationIndex < Model.PersonnelList.DataList.CurrentPage; paginationIndex++)
    {
        if (paginationIndex <= 0)
        {
            continue;
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link\" href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 811, "\"", 904, 5);
            WriteAttributeValue("", 821, "ClickPagingPersonnel(\'", 821, 22, true);
#nullable restore
#line 21 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
WriteAttributeValue("", 843, paginationIndex, 843, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 861, "\',\'", 861, 3, true);
#nullable restore
#line 21 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
WriteAttributeValue("", 864, Model.PersonnelList.DataList.PageSize, 864, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 902, "\')", 902, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
                                                                                                                                                     Write(paginationIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n");
#nullable restore
#line 23 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <li class=\"page-item active\">\r\n        <a class=\"page-link\" href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1043, "\"", 1161, 5);
            WriteAttributeValue("", 1053, "ClickPagingPersonnel(\'", 1053, 22, true);
#nullable restore
#line 26 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
WriteAttributeValue("", 1075, Model.PersonnelList.DataList.CurrentPage, 1075, 43, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1118, "\',\'", 1118, 3, true);
#nullable restore
#line 26 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
WriteAttributeValue("", 1121, Model.PersonnelList.DataList.PageSize, 1121, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1159, "\')", 1159, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
                                                                                                                                                                          Write(Model.PersonnelList.DataList.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </li>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
     for (int paginationIndex = Model.PersonnelList.DataList.CurrentPage + 1; paginationIndex < Model.PersonnelList.DataList.TotalPages + 1; paginationIndex++)
    {
        if (paginationIndex > Model.PersonnelList.DataList.TotalPages || paginationIndex > (Model.PersonnelList.DataList.CurrentPage + 3))
        {
            break;
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link\" href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1667, "\"", 1760, 5);
            WriteAttributeValue("", 1677, "ClickPagingPersonnel(\'", 1677, 22, true);
#nullable restore
#line 37 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
WriteAttributeValue("", 1699, paginationIndex, 1699, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1717, "\',\'", 1717, 3, true);
#nullable restore
#line 37 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
WriteAttributeValue("", 1720, Model.PersonnelList.DataList.PageSize, 1720, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1758, "\')", 1758, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
                                                                                                                                                     Write(paginationIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n");
#nullable restore
#line 39 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
     if (Model.PersonnelList.DataList.HasNextPage)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link btn-info\" href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1968, "\"", 2088, 5);
            WriteAttributeValue("", 1978, "ClickPagingPersonnel(\'", 1978, 22, true);
#nullable restore
#line 44 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
WriteAttributeValue("", 2000, Model.PersonnelList.DataList.CurrentPage+1, 2000, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2045, "\',\'", 2045, 3, true);
#nullable restore
#line 44 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
WriteAttributeValue("", 2048, Model.PersonnelList.DataList.PageSize, 2048, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2086, "\')", 2086, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n        </li>\r\n");
#nullable restore
#line 46 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <li class=\"page-item\">\r\n        <span class=\"small\">&nbsp;Current Size</span> ");
#nullable restore
#line 49 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
                                                 Write(Html.TextBox("txtPersonnelCurrentPage", "", new { @class = "form-control form-control-sm d-inline-block onlyNumberEntry", @id = "txtPersonnelCurrentPage", @style = "width:60px; height:calc(1.5em + 0.5rem - 2px); " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n\r\n    <li class=\"page-item\">\r\n        <span class=\"small\">&nbsp; Total Pages: ");
#nullable restore
#line 53 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\ProfilePersonnel\_PagingPartialPersonnelList.cshtml"
                                           Write(Model.PersonnelList.DataList.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n    </li>\r\n\r\n</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthyDuty.Web.Models.ProfilePersonnel.BatchEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591