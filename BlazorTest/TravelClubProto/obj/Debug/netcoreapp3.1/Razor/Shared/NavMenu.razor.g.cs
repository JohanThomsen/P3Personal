#pragma checksum "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "214b4259ad15b9f1982c4c25d04b35de7d1ae749"
// <auto-generated/>
#pragma warning disable 1591
namespace TravelClubProto.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand\" href>TravelClub</a>\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "navbar-toggler");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Shared\NavMenu.razor"
                                                               ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "\r\n            <span class=\"navbar-toggler-icon\"></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", 
#nullable restore
#line 7 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Shared\NavMenu.razor"
                                                ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "navbar-nav flex-grow-1");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "nav-item");
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "class", "nav-link text-dark");
            __builder.AddAttribute(25, "href", "");
            __builder.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Shared\NavMenu.razor"
                                                                       NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "\r\n                        <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "li");
            __builder.AddAttribute(32, "class", "nav-item");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "class", "nav-link text-dark");
            __builder.AddAttribute(36, "href", "counter");
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(38, "\r\n                        <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "nav-item");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "class", "nav-link text-dark");
            __builder.AddAttribute(46, "href", "vacationlist");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "\r\n                        <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Add Vacation\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "class", "nav-item");
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "nav-link text-dark");
            __builder.AddAttribute(56, "href", "fetchdata");
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "\r\n                        <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch Data\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "li");
            __builder.AddAttribute(62, "class", "nav-item");
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(64);
            __builder.AddAttribute(65, "class", "nav-link text-dark");
            __builder.AddAttribute(66, "href", "vacationView");
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(68, "\r\n                        <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> View Vacations\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Git\P3\OOP\Personal\BlazorTest\TravelClubProto\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string baseMenuClass = "navbar-collapse d-sm-inline-flex flex-sm-row-reverse";

    string NavMenuCssClass => baseMenuClass + (collapseNavMenu ? " collapse" : "");

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
