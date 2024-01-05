using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TGDD.Api.Migrations
{
    /// <inheritdoc />
    public partial class addDataProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Color", "Description", "ImageURL", "Name", "Price", "ProductImages", "ProductLine", "Qty" },
                values: new object[] { 8, "Apple", 2, "Silver", "The latest MacBook model", "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/mac-air-13-m1-bac-650x650.png", "MacBook Air 13 inch M1 2020", 803.28m, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/mac-air-13-m1-bac-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-silver-01-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-silver-02-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-silver-03-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-silver-04-650x650.jpg", "MacBook", 100 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
