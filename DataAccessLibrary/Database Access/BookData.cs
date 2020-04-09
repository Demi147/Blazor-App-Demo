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

        //##############################################################################################################################################################################################################
        // Get methods for Book Data Model
        //##############################################################################################################################################################################################################
        public Task<List<Books>> Get_Books()
        {
            string sql = @"Select * from dbo.tblBookSales";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<List<Books>> Get_SingleBook(int iSalesNumber)
        {
            string sql = @"Select * from dbo.tblBookSales Where SalesNumber=" + iSalesNumber + "";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<List<Books>> Get_DatePosted(string sDateOrder)//parameter is either ASC or DESC 
        {
            string sql = @"Select * from dbo.tblBookSales Order By DatePosted " + sDateOrder + "";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<int> Get_UserID_SalesNumber_Title(int iSalesNumber, string sBookTitle)
        {
            var userID = Task.FromResult(_db.Get<int>($"Select UserID from dbo.tblBookSales Where SalesNumber =" + iSalesNumber + " and BookTitle Like '" + sBookTitle + "'", null, commandType: CommandType.Text));

            return userID;
        }

        public Task<int> Get_SalesNumber_User_Title(int iUserId, string sBookTitle)
        {
            var salesNumber = Task.FromResult(_db.Get<int>($"Select SalesNumber from dbo.tblBookSales Where UserId=" + iUserId + " and BookTitle Like '" + sBookTitle + "'", null, commandType: CommandType.Text));

            return salesNumber;
        }

        public Task<int> Get_LocationID_SalesNumber(int iSalesNumber)
        {
            var locationId = Task.FromResult(_db.Get<int>($"Select LocationId from dbo.tblBookSales", null, commandType: CommandType.Text));

            return locationId;
        }

        //##############################################################################################################################################################################################################
        //Search methods for Books Data Model
        //##############################################################################################################################################################################################################
        public Task<List<Books>> SearchBooks_Title(string sBookTitle)
        {
            string sql = @"Select * from dbo.tblBookSales Where BookTitle Like '" + sBookTitle + "'";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<List<Books>> SearchBooks_ModuleCode(string sBookModuleCode)
        {
            string sql = @"Select * from dbo.tblBookSales Where BookTitle Like '" + sBookModuleCode + "'";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<List<Books>> SearchBooks_Institue(string sBookInsitute)
        {
            string sql = @"Select * from dbo.tblBookSales Where BookInstitute Like '" + sBookInsitute + "'";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<List<Books>> SearchBooks_PriceRange(decimal dPriceMin, decimal dPriceMax)
        {
            string sql = @"Select * from dbo.tblBookSales Where BookPrice >= " + dPriceMin + " and BookPrice <= " + dPriceMax + "";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        public Task<List<Books>> Search_MultiChar(string sSearchValue)//Nuwe method vir search all characters
        {
            string sql = @"Select * from dbo.tblBookSales Where BookTitle Like '%" + sSearchValue + "%' or ModuleCode Like '%" + sSearchValue + "%' Or BookInstitute Like '" + sSearchValue + "'";

            return _db.LoadData<Books, dynamic>(sql, new { });
        }

        //##############################################################################################################################################################################################################
        //CRUD Methods for Books Data Model
        //##############################################################################################################################################################################################################
        public Task InsertBook(Books book)
        {
            string sql = @"Insert into dbo.tblBookSales(SalesNumber,UserID,BookTitle,BookEdition,BookPrice,LocationID,ModuleCode,BookInstitute,DatePosted)
                           values(@SalesNumber,@UserID,BookTitle,@BookEdition,@BookPrice,@LocationID,@ModuleCode,@BookInstitute,@DatePosted)";

            return _db.SaveData(sql, book);
        }

        public Task RemoveBook(Books book, int iSalesID)
        {
            string sql = @"Delete from  dbo.tblBookSales Where SalesNumber =" + iSalesID;

            return _db.SaveData(sql, book);
        }


        //Check login terug a boolean, parm email password


        //public Task UpdateUser()
        //{

        //}

        //##############################################################################################################################################################################################################
        //Other methods of Book Data Model
        //##############################################################################################################################################################################################################
        public Task<int> Count_TotalBooks()
        {
            var totalBooks = Task.FromResult(_db.Get<int>($"Select count(*) from dbo.tblBookSales", null, commandType: CommandType.Text));

            return totalBooks;
        }

        public Task<List<Books>> ListAll(int skip, int take, string orderby, string direction = "DESC")
        {
            var books = Task.FromResult(_db.GetAll<Books>($"Select * from dbo.tblBookSales Order By {orderby} {direction} Offset {skip} Rows fetch new {take} rows only;", null, commandType: CommandType.Text));

            return books;
        }

        public Task<List<Books>> OrderPrice(string order)
        {
            string sql = @"Select * from dbo.tblBookSales Order By BookPrice '"+order+"' ";
            return _db.LoadData<Books, dynamic>(sql, new { });
        }

    }
}
