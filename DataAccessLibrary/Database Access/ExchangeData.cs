using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class ExchangeData : IExchangeData
    {
        private readonly ISqlDataAccess _db;

        public ExchangeData(ISqlDataAccess db)
        {
            _db = db;
        }
        //##############################################################################################################################################################################################################
        //Get methods for Exchange Data Model
        //##############################################################################################################################################################################################################
        public Task<List<Exchange>> Get_AllExchanges()
        {
            string sql = "Select * from dbo.tblExchange";

            return _db.LoadData<Exchange, dynamic>(sql, new { });
        }

        //##############################################################################################################################################################################################################
        //CRUD methods for Exchange Data Model
        //##############################################################################################################################################################################################################
        public Task InsertExchange(Exchange exchange)
        {
            string sql = @"Insert into dbo.tblExchange(ExchangeID,UserID,SalesNumber)
                              values(@ExchangeID,@UserID,@SalesNumber)";

            return _db.SaveData(sql, exchange);
        }

        public Task RemoveExchange(Exchange exchange, int iExchangeID)
        {
            string sql = @"Delete from dbo.tblExchange Where ExchangeID=" + iExchangeID;

            return _db.SaveData(sql, exchange);
        }
    }

}

