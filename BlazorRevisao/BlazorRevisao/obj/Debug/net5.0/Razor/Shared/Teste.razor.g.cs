#pragma checksum "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\Shared\Teste.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc19722d7e71a590264d1932667e4d1012e1aeda"
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
    public partial class Teste : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "sidebar");
            __builder.OpenComponent<global::BlazorRevisao.Shared.NavMenu>(4);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "<div class=\"top-row px-4\"><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">Teste</a></div>\r\n\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content px-4");
#nullable restore
#line 14 "C:\Users\joaopaulo.rocha\Desktop\Blazor\BlazorRevisao\BlazorRevisao\Shared\Teste.razor"
__builder.AddContent(11, Body);

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
