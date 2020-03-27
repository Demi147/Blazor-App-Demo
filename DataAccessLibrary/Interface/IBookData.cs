using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IBookData
    {
        Task<List<Books>> GetBooks();
        Task InsertBook(Books book);
    }
}