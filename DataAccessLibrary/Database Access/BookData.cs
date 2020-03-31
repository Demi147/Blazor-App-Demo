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

        public BookData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<Books>> GetBooks()
        {
            string sql = "Select * from dbo.tblBookSales";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<List<Books>> GetSingleBook(int iSalesNumber)
        {
            string sql = "Select * from dbo.tblBookSales Where SalesNumber=" + iSalesNumber + "";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<List<Books>> SearchBooks_Title(string sBookTitle)
        {
            string sql = "Select * from dbo.tblBookSales Where BookTitle Like '" + sBookTitle + "'";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<List<Books>> SearchBooks_ModuleCode(string sBookModuleCode)
        {
            string sql = "Select * from dbo.tblBookSales Where BookTitle Like '" + sBookModuleCode + "'";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<List<Books>> SearchBooks_Institue(string sBookInsitute)
        {
            string sql = "Select * from dbo.tblBookSales Where BookInstitute Like '" + sBookInsitute + "'";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task InsertBook(Books book)
        {
            string sql = @"Insert into dbo.tblBookSales(SalesNumber,UserID,BookTitle,BookEdition,BookPrice,LocationID,ModuleCode,BookInstitute)
                           values(@SalesNumber,@UserID,BookTitle,@BookEdition,@BookPrice,@LocationID,@ModuleCode,@BookInstitute)";

            return _db.SaveData(sql, book);
        }

        public Task RemoveBook(Books book, int iSalesID)
        {
            string sql = @"Delete from  dbo.tblBookSales Where SalesNumber =" + iSalesID;

            return _db.SaveData(sql, book);
        }

        public Task<int> Count()
        {
            var totalBooks = Task.FromResult(_db.Get<int>("Select count(*) from dbo.tblBookSales", null, commandType: CommandType.Text));

            return totalBooks;
        }

        public Task<List<Books>> ListAll(int skip, int take, string orderby, string direction = "DESC")
        {
            var books = Task.FromResult(_db.GetAll<Books>($"Select * from dbo.tblBookSales Order By {orderby} {direction} Offset {skip} Rows fetch new {take} rows only;", null, commandType: CommandType.Text));

            return books;
        }
    }
}
