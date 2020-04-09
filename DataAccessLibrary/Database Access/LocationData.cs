using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Data;
using Dapper;

namespace DataAccessLibrary
{
    public class LocationData : ILocationData
    {
        private readonly ISqlDataAccess _db;

        //public Task<int> Get_LocationID_SalesNumber(int iSalesNumber)
        //{
        //    var locationId = Task.FromResult(_db.Get<int>($"Select LocationId from dbo.tblBookSales", null, commandType: CommandType.Text));

        //    return locationId;
        //}

        public LocationData(ISqlDataAccess db)
        {
            _db = db;
        }

        //##############################################################################################################################################################################################################
        //Get methods for Locations Data Model
        //##############################################################################################################################################################################################################
        public Task<List<Locations>> Get_AllLocations()
        {
            string sql = @"Select * from dbo.tblLocations";

            return _db.LoadData<Locations, dynamic>(sql, new { });
        }

        public Task<int> Get_LocationID_Address(string SLocationAddress, string sCity)
        {
            var iLocalID = Task.FromResult(_db.Get<int>($"Select LocationID from dbo.tblLoactions Where Like '" + SLocationAddress + "' and City = '" + sCity + "'", null, commandType: CommandType.Text));

            return iLocalID;
        }

        public Task<List<Locations>> Get_AllProvince()
        {
            string sql = @"Select Province from dbo.tblLocations";

            return _db.LoadData<Locations, dynamic>(sql, new { });
        }

        public Task<List<Locations>> Get_AllCities()
        {
            string sql = @"Select City From dbo.tblLocations";

            return _db.LoadData<Locations, dynamic>(sql, new { });
        }

        public Task<string> Get_Address_LocalID(int iLocationID)
        {
            var sAddress = Task.FromResult(_db.Get<string>($"Select Address From dbo.tblLocations Where LocationID =" + iLocationID + "", null, commandType: CommandType.Text));

            return sAddress;
        }

        //##############################################################################################################################################################################################################
        //CRUD methods for Locations Data Model
        //##############################################################################################################################################################################################################
        public Task InsertLocation(Locations location)
        {
            string sql = @"Insert into dbo.tblLocations values(LocationsID,Province,City,Address,Building)
                          values(@LocationsID,@Province,@City,@Address,@Building)";

            return _db.SaveData(sql, location);
        }

        public Task RemoveLocation(Locations location, int iLocationID)
        {
            string sql = @"Delete from dbo.tblLocations Where LocationID=" + iLocationID;

            return _db.SaveData(sql, location);
        }


    }
}
