using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Linq;

namespace DataAccessLibrary.Bussiness_Logic.LoginLogic
{


    public class LoginLogic
    {
        //Test list for login data
        LoginTest[] x = new  LoginTest[]{ new LoginTest {ID=0,Name="Joey",Password="How you doin" },
        new LoginTest{ID=1,Name="Test",Password="Test" }
        };




        //Actual logic

        //Check Login Data
        public Task<bool> CheckLogin()
        {
            return Task.FromResult(false);
        }
        public Task<bool> CheckLogin(LoginTest model)
        {
            if (x.Contains(model))
            {
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }
        public Task<bool> CheckLogin(string _userName,string _password)
        {
            //Get the list of matching Login data From Franco
            // var x = dataAcces.getlogindata(_username);
            //Check if it contains the username -- if return null or zero entries > wrong username
            //if x == null return false;
            //if x.count == 0 return false;


            // if x[i].passowrd = _password return true else return false


            //Test code 
            foreach (var item in x)
            {
                if (item.Name==_userName)
                {
                    if (item.Password==_password)
                    {
                        return Task.FromResult(true);
                    }
                }
            }
            return Task.FromResult(false);

        }
        //Save new Login Data
        //Get login data for user from ID
    }
}
