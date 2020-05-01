using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IBookData
    {
        Task<int> Count_TotalBooks();
        Task<List<Books>> Get_10TopInstitute_Sales();
        Task<List<Books>> Get_Books();
        Task<List<Books>> Get_DatePosted(string sDateOrder);
        Task<byte[]> Get_ImageBytes(int iSalesNumber);
        Task<int> Get_LastSalesNumber();
        Task<int> Get_LocationID_SalesNumber(int iSalesNumber);
        Task<int> Get_SalesNumber_User_Title(int iUserId, string sBookTitle);
        Task<List<Books>> Get_SingleBook(int iSalesNumber);
        Task<int> Get_TotalSales_Province(string sProvince);
        Task<int> Get_UserID_SalesNumber_Title(int iSalesNumber, string sBookTitle);
        Task InsertBook(Books book);
        Task<List<Books>> ListAll(int skip, int take, string orderby, string direction = "DESC");
        Task<List<Books>> OrderBooks_Price(string sOrder);
        Task RemoveBook(Books book, int iSalesID);
        Task<List<Books>> SearchBooks_Institue(string sBookInsitute);
        Task<List<Books>> SearchBooks_ModuleCode(string sBookModuleCode);
        Task<List<Books>> SearchBooks_PriceRange(decimal dPriceMin, decimal dPriceMax);
        Task<List<Books>> SearchBooks_Title(string sBookTitle);
        Task<List<Books>> Search_MultiChar(string sSearchValue);
        Task UpdateBook_All(Books book);
        Task UpdateBook_BookEdition(Books book);
        Task UpdateBook_BookInstitute(Books book);
        Task UpdateBook_BookLocation(Books book);
        Task UpdateBook_BookModuleCode(Books book);
        Task UpdateBook_BookPrice(Books book);
        Task UpdateBook_BookTitle(Books book);
        Task UpdateBook_DatePosted(Books book);
        Task UpdateBook_UserID(Books book);
    }
}