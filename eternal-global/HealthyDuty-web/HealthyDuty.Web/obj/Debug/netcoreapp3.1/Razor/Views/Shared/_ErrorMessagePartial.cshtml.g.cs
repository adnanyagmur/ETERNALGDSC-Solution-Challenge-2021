#pragma checksum "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Shared\_ErrorMessagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b50d30b8f57fd864bee47559a22b052b97c64a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ErrorMessagePartial), @"mvc.1.0.view", @"/Views/Shared/_ErrorMessagePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b50d30b8f57fd864bee47559a22b052b97c64a7", @"/Views/Shared/_ErrorMessagePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51073bfce0c006a10793f9531a5fe23a33242194", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ErrorMessagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<script>\r\n    $(function () {\r\n        if (\'");
#nullable restore
#line 4 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Shared\_ErrorMessagePartial.cshtml"
        Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' != \"\") {\r\n            $(\'#errorModal\').modal(\'show\');\r\n        }\r\n    });\r\n\r\n</script>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Shared\_ErrorMessagePartial.cshtml"
         if (ViewBag.ErrorMessage != null && !string.IsNullOrEmpty(ViewBag.ErrorMessage))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!-- The Modal -->
            <div class=""modal"" id=""errorModal"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"">

                        <!-- Modal Header -->
                        <div class=""modal-header"">
                            <h4 class=""modal-title"">Hata Oluştu!</h4>
                            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        </div>

                        <!-- Modal body -->
                        <div class=""modal-body"">
                            ");
#nullable restore
#line 29 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Shared\_ErrorMessagePartial.cshtml"
                       Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                        <!-- Modal footer -->
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                        </div>

                    </div>
                </div>
            </div>
");
#nullable restore
#line 40 "C:\Users\sinem\OneDrive\Masaüstü\HealthyDuty\HealthyDuty.Web\Views\Shared\_ErrorMessagePartial.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
