#pragma checksum "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ba26e2964e0750afa8943e707ffd5e656663990"
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
#line 3 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor"
using DataAccessLibrary.Bussiness_Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor"
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
            __builder.OpenElement(0, "h1");
            __builder.AddMarkupContent(1, "\r\n        Add New Books\r\n        ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "type", "submit");
            __builder.AddAttribute(4, "name", "btnAddBookLoc");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "style", "float: right;");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor"
                                                                                                            AddNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Submit Sale Request");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "submit");
            __builder.AddAttribute(12, "name", "btnAddBookLoc");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "style", "float: right;");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor"
                                                                                                           BackNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Cancel Sale Request");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.AddMarkupContent(19, "<p>\r\n    <br>\r\n    Book Title: <input type=\"text\" name=\"txtBookTitle\" placeholder=\"Enter book title here\" style>\r\n    <br>\r\n    <br>\r\n    Book Edition: <input type=\"text\" name=\"txtBookEdition\" placeholder=\"Enter book edition here\">\r\n    <br>\r\n    <br>\r\n    Book Price: <input type=\"text\" name=\"txtBookPrice\" placeholder=\"Enter book price here\">\r\n    <br>\r\n    <br>\r\n    Module Code: <input type=\"text\" name=\"txtModuleCode\" placeholder=\"Enter module code here\">\r\n    <br>\r\n    <br>\r\n    Book Institute: <input type=\"text\" name=\"txtBookInstitute\" placeholder=\"Enter book institute here\">\r\n    <br>\r\n    <br>\r\n    Book Image:\r\n    <br>\r\n    <img src=\"data:image/jpeg;base64,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\">\r\n</p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\AddBooksPage.razor"
       


    void AddNav()
    {
        navigationManager.NavigateTo("/BooksPages/Main/AddBooks/Locations");
    }
    void BackNav()
    {
        navigationManager.NavigateTo("BooksPages/Main");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksBussinessLogic BooksService { get; set; }
    }
}
#pragma warning restore 1591
