using System.ComponentModel.DataAnnotations;

namespace ShopeeFood.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required(ErrorMessage ="City name is needed")]
        public string CityName { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public List<Restaurant> Restaurant { get; set; }
    }
}
