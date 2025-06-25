﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.ViewModels
{
	public class AddUserViewModel
	{

        public string Username { get; set; }
        public string Password { get; set; } 
        public string Role { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        //public string ShippingAddress { get; set; }
        //public string BillingAddress { get; set; }
    }
}