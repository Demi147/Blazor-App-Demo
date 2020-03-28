using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class LocationData : ILocationData
    {
        private readonly ISqlDataAccess _db;

        public LocationData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<Locations>> GetLocations()
        {
            string sql = "Select * from db.tblLocations";

            return _db.LoadData<Locations, dynamic>(sql, new { });
        }

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
