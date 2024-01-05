using System.ComponentModel.DataAnnotations;

namespace Products.API.Models
{

    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string ProductLine { get; set; }

        [Required]
        public string Color { get; set; }
        public decimal BasePrice { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string ProductImage { get; set; }

        public string? Description { get; set; }

        public string CategoryId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Category Category { get; set; }

        public ICollection<ProductReview> ProductReviews { get; set; }
    }

}
