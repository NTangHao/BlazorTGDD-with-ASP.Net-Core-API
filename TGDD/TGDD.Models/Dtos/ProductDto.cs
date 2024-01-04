namespace TGDD.Models.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string ProductLine { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string ProductImages { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
