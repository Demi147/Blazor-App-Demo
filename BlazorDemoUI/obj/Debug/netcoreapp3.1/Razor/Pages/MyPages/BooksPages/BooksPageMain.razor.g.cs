#pragma checksum "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7132fb32f038444c3dfdc6bf1aab44e937d383"
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
#line 1 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
using DataAccessLibrary.Bussiness_Logic.BooksLogic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
using DataAccessLibrary.Bussiness_Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
using BlazorDemoUI.Models;

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
            __builder.AddMarkupContent(1, "\r\n    Books For Sale\r\n    ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "type", "submit");
            __builder.AddAttribute(4, "name", "btnAddNew");
            __builder.AddAttribute(5, "class", "btn btn-outline-primary");
            __builder.AddAttribute(6, "style", "float: right;");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                                                           AddNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Add New Book");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n");
            __builder.OpenElement(11, "h5");
            __builder.AddMarkupContent(12, "\r\n    Search:\r\n    ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "id", "txtFilter");
            __builder.AddAttribute(16, "placeholder", "Enter text");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                             FilterVal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FilterVal = __value, FilterVal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "submit");
            __builder.AddAttribute(22, "for", "txtFilter");
            __builder.AddAttribute(23, "name", "btnSearch");
            __builder.AddAttribute(24, "class", "btn btn-outline-info");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                                                   SearchBooks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n    ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "style", "float: right;");
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "checkbox");
            __builder.AddAttribute(33, "id", "orderCheck");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                             SetAsc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                       boolValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => boolValue = __value, boolValue));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, " Check the box to sort the data according to price\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n\r\n");
            __builder.OpenElement(40, "h5");
            __builder.AddMarkupContent(41, "\r\n    Filter by Price:\r\n    ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "text");
            __builder.AddAttribute(44, "id", "txtMinPrice");
            __builder.AddAttribute(45, "placeholder", "Enter min price");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                              minPrice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => minPrice = __value, minPrice));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "id", "txtMaxPrice");
            __builder.AddAttribute(52, "placeholder", "Enter max price");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                              maxPrice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => maxPrice = __value, maxPrice));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "type", "submit");
            __builder.AddAttribute(58, "name", "btnPriceSearch");
            __builder.AddAttribute(59, "class", "btn btn-outline-info");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                                        filterPrices

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 56 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
 if (booksList is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "    ");
            __builder.AddMarkupContent(65, "<p><en>Loading...</en></p>\r\n");
