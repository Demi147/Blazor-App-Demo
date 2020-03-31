using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Data;

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

        public Task<int> Count()
        {
            var totalUsers = Task.FromResult(_db.Get<int>("Select count(*) from dbo.tblUsers", null, commandType: System.Data.CommandType.Text));

            return totalUsers;
        }

        public Task<List<Users>> ListAll(int skip, int take, string orderby, string direction = "DESC")
        {
            var users = Task.FromResult(_db.GetAll<Users>($"Select * from dbo.tblUsers Order By {orderby} {direction} Offset {skip} Rows fetch next {take} rows only;", null, commandType: CommandType.Text));

            return users;
        }
    }
}
