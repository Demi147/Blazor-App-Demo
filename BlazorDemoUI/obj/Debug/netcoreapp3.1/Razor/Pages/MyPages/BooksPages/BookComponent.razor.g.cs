#pragma checksum "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2b4a0670dcfbf0f77ea3d722c36e1618cb58f2a"
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
#line 3 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
using DataAccessLibrary.Bussiness_Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
using DataAccessLibrary.Bussiness_Logic.BooksLogic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
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
            __builder.AddMarkupContent(0, "<style>\r\n    .row div {\r\n        border: 0.5px solid;\r\n    }\r\n</style>\r\n\r\n\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddMarkupContent(2, "\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\" integrity=\"sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh\" crossorigin=\"anonymous\">\r\n    Book Information\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "type", "submit");
            __builder.AddAttribute(5, "name", "btnBack");
            __builder.AddAttribute(6, "class", "btn btn-outline-info");
            __builder.AddAttribute(7, "style", "float: right;");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                                                                                                      BackNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Browse More Books");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "type", "submit");
            __builder.AddAttribute(13, "name", "btnPurchase");
            __builder.AddAttribute(14, "class", "btn btn-outline-info");
            __builder.AddAttribute(15, "style", "float: right;");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                                                                                                          NavConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Request Book Purchase");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n\r\n");
#nullable restore
#line 35 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
 if (_book is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.AddMarkupContent(21, "<p><en>Loading...</en></p>\r\n");
#nullable restore
#line 38 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
     foreach (var item in _book)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-hover");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.AddMarkupContent(26, @"<thead class=""thead-light"">
                <tr>
                    <th>Title</th>
                    <th>Edition</th>
                    <th>Price</th>
                    <th>Module Code</th>
                    <th>Institute</th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(27, "tbody");
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 58 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                         item.BookTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 59 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                         item.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 60 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                         item.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 61 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                         item.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 62 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                         item.BookInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.AddMarkupContent(49, "        <br>\r\n");
            __builder.AddContent(50, "        ");
            __builder.OpenElement(51, "table");
            __builder.AddAttribute(52, "class", "table table-hover table-responsive ");
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "thead");
            __builder.AddAttribute(55, "class", "thead-light");
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "tr");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.AddMarkupContent(59, "<th>Title</th>\r\n                    ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 76 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                         item.BookTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "tr");
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.AddMarkupContent(66, "<th>Edition</th>\r\n                    ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 80 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                         item.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "tr");
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.AddMarkupContent(73, "<th>Price</th>\r\n                    ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 84 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                         item.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "tr");
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.AddMarkupContent(80, "<th>Module Code</th>\r\n                    ");
            __builder.OpenElement(81, "td");
            __builder.AddContent(82, 
#nullable restore
#line 88 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                         item.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "tr");
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.AddMarkupContent(87, "<th>Institute</th>\r\n                    ");
            __builder.OpenElement(88, "td");
            __builder.AddContent(89, 
#nullable restore
#line 92 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                         item.BookInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
            __builder.AddMarkupContent(94, "        <br>\r\n");
            __builder.AddContent(95, "        ");
            __builder.OpenElement(96, "table");
            __builder.AddAttribute(97, "class", "table table-hover  ");
            __builder.AddMarkupContent(98, "\r\n\r\n            ");
            __builder.OpenElement(99, "tbody");
            __builder.AddAttribute(100, "class", "thead-light");
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.OpenElement(102, "tr");
            __builder.AddAttribute(103, "class", "row");
            __builder.AddMarkupContent(104, "\r\n\r\n                    ");
            __builder.AddMarkupContent(105, "<th class=\"col-1\">Title</th>\r\n                    ");
            __builder.OpenElement(106, "td");
            __builder.AddAttribute(107, "class", "col-3");
            __builder.AddContent(108, 
#nullable restore
#line 108 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                                       item.BookTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.OpenElement(111, "tr");
            __builder.AddAttribute(112, "class", "row");
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.AddMarkupContent(114, "<th class=\"col-1\">Edition</th>\r\n                    ");
            __builder.OpenElement(115, "td");
            __builder.AddAttribute(116, "class", "col-3");
            __builder.AddContent(117, 
#nullable restore
#line 112 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                                       item.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                ");
            __builder.OpenElement(120, "tr");
            __builder.AddAttribute(121, "class", "row");
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.AddMarkupContent(123, "<th class=\"col-1\">Price</th>\r\n                    ");
            __builder.OpenElement(124, "td");
            __builder.AddAttribute(125, "class", "col-3");
            __builder.AddContent(126, 
#nullable restore
#line 116 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                                       item.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                ");
            __builder.OpenElement(129, "tr");
            __builder.AddAttribute(130, "class", "row");
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.AddMarkupContent(132, "<th class=\"col-1\">Module Code</th>\r\n                    ");
            __builder.OpenElement(133, "td");
            __builder.AddAttribute(134, "class", "col-3");
            __builder.AddContent(135, 
#nullable restore
#line 120 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                                       item.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                ");
            __builder.OpenElement(138, "tr");
            __builder.AddAttribute(139, "class", "row");
            __builder.AddMarkupContent(140, "\r\n                    ");
            __builder.AddMarkupContent(141, "<th class=\"col-1\">Institute</th>\r\n                    ");
            __builder.OpenElement(142, "td");
            __builder.AddAttribute(143, "class", "col-3");
            __builder.AddContent(144, 
#nullable restore
#line 124 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
                                       item.BookInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n");
#nullable restore
#line 128 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 136 "C:\Users\carel\Desktop\BlazorDemoApp\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BookComponent.razor"
       

    [Parameter]
    public int id { get; set; }

    List<Books> _book;

    protected override async Task OnInitializedAsync()
    {
        _book = await _db.Get_SingleBook(id);
    }

    //##########################################################################################################
    //Navigation code for the buttons
    //##########################################################################################################

    void BackNav()
    {
        NavigationManager.NavigateTo("/BooksPages/Main");
    }

    void NavConfirm()
    {
        //buyService.addSalesNumber(_book.SalesNumber);
        NavigationManager.NavigateTo("/BooksPages/Main/RequestPurchase");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksBuyService buyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksBussinessLogic BooksService { get; set; }
    }
}
#pragma warning restore 1591
