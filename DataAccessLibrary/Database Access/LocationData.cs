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
        private string sError = "";

        public LocationData(ISqlDataAccess db)
        {
            _db = db;
        }

        //##############################################################################################################################################################################################################
        //Get methods for Locations Data Model
        //##############################################################################################################################################################################################################
        public Task<List<Locations>> Get_AllLocations()
        {
            try
            {
                string sql = @"Select * from db.tblLocations";

                return _db.LoadData<Locations, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<int> Get_LocationID_Address(string SLocationAddress, string sCity)
        {
            try
            {
                var iLocalID = Task.FromResult(_db.Get<int>($"Select LocationID from dbo.tblLoactions Where Like '" + SLocationAddress + "' and City = '" + sCity + "'", null, commandType: CommandType.Text));

                return iLocalID;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Locations>> Get_AllProvince()
        {
            try
            {
                string sql = @"Select Province from dbo.tblLocations";

                return _db.LoadData<Locations, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Locations>> Get_AllCities()
        {
            try
            {
                string sql = @"Select City From dbo.tblLocations";

                return _db.LoadData<Locations, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<string> Get_Address_LocalID(int iLocationID)
        {
            try
            {
                var sAddress = Task.FromResult(_db.Get<string>($"Select Address From dbo.tblLocations Where LocationID =" + iLocationID + "", null, commandType: CommandType.Text));

                return sAddress;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        //##############################################################################################################################################################################################################
        //CRUD methods for Locations Data Model
        //##############################################################################################################################################################################################################
        public Task InsertLocation(Locations location)
        {
            try
            {
                string sql = @"Insert into dbo.tblLocations values(LocationsID,Province,City,Address,Building)
                          values(@LocationsID,@Province,@City,@Address,@Building)";

                return _db.SaveData(sql, location);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task RemoveLocation(Locations location, int iLocationID)
        {
            try
            {
                string sql = @"Delete from dbo.tblLocations Where LocationID=" + iLocationID;

                return _db.SaveData(sql, location);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        //##############################################################################################################################################################################################################
        //Update methods for Locations Data Model
        //##############################################################################################################################################################################################################
        public Task UpdateLocation_All(Locations location)
        {
            try
            {
                string sql = @"Update dbo.tblLocations Set Province = '" + location.Province + "',City = '" + location.City + "',Address = '" + location.Address + "'," +
                             "Building = '" + location.Building + "' Where LocationID = " + location.LocationID + "";

                return _db.SaveData(sql, location);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateLocation_Province(Locations location)
        {
            try
            {
                string sql = @"Update dbo.tblLocations Set Province = '" + location.Province + "' Where LocationId = " + location.LocationID + "";

                return _db.SaveData(sql, location);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateLocation_City(Locations location)
        {
            try
            {
                string sql = @"Update dbo.tblLocations Set City = '" + location.City + "' Where LocationId = " + location.LocationID + "";

                return _db.SaveData(sql, location);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateLocation_Address(Locations location)
        {
            try
            {
                string sql = @"Update dbo.tblLocations Set Address = '" + location.Address + "' Where LocationId = " + location.LocationID + "";

                return _db.SaveData(sql, location);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }


        public Task UpdateLocation_Building(Locations location)
        {
            try
            {
                string sql = @"Update dbo.tblLocations Set Building = '" + location.Building + "' Where LocationId = " + location.LocationID + "";

                return _db.SaveData(sql, location);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        //##############################################################################################################################################################################################################
        //Other methods of Location Data Model
        //##############################################################################################################################################################################################################

        public Task<int> Count_TotalLocations()
        {
            try
            {
                var totalLocations = Task.FromResult(_db.Get<int>($"Select Count(*) From dbo.tblLocations", null, commandType: CommandType.Text));

                return totalLocations;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Locations>> ListAll(int skip, int take, string orderby, string direction = "DESC")
        {

            try
            {
                var locations = Task.FromResult(_db.GetAll<Locations>($"Select * from dbo.tblBookSales Order By {orderby} {direction} Offset {skip} Rows fetch new {take} rows only;",
                                null, commandType: CommandType.Text));

                return locations;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }
    }
}
