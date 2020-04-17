using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Linq;

namespace DataAccessLibrary.Bussiness_Logic.LoginLogic
{
    //TODO implement password encryption using xml


    public class LoginLogic
    {
        public Users CurrentUser { get;private set; }

        public void setUser(Users _user)
        {
            CurrentUser = _user;
            CurrentUser.UserPassword = "";
        }

        public void Flush()
        {
            CurrentUser = null;
        }

        public bool IsAdmin()
        {
            return CurrentUser.IsAdmin;
        }


    }
}
