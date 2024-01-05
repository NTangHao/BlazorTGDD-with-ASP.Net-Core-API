using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BannerUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductReviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "BannerUrl", "Description", "Name" },
                values: new object[,]
                {
                    { "LAPTOP", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/MacBook-Pro-M3-2400-600-1920x480-1.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/MacBook-Pro-M3-2400-600-1920x480-1.png", "All kinds of laptops", "Laptops" },
                    { "PHONE", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/11/banner/IP15-2400-600-1920x480-1.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/11/banner/ip14-AW-S8-2400-600-1920x480-1.png", "All kinds of smartphones", "Phones" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasePrice", "Brand", "CategoryId", "Color", "CreatedAt", "Description", "ImageUrl", "Model", "ProductImage", "ProductLine", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1409.61m, "Apple", "PHONE", "Blue Titanium", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3542), "Latest iPhone model", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_300x300/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-thumbtz-650x650.png", "iPhone 15 Pro Max", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-7-650x650.jpg", "iPhone", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3557) },
                    { 2, 1362.23m, "Apple", "PHONE", "White Titanium", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3560), "Latest iPhone model", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-thumbtz-650x650.png", "iPhone 15 Pro Max", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-4-650x650.jpghttps://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-5-650x650.jpg", "iPhone", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3561) },
                    { 3, 1731.19m, "Apple", "PHONE", "Natural Titanium", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3563), "Latest iPhone model", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-thumbtz-650x650.png", "iPhone 15 Pro", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-0-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-3-650x650.jpg", "iPhone", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3563) },
                    { 4, 1195.22m, "Apple", "PHONE", "Yellow", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3565), "Latest iPhone model", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-yellow-thumbtz-650x650.png", "iPhone 15 Plus", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-yellow-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-8-650x650.jpg", "iPhone", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3566) },
                    { 5, 3091.73m, "Apple", "LAPTOP", "Midnight", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3568), "The latest MacBook model", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-black-650x650.png", "MacBook Pro 16 inch M3 Pro 2023", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-black-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-2-650x650.jpghttps://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-9-650x650.jpg", "MacBook", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3569) },
                    { 6, 3091.73m, "Apple", "LAPTOP", "Silver", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3571), "The latest MacBook model", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-silver-650x650.png", "MacBook Pro 16 inch M3 Pro 2023", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-silver-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-9-650x650.jpg", "MacBook", new DateTime(2023, 12, 22, 17, 45, 25, 147, DateTimeKind.Local).AddTicks(3571) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductId",
                table: "ProductReviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductReviews");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
