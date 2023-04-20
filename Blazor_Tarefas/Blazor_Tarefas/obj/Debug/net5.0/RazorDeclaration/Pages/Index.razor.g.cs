// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Tarefas.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\joaopaulo.rocha\Desktop\Blazor\Blazor_Tarefas\Blazor_Tarefas\Pages\Index.razor"
      

    protected override async Task OnInitializedAsync()
    {
        tarefas = await http.GetFromJsonAsync<List<Tarefa>>("dados/tarefas.json");
    }

    public class Tarefa
    {

        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCriacao { get; set; }

        public Tarefa(string descricao)
        {
            this.Descricao = descricao;
            this.Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
            Concluida = false;
        }

    }

    private string novaTarefa = "";

    private List<Tarefa> tarefas = new List<Tarefa>();

    void AdicionarNovaTarefa()
    {
        if(novaTarefa != "")
        {
            Tarefa tarefa = new Tarefa(novaTarefa);
            tarefas.Add(tarefa);

            novaTarefa = "";
        }
        else
        {
            Console.WriteLine("Tarefa vazia!");
        }
    }

    void RemoveTarefa(Guid id)
    {
        tarefas.Remove(tarefas.First(x => x.Id == id));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
