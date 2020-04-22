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
        [StringLength(30, MinimumLength = 5, ErrorMessage = "That Province does not exist")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Enter the City")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "That City does not exist")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter the Address")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "The address cannot be longer than a 100 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter the Building")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "That building does not exist")]
        public string Building { get; set; }
    }
}
