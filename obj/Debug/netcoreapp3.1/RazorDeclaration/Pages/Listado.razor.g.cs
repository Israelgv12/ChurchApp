#pragma checksum "c:\Programacion3\ChurchApp\Pages\Listado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9bb02ae7ced455bb03144a62b54401d3b2e9b10"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ChurchApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Programacion3\ChurchApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Programacion3\ChurchApp\_Imports.razor"
using ChurchApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Programacion3\ChurchApp\_Imports.razor"
using ChurchApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Programacion3\ChurchApp\Pages\Listado.razor"
using ChurchApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Programacion3\ChurchApp\Pages\Listado.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Programacion3\ChurchApp\Pages\Listado.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tables")]
    public partial class Listado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 938 "c:\Programacion3\ChurchApp\Pages\Listado.razor"
      

    private string buscando="";
    IFileListEntry image;
    Modelo UpdateIntegrante = new Modelo();
    List<Modelo> modelos = new List<Modelo>();
    
    AplicacionDbContext peregrinos = new AplicacionDbContext();

    async Task HandleSelectImagen(IFileListEntry[] Images) 
    {
        image = Images.FirstOrDefault();
    }
  private void SetIntegranteForUpdate(Modelo modelo){

      UpdateIntegrante = modelo;

  }
  private async Task DeleteIntegrante(Modelo modelo)
{
await Service.DeleteIntegranteAsync(modelo);
 await RefreshIntegrante();

}
void Detalle(){
    nav.NavigateTo("Detalle");
}

   private async Task UpdateIntegranteData(){

    await Service.UpdateIntegranteAsync(UpdateIntegrante);
     await RefreshIntegrante();

  }

  protected override async Task OnInitializedAsync(){

      await RefreshIntegrante();

  }

  private async Task RefreshIntegrante(){
       modelos = await Service.GetModelosAsync();
  }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IntegranteService Service { get; set; }
    }
}
#pragma warning restore 1591
