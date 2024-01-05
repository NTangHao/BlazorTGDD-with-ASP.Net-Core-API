using System.ComponentModel.DataAnnotations;

namespace Products.API.Models
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string BannerUrl { get; set; }

        public ICollection<Product> Products { get; set; }
    }

}
