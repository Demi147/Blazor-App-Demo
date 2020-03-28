using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

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
    }
}
