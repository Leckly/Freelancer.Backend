using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatingUserIdInRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatingUserId",
                table: "Rating",
                type: "int",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatingUserId",
                table: "Rating");

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 17, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5575), new DateTime(2025, 7, 27, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 1, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5595), new DateTime(2025, 8, 6, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 17, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 7, 2, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 22, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5601), new DateTime(2025, 8, 1, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 6, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5604), new DateTime(2025, 8, 11, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 7, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5608), new DateTime(2025, 7, 17, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 11, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5611), new DateTime(2025, 8, 18, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5613), new DateTime(2025, 8, 6, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5615), new DateTime(2025, 8, 4, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 9, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5619), new DateTime(2025, 8, 17, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5621), new DateTime(2025, 7, 7, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 25, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5624), new DateTime(2025, 8, 1, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 4, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5627), new DateTime(2025, 8, 9, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 12, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5635), new DateTime(2025, 7, 22, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5637), new DateTime(2025, 8, 14, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 13, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5645), new DateTime(2025, 8, 15, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 14, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5648), new DateTime(2025, 8, 19, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 2, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5651), new DateTime(2025, 8, 11, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 10, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5654), new DateTime(2025, 8, 18, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 27, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5657), new DateTime(2025, 8, 4, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP04a1FSgbzEKa4WnKXUkdvAjXProoOKRB1WFTT/CqblpSTW4JavR15nvGag72yr4Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN2+1N5FQkxCv232fKWcTMIOCPc8UPoKryBBG4lyHbzOnzcegRaO4wDz2xJ+Kr48RA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFE+5BcxITsJJFVnYKjkAi60eD9F2A6MnvXO5TvbGvlrruIxtroy3yHTTFVoR0JCSw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAlhhKUq2fUc2FUK6Cd+KCHie1aYOVNExy+7lmR9QVOUn1iaCNRSARjeoHWXSk8MHg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKCJmUuQ1fot6ZeHJRsGHWBzpE7z9F0H3A7SnyevFKv57cSvFdThfTLKiqmAc911Zg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIwM+8VNZ4yt7INnXYcDMi+HQI1ooDG+g8OGzQ0xQzv7zm4Q/lnDgZ878n0VrnFbFg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ+ur1GGJWfLgJTlRnk53BygCgNQloM6LCF2mQ+EHmyt4EXEfVy+OxUILPMeybZkcg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAED1C00wUaEovRABubg+UlTtATJXxjVDSFsL459wtk+xjSUWrr9D7NCU2IPlLwqh75g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHcPZy0oHLBRiayxQQOtOW0SEbpRNpJGcxFlueNRTNdGsa8pbaT8LMTSQMguiXyHZw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP4W62AuwxKqSnqJIp/xfG2E3GZNsVtNpvjRd6aZ3zBu7q2RsYUK1+1rNMwOZQjc5A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPJdSkk94rz4B/inoSJZCdz3cabjlefxFwb2p8SNX8p9vWPeFgMSDwR4ikaKsnZ2/g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEDO9Ppa3GloRQp0DBwxaXJpAFYlYOwBrW4MkMSXviYFm7Hrp3JxD6H1YuQR6jyGYw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGgDtcyE3MhXx9j91PRNsSr3q0a80G3YJxbzMK9+wFwXHl4wsyjGVxrL8ZyGKB+3YA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFI9pb5ILt138liwNYSHVFHMOKweZJT42/TExOpRwQfDOj/j3K6fftsuPQC1gHiUJw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHn3GI/0LLkIcSPO9RrWg0VI5LLkNUo3iDDQIGOYkiP6ptOl2hI+FrLJWnqk0ysOtg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENI2iGcn0vodxe7wXL7iAa/oF4/ev43yuc9U9B/m6iMPtOyehLYExFRYZptyBxGnuw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKc3AxE3vryIAtYEviqmUCcTcn6Sw8/dUZSSwx99CAoXDS/lMbTznul6+0Lugold5g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECJW4DC7FjJSxtrOgduRjc0h5mFu8Zaftxboa0oxfiZqH2+KenV8WS8Brk4kA5685w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJAVxHU9UWQ7KgWfc+npL+ZLWF8QktGt8jA+Pgz+2j+tScIsqjxwngq8y9sMYQzMHw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBj/eJZyvZbxx3Thra+JmmLhs78JcCpcDpDo19KhIlnYCI/CFyoeBMV5QkU+5XfhFA==");
        }
    }
}
