using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IUserData
    {
        Task<List<Users>> GetUsers();
        Task InsertUser(Users user);
    }
}