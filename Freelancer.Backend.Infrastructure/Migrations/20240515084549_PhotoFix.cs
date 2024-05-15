using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PhotoFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__JobPhoto__JobId__07C12930",
                table: "JobPhoto");

            migrationBuilder.DropForeignKey(
                name: "FK__JobPhoto__PhotoI__08B54D69",
                table: "JobPhoto");

            migrationBuilder.DropForeignKey(
                name: "FK__User__PhotoId__7F2BE32F",
                table: "User");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_User_PhotoId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_JobPhoto_PhotoId",
                table: "JobPhoto");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "JobPhoto");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "JobPhoto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "JobPhoto",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "JobPhoto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "JobPhoto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPhoto",
                table: "JobPhoto",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserPhoto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPhoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK__User__PhotoId__7F2BE32F",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPhoto_UserId",
                table: "UserPhoto",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK__JobPhoto__JobId__07C12930",
                table: "JobPhoto",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__JobPhoto__JobId__07C12930",
                table: "JobPhoto");

            migrationBuilder.DropTable(
                name: "UserPhoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPhoto",
                table: "JobPhoto");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "JobPhoto");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "JobPhoto");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "JobPhoto");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "JobPhoto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PhotoId",
                table: "JobPhoto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_PhotoId",
                table: "User",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPhoto_PhotoId",
                table: "JobPhoto",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_JobId",
                table: "Photo",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK__JobPhoto__JobId__07C12930",
                table: "JobPhoto",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__JobPhoto__PhotoI__08B54D69",
                table: "JobPhoto",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__User__PhotoId__7F2BE32F",
                table: "User",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "Id");
        }
    }
}
