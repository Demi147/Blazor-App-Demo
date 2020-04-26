using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    //TODO implement better book search capability

    public class BookTest
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public bool isEqualTo(object _item)
        {
            if (_item.GetType() != typeof(BookTest))
            {
                throw new NotImplementedException();
            }

            BookTest x = (BookTest)_item;

            if (x.Title == this.Title)
            {
                return true;
            }

            return false;
        }
    }
}
