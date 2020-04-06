#pragma checksum "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0e50cf5193a80eb04d61743eb3e9081381c98c6"
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
#line 10 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorInputFile;

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
            __builder.OpenElement(0, "h1");
            __builder.AddMarkupContent(1, "    \r\n    Available Book Sales\r\n    ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "type", "submit");
            __builder.AddAttribute(4, "name", "btnAddNew");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "style", "float: right;");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                                                   AddNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Add New Book");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "h5");
            __builder.AddMarkupContent(12, "\r\n    Filter Search:\r\n    ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "name", "txtFilter");
            __builder.AddAttribute(16, "placeholder", "Enter text to filter");
            __builder.AddAttribute(17, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                                     EventArgs => { Filter(EventArgs.Value); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "checkbox");
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                      EventArgs => { setAccending(EventArgs.Value); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(22, " Click for Accending Order\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
 if (booksList is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.AddMarkupContent(25, "<p><en>Loading...</en></p>\r\n");
#nullable restore
#line 24 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "class", "table table-striped");
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "thead");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 31 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                     BooksAtributes.BookTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 32 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                     BooksAtributes.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 33 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                     BooksAtributes.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 34 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                     BooksAtributes.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 35 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                     BooksAtributes.BooksInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "tbody");
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 39 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
             foreach (var item in booksList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "                ");
            __builder.OpenElement(54, "tr");
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(57);
            __builder.AddAttribute(58, "href", 
#nullable restore
#line 42 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                       string.Format("/BooksPages/Main/{0}",item.SalesNumber)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(60, 
#nullable restore
#line 42 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                                               item.BookTitle

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 43 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                         item.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 44 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                         item.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 45 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                         item.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 46 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                         item.BooksInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 48 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 51 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
       

    List<Books> booksList;
    List<Books> OGlist;

    BooksAtributes lastAtribute;
    BooksAtributes chaningAttribute;
    string FilterVal { get; set; }
    bool accending;

    protected override async Task OnInitializedAsync()
    {
        OGlist = StaticTestData.BookTestData;
        lastAtribute = BooksAtributes.BookTitle;
        chaningAttribute = BooksAtributes.ModuleCode;
        booksList = OGlist;

    }

    protected void sortAndFilter(BooksAtributes atribute)
    {
        lastAtribute = atribute;
        if (FilterVal == null || FilterVal.Length == 0)
        {

            booksList = BooksService.SortBooks(OGlist, atribute, accending);
        }
        else
        {
            booksList = BooksService.FilterAndSort(OGlist, atribute, accending, FilterVal);
        }

    }

    void setAccending(object value)
    {
        accending = (bool)value;
        sortAndFilter(lastAtribute);
    }

    void Filter(object _val)
    {
        FilterVal = _val.ToString();
        booksList = BooksService.SortBooks(BooksService.MultiFilter(OGlist, _val.ToString()), lastAtribute, accending);
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
