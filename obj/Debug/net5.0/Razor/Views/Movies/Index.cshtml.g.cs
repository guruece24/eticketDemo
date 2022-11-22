#pragma checksum "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ae8f65063c7e4828b25b94f004eaafeed54f6b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ae8f65063c7e4828b25b94f004eaafeed54f6b0", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "List Of Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
   foreach (var item in Model)
  {      

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      <div class=""col-md-4 col-xs-6 col-lg-4 border-primary mb-3"">
          <div class=""card mb-3"" style=""max-width: 540px;"">
              <div class=""row g-0"">
                  <div class=""col-md-12"">
                      <div class=""card-header text-white bg-info"">
                          <p class=""card-text"">
                              <h5 class=""card-title"">
                                  ");
#nullable restore
#line 19 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                  <a class=""text-white float-right""><i class=""bi bi-pencil-square""></i></a>
                              </h5>
                          </p>
                      </div>
                  </div>

                  <div class=""col-md-6"">
                      <img");
            BeginWriteAttribute("src", " src=\"", 878, "\"", 898, 1);
#nullable restore
#line 27 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 884, item.ImageURL, 884, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 912, "\"", 928, 1);
#nullable restore
#line 27 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 918, item.Name, 918, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                  </div>\r\n\r\n                  <div class=\"col-md-6\">\r\n                      <div class=\"card-body\">\r\n                          <p class=\"card-text\">");
#nullable restore
#line 32 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
                                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                          <p class=\"card-text\"><b>Cinema: </b>");
#nullable restore
#line 33 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
                                                         Write(item.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                          <p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 34 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
                                                           Write(item.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                          <p class=\"card-text\"><b>Start Date: </b>");
#nullable restore
#line 35 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
                                                             Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                          <p class=\"card-text\"><b>End Date: </b>");
#nullable restore
#line 36 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
                                                           Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                          <p class=\"card-text\">\r\n                              <b>Status: </b>\r\n");
#nullable restore
#line 39 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
                               if(DateTime.Now >= @item.StartDate && DateTime.Now <= @item.EndDate)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-success text-white\">AVAILABLE</span>\r\n");
#nullable restore
#line 42 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
                              }
                              else
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-primary text-white\">UPCOMING</span>\r\n");
#nullable restore
#line 46 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                          </p>
                      </div>
                  </div>

                  <div class=""col-md-12"">
                      <div class=""card-footer"">
                          <p class=""card-text"">
                              <a class=""btn btn-outline-primary float-right""><i class=""bi bi-eye-fill""></i> Show Details</a>
                              <a class=""btn btn-success text-white""><i class=""bi bi-cart-plus""></i>Add to Cart ($X.XX)</a>
                          </p>
                      </div>
                  </div>
               </div>
           </div>
      </div>
");
#nullable restore
#line 62 "C:\Users\Guruprasad\source\repos\eTickets\Views\Movies\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
