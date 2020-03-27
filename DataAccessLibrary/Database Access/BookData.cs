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

        public Task InsertBook(Books book)
        {
            string sql = @"Insert into dbo.tblBookSales(SalesNumber,UserID,BookTitle,BookEdition,BookPrice,LocationID,ModuleCode,BookInstitute)
                           values(@SalesNumber,@UserID,BookTitle,@BookEdition,@BookPrice,@LocationID,@ModuleCode,@BookInstitute)";

            return _db.SaveData(sql, book);
        }
    }
}
