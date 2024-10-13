using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoatRental.Migrations
{
    /// <inheritdoc />
    public partial class ImageNameFieldInBoatModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Boats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageName",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Boats");
        }
    }
}
