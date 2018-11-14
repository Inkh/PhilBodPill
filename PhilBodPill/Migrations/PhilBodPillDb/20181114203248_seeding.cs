using Microsoft.EntityFrameworkCore.Migrations;

namespace PhilBodPill.Migrations.PhilBodPillDb
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Have some tea with Bertrand Russell", "/Pillows/BertrandRussell.png", "Bertrand Russell Pillow", 15m },
                    { 2, "Have some fun with Friedrich Nietzche", "/Pillows/FriedrichNietzche.png", "Friedrich Nietzche", 15m },
                    { 3, "Sleep with Immanuel Kant", "/Pillows/ImmanuelKant.png", "Immanuel Kant", 15m },
                    { 4, "Whoa", "/Pillows/KarlMarx.png", "Karl Marx", 15m },
                    { 5, "Chill with Ludwig for a while", "/Pillows/LudwigWittgenstein.png", "Ludwig Wittgenstein", 15m },
                    { 6, "It's Musashi!", "/Pillows/MiyamotoMusashi.png", "Miyamoto Musashi", 15m },
                    { 7, "It's Plato! What else can we say?", "/Pillows/Plato.png", "Plato", 15m },
                    { 8, "Sleep well with Rene", "/Pillows/ReneDescartes.png", "Rene Descartes", 15m },
                    { 9, "Never have insomnia", "/Pillows/SorenKierkegaard.png", "Soren Kierkegaard", 15m },
                    { 10, "Keep your nights cozy and warm", "/Pillows/ThomasAquinas.png", "Thomas Aquinas", 15m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 10);
        }
    }
}
