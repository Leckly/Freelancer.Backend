using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class JobRequestModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobUser");

            migrationBuilder.DropIndex(
                name: "IX_UserJobs_JobId",
                table: "UserJobs");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "UserJobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserJobs",
                table: "UserJobs",
                columns: new[] { "JobId", "UserId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserJobs",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserJobs");

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
                name: "IX_UserJobs_JobId",
                table: "UserJobs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobUser_JobsUserId",
                table: "JobUser",
                column: "JobsUserId");
        }
    }
}
