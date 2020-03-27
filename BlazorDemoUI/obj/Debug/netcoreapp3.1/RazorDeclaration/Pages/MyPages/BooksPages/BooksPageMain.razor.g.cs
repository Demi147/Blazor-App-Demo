#pragma checksum "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0efc593a7d597499824d876486f8b1746b929e61"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemoUI.Pages.MyPages.BooksPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
using DataAccessLibrary.Bussiness_Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BooksPages/Main")]
    public partial class BooksPageMain : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
       

    List<Books> booksList;

    BooksAtributes lastAtribute;
    BooksAtributes chaningAttribute;
    string FilterVal { get; set; }
    bool accending;

    protected override async Task OnInitializedAsync()
    {
        booksList = StaticTestData.BookTestData;
        lastAtribute = BooksAtributes.BookTitle;
        chaningAttribute = BooksAtributes.ModuleCode;

    }

    protected void sortAndFilter(BooksAtributes atribute)
    {
        lastAtribute = atribute;
        if (FilterVal == null || FilterVal.Length == 0)
        {

            booksList = BooksService.SortBooks(booksList, atribute, accending);
        }
        else
        {
            booksList = BooksService.FilterAndSort(booksList, atribute, accending, FilterVal);
        }

    }

    void setAccending(object value)
    {
        accending = (bool)value;
        sortAndFilter(lastAtribute);
    }

    protected void FilterBooks(BooksAtributes atribute)
    {
        chaningAttribute = atribute;

        if (FilterVal.Length != 0)
        {
            booksList = BooksService.FilterBooks(booksList, atribute, FilterVal);
        }

    }

    void filtering(object value)
    {
        FilterVal = (string)value;
        FilterBooks(chaningAttribute);
    }

    void AddNav()
    {
        NavigationManager.NavigateTo("/BooksPages/Main/AddBooks");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksBussinessLogic BooksService { get; set; }
    }
}
#pragma warning restore 1591
