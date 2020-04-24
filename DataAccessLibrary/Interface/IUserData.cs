using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IUserData
    {
        Task<int> Count();
        Task<List<Users>> Get_AllUsers();
        Task<bool> Get_IsAdmin_UserID(int iUserID);
        Task<List<Users>> Get_SingleUser(int iUserID);
        Task<string> Get_UserEmail_UserID(int iUserID);
        Task<int> Get_UserID_Email(string sUserEmail);
        Task InsertUser(Users user);
        Task<List<Users>> ListAll(int skip, int take, string orderby, string direction = "DESC");
        Task RemoveUser(Users user);
        Task UpdateUser_Admin(Users user);
        Task UpdateUser_All(Users user);
        Task UpdateUser_UserEmail(Users user);
        Task UpdateUser_UserName(Users user);
        Task<bool> VarifyLogin(string sEmail, string sPassword);
    }
}