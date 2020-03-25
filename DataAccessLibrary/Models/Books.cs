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
        public int BookEdition { get; set; }
        public double BookPrice { get; set; }
        public string ModuleCode { get; set; }
        public string BooksInstitute { get; set; }
        public string LocationID { get; set; }
    }
}
