using Microsoft.EntityFrameworkCore.Migrations;

namespace PhilBodPill.Migrations.PhilBodPillDb
{
    public partial class refresh2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Basket",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Basket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
