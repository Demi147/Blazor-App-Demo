using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ILocationData
    {
        Task<string> Get_Address_LocalID(int iLocationID);
        Task<List<Locations>> Get_AllCities();
        Task<List<Locations>> Get_AllLocations();
        Task<List<Locations>> Get_AllProvince();
        Task<int> Get_LocationID_Address(string SLocationAddress, string sCity);
        Task InsertLocation(Locations location);
        Task RemoveLocation(Locations location, int iLocationID);
    }
}