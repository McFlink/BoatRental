using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoatRental.Migrations
{
    /// <inheritdoc />
    public partial class SeedDbWithBoats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Boats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "CurrentRenterId", "Description", "IsAvailable", "Location", "LockCombination", "PostalCode", "PricePerDay", "UserId" },
                values: new object[,]
                {
                    { 1, null, "Blå faran", true, null, null, null, 300m, null },
                    { 2, null, "Röda blixten", true, null, null, null, 350m, null },
                    { 3, null, "Crecent 415", true, null, null, null, 350m, null },
                    { 4, null, "Onda katten", true, null, null, null, 400m, null },
                    { 5, null, "Tandfen", true, null, null, null, 250m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Boats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
