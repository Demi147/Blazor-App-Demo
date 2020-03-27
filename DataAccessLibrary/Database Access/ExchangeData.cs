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

        public Task<List<Exchange>> GetExchanges()
        {
            string sql = "Select * from dbo.tblExchange";

            return _db.LoadData<Exchange, dynamic>(sql, new { });

        }
        public Task InsertExchange(Exchange exchange)
        {
            string sql = @"Insert into dbo.tblExchange(ExchangeID,UserID,SalesNumber)
                              values(@ExchangeID,@UserID,@SalesNumber)";

            return _db.SaveData(sql, exchange);
        }
    }

}
 
