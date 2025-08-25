using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedForRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "Comment", "CreatingUserId", "Rate", "UserId" },
                values: new object[,]
                {
                    { 1, "Great work!", 2, (byte)4, 1 },
                    { 2, "Very professional.", 3, (byte)5, 1 },
                    { 3, "Good, but room to improve.", 4, (byte)3, 1 },
                    { 4, "Excellent skills!", 5, (byte)5, 1 },
                    { 5, "Could be better.", 6, (byte)2, 1 },
                    { 6, "Nice collaboration.", 7, (byte)4, 1 },
                    { 7, "Outstanding developer.", 1, (byte)5, 2 },
                    { 8, "Very reliable.", 3, (byte)4, 2 },
                    { 9, "Good, but slow on some tasks.", 4, (byte)3, 2 },
                    { 10, "Highly recommended.", 5, (byte)5, 2 },
                    { 11, "Needs more attention to detail.", 6, (byte)2, 2 },
                    { 12, "Solid work ethic.", 7, (byte)4, 2 },
                    { 13, "Excellent in React.", 1, (byte)5, 3 },
                    { 14, "Great teamwork.", 2, (byte)4, 3 },
                    { 15, "Average communication.", 4, (byte)3, 3 },
                    { 16, "Strong problem-solving skills.", 5, (byte)5, 3 },
                    { 17, "Sometimes late with tasks.", 6, (byte)2, 3 },
                    { 18, "Good coding standards.", 7, (byte)4, 3 },
                    { 19, "Backend expertise is solid.", 1, (byte)5, 4 },
                    { 20, "Reliable developer.", 2, (byte)4, 4 },
                    { 21, "Can improve testing.", 3, (byte)3, 4 },
                    { 22, "Knows Spring Boot very well.", 5, (byte)5, 4 },
                    { 23, "Slow in code reviews.", 6, (byte)2, 4 },
                    { 24, "Good design patterns usage.", 7, (byte)4, 4 },
                    { 25, "Excellent frontend skills.", 1, (byte)5, 5 },
                    { 26, "Creative UI designs.", 2, (byte)4, 5 },
                    { 27, "Occasionally misses deadlines.", 3, (byte)3, 5 },
                    { 28, "Very good with Angular.", 4, (byte)5, 5 },
                    { 29, "Needs more TypeScript experience.", 6, (byte)2, 5 },
                    { 30, "Strong in frontend architecture.", 7, (byte)4, 5 },
                    { 31, "Excellent software architect.", 1, (byte)5, 6 },
                    { 32, "Great with DDD and CQRS.", 2, (byte)4, 6 },
                    { 33, "Sometimes overcomplicates designs.", 3, (byte)3, 6 },
                    { 34, "Good microservices design.", 4, (byte)5, 6 },
                    { 35, "Needs better documentation.", 5, (byte)2, 6 },
                    { 36, "Strong .NET expertise.", 7, (byte)4, 6 },
                    { 37, "QA automation expert.", 1, (byte)5, 7 },
                    { 38, "Good test coverage.", 2, (byte)4, 7 },
                    { 39, "Sometimes misses edge cases.", 3, (byte)3, 7 },
                    { 40, "Excellent Selenium skills.", 4, (byte)5, 7 },
                    { 41, "Needs improvement in Cypress.", 5, (byte)2, 7 },
                    { 42, "Good testing practices.", 6, (byte)4, 7 },
                    { 43, "DevOps expertise is top-notch.", 1, (byte)5, 8 },
                    { 44, "Very reliable with Kubernetes.", 2, (byte)4, 8 },
                    { 45, "Occasionally slow CI/CD pipelines.", 3, (byte)3, 8 },
                    { 46, "Excellent Docker knowledge.", 4, (byte)5, 8 },
                    { 47, "Needs better Linux troubleshooting.", 5, (byte)2, 8 },
                    { 48, "Good DevOps practices.", 6, (byte)4, 8 },
                    { 49, "Great data scientist.", 1, (byte)5, 9 },
                    { 50, "Good Python skills.", 2, (byte)4, 9 },
                    { 51, "Needs more ML optimization.", 3, (byte)3, 9 },
                    { 52, "Excellent with TensorFlow.", 4, (byte)5, 9 },
                    { 53, "PyTorch skills need improvement.", 5, (byte)2, 9 },
                    { 54, "Strong data analysis.", 6, (byte)4, 9 },
                    { 55, "Mobile apps are excellent.", 1, (byte)5, 10 },
                    { 56, "Great Flutter skills.", 2, (byte)4, 10 },
                    { 57, "Sometimes slow in React Native.", 3, (byte)3, 10 },
                    { 58, "Good cross-platform knowledge.", 4, (byte)5, 10 },
                    { 59, "Firebase integration can improve.", 5, (byte)2, 10 },
                    { 60, "Strong mobile architecture.", 6, (byte)4, 10 },
                    { 61, "Solid IT solutions.", 12, (byte)4, 11 },
                    { 62, "Great APIs.", 13, (byte)5, 11 },
                    { 63, "Some delays in projects.", 14, (byte)3, 11 },
                    { 64, "Excellent mobile apps.", 15, (byte)5, 11 },
                    { 65, "Needs better documentation.", 16, (byte)2, 11 },
                    { 66, "Very professional.", 17, (byte)4, 11 },
                    { 67, "Excellent recruitment services.", 11, (byte)5, 12 },
                    { 68, "Great onboarding processes.", 13, (byte)4, 12 },
                    { 69, "Communication can improve.", 14, (byte)3, 12 },
                    { 70, "Very professional team.", 15, (byte)5, 12 },
                    { 71, "Needs more follow-ups.", 16, (byte)2, 12 },
                    { 72, "Reliable HR services.", 17, (byte)4, 12 },
                    { 73, "Great SEO campaigns.", 11, (byte)5, 13 },
                    { 74, "Effective Google Ads.", 12, (byte)4, 13 },
                    { 75, "Reporting can improve.", 14, (byte)3, 13 },
                    { 76, "Creative marketing team.", 15, (byte)5, 13 },
                    { 77, "Needs faster execution.", 16, (byte)2, 13 },
                    { 78, "Strong analytics expertise.", 17, (byte)4, 13 },
                    { 79, "Amazing design studio.", 11, (byte)5, 14 },
                    { 80, "Good UX/UI work.", 12, (byte)4, 14 },
                    { 81, "Could improve accessibility.", 13, (byte)3, 14 },
                    { 82, "Very creative designs.", 15, (byte)5, 14 },
                    { 83, "Some delays in delivery.", 16, (byte)2, 14 },
                    { 84, "Strong prototyping skills.", 17, (byte)4, 14 },
                    { 85, "Excellent B2B consulting.", 11, (byte)5, 15 },
                    { 86, "Great negotiation skills.", 12, (byte)4, 15 },
                    { 87, "Sales approach can improve.", 13, (byte)3, 15 },
                    { 88, "Reliable business partner.", 14, (byte)5, 15 },
                    { 89, "CRM usage needs improvement.", 16, (byte)2, 15 },
                    { 90, "Strong consulting services.", 17, (byte)4, 15 },
                    { 91, "Excellent Agile coordination.", 11, (byte)5, 16 },
                    { 92, "Good project management.", 12, (byte)4, 16 },
                    { 93, "Some sprints delayed.", 13, (byte)3, 16 },
                    { 94, "Very organized team.", 14, (byte)5, 16 },
                    { 95, "Jira usage can improve.", 15, (byte)2, 16 },
                    { 96, "Strong Scrum practices.", 17, (byte)4, 16 },
                    { 97, "Excellent IT security.", 11, (byte)5, 17 },
                    { 98, "Good networking skills.", 12, (byte)4, 17 },
                    { 99, "Monitoring can improve.", 13, (byte)3, 17 },
                    { 100, "Reliable server management.", 14, (byte)5, 17 },
                    { 101, "Needs faster incident response.", 15, (byte)2, 17 },
                    { 102, "Strong DevSecOps practices.", 16, (byte)4, 17 },
                    { 103, "Great business analytics.", 11, (byte)5, 18 },
                    { 104, "Good SQL skills.", 12, (byte)4, 18 },
                    { 105, "ETL pipelines need improvement.", 13, (byte)3, 18 },
                    { 106, "Excellent BI knowledge.", 14, (byte)5, 18 },
                    { 107, "UML diagrams can be clearer.", 15, (byte)2, 18 },
                    { 108, "Strong data warehousing skills.", 16, (byte)4, 18 },
                    { 109, "Excellent IT support.", 11, (byte)5, 19 },
                    { 110, "Reliable helpdesk services.", 12, (byte)4, 19 },
                    { 111, "Troubleshooting can be faster.", 13, (byte)3, 19 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 24, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1727), new DateTime(2025, 8, 3, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1746), new DateTime(2025, 8, 13, 15, 23, 10, 309, DateTimeKind.Utc).AddTicks(1746) });

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
        }
    }
}
