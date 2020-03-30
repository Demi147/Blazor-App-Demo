#pragma checksum "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f67c82d1cbe7822e8d653d2c7446dbd3685240c2"
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
#line 3 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
using DataAccessLibrary.Bussiness_Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BooksPages/Main/{id:int}")]
    public partial class BookComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Book Information</h1>\r\n\r\n");
            __builder.AddContent(1, 
#nullable restore
#line 13 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
 _book.SalesNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n");
            __builder.AddContent(3, 
#nullable restore
#line 14 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
 _book.BookTitle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n");
            __builder.AddContent(5, 
#nullable restore
#line 15 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
 _book.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n");
            __builder.AddContent(7, 
#nullable restore
#line 16 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
 _book.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n");
            __builder.AddContent(9, 
#nullable restore
#line 17 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
 _book.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n");
            __builder.AddContent(11, 
#nullable restore
#line 18 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
 _book.BooksInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "href", "/BooksPages/Main");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(16, "Return to Books page");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
       

    [Parameter]
    public int id { get; set; }

    protected Books _book;



        protected override void OnInitialized()
        {
            _book = StaticTestData.GetSingleBook(id);
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksBussinessLogic BooksService { get; set; }
    }
}
#pragma warning restore 1591
