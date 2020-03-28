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

        public Task<List<Users>> GetAllUsers()
        {
            string sql = "Select * from dbo.tblUsers";

            return _db.LoadData<Users, dynamic>(sql, new { });
        }

        public Task<List<Users>> GetSingleUser(int iUserID)
        {
            string sql = "Select * from dbo.tblUsers where UserID =" + iUserID + "";

            return _db.LoadData<Users, dynamic>(sql, new { });
        }


        public Task<List<Users>> GetUser_Email(string sUserEmail)
        {
            string sql = "Select * from dbo.tblUsers where UserEmail ='" + sUserEmail + "'";

            return _db.LoadData<Users, dynamic>(sql, new { });
        }

        public Task InsertUser(Users user)
        {
            string sql = @"Insert into dbo.tblUsers(UserID,UserName,UserEmail,UserPassword,IsAdmin)
                          values(@UserID,@UserName,@UserEmail,@UserPassword,@IsAdmin)";

            return _db.SaveData(sql, user);
        }

        public Task RemoveUser(Users user)
        {
            string sql = @"Delete from  dbo.tblUsers Where UserID =" + user.UserID + "";

            return _db.SaveData(sql, user);
        }

        //public Task UpdateUser(Users user)
        //{
        //    string sql =@"Update "
        //}
    }
}
