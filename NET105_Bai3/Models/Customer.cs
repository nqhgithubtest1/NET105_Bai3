using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NET105_Bai3.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MinLength(6)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
