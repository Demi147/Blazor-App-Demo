using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Bussiness_Logic
{
    public interface IBooksBussinessLogic
    {
        Task<BookTest> GetSingleTestBook(string _title);
        Task<List<BookTest>> GetTestData();
    }
}