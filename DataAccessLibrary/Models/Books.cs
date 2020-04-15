using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class Books
    {
        public int SalesNumber { get; set; }
        public int UserID { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int BookEdition { get; set; }
        public double BookPrice { get; set; }
        public string ModuleCode { get; set; }
        public string BookInstitute { get; set; }
        public int LocationID { get; set; }
        public DateTime DatePosted { get; set; }
        public byte[] BookImage { get; set; }

        public bool CheckIfContains(string _val)
        {
            if (BookTitle.ToLower().Contains(_val.ToLower()))
            {
                return true;
            }
            if (BookEdition.ToString().ToLower().Contains(_val.ToLower()))
            {
                return true;
            }
            if (ModuleCode.ToLower().Contains(_val.ToLower()))
            {
                return true;
            }
            if (BookInstitute.ToLower().Contains(_val.ToLower()))
            {
                return true;
            }
            try
            {
                int x = int.Parse(_val);
                if (BookPrice <= x)
                {
                    return true;
                }
            }
            catch
            {

            }

            return false;
        }
    }
}
