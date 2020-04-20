using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Models
{
    public class Locations
    {   
        public int LocationID { get; set; }

        [Required(ErrorMessage = "Enter the Province")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Enter the City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter the Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter the Building")]
        public string Building { get; set; }
    }
}
