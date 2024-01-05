using System.ComponentModel.DataAnnotations;

namespace Products.API.Models
{
    public class ProductReview
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; } // Giả sử đã có model Customer
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        // Mối quan hệ: Một ProductReview thuộc về một Product
        public Product Product { get; set; }
    }
}
