#pragma checksum "/Users/john/Projects/Invoicing/Invoicing/Views/Company/Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87bc200d9ccee722298170708dd0bd3270b03162"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Add), @"mvc.1.0.view", @"/Views/Company/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/Add.cshtml", typeof(AspNetCore.Views_Company_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bc200d9ccee722298170708dd0bd3270b03162", @"/Views/Company/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecfe7c34b0db7fd3e96965e793dcfb0b92c3872f", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/john/Projects/Invoicing/Invoicing/Views/Company/Add.cshtml"
  
    ViewData["Title"] = Html.DisplayTextFor(model => model.CreateText);

#line default
#line hidden
            BeginContext(103, 55, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(159, 46, false);
#line 8 "/Users/john/Projects/Invoicing/Invoicing/Views/Company/Add.cshtml"
                     Write(Html.DisplayTextFor(model => model.CreateText));

#line default
#line hidden
            EndContext();
            BeginContext(205, 133, true);
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col col-sm-4\"></div>\r\n    <div class=\"col col-sm-4\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 15 "/Users/john/Projects/Invoicing/Invoicing/Views/Company/Add.cshtml"
             using (Html.BeginForm(Model.AddForm.Action, Model.AddForm.Controller))
            {
                

#line default
#line hidden
#line 17 "/Users/john/Projects/Invoicing/Invoicing/Views/Company/Add.cshtml"
                 foreach (var property in ViewData.ModelMetadata.Properties.Where(p => p.DisplayName != null))
                {

#line default
#line hidden
            BeginContext(569, 150, true);
            WriteLiteral("                        <div class=\"form-group form-inline\">\r\n                            <div class=\"col col-sm-6\">\r\n                                ");
            EndContext();
            BeginContext(720, 32, false);
#line 21 "/Users/john/Projects/Invoicing/Invoicing/Views/Company/Add.cshtml"
                           Write(Html.Label(property.DisplayName));

#line default
#line hidden
            EndContext();
            BeginContext(752, 126, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col col-sm-6\">\r\n                                ");
            EndContext();
            BeginContext(879, 34, false);
#line 24 "/Users/john/Projects/Invoicing/Invoicing/Views/Company/Add.cshtml"
                           Write(Html.Editor(property.PropertyName));

#line default
#line hidden
            EndContext();
            BeginContext(913, 70, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 27 "/Users/john/Projects/Invoicing/Invoicing/Views/Company/Add.cshtml"
                }

#line default
#line hidden
            BeginContext(1021, 38, false);
#line 29 "/Users/john/Projects/Invoicing/Invoicing/Views/Company/Add.cshtml"
           Write(await Html.PartialAsync("SaveButtons"));

#line default
#line hidden
            EndContext();
#line 29 "/Users/john/Projects/Invoicing/Invoicing/Views/Company/Add.cshtml"
                                                       
            }

#line default
#line hidden
            BeginContext(1076, 72, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col col-sm-4\"></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
