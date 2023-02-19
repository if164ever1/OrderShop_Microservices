using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Monitor", "68.6 cm (27\") 16:9, IPS-Panel (matt)", "https://img.computerunivers.net/images/400x400/908610758A1A6A22A492410BAD9A4C32.jpg", "LG UltraGear 27GN800-B 68.6 cm (27\") WQHD Monitor", 289.89999999999998 },
                    { 2, "Monitor", "1920 x 1080 Full HD, Reaktionszeit 1 ms, HDR10", "https://img.computerunivers.net/images/400x400/90912818F785671B23BD4C2A93CB400E.jpg", "LG UltraGear 24GN60R-B 61.0 cm (24\") Full HD Monitor", 173.90000000000001 },
                    { 3, "Monitor", "68.6 cm (27\") 16:9 Curved, VA-Panel", "https://img.computerunivers.net/images/400x400/9078908779FE8FA2CB54449EB7996CD7.jpg", "AOC CQ27G2U/BK 68.6 cm (27\") WQHD Monitor", 259.89999999999998 },
                    { 4, "Monitor", "up to 165 Hz, Adaptive Sync / FreeSync, G-SYNC®, G-SYNC® kompatibel", "https://img.computerunivers.net/images/400x400/90777448CE8646DF987A45B098375EA1.jpg", "ASUS TUF VG27AQ 68.6 cm (27\") WQHD Monitor", 319.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
