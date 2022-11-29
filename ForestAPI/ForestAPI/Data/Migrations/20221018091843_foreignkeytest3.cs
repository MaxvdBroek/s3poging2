using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForestAPI.Data.Migrations
{
    public partial class foreignkeytest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pages_CategoryID",
                table: "Pages",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Categories_CategoryID",
                table: "Pages",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Categories_CategoryID",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_CategoryID",
                table: "Pages");
        }
    }
}
