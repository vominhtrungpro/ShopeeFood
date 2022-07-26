﻿using System.ComponentModel.DataAnnotations;

namespace ShopeeFood.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Customer username is needed")]
        public string CustomerUsername { get; set; }
        [Required(ErrorMessage ="Customer password is needed")]

        public string CustomerPassword { get; set; }
        [Required(ErrorMessage ="Customer full name is needed")]
        public string CustomerFullname { get; set; }
        [Required(ErrorMessage ="Customer address is needed")]
        public string CustomerAddress { get; set; }
        [Required(ErrorMessage ="Customer phone number is needed")]
        public string CustomerPhone { get; set; }
        [Required(ErrorMessage ="Customer email is needed")]
        public string CustomerEmail { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public List<Order> Order { get; set; }
    }
}
