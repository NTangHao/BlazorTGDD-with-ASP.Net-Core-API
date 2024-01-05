namespace CloneTGDD.Web.Models.DTO
{
    public class ProductsDTO
    {
        public int Id { get; set; }

        public required string Model { get; set; }

        public required string Brand { get; set; }

        public required string ProductLine { get; set; }

        public required string Color { get; set; }

        public decimal BasePrice { get; set; }
        public string Category { get; set; }
        public int AvailableStock { get; set; }

        public string? Description { get; set; }

        public required string ImageUrl { get; set; }

        public required string ProductImage { get; set; }
    }
}
