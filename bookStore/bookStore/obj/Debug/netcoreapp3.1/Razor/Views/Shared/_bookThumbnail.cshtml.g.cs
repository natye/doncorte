#pragma checksum "C:\Users\HP\source\repos\doncorte\new\bookStore\bookStore\Views\Shared\_bookThumbnail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df2d3d24c94cfafe949ba3658fd1998effdadbeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__bookThumbnail), @"mvc.1.0.view", @"/Views/Shared/_bookThumbnail.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\doncorte\new\bookStore\bookStore\Views\_ViewImports.cshtml"
using bookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2d3d24c94cfafe949ba3658fd1998effdadbeb", @"/Views/Shared/_bookThumbnail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"462edd2c63424b6eb987eebddee00e57f484a720", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__bookThumbnail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\source\repos\doncorte\new\bookStore\bookStore\Views\Shared\_bookThumbnail.cshtml"
  
    ViewData["Title"] = "Book Detail" + Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-4 shadow-sm\">\r\n    <img class=\"bd-placeholder-img card-img-top\" width=\"100\" height=\"225\"");
            BeginWriteAttribute("src", " src=\"", 187, "\"", 213, 1);
#nullable restore
#line 6 "C:\Users\HP\source\repos\doncorte\new\bookStore\bookStore\Views\Shared\_bookThumbnail.cshtml"
WriteAttributeValue("", 193, Model.CoverImageUrl, 193, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\HP\source\repos\doncorte\new\bookStore\bookStore\Views\Shared\_bookThumbnail.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <p class=""card-text"">description@Model.Description</p>
    <div class=""d-flex justify-content-between align-items-center"">
        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Details</a>
    </div>
    <small class="" text-muted"">Auther Name</small>



</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591