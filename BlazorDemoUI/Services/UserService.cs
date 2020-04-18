using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace BlazorDemoUI.Services
{
    public class UserService
    {
        public Users user { get; private set; }

        public void SetUser(Users _user)
        {
            user = _user;
        }
    }
}
