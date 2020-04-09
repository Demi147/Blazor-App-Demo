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
                BookTitle = "INTRO TO NWU",
                BookEdition = 1,
                BookPrice = 500.55,
                ModuleCode = "ITRW 101",
                BookInstitute = "CUT",
                LocationID = 1
            },
            new Books
            {
                SalesNumber = 2,
                UserID = 2,
                BookTitle = "ATest2",
                BookEdition = 2,
                BookPrice = 2000,
                ModuleCode = "CMPG 101",
                BookInstitute = "NWU",
                LocationID = 1
            },
            new Books
            {
                SalesNumber = 3,
                UserID = 3,
                BookTitle = "CTest3",
                BookEdition = 3,
                BookPrice = 500.55,
                ModuleCode = "ITRW 101",
                BookInstitute = "VUT",
                LocationID = 1
            }
        };

        public static Books GetSingleBook(int _id)
        {
            //JAAAAAA EK WEET < NET N STUPID METHOD VIR TYD IN WYL
            if (_id<4)
            {
                return StaticTestData.BookTestData[_id-1];
            }
            else
            {
                return null;
            }
        }

        public static List<Users> UserTestData = new List<Users> 
        {
            new Users
            {
                UserID = 0,
                UserName = "Carel",
                UserEmail = "Carel.haasbroekt@gmail.com",
                UserPassword = "1234",
                IsAdmin = true
            },
            new Users
            {
                UserID = 1,
                UserName = "Carmen",
                UserEmail = "EH",
                UserPassword = "1234",
                IsAdmin = true
            },
            new Users
            {
                UserID = 2,
                UserName = "Waldo",
                UserEmail = "MEH",
                UserPassword = "1234",
                IsAdmin = false
            }
        };

        
    }
}
