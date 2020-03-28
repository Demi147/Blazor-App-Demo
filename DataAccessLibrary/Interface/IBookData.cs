using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IBookData
    {
        Task<List<Books>> GetBooks();
        Task<List<Books>> GetSingleBook(int iSalesNumber);
        Task<List<Books>> SearchBooks_Title(string sBookTitle);
        Task<List<Books>> SearchBooks_ModuleCode(string sBookModuleCode);
        Task<List<Books>> SearchBooks_Institue(string sBookInsitute);
        Task InsertBook(Books book);
        Task RemoveBook(Books book, int iSalesID);
    }
}