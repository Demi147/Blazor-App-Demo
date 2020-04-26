using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Models
{
    public class Users
    {
        public int UserID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        [MaxLength(16)]
        [MinLength(6)]
        public string UserPassword { get; set; }
        public bool IsAdmin { get; set; }
    }
}
