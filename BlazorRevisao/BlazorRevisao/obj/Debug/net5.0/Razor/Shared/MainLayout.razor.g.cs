#pragma checksum "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf971bfcfbebc740fee1e7196aea5bb30fb32b56"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorRevisao.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\_Imports.razor"
using BlazorRevisao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\_Imports.razor"
using BlazorRevisao.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-j885fhwjd3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-j885fhwjd3");
            __builder.OpenComponent<global::BlazorRevisao.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-j885fhwjd3");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-j885fhwjd3><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-j885fhwjd3>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-j885fhwjd3");
#nullable restore
#line 14 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\Shared\MainLayout.razor"
__builder.AddContent(15, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
