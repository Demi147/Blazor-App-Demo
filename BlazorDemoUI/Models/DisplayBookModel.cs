using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemoUI.Models
{
    public class DisplayBookModel
    {
        public int SalesNumber { get; set; }
        public int UserID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Title is to long")]
        [MinLength(1, ErrorMessage = "Title is to short")]
        public string BookTitle { get; set; }

        public int BookEdition { get; set; }
        public double BookPrice { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Code is to long")]
        [MinLength(1, ErrorMessage = "Code is to short")]
        public string ModuleCode { get; set; }


        [Required]
        [StringLength(10, ErrorMessage = "Institute is to long")]
        [MinLength(1, ErrorMessage = "Institute is to short")]
        public string BooksInstitute { get; set; }

        public int LocationID { get; set; }
        public DateTime DatePosted { get; set; }
        public byte[] BookImage { get; set; }
    }
}
