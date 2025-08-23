using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CascadeDeletionForJobRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__UserJobs__JobId__03F0984C",
                table: "JobRequests");

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2025, 7, 24, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1727), new DateTime(2025, 8, 3, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1732), 11 });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1746), new DateTime(2025, 8, 13, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1746), 11 });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 24, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1748), new DateTime(2025, 7, 9, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1752), new DateTime(2025, 8, 8, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1754), new DateTime(2025, 8, 18, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 14, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1758), new DateTime(2025, 7, 24, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 18, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1761), new DateTime(2025, 8, 25, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1763), new DateTime(2025, 8, 13, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1765), new DateTime(2025, 8, 11, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 16, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1768), new DateTime(2025, 8, 24, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 4, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1770), new DateTime(2025, 7, 14, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1773), new DateTime(2025, 8, 8, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1776), new DateTime(2025, 8, 16, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 19, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1814), new DateTime(2025, 7, 29, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 15, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1817), new DateTime(2025, 8, 21, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 20, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1827), new DateTime(2025, 8, 22, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 21, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1830), new DateTime(2025, 8, 26, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1834), new DateTime(2025, 8, 18, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 17, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1836), new DateTime(2025, 8, 25, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 3, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1839), new DateTime(2025, 8, 11, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIgbUKFSBEY27FYUUxQdMa3hLg1EVukRU48fy1YRIZ3CFRzLc/rU2j6JATKISIwpOg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEF2ewPxGGsT1HmClUsbdN0Je2sejORU5AYpEpP5VTIQhuG8qJxhPHSc/DweOB0PmUA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAR/kBfA/zZMm5gNZwpgszvruO8RmXXAk0kgLTEbdE5f3QLpeejH2VGziiOfmb3sMQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBW6r/yjlVD3pMg17kdxQc+yzJqTWaiQb18SwzOQ0sjCFirOwKzQaZ7GYqMazZzwhA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJJbbG9DkYMpqjw8Pwwx3gkUqgqjbyk3QHFIuYvIu4xAT3CTakIxaCmoMOuborBEPQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPp5gcQtFykBqewQ+lsnU3nbRyrYu9V24I7MpsiAE8S7ME8OfCldX8rm2n2DVsKdvA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIJVEMH8nQmH6eFHjp5cpovks0+ztlPpHkQL6BOvNM5dH47jKhJectGJAOVrRUhSFA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELfPzYAXRf3GNbhu1SFwr7wirncFug8/o+dgdYNzEPRqEG7TbpVcChu5LsCBuh21gA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFYM6qCQdwitxmOj0YOp3fLLUnGry4571zyw//kz/4pPX89l0p1alJgxASWZK3cD2Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGeji7lH8oH6MOLl9AH62VejlLHmIV6VzT3kGzUTElTU/eyAqkdL4C732Q1j3PtQZQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFVmuB2VHvBUg8aqW4h7+V9NL5Icpo7ckWAg87f6PtfzLWrzMmEq7+Al4rjEW+9Mvg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECsHbUv+cWi3bW/y3rxT6PqgOkL79Gsg0a3L6vZffvUWjEQO4us7CsB8JnTa5jxWJg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIMAjKShzgzDw6C2sNsBLpAM3UveRwBE5i5UcOtBiogtodu985J+JKdtOzH0KcDvHQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIKjZuTjm8l5ZbbI+m/ZqZ9EcTuJXSGQM7WEWMV8ldLJ/+sO6yzSO1QqbyEeZlB1Vw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENURtYMI4YKET6cs6VkKKV41cw3puORQ1vl5si1KXeqFRxWKwABxtcQvg/aI27frOA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHI445FpSIWLtl8o7tSnAz9WW5X1uJst0i5bfx1S9PeE1VElfWCCJAu5f6/Vz6124w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIk44WWl/gBA8Nsn/iiccUNQoZQ9yjF6X+angGvunQGndbeejZ1XE5XUajApqPea5Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAV6uJRlaZKblneDJzxPabn3k38pRgvc3fetgR4uKbv0neMweup1jY/B6e8Jr4c89Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKvokgS8uDop4643+XB3AK44tAfST3El4ElfxBv1v8/1Kb8mXAhzOAe6y/KtFjAOGQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOEpQm+maxZU1dIDtMzmCE3PVSifzQWiRbfX7xVsM60WtICkf2gew+0BJ9snp02Cuw==");

            migrationBuilder.AddForeignKey(
                name: "FK__UserJobs__JobId__03F0984C",
                table: "JobRequests",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__UserJobs__JobId__03F0984C",
                table: "JobRequests");

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2025, 7, 23, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7463), new DateTime(2025, 8, 2, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7469), 10 });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2025, 8, 7, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7480), new DateTime(2025, 8, 12, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7481), 10 });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 23, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7483), new DateTime(2025, 7, 8, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 28, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7485), new DateTime(2025, 8, 7, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 12, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7488), new DateTime(2025, 8, 17, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 13, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7492), new DateTime(2025, 7, 23, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 17, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7497), new DateTime(2025, 8, 24, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 2, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7499), new DateTime(2025, 8, 12, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 4, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7501), new DateTime(2025, 8, 10, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 15, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7505), new DateTime(2025, 8, 23, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7507), new DateTime(2025, 7, 13, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 31, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7510), new DateTime(2025, 8, 7, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 10, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7512), new DateTime(2025, 8, 15, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 18, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7519), new DateTime(2025, 7, 28, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 14, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7521), new DateTime(2025, 8, 20, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 19, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7528), new DateTime(2025, 8, 21, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 20, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7530), new DateTime(2025, 8, 25, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 8, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7533), new DateTime(2025, 8, 17, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 16, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7536), new DateTime(2025, 8, 24, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 2, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7538), new DateTime(2025, 8, 10, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHnutzaWaiZi+r3GMoVGzuvnObgX9dWNBs9Kw7Jhdb2WYrRXhSVVpD+yMSGTfO4Q0w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOK+kq5f+EBupxP/LsUJ3GNiME/PCzdiELUBNIKG9a40CkP8u6oAiQwBiU6uY7WG+g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBGajixKBLYXdPfTbfRj6uq2oKJ3sRohr6rlsi7Dr9oOrnI1kNZ69tbG8E9o6j6IFw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECU7NIbT63fw00MChdsQBaXear/26rHqUuqv65ptCiPghij3xT12wZgFqOh917S7mg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMBXxL1KH5t59hk4h3MTzxVCpuEei3iL4HaC9amsJAI9tVaT5baNtAULA9iED81H9Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEI2Aott+RmlEf4siCQbiWGPC2cWtpaxIAEyOjCwNyxp1JP3Z17I+DdXLGP0nvRHzGg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDkQ+IjX5GtdfwSmKiewkDLROQZb+1G8ufTiJPbCcnnvvR0abnSBQIOwdNQ9OXOq6w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHVNh7UlpSGHNFMhFLC+xgyQ+Xb2W07e2q59Fmx9aEJi9WQRZanL/0nNbMyHkYJ4nw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOKUAzxSbTAT7YHasgAT9OMtH6ul3IUwsEns3QQNbZj6+11W5uEeCTA4hZ7gr/FFJQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPWUeLmLZhkdkOEe4oJgN7GzPl2ntzwFpPCI7L1xEJX+LbjhNqxsa47hc/k0SMqt+Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAgYHI21sUuw+R5iWLgZjC1morYxIJqtmyJFzSE+L9ZPdowGLkbkSurm6RQtzuxvuw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPYL8V983SesE3D+zlgVqm7Vkfu58eapYNXgevqoYd6wqx7lVg5QyqVGx5rnSzfVMQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJVxO1u+dglATsDnKg8OqNtH115M3UT95lwvKs7OCnE0FRn83m+7J6Bl49YMhrYoqg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ5bnyPWUM9bJnUof0HGMCOFYE78p7c3LIgdoxz3m+AeeobFK8tI4nxm6dc7rpjfaQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEK8WV/z+x1bog6+zftjIpA9Rf3hMi55M4hYbYHEZSOTTWjsWjIy8BCiZchYfOjnAJA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAfLomjXiNcSK9KNNRBmJDTzLg1Cyd8s8WOSzo8kiFI/KGlBqD16JpN4FuGZn2u73w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIasYdg7T4n/KDpYVnWf4bacYZ7TonF36AkiVdI3qOqMgoC7l17jScOFgqD3Y7hj5g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPsoFZPMT1gd/fbxfgJ1RJfr2RhbMHAX4Ym5tn+7hC6ropqfwXix9T5YF0vK/6Qm3w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFRAwSNYDlbbXXkYXYZRkQjLVifdLaeBSebosi8CEa/9yG7h1DJYBsJ7//6sbUIMGA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBv62lP7eaVmOSHUVOJpITiWMqmApRVS8hlle44BMeBNgqJtvhuw44dLNgnW7G/QwA==");

            migrationBuilder.AddForeignKey(
                name: "FK__UserJobs__JobId__03F0984C",
                table: "JobRequests",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id");
        }
    }
}
