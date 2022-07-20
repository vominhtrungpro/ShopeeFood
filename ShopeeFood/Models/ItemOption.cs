using System.ComponentModel.DataAnnotations;

namespace ShopeeFood.Models
{
    public class ItemOption
    {
        [Key]
        public int ItemOptionId { get; set; }
        [Required(ErrorMessage ="Product id is needed")]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Option id is needed")]
        public int OptionId { get; set; }

        public Product Product { get; set; }

        public Option Option { get; set; }
    }
}
