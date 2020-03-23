using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Linq;

namespace DataAccessLibrary.Bussiness_Logic.LoginLogic
{
    //TODO implement password encryption using xml
    //C
    //R
    //U
    //D

    public class LoginLogic
    {
        //Test list for login data
        List<LoginTest> x = new  List<LoginTest>{ new LoginTest {ID=0,Name="Joey",Password="How you doin" },
        new LoginTest{ID=1,Name="Test",Password="Test" }
        };

        //Actual logic

        //Check Login Data
        public Task<bool> CheckLogin()
        {
            return Task.FromResult(false);
        }

        //wat ek 10 teen 1 vanaf franco sal kry
        public List<LoginTest> GetAllLogins()
        {
            return  x.ToList();
        }

        //get logins with username as param
        public List<LoginTest> GetAllLogins(string _username)
        {
            return x.Where(q=>q.Name==_username) as List<LoginTest>;
        }


        public Task<bool> CheckLogin(string _userName,string _password)
        {
            //Get the list of matching Login data From Franco
            // var x = dataAcces.getlogindata(_username);
            //Check if it contains the username -- if return null or zero entries > wrong username
            //Test code 
            var q = GetAllLogins();
            var logintoTest = new LoginTest { Name = _userName, Password = _password };
            return Task.FromResult(Utilities.CheckIfContains(q, logintoTest));

        }
        //Save new Login Data
        //Get login data for user from ID


    }
}
