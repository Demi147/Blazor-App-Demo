#pragma checksum "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8e1b75c0c259ee24ce14bfc257933bb4295f8aa"
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
#line 3 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
using DataAccessLibrary.Bussiness_Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
using DataAccessLibrary.Bussiness_Logic.BooksLogic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
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
            __builder.AddMarkupContent(0, "<h3>Books Main page</h3>\r\n\r\n\r\n<hr>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
 if (booksList is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><en>Loading...</en></p>\r\n");
#nullable restore
#line 20 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
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
#line 24 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                  lastAtribute

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table-striped");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "thead");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "th");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                    e=>sortAndFilter(BooksAtributes.BookTitle)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, 
#nullable restore
#line 30 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                                  BooksAtributes.BookTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "th");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                    e=>sortAndFilter(BooksAtributes.BookEdition)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, 
#nullable restore
#line 33 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                                    BooksAtributes.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "th");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                    e=>sortAndFilter(BooksAtributes.BookPrice)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, 
#nullable restore
#line 36 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                                  BooksAtributes.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "th");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                    e=>sortAndFilter(BooksAtributes.ModuleCode)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, 
#nullable restore
#line 39 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                                   BooksAtributes.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "th");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                    e=>sortAndFilter(BooksAtributes.BooksInstitute)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(53, 
#nullable restore
#line 42 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                                       BooksAtributes.BooksInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "th");
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "checkbox");
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                      EventArgs => { setAccending(EventArgs.Value); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(61, " accending\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "th");
            __builder.AddMarkupContent(64, "\r\n                    Filter Value ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "type", "search");
            __builder.AddAttribute(67, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                EventArgs => { Filter(EventArgs.Value); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddContent(68, " ");
            __builder.AddContent(69, 
#nullable restore
#line 48 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                                               FilterVal

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n        ");
            __builder.OpenElement(74, "tbody");
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 55 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
             foreach (var item in booksList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                ");
            __builder.OpenElement(77, "tr");
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "th");
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(81);
            __builder.AddAttribute(82, "href", 
#nullable restore
#line 59 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                       string.Format("/TestEnviroment/test/{0}",item.SalesNumber)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(84, 
#nullable restore
#line 59 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                                                                                                   item.BookTitle

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "th");
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.AddContent(89, 
#nullable restore
#line 62 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                         item.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.OpenElement(92, "th");
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.AddContent(94, 
#nullable restore
#line 65 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                         item.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.OpenElement(97, "th");
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.AddContent(99, 
#nullable restore
#line 68 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                         item.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(100, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.OpenElement(102, "th");
            __builder.AddMarkupContent(103, "\r\n                        ");
            __builder.AddContent(104, 
#nullable restore
#line 71 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
                         item.BookInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 75 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 78 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Carmen\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\TestEnviroment\CodingTest.razor"
       

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
