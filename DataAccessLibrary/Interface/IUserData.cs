using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IUserData
    {
        Task<List<Users>> GetAllUsers();
        Task<List<Users>> GetSingleUser(int iUserID);
        Task<List<Users>> GetUser_Email(string sUserEmail);
        Task InsertUser(Users user);
        Task RemoveUser(Users user);
    }
}