#nullable restore
#line 59 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "    ");
            __builder.OpenElement(67, "table");
            __builder.AddAttribute(68, "class", "table table-hover");
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.AddMarkupContent(70, @"<thead class=""thead-light"">
            <tr>
                <th>Title</th>
                <th>Edition</th>
                <th>Price</th>
                <th>Module Code</th>
                <th>Institute</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(71, "tbody");
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 74 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
             foreach (var item in booksList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "            ");
            __builder.OpenElement(74, "tr");
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "td");
            __builder.AddAttribute(77, "href", "#");
            __builder.AddAttribute(78, "data-toggle", "tooltip");
            __builder.AddAttribute(79, "title", "See Book Info");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(80);
            __builder.AddAttribute(81, "href", 
#nullable restore
#line 77 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                                        string.Format("/BooksPages/Main/{0}",item.SalesNumber)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(83, 
#nullable restore
#line 77 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                                                                                                item.BookTitle

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "td");
            __builder.AddContent(86, 
#nullable restore
#line 78 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                     item.BookEdition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "td");
            __builder.AddContent(89, 
#nullable restore
#line 79 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                     item.BookPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "td");
            __builder.AddContent(92, 
#nullable restore
#line 80 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                     item.ModuleCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.OpenElement(94, "td");
            __builder.AddContent(95, 
#nullable restore
#line 81 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                     item.BookInstitute

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 83 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "pagination");
            __builder.AddMarkupContent(103, "\r\n        ");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "class", "btn btn-custom");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                  async ()=>await NavigateToPage("previous")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(107, "Prev");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 88 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
         for (int i = startPage; i <= endPage; i++)
        {
            var currentPage = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, "            ");
            __builder.OpenElement(110, "button");
            __builder.AddAttribute(111, "class", "btn" + " btn-custom" + " pagebutton" + " " + (
#nullable restore
#line 91 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                       currentPage==curPage?"btn-danger":""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                                                                         async () =>await refreshRecords(currentPage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(113, "\r\n                ");
            __builder.AddContent(114, 
#nullable restore
#line 92 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                 currentPage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(115, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n");
#nullable restore
#line 94 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(117, "        ");
            __builder.OpenElement(118, "button");
            __builder.AddAttribute(119, "class", "btn btn-custom");
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
                                                  async ()=>await NavigateToPage("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(121, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 97 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
 
    public bool boolValue { get; set; }
    void toggle()
    {
        if (boolValue)
        {
            boolValue = !boolValue;
        }
        else
        {
            boolValue = !boolValue;
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor"
       

    List<Books> booksList;
    List<Books> OGlist;

    private DisplayBookModel showBooks = new DisplayBookModel();

    //******************************************
    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;
    string sortColumnName = "SalesNumber";
    string sortDir = "DESC";
    //******************************************

    //bool isChecked { get; set; } = false;

    string minPrice { get; set; }
    string maxPrice { get; set; }

    string FilterVal { get; set; }
    string orderBy;

    protected override async Task OnInitializedAsync()
    {
        OGlist = await _db.Get_Books();
        //booksList = OGlist;

        pagerSize = 3;
        pageSize = 5;
        curPage = 1;

        OGlist = await _db.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir);
        booksList = OGlist;

        totalRecords = await _db.Count_TotalBooks();
        totalPages = (int)Math.Ceiling(totalRecords / (decimal)pageSize);
        SetPagerSize("forward");


    }

    //##########################################################################################################
    //Code to filter data according to price range
    //##########################################################################################################

    private async Task SearchBooks()
    {
        try
        {
            if (FilterVal == null || FilterVal.Length == 0)
            {

                booksList = await _db.Get_Books();
            }
            else
            {
                booksList = await _db.Search_MultiChar(FilterVal);
                FilterVal = "";
            }
        }
        catch (Exception ex)
        {
            string stest = ex.ToString();
        }
    }

    //##########################################################################################################
    //Code to search for specific books
    //##########################################################################################################

    private async Task filterPrices()
    {
        try
        {
            if ((minPrice.ToString() == null || minPrice.ToString().Length == 0) || (maxPrice.ToString() == null || maxPrice.ToString().Length == 0))
            {

                booksList = await _db.Get_Books();
            }
            else
            {
                booksList = await _db.SearchBooks_PriceRange(Convert.ToDecimal(minPrice), Convert.ToDecimal(maxPrice));
                minPrice = "";
                maxPrice = "";
            }
        }
        catch (Exception ex)
        {
            string stest = ex.ToString();
        }
    }

    //##########################################################################################################
    //Code to set data to asc/desc
    //##########################################################################################################

    private async Task SetAsc()
    {
        try
        {
            toggle();
            if (boolValue == true)
            {
                booksList = await _db.OrderBooks_Price("ASC");
                //isChecked = !isChecked;
            }
            else
            {
                toggle();
                booksList = await _db.Get_Books();
                //booksList = await _db.OrderBooks_Price("DESC");
                //isChecked = !isChecked;
            }
        }
        catch (Exception ex)
        {
            string sError = ex.ToString();
        }
    }

    //##########################################################################################################
    //Code to navigate to the addBooksPage
    //##########################################################################################################

    void AddNav()
    {
        booksAdd.flush(); //Reset booksAdd list
        NavigationManager.NavigateTo("/BooksPages/Main/AddBooks");
    }


    //##########################################################################################################
    //Code for Paging
    //##########################################################################################################

    public async Task refreshRecords(int currentPage)
    {
        booksList = await _db.ListAll((currentPage - 1) * pageSize, pageSize, sortColumnName, sortDir);
        curPage = currentPage;
        this.StateHasChanged();
    }

    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < totalPages)
        {
            startPage = endPage + 1;
            if (endPage + pagerSize < totalPages)
            {
                endPage = startPage + pagerSize - 1;
            }
            else
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - pagerSize;
        }
    }

    public async Task NavigateToPage(string direction)
    {
        if (direction == "next")
        {
            if (curPage < totalPages)
            {
                if (curPage == endPage)
                {
                    SetPagerSize("forward");
                }
                curPage += 1;
            }
        }
        else if (direction == "previous")
        {
            if (curPage > 1)
            {
                if (curPage == startPage)
                {
                    SetPagerSize("back");
                }
                curPage -= 1;
            }
        }
        await refreshRecords(curPage);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksCreateService booksAdd { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
