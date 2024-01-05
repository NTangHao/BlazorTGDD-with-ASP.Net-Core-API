using Microsoft.EntityFrameworkCore;
using Products.API.Models;

namespace Products.API.Data
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = "PHONE",
                    Name = "Phones",
                    Description = "All kinds of smartphones",
                    BannerUrl= "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/11/banner/IP15-2400-600-1920x480-1.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/11/banner/ip14-AW-S8-2400-600-1920x480-1.png"
                },
                new Category
                {
                    Id = "LAPTOP",
                    Name = "Laptops",
                    Description = "All kinds of laptops",
                    BannerUrl= "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/MacBook-Pro-M3-2400-600-1920x480-1.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/MacBook-Pro-M3-2400-600-1920x480-1.png"
                }

            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Model = "iPhone 15 Pro Max",
                    Brand = "Apple",
                    ProductLine = "iPhone",
                    Color = "Blue Titanium",
                    BasePrice = 1409.61M,
                    ImageUrl = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_300x300/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-thumbtz-650x650.png",
                    ProductImage = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-7-650x650.jpg",
                    Description = "Latest iPhone model",
                    CategoryId = "PHONE",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 2,
                    Model = "iPhone 15 Pro Max",
                    Brand = "Apple",
                    ProductLine = "iPhone",
                    Color = "White Titanium",
                    BasePrice = 1362.23M,
                    ImageUrl = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-thumbtz-650x650.png",
                    ProductImage = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-4-650x650.jpghttps://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-5-650x650.jpg",
                    Description = "Latest iPhone model",
                    CategoryId = "PHONE",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    Model = "iPhone 15 Pro",
                    Brand = "Apple",
                    ProductLine = "iPhone",
                    Color = "Natural Titanium",
                    BasePrice = 1731.19M,
                    ImageUrl = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-thumbtz-650x650.png",
                    ProductImage = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-0-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-3-650x650.jpg",
                    Description = "Latest iPhone model",
                    CategoryId = "PHONE",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 4,
                    Model = "iPhone 15 Plus",
                    Brand = "Apple",
                    ProductLine = "iPhone",
                    Color = "Yellow",
                    BasePrice = 1195.22M,
                    ImageUrl = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-yellow-thumbtz-650x650.png",
                    ProductImage = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-yellow-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-8-650x650.jpg",
                    Description = "Latest iPhone model",
                    CategoryId = "PHONE",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Product
                {
                    Id = 5,
                    Model = "MacBook Pro 16 inch M3 Pro 2023",
                    Brand = "Apple",
                    ProductLine = "MacBook",
                    Color = "Midnight",
                    BasePrice = 3091.73M,
                    ImageUrl = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-black-650x650.png",
                    ProductImage = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-black-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-2-650x650.jpghttps://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-9-650x650.jpg",
                    Description = "The latest MacBook model",
                    CategoryId = "LAPTOP",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 6,
                    Model = "MacBook Pro 16 inch M3 Pro 2023",
                    Brand = "Apple",
                    ProductLine = "MacBook",
                    Color = "Silver",
                    BasePrice = 3091.73M,
                    ImageUrl = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-silver-650x650.png",
                    ProductImage = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-silver-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-9-650x650.jpg",
                    Description = "The latest MacBook model",
                    CategoryId = "LAPTOP",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
        }
    }
}
