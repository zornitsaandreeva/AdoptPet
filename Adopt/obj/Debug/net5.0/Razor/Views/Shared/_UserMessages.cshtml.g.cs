#pragma checksum "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cfe5458818e96bb7e244aef7904db5150f7a622"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserMessages), @"mvc.1.0.view", @"/Views/Shared/_UserMessages.cshtml")]
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
#line 1 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\_ViewImports.cshtml"
using Adopt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\_ViewImports.cshtml"
using Adopt.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml"
using Adopt.Core.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cfe5458818e96bb7e244aef7904db5150f7a622", @"/Views/Shared/_UserMessages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de996a3610d002c7e4696af295ed98f3b4dfbb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UserMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml"
 if (ViewData[MessageConstant.ErrorMessage] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n           $(function () {\r\n                 toastr.error(\'");
#nullable restore
#line 7 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml"
                          Write(ViewData[MessageConstant.ErrorMessage]?.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n            });\r\n    </script>\r\n");
#nullable restore
#line 10 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml"
 if (ViewData[MessageConstant.SucessMessage] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n           $(function () {\r\n                  toastr.success(\'");
#nullable restore
#line 16 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml"
                             Write(ViewData[MessageConstant.SucessMessage]?.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n            });\r\n    </script>\r\n");
#nullable restore
#line 19 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml"
 if (ViewData[MessageConstant.WarningMessage] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n          $(function () {\r\n                 toastr.warning(\'");
#nullable restore
#line 25 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml"
                            Write(ViewData[MessageConstant.WarningMessage]?.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n          });\r\n    </script>\r\n");
#nullable restore
#line 28 "D:\Soft Uni\Web\ASP.NET\Adopt\AdoptPet\Adopt\Views\Shared\_UserMessages.cshtml"
}

#line default
#line hidden
#nullable disable
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
