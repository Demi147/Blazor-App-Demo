using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemoUI.Models
{
    public class DisplayUserModel
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Name is to long")]
        [MinLength(1, ErrorMessage = "Name is to short")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Password is to long")]
        [MinLength(6, ErrorMessage = "Password is to short")]
        public string UserPassword { get; set; }

        public bool IsAdmin { get; set; }
    }
}
