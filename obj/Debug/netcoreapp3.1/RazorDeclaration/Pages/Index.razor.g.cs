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
#line 1 "C:\Programacion3\ChurchApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Programacion3\ChurchApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Programacion3\ChurchApp\_Imports.razor"
using ChurchApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Programacion3\ChurchApp\_Imports.razor"
using ChurchApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programacion3\ChurchApp\Pages\Index.razor"
using ChurchApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 862 "C:\Programacion3\ChurchApp\Pages\Index.razor"
      

    public Modelo NewIntegrante {get; set;} = new Modelo();

    public async Task AddIntegrante(){
      await service.AddIntegranteAsync(newIntegrante);
      NewIntegrante= newIntegrante();
    } 







#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IntegrantesService service { get; set; }
    }
}
#pragma warning restore 1591
