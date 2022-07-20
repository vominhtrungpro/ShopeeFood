using System.ComponentModel.DataAnnotations;

namespace ShopeeFood.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        [Required(ErrorMessage ="Order id is needed")]
        public int OrderId { get; set; }
        [Required(ErrorMessage ="Product id is needed")]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Amount is needed")]
        public int Amount { get; set; }
        [Required(ErrorMessage ="Price is needed")]
        public double Price { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
