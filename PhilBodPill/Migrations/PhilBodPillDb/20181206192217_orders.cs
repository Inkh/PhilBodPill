using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhilBodPill.Migrations.PhilBodPillDb
{
    public partial class orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Basket_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Basket_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Basket_OrderID",
                table: "Basket",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Basket_ProductID",
                table: "Basket",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
