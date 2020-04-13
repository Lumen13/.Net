using Microsoft.EntityFrameworkCore.Migrations;

namespace TechAtHome.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Db_Category",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Specification = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Db_Good",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortSpec = table.Column<string>(nullable: true),
                    LongSpec = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    IsFavour = table.Column<bool>(nullable: false),
                    Available = table.Column<bool>(nullable: false),
                    CategoryNum = table.Column<int>(nullable: false),
                    GoodModel_ListID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_Good", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Db_Good_Db_Category_GoodModel_ListID",
                        column: x => x.GoodModel_ListID,
                        principalTable: "Db_Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Db_ShopCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodModelCartID = table.Column<int>(nullable: true),
                    PriceCart = table.Column<decimal>(nullable: false),
                    ShopCartModelId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_ShopCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Db_ShopCartItem_Db_Good_GoodModelCartID",
                        column: x => x.GoodModelCartID,
                        principalTable: "Db_Good",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Db_Good_GoodModel_ListID",
                table: "Db_Good",
                column: "GoodModel_ListID");

            migrationBuilder.CreateIndex(
                name: "IX_Db_ShopCartItem_GoodModelCartID",
                table: "Db_ShopCartItem",
                column: "GoodModelCartID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Db_ShopCartItem");

            migrationBuilder.DropTable(
                name: "Db_Good");

            migrationBuilder.DropTable(
                name: "Db_Category");
        }
    }
}
