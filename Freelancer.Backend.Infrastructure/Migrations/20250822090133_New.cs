using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 23, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7463), new DateTime(2025, 8, 2, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 7, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7480), new DateTime(2025, 8, 12, 9, 1, 31, 600, DateTimeKind.Utc).AddTicks(7481) });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 22, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(313), new DateTime(2025, 8, 1, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 6, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(325), new DateTime(2025, 8, 11, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 22, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(328), new DateTime(2025, 7, 7, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 27, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(335), new DateTime(2025, 8, 6, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 11, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(338), new DateTime(2025, 8, 16, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 12, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(342), new DateTime(2025, 7, 22, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 16, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(344), new DateTime(2025, 8, 23, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 1, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(347), new DateTime(2025, 8, 11, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 3, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(349), new DateTime(2025, 8, 9, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 14, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(385), new DateTime(2025, 8, 22, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 2, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(387), new DateTime(2025, 7, 12, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 30, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(390), new DateTime(2025, 8, 6, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 9, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(393), new DateTime(2025, 8, 14, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 17, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(399), new DateTime(2025, 7, 27, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 13, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(402), new DateTime(2025, 8, 19, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 18, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(414), new DateTime(2025, 8, 20, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 19, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(417), new DateTime(2025, 8, 24, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 7, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(420), new DateTime(2025, 8, 16, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 15, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(423), new DateTime(2025, 8, 23, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 1, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(425), new DateTime(2025, 8, 9, 14, 0, 11, 823, DateTimeKind.Utc).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAPOeJ4cd3hN5J9PMOFM7EH3sf8UwMXj9+MywU3GizcWEpBHUHYP9rFNGuaNEnC0Kg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENQNB71uhYYcx8tlWqDYd5pfr6WT9s9vUu6My1z1FQ88en/QDDbRgNeWwrUz1oEECg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE2yyFIBag5dcDSZuaolJirYxQO+zfnjxv/hWu+7T5DKx6WSPADNPGY4jX15bUBHlQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFWISWS0SQAgyzzgKKFtkpQzUAVe6AVCYWsCyUOX3auc4KO7CbJJWarif0umP/ZGLw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIUC61I6iE/Mi5dd6VMiJqz13SjPBMiOGxqT88LcB4D/nG8vM9xvZKwfTlkjTpWv+g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMsFyoOgNIyU6A+b+Pk2A1//X5ETI255kimh+VOGK5QymRFRNlcYoVXQMF4x2ZpVVQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMtPuUYlE8UZMlOTVx6TSjeBw2tXhSt/f6mPdwuoC+aehUyYIH9MaOhJGAqYVLhE+w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGgxCF0QU5OFW4DytxxaODHAuZymPNDbPJSYdxMBZK6W5JZumQs8ScJAOiyiw6SeSg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH/1z2GhWWOBPf7MZ/pcVhKT3Of1q9nMlCQ4HFIpWDy1YD/BkRQk1vi0gH8jzi26BQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFelh9HHc/7iyKQR48aAMKunr7PgZkHp5WPP3vkQj2QteeFvDyQHN83IKf8RVVz5Dg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMqO/zm9wSgfdT69dZX4xcZkX/BagYlJa0gIUh7bLRM87EEYhRxDxjEZFEeOfeFM8Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELWxnWrYBsdSTxVQ6N5ZTcp1eQcid+MIEnwbykWL5z7wT/UKhqusVgZIUkHjmEH5Vw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENEYDQAy6DpsRC43mAN9dfkCUFizLI+Ss6ZRHcDsbqZV5awU2OoI896hL9gOhRSPpA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPklnHgrbOkvndBrfAS1bi7n4oN6JPuEGQsdXxg9a8P5fE9B5XkfNS1dCXkEr1I/QA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMiWQPAquozx8fMkMQt47UvwTQfY96p14eduO/wP43A/ehLw5zqN4HbW4VoaqgDWvQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHR8SzWNKt+5CBVQaRGPjtjqGLTQUw1ioo29F3tD5RRH1KfBYuK15OBSlwYQqzTJVw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOPaporvj5aMSsrfgfHO97YBAxF8rQ56g2XvWo/JKMsSVmJbdbX20zvWPiYMFMji/w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHElmi3260oX1pRzUl7mRCRkjKmoT5wZNlLuTW9uG1Hl0VJ6rA5vqSRnUkzn5wVczg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBekvceaT0d4aXrZ2+LhSVm6gjhpFzdgMYQc962iqZ3/KVaKwdAm30WjHsjj47XLgQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGothKv81bbcEqfLG7BnPtRYBwdx0fnaT+aMaYupRMBOMHCRt8hoS33YEiFG9TWpOA==");
        }
    }
}
