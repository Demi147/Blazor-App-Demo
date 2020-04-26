using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class LoginTest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public bool isEqualTo(object _item)
        {
            if (_item.GetType() != typeof(LoginTest))
            {
                throw new NotImplementedException();
            }

            LoginTest x = (LoginTest)_item;

            if (x.Name==this.Name)
            {
                if (x.Password == this.Password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
