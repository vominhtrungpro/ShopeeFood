using System.ComponentModel.DataAnnotations;

namespace ShopeeFood.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Category name is needed")]

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public List<RestaurantType> RestaurantType { get; set; }
    }
}
