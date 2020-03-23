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

        public Task<List<BookTest>> GetAllBooks(BooksAtributes _sortBy)
        {
            var q = GetTestData();
            switch (_sortBy)
            {
                case BooksAtributes.Title:
                    return Task.FromResult(q.Result.OrderBy(e=>e.Title) as List<BookTest>);
                    break;
                case BooksAtributes.Price:
                    return Task.FromResult(q.Result);
                    break;
                default:
                    return Task.FromResult(q.Result);
                    break;
            }
        }

        public Task<List<BookTest>> GetAllBooks(BooksAtributes _sortBy, BooksAtributes _filterBy, string filterVar)
        {
            var q = GetTestData().Result;

            var temp = new  List<BookTest>();

            switch (_sortBy)
            {
                case BooksAtributes.Title:
                    temp = q.OrderBy(e => e.Title) as List<BookTest>;
                    break;
                case BooksAtributes.Price:
                    return Task.FromResult(q);
                    break;
                default:
                    return Task.FromResult(q);
                    break;
            }

            switch (_filterBy)
            {
                case BooksAtributes.Title:
                    temp = temp.Where(e => e.Title == filterVar) as List<BookTest>;
                    break;
                case BooksAtributes.Price:
                    break;
                default:
                    break;
            }

            return Task.FromResult(temp);
        }

        public Task<BookTest> GetSingleTestBook(string _title)
        {
            if (Utilities.CheckIfContains(x,new BookTest {Title = _title }))
            {

            }
            return Task.FromResult(x.Where(a => a.Title == _title).First());
        }
    }
}
