#pragma checksum "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\ViewVacations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9e132981594e40f06470bd4f05b3410a25ddbac"
// <auto-generated/>
#pragma warning disable 1591
namespace TravelClubProto.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\_Imports.razor"
using TravelClubProto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\_Imports.razor"
using TravelClubProto.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\ViewVacations.razor"
using TravelClubProto.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacationView")]
    public partial class ViewVacations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>View Vacations</h3>\r\n");
            __builder.OpenElement(1, "ul");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 8 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\ViewVacations.razor"
     foreach (var Vacation in VacationAdmin.PublishedVacations)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "li");
            __builder.AddContent(5, " Type: ");
            __builder.AddContent(6, 
#nullable restore
#line 10 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\ViewVacations.razor"
                    Vacation.Type

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " Destination: ");
            __builder.AddContent(8, 
#nullable restore
#line 10 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\ViewVacations.razor"
                                                Vacation.Destination

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, "  Price: ");
            __builder.AddContent(10, 
#nullable restore
#line 10 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\ViewVacations.razor"
                                                                              Vacation.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 11 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\ViewVacations.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VacationAdmin VacationAdmin { get; set; }
    }
}
#pragma warning restore 1591
