﻿using System.ComponentModel.DataAnnotations;

namespace ShopeeFood.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Menu id is needed")]
        public int MenuId { get; set; }
        [Required(ErrorMessage ="Product name is needed")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="Product price is needed")]
        public double ProductPrice { get; set; }
        [Required(ErrorMessage ="Product image is needed")]
        public string ProductImage { get; set; }
        [Required(ErrorMessage ="Amount stock is needed")]
        public int AmountStock { get; set; }
        [Required(ErrorMessage ="Amount purchased is needed")]
        public int AmountPurchased { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public List<OrderDetail> OrderDetail { get; set; }

        public List<ItemOption> ItemOption { get; set; }

        public Menu Menu { get; set; }
    }
}
