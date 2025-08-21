using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OnCascadeDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Job__UserId__02084FDA",
                table: "Job");

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

            migrationBuilder.AddForeignKey(
                name: "FK__Job__UserId__02084FDA",
                table: "Job",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Job__UserId__02084FDA",
                table: "Job");

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2265), new DateTime(2025, 7, 29, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 3, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 8, 8, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 19, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2283), new DateTime(2025, 7, 4, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 24, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2285), new DateTime(2025, 8, 3, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 8, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2288), new DateTime(2025, 8, 13, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 9, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2319), new DateTime(2025, 7, 19, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 13, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2322), new DateTime(2025, 8, 20, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 29, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2324), new DateTime(2025, 8, 8, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 31, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2327), new DateTime(2025, 8, 6, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 11, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2331), new DateTime(2025, 8, 19, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2333), new DateTime(2025, 7, 9, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 27, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2335), new DateTime(2025, 8, 3, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 6, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2339), new DateTime(2025, 8, 11, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 14, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2345), new DateTime(2025, 7, 24, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 10, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2348), new DateTime(2025, 8, 16, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 15, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2357), new DateTime(2025, 8, 17, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 16, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2360), new DateTime(2025, 8, 21, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 4, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2363), new DateTime(2025, 8, 13, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 12, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2365), new DateTime(2025, 8, 20, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 29, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2368), new DateTime(2025, 8, 6, 17, 36, 25, 641, DateTimeKind.Utc).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOo22Uq9ozqTsdqqdxi1TgJJbqE65PjzGBIsepzGDae3s5W+lNjQxtEciOoA9uHw6w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHeX+BUUV9SILqKONdm9XpUh3W7N5oTn4WSbsCE9vJuoOB8Ou3BBAeBg2pnRBmg5xQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEANtz3IA8ZFTmV1K9ibxE+7GxwnhGEqohoTG3Au737GtLccRICdmGNXNrZKFITFDZw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN1hlXAM1V/mV1H+tM5TJVczNG0QHUsyey5OZuQqRu1KfSwEXogobc5CMY4ZpANg7A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJjJasL2XXxztAQ+ffUgjFDP8Syj0m3TAjig1A9ABhyktAtbQtnB7Bqoh8UpIHlBxA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM7BcM2jFyBss49VIH66MAzbVlIa78uh7/P9u5xR6M7Q72Bd50itYNPY+MhpAl7ahw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM8A/5vUOjMnbh2j4vN3EPqsJUJqChNsTcwkgdv5HLYQ0ZmeV+e21u42SCBQOZ2HyQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP3Jb8ZMJxtdNXiWdX7QO1c7SveiQ/E6lysSlue0kV/jZEEPGfIFUJsenl97LBiwWg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN1C8DheNB9oaeV5XWgy2zFTAZeePMcpdrwwZ0EY97Jk3t7+PVhGFIStxupLxWksHA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDNdeaR/HEFb1UCfn54jAIKGqJ5iSOMl5u8mFNI2hnTQdzZMd3NWVhWzAquWPzhC5A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKY+di8NEFsX0a4CcH1IB/dTI1VwLogsKAkUbQgIH4htykFxY2fcyPNQOvulfZ9qLA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECMIdJkNS0JClv0ABv9qXnow9zZ59+aIuRyHklxEv6IlXgR5dAZeikxdzZ68V7ceoA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEL4MMMIHuPtKSYEHaWBxQykSfrPcvuzrgVP2DF3HwYIaqddZe5M5CHhJ+V+JAeFz1Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFfVES7NJ4GVFU5bJJYoVqMg82q5Ej5GriZzZpCTRD9GoO47pkkNwX6uRYQqlroBRw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBYnHejq3SOh0RHA9U9waJye2PCuITXN/IiKQpbkXjWhPceuFjYUZeGPPRIid8tg8Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIvcgLJXycIhhNFQO9neiMUzGEbYXOPbAo5KynlSEumF9/sTDv4UVyt4UxHJ0dgxaw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECh3bvMv0VAa4Drhd4L/U9Ya2zHyPeEMCVb4Nxc27dp2sf9e/6XE6T8PIbawHnXR+g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHs6E2BkfmaB87UNhU99QpTzLY9trwNhZBTKwdyVjSJoMh5JJHfEJ1MUHyuhJgOWlw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHNjs+RrgY3rN56VR+//V3ulucY7WH1iN5Wf38iYdYuZ3vUf0+I2QC7TsZS3zZoZgA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEG46hcc97vgu6dpY0NuznuDofUnS3fAUhOE6EKiIrCKQqvREb2fQyvpki1ItzdMY5w==");

            migrationBuilder.AddForeignKey(
                name: "FK__Job__UserId__02084FDA",
                table: "Job",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
