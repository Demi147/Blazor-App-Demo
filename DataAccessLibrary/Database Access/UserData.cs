using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<Users>> GetUsers()
        {
            string sql = "Select * from dbo.tblUsers";

            return _db.LoadData<Users, dynamic>(sql, new { });
        }

        public Task InsertUser(Users user)
        {
            string sql = @"Insert into dbo.tblUsers(UserID,UserName,UserEmail,UserPassword,IsAdmin)
                          values(@UserID,@UserName,@UserEmail,@UserPassword,@IsAdmin)";

            return _db.SaveData(sql, user);
        }
    }
}
