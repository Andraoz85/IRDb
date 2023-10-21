using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace IRDb.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Movies",
                type: "decimal(3,1)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Action", 7.8m, "Matrix", 1999 },
                    { 2, "Thriller", 8.6m, "The Silence of the Lambs", 1991 },
                    { 3, "Drama", 8.7m, "One Flew Over the Cuckoo's Nest", 1975 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Movies",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)");
        }
    }
}
