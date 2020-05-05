using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Models
{
    public class FrontEndUser
    {
        public int UserID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }

        public bool IsAdmin { get; set; }
    }
}
