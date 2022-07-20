using System.ComponentModel.DataAnnotations;

namespace ShopeeFood.Models
{
    public class OptionType
    {
        [Key]
        public int OptionTypeId { get; set; }
        [Required(ErrorMessage ="OptionType name is needed")]
        public string OptionTypeName { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public List<Option> Option { get; set; }

    }
}
