#pragma checksum "C:\Tugas6_358\Blazor\BlazorFrontend_358\Pages\DetailDepartment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3704696eede917383985ee7d9900b5b5162832c2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFrontend_358.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Tugas6_358\Blazor\BlazorFrontend_358\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Tugas6_358\Blazor\BlazorFrontend_358\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Tugas6_358\Blazor\BlazorFrontend_358\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Tugas6_358\Blazor\BlazorFrontend_358\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Tugas6_358\Blazor\BlazorFrontend_358\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Tugas6_358\Blazor\BlazorFrontend_358\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Tugas6_358\Blazor\BlazorFrontend_358\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Tugas6_358\Blazor\BlazorFrontend_358\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Tugas6_358\Blazor\BlazorFrontend_358\_Imports.razor"
using BlazorFrontend_358;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Tugas6_358\Blazor\BlazorFrontend_358\_Imports.razor"
using BlazorFrontend_358.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/departmentdetail/{id}")]
    public partial class DetailDepartment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Department List</h1><br>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card border-secondary mb-6");
            __builder.AddAttribute(5, "style", "min-width: 18rem; max-width:40%");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "class", "card-text");
            __builder.AddContent(10, "1. Department Id : ");
            __builder.AddContent(11, 
#nullable restore
#line 10 "C:\Tugas6_358\Blazor\BlazorFrontend_358\Pages\DetailDepartment.razor"
                                                     Department.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "p");
            __builder.AddAttribute(14, "class", "card-text");
            __builder.AddContent(15, "2. DepartmentName: ");
            __builder.AddContent(16, 
#nullable restore
#line 11 "C:\Tugas6_358\Blazor\BlazorFrontend_358\Pages\DetailDepartment.razor"
                                                     Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "<br>\r\n");
            __builder.AddMarkupContent(18, "<div><a href=\"departmentpage\"><button type=\"button\" class=\"btn btn-dark btn-lg\">Back</button></a></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
