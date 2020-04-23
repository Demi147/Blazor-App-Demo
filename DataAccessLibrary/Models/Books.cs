using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Models
{
    public class Books
    {
        
        public int SalesNumber { get; set; }
        public int UserID { get; set; }

        [Required(ErrorMessage = "Enter the Title")]
        public string BookTitle { get; set; }

        [Required(ErrorMessage = "Enter the Author")]
        public string BookAuthor { get; set; }

        [Required(ErrorMessage = "Enter the Edition")]
        [Range(1, 100, ErrorMessage = "Enter a valid Edition range")]
        public int BookEdition { get; set; }

        [Required(ErrorMessage = "Enter the Price")]
        [Range(1, 10000, ErrorMessage ="The book price can only be a numeric value")]
        public double BookPrice { get; set; }

        [Required(ErrorMessage = "Enter the Module Code")]
        [StringLength(10, MinimumLength = 5, ErrorMessage ="The module code cannot be shorter or longer than 7")]
        public string ModuleCode { get; set; }

        [Required(ErrorMessage = "Enter the Institute")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "That institute does not exist")]
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
