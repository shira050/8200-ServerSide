#pragma checksum "C:\Users\user\Desktop\8200 shiraChadad\8200HW\8200HW\Pages\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0906750319c55d6ce48b545e707c28c2eb4094c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_8200HW.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
namespace _8200HW.Pages
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
#line 1 "C:\Users\user\Desktop\8200 shiraChadad\8200HW\8200HW\Pages\_ViewImports.cshtml"
using _8200HW;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0906750319c55d6ce48b545e707c28c2eb4094c", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe832a08bed259c6574bc849ce9eab8a5db9a16", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\8200 shiraChadad\8200HW\8200HW\Pages\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\user\Desktop\8200 shiraChadad\8200HW\8200HW\Pages\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
