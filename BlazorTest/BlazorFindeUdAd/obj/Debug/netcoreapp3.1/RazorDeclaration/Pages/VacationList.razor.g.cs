#pragma checksum "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\Pages\VacationList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93a14833baddcd71c131164603e6891c3cc23523"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorFindeUdAd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\_Imports.razor"
using BlazorFindeUdAd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\_Imports.razor"
using BlazorFindeUdAd.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacationList")]
    public partial class VacationList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\Pages\VacationList.razor"
       
    private IList<Vacation> vacations = new List<Vacation>();
    private string type;
    private string destination;
    private int price;

    private void AddVacation()
    {
        if (!string.IsNullOrWhiteSpace(type))
        {
            vacations.Add(new Vacation(type, destination, price));
            type = string.Empty;
            destination = string.Empty;
            price = 0;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
