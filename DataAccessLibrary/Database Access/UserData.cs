using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Data;
using Dapper;

namespace DataAccessLibrary
{
    public class UserData :IUserData
    {
        private readonly ISqlDataAccess _db;
        private string sError = "";

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        //##############################################################################################################################################################################################################
        #region Get methods for User Data Model
        public Task<List<Users>> Get_AllUsers()//Tested - Working
        {
            try
            {
                string sql = @"Select * From dbo.tblUsers";

                return _db.LoadData<Users, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Users>> Get_SingleUser(int iUserID)//Tested - Working
        {
            try
            {
                string sql = @"Select * From dbo.tblUsers Where UserID = " + iUserID + "";

                return _db.LoadData<Users, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<int> Get_UserID_Email(string sUserEmail)//Tested - Working
        {
            try
            {
                var iUserID = Task.FromResult(_db.Get<int>($"Select UserID From dbo.tblUsers Where UserEmail ='" + sUserEmail + "'", null, commandType: CommandType.Text));

                return iUserID;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<bool> Get_IsAdmin_UserID(int iUserID)//Tested - Working
        {
            try
            {
                var bAdmin = Task.FromResult(_db.Get<bool>($"Select IsAdmin From dbo.tblUsers Where UserID = " + iUserID + "", null, commandType: CommandType.Text));

                return bAdmin;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<string> Get_UserEmail_UserID(int iUserID)//Tested - Working
        {
            try
            {
                var sEmail = Task.FromResult(_db.Get<string>($"Select UserEmail From dbo.tblUsers Where UserID = " + iUserID + "", null, commandType: CommandType.Text));

                return sEmail;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        private Task<string> Get_UserPassword_UserID(int iUserID)//Not tested
        {
            try
            {
                var sPassword = Task.FromResult(_db.Get<string>($"Select UserPassword From dbo.tblUsers Where UserID = " + iUserID + "", null, commandType: CommandType.Text));

                return sPassword;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }
        #endregion

        //##############################################################################################################################################################################################################
        #region CRUD methods for User Data Model
        public Task InsertUser(Users user)//Tested - Working
        {
            try
            {
                string sql = @"Insert Into dbo.tblUsers(UserID,UserName,UserEmail,UserPassword,IsAdmin)
                          values(@UserID,@UserName,@UserEmail,@UserPassword,@IsAdmin)";

                return _db.SaveData(sql, user);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task RemoveUser(Users user)//Tested - Working
        {
            try
            {
                string sql = @"Delete From  dbo.tblUsers Where UserID =" + user.UserID + "";

                return _db.SaveData(sql, user);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }
        #endregion

        //##############################################################################################################################################################################################################
        #region Update methods for User Data Model
        public Task UpdateUser_All(Users user)//Tested - Working
        {
            try
            {
                string sql = @"Update dbo.tblUsers Set UserName = '" + user.UserName + "',UserEmail = '" + user.UserEmail + "' Where UserID = " + user.UserID + "";

                return _db.SaveData(sql, user);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateUser_UserName(Users user)//Tested - Working
        {
            try
            {
                string sql = @"Update dbo.tblUsers Set UserName = '" + user.UserName + "' Where UserID = " + user.UserID + "";

                return _db.SaveData(sql, user);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateUser_UserEmail(Users user)//Tested - Working
        {
            try
            {
                string sql = @"Update dbo.tblUsers Set UserEmail = '" + user.UserEmail + "' Where UserID = " + user.UserID + "";

                return _db.SaveData(sql, user);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateUser_Admin(Users user)//Tested - Working
        {
            try
            {
                string sql = @"Update dbo.tblUsers Set IsAdmin = " + user.IsAdmin + " Where UserID = " + user.UserID + "";

                return _db.SaveData(sql, user);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }
        #endregion

        //##############################################################################################################################################################################################################
        #region Other methods for User Data Model
        public Task<int> Count()//Tested - Working
        {
            try
            {
                var totalUsers = Task.FromResult(_db.Get<int>($"Select count(UserID) From dbo.tblUsers", null, commandType: CommandType.Text));

                return totalUsers;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<Users>> ListAll(int skip, int take, string orderby, string direction = "DESC")
        {
            try
            {
                var users = Task.FromResult(_db.GetAll<Users>($"Select * From dbo.tblUsers Order By {orderby} {direction} Offset {skip} Rows fetch next {take} rows only;", null, commandType: CommandType.Text));

                return users;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<bool> VarifyLogin(string sEmail, string sPassword)//Tested - Working
        {
            try
            {
                var TotalUsers = Task.FromResult(_db.Get<int>($"Select count(*) From dbo.tblUsers Where UserEmail = '" + sEmail + "' AND UserPassword = '" + sPassword + "'", null, commandType: CommandType.Text));

                var bValidLogin = false;

                int iTotal = TotalUsers.Result;

                if (iTotal == 1)
                {
                    bValidLogin = true;
                }
                else
                {
                    bValidLogin = false;
                }

                return Task.FromResult(bValidLogin);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return Task.FromResult(false); ;
            }
        }
        #endregion
    }
}
