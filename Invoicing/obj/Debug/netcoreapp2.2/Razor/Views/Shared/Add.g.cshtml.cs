#pragma checksum "/Users/john/Projects/Invoicing/Invoicing/Views/Shared/Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c20fa1fae7e04b4c9466bb93ac8d0a043f84161f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Add), @"mvc.1.0.view", @"/Views/Shared/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Add.cshtml", typeof(AspNetCore.Views_Shared_Add))]
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
#line 1 "/Users/john/Projects/Invoicing/Invoicing/Views/_ViewImports.cshtml"
using Invoicing;

#line default
#line hidden
#line 2 "/Users/john/Projects/Invoicing/Invoicing/Views/_ViewImports.cshtml"
using Invoicing.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c20fa1fae7e04b4c9466bb93ac8d0a043f84161f", @"/Views/Shared/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecfe7c34b0db7fd3e96965e793dcfb0b92c3872f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BaseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(21, 43, false);
#line 3 "/Users/john/Projects/Invoicing/Invoicing/Views/Shared/Add.cshtml"
Write(await Html.PartialAsync("EditModel", Model));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BaseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
