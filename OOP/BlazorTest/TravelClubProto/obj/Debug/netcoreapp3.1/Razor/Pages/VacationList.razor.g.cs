#pragma checksum "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\VacationList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ef28992bad565f1722741af4a6a0b032d1d572"
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
#line 3 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\VacationList.razor"
using TravelClubProto.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacationList")]
    public partial class VacationList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3> Add a Vacation</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "placeholder", "Type");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\VacationList.razor"
                                 type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => type = __value, type));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "placeholder", "Destination");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\VacationList.razor"
                                        destination

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => destination = __value, destination));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "number");
            __builder.AddAttribute(13, "placeholder", "Price");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\VacationList.razor"
                                                price

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => price = __value, price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\VacationList.razor"
                  AddVacation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Add Vacation");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Pages\VacationList.razor"
       
    private string type;
    private string destination;
    private int price;

    public void AddVacation()
    {
        if (!string.IsNullOrWhiteSpace(type))
        {
            VacationAdmin.PublishVacation(new Vacation(type, destination, price));
            type = string.Empty;
            destination = string.Empty;
            price = 0;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VacationAdmin VacationAdmin { get; set; }
    }
}
#pragma warning restore 1591