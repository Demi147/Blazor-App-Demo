#pragma checksum "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "217983403a303676bc232bc9131e98df44200495"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemoUI.Pages.TestEnviroment
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
#line 3 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
using DataAccessLibrary.Bussiness_Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
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
            __builder.AddMarkupContent(0, "<h3>Books Main page</h3>\r\n\r\n\r\n<hr>\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
 if (booksList is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><en>Loading...</en></p>\r\n");
#nullable restore
#line 19 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "    <hr>\r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Filter By ");
            __builder.AddContent(6, 
#nullable restore
#line 23 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                  lastAtribute

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table-striped");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "thead");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "th");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                e=>sortAndFilter(BooksAtributes.BookTitle)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, 
#nullable restore
#line 29 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                              BooksAtributes.BookTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "th");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                e=>sortAndFilter(BooksAtributes.BookEdition)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, 
#nullable restore
#line 32 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                                BooksAtributes.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "th");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                e=>sortAndFilter(BooksAtributes.BookPrice)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, 
#nullable restore
#line 35 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                              BooksAtributes.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "th");
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                e=>sortAndFilter(BooksAtributes.ModuleCode)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, 
#nullable restore
#line 38 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                               BooksAtributes.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "th");
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                e=>sortAndFilter(BooksAtributes.BooksInstitute)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, 
#nullable restore
#line 41 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                                   BooksAtributes.BooksInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "th");
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "checkbox");
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                  EventArgs => { setAccending(EventArgs.Value); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(60, " accending\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "th");
            __builder.AddMarkupContent(63, "\r\n                Filter Value ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "search");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                               FilterVal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FilterVal = __value, FilterVal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(68, " ");
            __builder.AddContent(69, 
#nullable restore
#line 47 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                             FilterVal

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(70, "  \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n    ");
            __builder.OpenElement(74, "tbody");
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 54 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
         foreach (var item in booksList)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "        ");
            __builder.OpenElement(77, "tr");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "th");
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(81);
            __builder.AddAttribute(82, "href", 
#nullable restore
#line 58 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                               string.Format("/BooksPages/Main/{0}",item.BookTitle)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(84, 
#nullable restore
#line 58 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                     item.BookTitle

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.OpenElement(87, "th");
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.AddContent(89, 
#nullable restore
#line 61 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                 item.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.OpenElement(92, "th");
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.AddContent(94, 
#nullable restore
#line 64 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                 item.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.OpenElement(97, "th");
            __builder.AddMarkupContent(98, "\r\n                ");
            __builder.AddContent(99, 
#nullable restore
#line 67 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                 item.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(100, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "th");
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.AddContent(104, 
#nullable restore
#line 70 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                 item.BooksInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 74 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 77 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
       

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
    }

    protected void sortAndFilter(BooksAtributes _atribute)
    {
        lastAtribute = _atribute;
        if (FilterVal==null || FilterVal.Length == 0)
        {

            booksList = BooksService.SortBooks(booksListOG, _atribute, accending);
        }
        else
        {
            booksList = BooksService.FilterAndSort(booksListOG,_atribute,accending,FilterVal);
        }

    }

    void setAccending(object value)
    {
        accending = (bool)value;
        sortAndFilter(lastAtribute);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksBussinessLogic BooksService { get; set; }
    }
}
#pragma warning restore 1591
