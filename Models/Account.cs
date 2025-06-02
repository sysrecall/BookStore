using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Account
    {
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string PasswordHash { get; set; }
        
        public string Role { get; set; }
    }
}