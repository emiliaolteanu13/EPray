#pragma checksum "C:\Users\HP\Documents\EPray\EPray\Views\Home\GetPrayers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64deed0f16b6ccd8db0d10e8caf693c3657223ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetPrayers), @"mvc.1.0.view", @"/Views/Home/GetPrayers.cshtml")]
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
#line 1 "C:\Users\HP\Documents\EPray\EPray\Views\_ViewImports.cshtml"
using EPray;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\EPray\EPray\Views\_ViewImports.cshtml"
using EPray.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64deed0f16b6ccd8db0d10e8caf693c3657223ca", @"/Views/Home/GetPrayers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c742fb1c15d4066fcd64deb56e2c2b571be95bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetPrayers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EPray.Models.PrayerModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Documents\EPray\EPray\Views\Home\GetPrayers.cshtml"
  
    ViewData["Title"] = "GetPrayers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Christian Prayers</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\HP\Documents\EPray\EPray\Views\Home\GetPrayers.cshtml"
           Write(Html.DisplayNameFor(model => model.Lyrics));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\HP\Documents\EPray\EPray\Views\Home\GetPrayers.cshtml"
           Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\HP\Documents\EPray\EPray\Views\Home\GetPrayers.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\HP\Documents\EPray\EPray\Views\Home\GetPrayers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Lyrics.ToString().Substring(0,16)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\HP\Documents\EPray\EPray\Views\Home\GetPrayers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\HP\Documents\EPray\EPray\Views\Home\GetPrayers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EPray.Models.PrayerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
