#pragma checksum "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ed4258d46a8c2cf99c8864289580d27e867933"
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
#line 1 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor"
using DataAccessLibrary.Bussiness_Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BooksPages/Main/AddBooks")]
    public partial class AddBooksPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor"
       


    void AddNav()
    {
        NavigationManager.NavigateTo("/BooksPages/Main/AddBooks/Locations");
    }
    void BackNav()
    {
        NavigationManager.NavigateTo("BooksPages/Main");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksBussinessLogic BooksService { get; set; }
    }
}
#pragma warning restore 1591
