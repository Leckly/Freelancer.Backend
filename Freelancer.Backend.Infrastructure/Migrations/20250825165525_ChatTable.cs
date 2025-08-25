using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChatTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    JobId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 26, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4777), new DateTime(2025, 8, 5, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 10, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4823), new DateTime(2025, 8, 15, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 26, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4827), new DateTime(2025, 7, 11, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 31, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4829), new DateTime(2025, 8, 10, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 15, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4832), new DateTime(2025, 8, 20, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 16, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4836), new DateTime(2025, 7, 26, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 20, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4839), new DateTime(2025, 8, 27, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 5, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4842), new DateTime(2025, 8, 15, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 7, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4845), new DateTime(2025, 8, 13, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 18, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4849), new DateTime(2025, 8, 26, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 6, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4851), new DateTime(2025, 7, 16, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 3, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4855), new DateTime(2025, 8, 10, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 13, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4858), new DateTime(2025, 8, 18, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 21, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4865), new DateTime(2025, 7, 31, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 17, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4868), new DateTime(2025, 8, 23, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 22, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4879), new DateTime(2025, 8, 24, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 23, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4881), new DateTime(2025, 8, 28, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 11, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4885), new DateTime(2025, 8, 20, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 19, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4887), new DateTime(2025, 8, 27, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 5, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4890), new DateTime(2025, 8, 13, 16, 55, 24, 3, DateTimeKind.Utc).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEILM1AV5n8vnkxRebJP4MBqbGHoqyyeUISF5TNaVazOXx9/76QI5LyDLPXce973olw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAH3H6K5ecWTU0nDUMXxqA0V+PMBgYwi9NVtojTrZrv5/hk2qnoQlVQuozUpDa1w9g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMHeLwaTz6P2w2h1NLAfqnsCll1n0zJHRdjMur2BJ6XVl/Rpr0gv2QuHRcJH1fxnpQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPUPOXCynbsoV8LRrVOAcdr2CBkNIb0gBDpwj5jc8CTdVZZUljeAAAIkb5zyRM+MmA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEF8VOn9wIAvf3c6TORx1Sj9ZUagj42K99hT+lWnDslIBDz5ZyueWCqu9VQTZu3O8wg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECxWUNS7FRF1UCgnhCQB80ZVhkmGNm59/pmmGQQbpeAOMUt0MD/sdTUVBdfZtBDIZQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDMX4u2tJKcoCuNty8QJeDQZ8Rd5lXgSJUNzjLmzilp6dnM6S5egO2xjrXGVE/lwPQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMp0w2lDK0NuPkBwY8mL2+v6/LVetxEvidkmO3RaamJ7blXcSxXQD22ENzitCS+QQA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGvn6Vh7l03i2ppKt/8bPruZWDM+7bouB+wQr+Jo4lfhxhI2f8Nw+stPmUWJOW1TTg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENiLnh3lBhylWd8/wFiE9n6x2Ct/OCsxAifjlXmAjzqOf3EhIDVWmCYizuCC7TnC8Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAc1OQZrTnm+TXq1EDIjZWUu1QYwISpXA1ny6xFiMWh7Mu+5Ak9/vVUedNKe9qBhPQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKQ3412QLWf7vpKtvoBojACN1sd1pl6D9Wjfa8XFt3F3ROaT+0Nbb9+uS4fOX9tG5A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENAiA489fSPlTlNVIIwamECqNzGOoY+FHOe1WgjLao1oy/J6GL3EIX3z/DdH4zaPwA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKjvaIchsxyplY2T53LHVA93URhn5cvhmV0QyQQFhO9sx/O1rc2z2o0IhF2f2OUEzg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO/p+l36U24lgVpUmS7sg3fUeshGSUxEMj2Bmw8A8/j3KPvjTlzvjSztrOfVFWqlNA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEG/sOIXLZIzIIyFoqblezYedkhfG4wdwEP2Xn94z6B7c7GO3wvC69vRh1sCMmbodQA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBDlTOlw6hQiE/7Vn/AFk2X/cO6QkSrbnzuFbD3rMQWNuVV+IUEslEK4cstHfZczDw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPmmT/q+3BReaYefIVSKnlPy0BF9vMDnvTGsZQ/s6BXn4Y1eTaIgyubKjrNqUOcYxQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH0Timbf5hv6ci5bj/KTg2MwqFlsVNva5xJY8hbvBg4OnfEprkaCkhd8SesU/T6BDQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP1RuxBxyDPjGeIdHHxLZjCmN2dwEiW5HPCp1LQwyaVYYwl1qp5YHVweG8X6IQGTjA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 26, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4082), new DateTime(2025, 8, 5, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 10, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4092), new DateTime(2025, 8, 15, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 26, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4095), new DateTime(2025, 7, 11, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 31, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4097), new DateTime(2025, 8, 10, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 15, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4100), new DateTime(2025, 8, 20, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 16, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4104), new DateTime(2025, 7, 26, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 20, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4106), new DateTime(2025, 8, 27, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 5, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4109), new DateTime(2025, 8, 15, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 7, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4111), new DateTime(2025, 8, 13, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 18, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4114), new DateTime(2025, 8, 26, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 6, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4117), new DateTime(2025, 7, 16, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 3, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4120), new DateTime(2025, 8, 10, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 13, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4123), new DateTime(2025, 8, 18, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 21, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4130), new DateTime(2025, 7, 31, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 17, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4133), new DateTime(2025, 8, 23, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 22, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4144), new DateTime(2025, 8, 24, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 23, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4147), new DateTime(2025, 8, 28, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 11, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4150), new DateTime(2025, 8, 20, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 19, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4172), new DateTime(2025, 8, 27, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 5, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4175), new DateTime(2025, 8, 13, 16, 1, 49, 647, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ7CNapDlFHbpARLMz9ZeGMG/s+/RtrNzI7uz1Bh+E0hMXfYW0/rBdK2D+uo1VvK5g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMsfhy8G5+yIIc0WR1w4gaxU0RhmHbb1IRb8wHfDugCl5p0Icp8ecv9To2JHzbRG2Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECOmenVW2+X+tCAbL/5rzUkHctr3TDcXucX/qipHBffLwXKwBU3VZb/5rn3ZTTGnBA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMc62fJoEDiN6+Oe98EQrXw3ed43XBhH32b0yOWiEqBPTZ81wTspRagM3Kncalmtaw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB1zlw2u2YqkF4oD450Y+Za2Ez7hl4R7VSXTQE1aNANfrNLnK7zmmaVg55r3yRG0ug==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGrwY0RMYs2h0mhSGn9oJ6yeJMsjPCb4XUrQpXrt6dVebfzhRTdn7tbuAq7/aOxvFg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELl2Vn/E+Nn0QEAvcZldYHE4SHTuJ8K9OLi6dPaZyxXr9oE4ljgi01Z1DQWRkfgFYw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ4eua7Gd6vT0F+I36T3i8umoQwu3FzGCwQy/42+8SZWuFDH4LiejVlloRUa1G1xcg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENN4/TyTxyy5GEK8u5zO4wBiAzunqigH97nIyreHzHTB9RtLdRNCaRA3r1Vk4lIsvw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ5JhhZuOLGDl+fUS549iK1rG0I+/PGrIL82Yuedq3ZJifvdVpHrrp6b+9dFGc1Khw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMVoKZsXjHEYR3bJIifhYirRz/XIidOVzBA4xB4b067NG5NUYQsegib2OY/qUAIvPA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENxrDdrhfsjhd6PSI0nfnlbcdm9QCkJFOvJtTEeqjNGZdyw8IRlfZyad6tO1GjIZiw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOBa89T0i1U8OTvCS3vNLg7GTlDTwKonoJTsCkQQrq/rQbutwW3DELXNSW/nCg9U6A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJTSicZIdPbEfgZMC4DNc/zicze+ljM8eiYS+1/zmRVU8e4FePlgvhNM8fPf6nmVlg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPiFHu+5RQtuqmoHwCPae8cxiyS06cftCO3IhJ4QjS/8w/A+jE+pWTS/lNu4PF2npQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHBqUe4JFAvRDtrbobpd+G9fjGdu+BVuV9Di4QhRDsGE7YRoaq2KdSXO0iFnH3zGsA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDTPnftqwuB6K8DfdW2jD+uGU5yMK8FVQLW+GcKVwwB+vWd5ph/kRcq/Sj5c3eGV5Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAuz58HpvZLgkq5trIcFzqxHnVzxRr7sKCsgFnmVysgBcYXa7CqpLy3+x/IcQMMzrg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHV3CKgn0HZmWKSngsylc1MFV/5Pmc8GB3SObAobvS6yqX5DPyB9j18e0gew7/BOkA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEANCw92K961LhMDyVK3PyLH4HFgx6exgnNHl3CzG0BErQ12WVsy/3czUuIr+hg4qVQ==");
        }
    }
}
