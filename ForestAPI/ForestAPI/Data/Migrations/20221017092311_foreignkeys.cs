using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForestAPI.Data.Migrations
{
    public partial class foreignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Pages",
                newName: "CategoryID");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pages_CategoryID",
                table: "Pages",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Category_CategoryID",
                table: "Pages",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Category_CategoryID",
                table: "Pages");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Pages_CategoryID",
                table: "Pages");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Pages",
                newName: "Category");
        }
    }
}
