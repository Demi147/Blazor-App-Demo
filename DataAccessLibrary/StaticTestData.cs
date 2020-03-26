using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public static class StaticTestData
    {
        public static List<Books> BookTestData = new List<Books> 
        {
            new Books
            {
                SalesNumber = 1,
                UserID = 1,
                BookTitle = "Test1",
                BookEdition = 1,
                BookPrice = 500.55,
                ModuleCode = "ITRW 101",
                BooksInstitute = "NWU",
                LocationID = 1
            },
            new Books
            {
                SalesNumber = 2,
                UserID = 2,
                BookTitle = "Test2",
                BookEdition = 2,
                BookPrice = 2000,
                ModuleCode = "ITRW 101",
                BooksInstitute = "NWU",
                LocationID = 1
            },
            new Books
            {
                SalesNumber = 3,
                UserID = 3,
                BookTitle = "Test3",
                BookEdition = 3,
                BookPrice = 500.55,
                ModuleCode = "ITRW 101",
                BooksInstitute = "NWU",
                LocationID = 1
            }
        };
    }
}
