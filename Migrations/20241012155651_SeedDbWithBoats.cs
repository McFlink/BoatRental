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
            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "CurrentRenterId", "Description", "IsAvailable", "Location", "LockCombination", "Name", "PostalCode", "PricePerDay", "UserId" },
                values: new object[,]
                {
                    { 1, null, "En klassisk Smögen 45:a som är 4,5 meter och riktigt stabil!", true, null, null, "Blå faran", null, 300m, null },
                    { 2, null, "En Ockelbo på 4,2 meter, perfekt för 2 personer", true, null, null, "Röda Blixten", null, 350m, null },
                    { 3, null, "Crecent 415 är som namnet antyder 4,15m lång och en av det mest populära båtarna att fiska i. Lätt och stabil.", true, null, null, "Crecent 415", null, 350m, null },
                    { 4, null, "Denna pärla är vår minsta modell i nuläget, som sträcker 3,7m och passar en till två personer.", true, null, null, "Onda katten", null, 400m, null },
                    { 5, null, "Fin och lätt som en tandfe, den här båten ligger på 3,9 meter men är extremt stabil för sin längd", true, null, null, "Tandfen", null, 250m, null }
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
        }
    }
}
