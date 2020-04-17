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
        private string sError = "";
        public ExchangeData(ISqlDataAccess db)
        {
            _db = db;
        }

        //##############################################################################################################################################################################################################
        //Get methods for Exchange Data Model
        //##############################################################################################################################################################################################################
        public Task<List<Exchange>> Get_AllExchanges()
        {
            try
            {
                string sql = "Select * from dbo.tblExchange";

                return _db.LoadData<Exchange, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        //##############################################################################################################################################################################################################
        //CRUD methods for Exchange Data Model
        //##############################################################################################################################################################################################################
        public Task InsertExchange(Exchange exchange)
        {
            try
            {
                string sql = @"Insert into dbo.tblExchange(ExchangeID,UserID,SalesNumber)
                              values(@ExchangeID,@UserID,@SalesNumber)";

                return _db.SaveData(sql, exchange);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task RemoveExchange(Exchange exchange, int iExchangeID)
        {
            try
            {
                string sql = @"Delete from dbo.tblExchange Where ExchangeID=" + iExchangeID;

                return _db.SaveData(sql, exchange);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        //##############################################################################################################################################################################################################
        //Update methods for Exchange Data Model
        //##############################################################################################################################################################################################################

        public Task UpdateExchange_All(Exchange exchange)
        {
            try
            {
                string sql = @"Update dbo.tblExchange Set UserID = " + exchange.UserID + ", SalesNumber = " + exchange.SalesNumber + "Where ExchangeID = " + exchange.ExchangeID + "";

                return _db.SaveData(sql, exchange);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

    }

}

