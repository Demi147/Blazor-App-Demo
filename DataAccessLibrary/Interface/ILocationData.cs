using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ILocationData
    {
        Task<List<Locations>> GetLocations();
        Task InsertLocation(Locations location);
    }
}