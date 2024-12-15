using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobNet.Data.Migrations
{
    /// <inheritdoc />
    public partial class Dto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_JobID",
                table: "Requests",
                column: "JobID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserID",
                table: "Requests",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_EmployerID",
                table: "Jobs",
                column: "EmployerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Employers_EmployerID",
                table: "Jobs",
                column: "EmployerID",
                principalTable: "Employers",
                principalColumn: "EmployerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Jobs_JobID",
                table: "Requests",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserID",
                table: "Requests",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Employers_EmployerID",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Jobs_JobID",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserID",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Requests_JobID",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_UserID",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_EmployerID",
                table: "Jobs");
        }
    }
}
