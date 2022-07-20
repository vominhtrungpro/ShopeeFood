using System.ComponentModel.DataAnnotations;

namespace ShopeeFood.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        [Required(ErrorMessage ="Menu name is needed")]
        public string MenuName { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
        [Required(ErrorMessage ="Restaurant id is needed")]
        public int RestaurantId { get; set; }

        public List<Product> Product { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
