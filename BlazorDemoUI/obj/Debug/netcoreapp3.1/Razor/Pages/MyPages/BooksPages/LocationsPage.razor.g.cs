#pragma checksum "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac20062825230ce128c694d9e0ef5f3d5f6ae659"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemoUI.Pages.MyPages.BooksPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
using DataAccessLibrary.Bussiness_Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
using DataAccessLibrary.Bussiness_Logic.BooksLogic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
using BlazorDemoUI.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BooksPages/Main/AddBooks/Locations")]
    public partial class LocationsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Reccomended Locations for book Transaction</h3>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h5>Select Any of the below reccomeneded locations or enter your own.</h5>\r\n\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
 if (locationList is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 27 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <label for=\"Locations\" class=\"control-label\">Select a Location:</label>\r\n        </div>\r\n    </div>\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddAttribute(8, "style", "padding-top:1px");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-4");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "id", "selectBox");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                                                                       disableControls

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                                          selectedLocation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedLocation = __value, selectedLocation));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", true);
            __builder.AddContent(21, "-- Select Location --");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
#nullable restore
#line 40 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                 foreach (var item in locationList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                    ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", 
#nullable restore
#line 42 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                                    item.LocationID

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.AddContent(27, 
#nullable restore
#line 43 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                         item.Province.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, ", ");
            __builder.AddContent(29, 
#nullable restore
#line 43 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                                                    item.Address.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, ",\r\n                        ");
            __builder.AddContent(31, 
#nullable restore
#line 44 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                         item.City.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, ", ");
            __builder.AddContent(33, 
#nullable restore
#line 44 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                                                item.Building.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 46 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.AddAttribute(42, "style", "padding-top:5px");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-md-4");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "label");
            __builder.AddAttribute(48, "class", "control-label");
            __builder.AddContent(49, " Selected Location Name: ");
            __builder.AddContent(50, 
#nullable restore
#line 52 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                                                                   selectedLocation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 55 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(55, "fieldset");
            __builder.AddAttribute(56, "disabled", 
#nullable restore
#line 67 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                    isTrue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.AddMarkupContent(58, @"<h6>Desired Transaction Location:</h6>
    Enter Province: <input type=""text"" id=""txtProvince"" placeholder=""Enter Province here"" style>
    <br>
    <br>
    Enter Physical Adress: <input type=""text"" id=""txtPhysAdres"" placeholder=""Enter Physical Address here"" style>
    <br>
    <br>
    Enter City: <input type=""text"" id=""txtCity"" placeholder=""Enter City here"" style>
    <br>
    <br>
    Enter Transaction Building: <input type=""text"" id=""txtBuilding"" placeholder=""Enter Building here"" style>
    <br>
    <br>
");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "submit");
            __builder.AddAttribute(62, "id", "btnNext");
            __builder.AddAttribute(63, "class", "btn btn-primary");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
                                                                     NextNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "style", "float: left;");
            __builder.AddContent(66, "Submit");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\LocationsPage.razor"
       

    public int selectedLocation { get; set; }

    List<Locations> locationList;
    List<Locations> OGlist;

    bool isTrue { get; set; } = false;

    int id = 1;

    protected override async Task OnInitializedAsync()
    {
        OGlist = await _db.Get_AllLocations();
        locationList = OGlist;
    }

    //##########################################################################################################
    //Code to disable controls to enter own adress when one has been chosen
    //##########################################################################################################

    public void disableControls()
    {
        if (selectedLocation < 0)
        {
            isTrue = false;
        }
        else
        {
            isTrue = true;
        }
    }

    void NextNav()
    {
        booksAdd.AddBookLocation(selectedLocation);
        NavigationManager.NavigateTo("/BooksPages/Main/SaleConfirm");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksCreateService booksAdd { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocationData _db { get; set; }
    }
}
#pragma warning restore 1591
