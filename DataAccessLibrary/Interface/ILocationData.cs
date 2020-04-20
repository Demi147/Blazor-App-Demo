using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ILocationData
    {
        Task<int> Count_TotalLocations();
        Task<string> Get_Address_LocalID(int iLocationID);
        Task<List<Locations>> Get_AllCities();
        Task<List<Locations>> Get_AllLocations();
        Task<List<Locations>> Get_AllProvince();
        Task<int> Get_LocationID_Address(string SLocationAddress, string sCity);
        Task InsertLocation(Locations location);
        Task<List<Locations>> ListAll(int skip, int take, string orderby, string direction = "DESC");
        Task RemoveLocation(Locations location);
        Task UpdateLocation_Address(Locations location);
        Task UpdateLocation_All(Locations location);
        Task UpdateLocation_Building(Locations location);
        Task UpdateLocation_City(Locations location);
        Task UpdateLocation_Province(Locations location);
    }
}