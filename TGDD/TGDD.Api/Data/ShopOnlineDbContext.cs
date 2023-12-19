using Microsoft.EntityFrameworkCore;
using TGDD.Api.Entities;

namespace TGDD.Api.Data
{
    public class ShopOnlineDbContext : DbContext
    {
        public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Products
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Iphone 14",
                Description = "High end phone",
                ImageURL = "https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-xanh-1.jpg",
                Price = 100,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Vivo",
                Description = "Android Phone",
                ImageURL = "https://cdn.tgdd.vn/Products/Images/42/309723/vivo-y02t-den-1.jpeg",
                Price = 50,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Vivoy92",
                Description = "Android Phone",
                ImageURL = "https://cdn.tgdd.vn/Products/Images/42/309723/vivo-y02t-xanh-tim-1.jpeg",
                Price = 20,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Vivo v29",
                Description = "Android phone",
                ImageURL = "https://cdn.tgdd.vn/Products/Images/42/314203/vivo-v29e-xanh-glr-1.jpg",
                Price = 50,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Redmi 13c",
                Description = "Skin Care Kit, containing skin care and hair care products",
                ImageURL = "https://cdn.tgdd.vn/Products/Images/42/316771/xiaomi-redmi-13c-xanh-1-1.jpg",
                Price = 30,
                Qty = 85,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Air Pods",
                Description = "Air Pods - in-ear wireless headphones",
                ImageURL = "https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-xanh-1.jpg",
                Price = 100,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Iphone 13",
                Description = "IOS Phone",
                ImageURL = "https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-xanh-1.jpg",
                Price = 40,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Xiaomi 13T Pro",
                Description = "Highend android phone",
                ImageURL = "https://cdn.tgdd.vn/Products/Images/42/309816/xiaomi-13t-pro-xanh-1.jpg",
                Price = 40,
                Qty = 300,
                CategoryId = 3

            });
          
           
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Phone",
                IconCSS = "fas fa-phones"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Laptop",
                IconCSS = "fas fa-couch"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Flaship",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Gear",
                IconCSS = "fas fa-shoe-prints"
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Hao"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Dung"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });


        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
