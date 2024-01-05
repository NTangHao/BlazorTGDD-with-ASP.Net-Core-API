namespace Products.API.Models.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string ProductLine { get; set; }
        public string Color { get; set; }
        public decimal BasePrice { get; set; }
        public string ImageUrl { get; set; }
        public string ProductImage { get; set; }
        public string? Description { get; set; }
        public string CategoryId { get; set; }
    }
}
