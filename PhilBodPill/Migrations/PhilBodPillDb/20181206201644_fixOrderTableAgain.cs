using Microsoft.EntityFrameworkCore.Migrations;

namespace PhilBodPill.Migrations.PhilBodPillDb
{
    public partial class fixOrderTableAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalPrice",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
