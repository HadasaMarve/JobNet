using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobNet.Data.Migrations
{
    /// <inheritdoc />
    public partial class async4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employers_Users_UserID",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_Employers_UserID",
                table: "Employers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employers_UserID",
                table: "Employers",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_Users_UserID",
                table: "Employers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
