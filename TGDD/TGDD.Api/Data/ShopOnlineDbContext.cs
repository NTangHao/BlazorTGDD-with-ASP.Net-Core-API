using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TGDD.Api.Entities;

namespace TGDD.Api.Data
{
    public class ShopOnlineDbContext : IdentityDbContext<IdentityUser>
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
                Name = "IPhone 15 Pro Max",
                Brand = "Apple",
                ProductLine = "iPhone",
                Color = "Blue Titanium",
                Description = "Latest iPhone model",
                ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_300x300/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-thumbtz-650x650.png",
                ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-7-650x650.jpg",
                Price = 1409.61M,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "IPhone 15 Pro Max",
                Brand = "Apple",
                ProductLine = "iPhone",
                Color = "White Titanium",
                Description = "Latest iPhone model",
                ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-thumbtz-650x650.png",
                ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-4-200x200.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-4-200x200.jpg",
                Price = 1362.23M,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "IPhone 15 Pro",
                Brand = "Apple",
                ProductLine = "iPhone",
                Color = "Natural Titanium",
                Description = "Latest iPhone model",
                ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-thumbtz-650x650.png",
                ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-0-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-3-650x650.jpg",
                Price = 1731.19M,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "IPhone 15 Plus",
                Brand = "Apple",
                ProductLine = "iPhone",
                Color = "Yellow",
                Description = "Latest iPhone model",
                ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-yellow-thumbtz-650x650.png",
                ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-yellow-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-8-650x650.jpg",
                Price = 1195.22M,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "MacBook Pro 16 inch M3 Pro 2023",
                Brand = "Apple",
                ProductLine = "MacBook",
                Color = "Midnight",
                Description = "The latest MacBook model",
                ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-black-650x650.png",
                ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-black-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318236/s16/apple-macbook-pro-16-inch-m3-max-2023-16-core-black-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-9-650x650.jpg",
                Price = 3091.73M,
                Qty = 85,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "MacBook Pro 16 inch M3 Pro 2023",
                Brand = "Apple",
                ProductLine = "MacBook",
                Color = "Silver",
                Description = "The latest MacBook model",
                ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-silver-650x650.png",
                ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-silver-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-9-650x650.jpg",
                Price = 3091.73M,
                Qty = 120,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "MacBook Air 13 inch M1 2020",
                Brand = "Apple",
                ProductLine = "MacBook",
                Color = "Golden",
                Description = "The latest MacBook model",
                ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_300x300/https://cdn.tgdd.vn/Products/Images/44/231244/s16/mac-air-13-m1-vang-650x650.png",
                ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/mac-air-13-m1-vang-200x200.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-gold-01-200x200.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-gold-02-200x200.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-gold-03-200x200.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-gold-04-200x200.jpg",
                Price = 803.28M,
                Qty = 200,
                CategoryId = 2

            });

            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Phone",
                IconCSS = "bi bi-phone",
                BannerImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2024/01/banner/iPhone13-2400-600-1920x480.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/iPhone11-2400-600-1920x480.png"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Laptop",
                IconCSS = "bi bi-laptop",
                BannerImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/Mac-Air-M2-2400-600-1920x480.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/Mac-Air-M1-2400-600-1920x480.png"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Tablet",
                IconCSS = "bi bi-tablet",
                BannerImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/ipad9-2400-600-1920x480.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2024/01/banner/iPad-Air5-2400-600-1920x480.png"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Accessory",
                IconCSS = "fas fa-shoe-prints",
                BannerImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/Phu-kien-2400-600-1920x480-2.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2024/01/banner/OLIP-15-2400-600-1920x480.png"
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
