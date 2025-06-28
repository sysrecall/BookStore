using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Models.Store;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
	public class Admin
	{
        public int Id { get; set; }
        [ForeignKey("Account")]
        public int AccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public string JoinDate { get; set; }
        public virtual Account Account { get; set; }
    }
}