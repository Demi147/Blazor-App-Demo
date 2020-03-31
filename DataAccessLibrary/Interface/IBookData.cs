using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IBookData
    {
        Task<int> Count();
        Task<List<Books>> GetBooks();
        Task<List<Books>> GetSingleBook(int iSalesNumber);
        Task InsertBook(Books book);
        Task<List<Books>> ListAll(int skip, int take, string orderby, string direction = "DESC");
        Task RemoveBook(Books book, int iSalesID);
        Task<List<Books>> SearchBooks_Institue(string sBookInsitute);
        Task<List<Books>> SearchBooks_ModuleCode(string sBookModuleCode);
        Task<List<Books>> SearchBooks_Title(string sBookTitle);
    }
}