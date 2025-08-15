using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class JobFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Job");
        }
    }
}
