#pragma checksum "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe05a2eb60cc03371f8451df56453be8b756e28"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemoUI.Pages.TestEnviroment
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
#line 3 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
using DataAccessLibrary.Bussiness_Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
using DataAccessLibrary.Bussiness_Logic.BooksLogic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TestEnviroment")]
    public partial class CodingTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
       

    List<Books> booksListOG;
    List<Books> booksList;

    BooksAtributes lastAtribute;

    bool accending;

    string FilterVal { get; set; }

    protected override void OnInitialized()
    {
        booksListOG = StaticTestData.BookTestData;
        booksList = booksListOG;
        lastAtribute = BooksAtributes.BookTitle;

        BooksBuyService.addUser(5);
    }

    protected void sortAndFilter(BooksAtributes _atribute)
    {
        lastAtribute = _atribute;

    }

    void setAccending(object value)
    {
        accending = (bool)value;
        sortAndFilter(lastAtribute);
    }

    void Filter(object _val)
    {
        FilterVal = _val.ToString();
        booksList = BooksService.SortBooks(BooksService.MultiFilter(booksListOG, _val.ToString()), lastAtribute, accending);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksBuyService BooksBuyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksBussinessLogic BooksService { get; set; }
    }
}
#pragma warning restore 1591
