#pragma checksum "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d3eb459e34b9901bcae76e7190f4f6e100a65a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Index), @"mvc.1.0.view", @"/Views/Actors/Index.cshtml")]
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
#line 1 "C:\Users\Guruprasad\source\repos\eTickets\Views\_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guruprasad\source\repos\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d3eb459e34b9901bcae76e7190f4f6e100a65a8", @"/Views/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Actors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Actor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml"
   
    ViewData["Title"] = "List Of Actors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-10 offset-md-2\">\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr  class=\"text-center\">\r\n                <th>");
#nullable restore
#line 15 "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ProfilePictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 16 "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 17 "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Actions</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"align-middle\">\r\n                    <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 704, "\"", 733, 1);
#nullable restore
#line 26 "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml"
WriteAttributeValue("", 710, item.ProfilePictureURL, 710, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 734, "\"", 754, 1);
#nullable restore
#line 26 "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml"
WriteAttributeValue("", 740, item.FullName, 740, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\r\n                </td>\r\n                <td class=\"align-middle\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"align-middle\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
                <td class=""align-middle"">
                    <a class=""btn btn-outline-primary""><i class=""bi bi-pencil-square""></i> Edit </a> |
                    <a class=""btn btn-outline-info""><i class=""bi bi-eye""></i> Details </a> |
                    <a class=""btn btn-danger text-white""><i class=""bi bi-trash""></i> Delete </a>
                </td>                
            </tr>
");
#nullable restore
#line 40 "C:\Users\Guruprasad\source\repos\eTickets\Views\Actors\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>  \r\n\r\n    </table>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Actor>> Html { get; private set; }
    }
}
#pragma warning restore 1591