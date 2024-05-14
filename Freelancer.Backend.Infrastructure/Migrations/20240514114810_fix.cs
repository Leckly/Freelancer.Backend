using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__JobTags__JobId__01142BA1",
                table: "JobTags");

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Photo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobUser",
                columns: table => new
                {
                    JobUsersId = table.Column<int>(type: "int", nullable: false),
                    JobsUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobUser", x => new { x.JobUsersId, x.JobsUserId });
                    table.ForeignKey(
                        name: "FK_JobUser_Job_JobsUserId",
                        column: x => x.JobsUserId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobUser_User_JobUsersId",
                        column: x => x.JobUsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_JobId",
                table: "Photo",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobUser_JobsUserId",
                table: "JobUser",
                column: "JobsUserId");

            migrationBuilder.AddForeignKey(
                name: "FK__JobTags__JobId__01142BA1",
                table: "JobTags",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Job_JobId",
                table: "Photo",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__JobTags__JobId__01142BA1",
                table: "JobTags");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Job_JobId",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "JobUser");

            migrationBuilder.DropIndex(
                name: "IX_Photo_JobId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Photo");

            migrationBuilder.AddForeignKey(
                name: "FK__JobTags__JobId__01142BA1",
                table: "JobTags",
                column: "JobId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
