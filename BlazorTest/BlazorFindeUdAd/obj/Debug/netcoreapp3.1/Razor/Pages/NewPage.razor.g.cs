#pragma checksum "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\Pages\NewPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "020a6505fce1eed65c7fb8c46bb770fe42e8b4b5"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/testPage")]
    public partial class NewPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Counter</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count : ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\Pages\NewPage.razor"
                    count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 7 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\Pages\NewPage.razor"
 foreach (int item in list)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, 
#nullable restore
#line 9 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\Pages\NewPage.razor"
        item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 10 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\Pages\NewPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\Pages\NewPage.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Git\P3\OOP\Personal\BlazorTest\BlazorFindeUdAd\Pages\NewPage.razor"
       

    private List<int> list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
    private int count = 0;

    private void IncrementCount()
    {
        count++;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591