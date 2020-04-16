#pragma checksum "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\BooksPages\BooksPageMain.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7132fb32f038444c3dfdc6bf1aab44e937d383"
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
