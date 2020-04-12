using Microsoft.EntityFrameworkCore.Migrations;

namespace TechAtHome.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShopIDCart",
                table: "Db_ShopCartItem");

            migrationBuilder.AddColumn<string>(
                name: "ShopCartModelId",
                table: "Db_ShopCartItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShopCartModelId",
                table: "Db_ShopCartItem");

            migrationBuilder.AddColumn<string>(
                name: "ShopIDCart",
                table: "Db_ShopCartItem",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
