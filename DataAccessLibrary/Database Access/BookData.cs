using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Data;
using Dapper;

namespace DataAccessLibrary
{
    public class BookData : IBookData
    {
        private readonly ISqlDataAccess _db;

        private string sError = "";

        public BookData(ISqlDataAccess db)
        {
            _db = db;
        }

        //##############################################################################################################################################################################################################
        // Get methods for Book Data Model
        //##############################################################################################################################################################################################################
        public Task<List<Books>> Get_Books()
        {
            try
            {
                string sql = @"Select * from dbo.tblBookSales";

                return _db.LoadData<Books, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Books>> Get_SingleBook(int iSalesNumber)
        {
            try
            {
                string sql = @"Select * from dbo.tblBookSales Where SalesNumber=" + iSalesNumber + "";

                return _db.LoadData<Books, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Books>> Get_DatePosted(string sDateOrder)//parameter is either ASC or DESC 
        {
            try
            {
                string sql = @"Select * from dbo.tblBookSales Order By DatePosted " + sDateOrder + "";

                return _db.LoadData<Books, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<int> Get_UserID_SalesNumber_Title(int iSalesNumber, string sBookTitle)
        {
            try
            {
                var userID = Task.FromResult(_db.Get<int>($"Select UserID from dbo.tblBookSales Where SalesNumber =" + iSalesNumber + " and BookTitle Like '" + sBookTitle + "'", null, commandType: CommandType.Text));

                return userID;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<int> Get_SalesNumber_User_Title(int iUserId, string sBookTitle)
        {
            try
            {
                var salesNumber = Task.FromResult(_db.Get<int>($"Select SalesNumber from dbo.tblBookSales Where UserId=" + iUserId + " and BookTitle Like '" + sBookTitle + "'", null, commandType: CommandType.Text));

                return salesNumber;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<int> Get_LocationID_SalesNumber(int iSalesNumber)
        {
            try
            {
                var locationId = Task.FromResult(_db.Get<int>($"Select LocationId from dbo.tblBookSales", null, commandType: CommandType.Text));

                return locationId;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<byte[]> Get_ImageBytes(int iSalesNumber)
        {
            try
            {
                var imageByte = Task.FromResult(_db.Get<byte[]>($"Select BookImage from dbo.tblBookSales Where SalesNumber = " + iSalesNumber + "", null, commandType: CommandType.Text));

                return imageByte;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<int> Get_LastSalesNumber()
        {
            try
            {
                var LastId = Task.FromResult(_db.Get<int>($"Select TOP 1 SalesNumber from dbo.tblBookSales Order By SalesNumber DESC", null, commandType: CommandType.Text));

                return LastId;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        //##############################################################################################################################################################################################################
        //Search methods for Books Data Model
        //##############################################################################################################################################################################################################
        public Task<List<Books>> SearchBooks_Title(string sBookTitle)
        {
            try
            {
                string sql = @"Select * from dbo.tblBookSales Where BookTitle Like '" + sBookTitle + "'";

                return _db.LoadData<Books, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Books>> SearchBooks_ModuleCode(string sBookModuleCode)
        {
            try
            {
                string sql = @"Select * from dbo.tblBookSales Where BookTitle Like '" + sBookModuleCode + "'";

                return _db.LoadData<Books, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Books>> SearchBooks_Institue(string sBookInsitute)
        {
            try
            {
                string sql = @"Select * from dbo.tblBookSales Where BookInstitute Like '" + sBookInsitute + "'";

                return _db.LoadData<Books, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Books>> SearchBooks_PriceRange(decimal dPriceMin, decimal dPriceMax)
        {
            try
            {
                string sql = @"Select * from dbo.tblBookSales Where BookPrice >= " + dPriceMin + " and BookPrice <= " + dPriceMax + "";

                return _db.LoadData<Books, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Books>> Search_MultiChar(string sSearchValue)
        {
            try
            {
                string sql = @"Select * from dbo.tblBookSales Where BookTitle Like '%" + sSearchValue + "%' or ModuleCode Like '%" + sSearchValue + "%' Or BookInstitute Like '%" + sSearchValue + "%'";

                return _db.LoadData<Books, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        //##############################################################################################################################################################################################################
        //CRUD Methods for Books Data Model
        //##############################################################################################################################################################################################################
        public Task InsertBook(Books book)
        {
            try
            {
                string sql = @"Insert into dbo.tblBookSales(UserID,BookTitle,BookAuthor,BookEdition,BookPrice,LocationID,ModuleCode,BookInstitute,DatePosted,BookImage) 
                             values(@UserID,@BookTitle,@BookAuthor,@BookEdition,@BookPrice,@LocationID,@ModuleCode,@BookInstitute,@DatePosted,@BookImage)";

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }

        }

        public Task RemoveBook(Books book, int iSalesID)
        {
            try
            {
                string sql = @"Delete from  dbo.tblBookSales Where SalesNumber =" + iSalesID;

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        //##############################################################################################################################################################################################################
        //Update Methods for Books Data Model
        //##############################################################################################################################################################################################################
        public Task UpdateBook_BookTitle(Books book)
        {
            try
            {
                string sql = @"Update dbo.tblBookSales Set BookTitle = '" + book.BookTitle + "' Where SalesNumber = " + book.SalesNumber + "";

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateBook_UserID(Books book)
        {
            try
            {
                string sql = @"Update dbo.tblBookSales Set UserID = " + book.UserID + " Where SalesNumber = " + book.SalesNumber + "";

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateBook_BookEdition(Books book)
        {
            try
            {
                string sql = @"Update dbo.tblBookSales Set BookEdition = '" + book.BookEdition + "' Where SalesNumber = " + book.SalesNumber + "";

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateBook_BookPrice(Books book)
        {
            try
            {
                string sql = @"Update dbo.tblBookSales Set BookPrice = " + book.BookPrice + " Where SalesNumber = " + book.SalesNumber + "";

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateBook_BookLocation(Books book)
        {
            try
            {
                string sql = @"Update dbo.tblBookSales Set BookLocation = " + book.LocationID + " Where SalesNumber = " + book.SalesNumber + "";

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateBook_BookModuleCode(Books book)
        {
            try
            {
                string sql = @"Update dbo.tblBookSales Set ModuleCode = '" + book.ModuleCode + "' Where SalesNumber = " + book.SalesNumber + "";

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateBook_BookInstitute(Books book)
        {
            try
            {
                string sql = @"Update dbo.tblBookSales Set BookInstitute = '" + book.BookInstitute + "' Where SalesNumber = " + book.SalesNumber + "";

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateBook_DatePosted(Books book)
        {
            try
            {
                string sql = @"Update dbo.tblBookSales Set DatePosted = " + book.DatePosted + " Where SalesNumber = " + book.SalesNumber + "";

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateBook_All(Books book)
        {
            try
            {
                string sql = @"Update dbo.tblBookSales Set UserID = " + book.UserID + ",BookTitle = '" + book.BookTitle + "',BookAuthor = '" + book.BookAuthor + "',BookEditiion = " + book.BookEdition + ",BookPrice = " + book.BookPrice +
                             ",LocationID = " + book.LocationID + ",ModuleCode = '" + book.ModuleCode + "',BookInstitute = '" + book.BookInstitute + "',DatePosted = " + book.DatePosted +
                             " Where SalesNumber = " + book.SalesNumber + "";

                return _db.SaveData(sql, book);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        //##############################################################################################################################################################################################################
        //Other methods of Book Data Model
        //##############################################################################################################################################################################################################
        public Task<int> Count_TotalBooks()
        {
            try
            {
                var totalBooks = Task.FromResult(_db.Get<int>(@"Select COUNT(*) from dbo.tblBookSales", null, commandType: CommandType.Text));

                return totalBooks;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Books>> ListAll(int skip, int take, string orderby, string direction = "DESC")
        {
            try
            {
                var books = Task.FromResult(_db.GetAll<Books>($"Select * from dbo.tblBookSales ORDER BY {orderby} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY;",
                            null, commandType: CommandType.Text));

                return books;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Books>> OrderBooks_Price(string sOrder)
        {
            try
            {
                string sql = @"Select * from dbo.tblBookSales Order By BookPrice " + sOrder + "";

                return _db.LoadData<Books, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

    }
}

