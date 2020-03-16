using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Linq;

namespace DataAccessLibrary.Bussiness_Logic
{
    public class BooksBussinessLogic : IBooksBussinessLogic
    {

        List<BookTest> x = new List<BookTest> {
        new BookTest { Title = "AAAAAAAA", Description = "AAAAAAAAAAA" },
        new BookTest { Title = "BBBBBBBBB", Description = "BBBBBBBB" }
        };


        //test method for test data
        public Task<List<BookTest>> GetTestData()
        {
            return Task.FromResult(x);
        }

        public Task<BookTest> GetSingleTestBook(string _title)
        {
            return Task.FromResult(x.Where(a => a.Title == _title).ToList()[0]);
        }
    }
}
