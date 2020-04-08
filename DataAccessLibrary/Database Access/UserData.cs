using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Data;
using Dapper;

namespace DataAccessLibrary
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        //##############################################################################################################################################################################################################
        // Get methods for User Data Model
        //##############################################################################################################################################################################################################
        public Task<List<Users>> Get_AllUsers()
        {
            string sql = @"Select * From dbo.tblUsers";

            return _db.LoadData<Users, dynamic>(sql, new { });
        }

        public Task<List<Users>> Get_SingleUser(int iUserID)
        {
            string sql = @"Select * From dbo.tblUsers Where UserID =" + iUserID + "";

            return _db.LoadData<Users, dynamic>(sql, new { });
        }

        public Task<List<Users>> Get_UserID_Email(string sUserEmail)
        {
            string sql = @"Select UserID From dbo.tblUsers Where UserEmail ='" + sUserEmail + "'";

            return _db.LoadData<Users, dynamic>(sql, new { });
        }

        public Task<bool> Get_IsAdmin_UserID(int iUserID)//Method that returns true if the user is admin and false if not using the userID to find user int DB
        {
            var bAdmin = Task.FromResult(_db.Get<bool>($"Select IsAdmin From dbo.tblUsers Where UserID = " + iUserID + "", null, commandType: CommandType.Text));

            return bAdmin;
        }

        public Task<string> Get_UserEmail_UserID(int iUserID)
        {
            var sEmail = Task.FromResult(_db.Get<string>($"Select UserEmail From dbo.tblUsers Where UserID = " + iUserID + "", null, commandType: CommandType.Text));

            return sEmail;
        }

        public Task<string> Get_UserPassword_UserID(int iUserID)
        {
            var sPassword = Task.FromResult(_db.Get<string>($"Select UserPassword From dbo.tblUsers Where UserID = " + iUserID + "", null, commandType: CommandType.Text));

            return sPassword;
        }

        //##############################################################################################################################################################################################################
        // CRUD methods for User Data Model
        //##############################################################################################################################################################################################################
        public Task InsertUser(Users user)
        {
            string sql = @"Insert Into dbo.tblUsers(UserID,UserName,UserEmail,UserPassword,IsAdmin)
                          values(@UserID,@UserName,@UserEmail,@UserPassword,@IsAdmin)";

            return _db.SaveData(sql, user);
        }

        public Task RemoveUser(Users user)
        {
            string sql = @"Delete From  dbo.tblUsers Where UserID =" + user.UserID + "";

            return _db.SaveData(sql, user);
        }

        //public Task<int> UpdateUser(Users user)
        //{
        //    var dbPara = new DynamicParameters();
        //    dbPara.Add("Id", user.UserID);
        //    dbPara.Add("Name", user.UserName, DbType.String);

        //    var updateUser = Task.FromResult(_db.Update<int>("[dbo].[tblUsers]", dbPara, commandType: CommandType.StoredProcedure));

        //    return updateUser;
        //}

        //##############################################################################################################################################################################################################
        // Other methods for User Data Model
        //##############################################################################################################################################################################################################
        public Task<int> Count()
        {
            var totalUsers = Task.FromResult(_db.Get<int>($"Select count(*) From dbo.tblUsers", null, commandType: System.Data.CommandType.Text));

            return totalUsers;
        }

        public Task<List<Users>> ListAll(int skip, int take, string orderby, string direction = "DESC")
        {
            var users = Task.FromResult(_db.GetAll<Users>($"Select * From dbo.tblUsers Order By {orderby} {direction} Offset {skip} Rows fetch next {take} rows only;", null, commandType: CommandType.Text));

            return users;
        }


    }
}
