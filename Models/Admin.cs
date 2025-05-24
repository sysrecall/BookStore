using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
	public class Admin
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        [Required]
        public string Password{ get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public string JoinDate { get; set; }


        //public DateTime CreatedAt { get; set; }
        //public Admin()
        //{
        //    CreatedAt = DateTime.Now;
        //}
    }
}