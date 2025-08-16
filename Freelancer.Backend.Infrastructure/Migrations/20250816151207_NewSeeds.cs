using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserJobs",
                table: "UserJobs");

            migrationBuilder.RenameTable(
                name: "UserJobs",
                newName: "JobRequests");

            migrationBuilder.RenameTable(
                name: "JobsUsers",
                newName: "JobsUser");

            migrationBuilder.RenameIndex(
                name: "IX_UserJobs_UserId",
                table: "JobRequests",
                newName: "IX_JobRequests_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobsUsers_UserId",
                table: "JobsUser",
                newName: "IX_JobsUser_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobsUsers_JobId",
                table: "JobsUser",
                newName: "IX_JobsUser_JobId");

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobRequests",
                table: "JobRequests",
                columns: new[] { "JobId", "UserId" });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "CreateDate", "Description", "Name", "Price", "StartDate", "Status", "Tags", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 17, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5575), "Projekt aplikacji mobilnej dla sklepu internetowego z wykorzystaniem Flutter i React Native.", "Rozwój aplikacji mobilnej e-commerce", 15000, new DateTime(2025, 7, 27, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5582), 0, "[\"Flutter\",\"React Native\",\"E-Commerce\"]", 10 },
                    { 2, new DateTime(2025, 8, 1, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5595), "Dodanie logowania Google i obsługi powiadomień push w aplikacji mobilnej.", "Integracja Firebase w aplikacji mobilnej", 4000, new DateTime(2025, 8, 6, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5596), 1, "[\"Firebase\",\"Push Notifications\",\"Mobile\"]", 10 },
                    { 3, new DateTime(2025, 6, 17, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5598), "Tworzenie skalowalnej platformy e-commerce opartej o mikroserwisy w .NET i Javie.", "Budowa platformy e-commerce w .NET", 25000, new DateTime(2025, 7, 2, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5599), 0, "[\".NET\",\"Java\",\"Microservices\",\"E-Commerce\"]", 11 },
                    { 4, new DateTime(2025, 7, 22, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5601), "Projekt aplikacji webowej wspierającej proces rekrutacyjny i onboarding programistów.", "System do zarządzania rekrutacją IT", 7000, new DateTime(2025, 8, 1, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5602), 1, "[\"ASP.NET Core\",\"HRTech\",\"Recruitment\"]", 12 },
                    { 5, new DateTime(2025, 8, 6, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5604), "Budowa platformy webowej z materiałami szkoleniowymi i check-listą onboardingu.", "Portal onboardingowy dla nowych pracowników", 3000, new DateTime(2025, 8, 11, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5604), 0, "[\"Blazor\",\"ASP.NET Core\",\"Onboarding\"]", 12 },
                    { 6, new DateTime(2025, 7, 7, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5608), "Aplikacja webowa analizująca SEO stron i generująca raporty dla klientów.", "System analizy SEO", 8000, new DateTime(2025, 7, 17, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5608), 1, "[\"SEO\",\"WebApp\",\"Analytics\"]", 13 },
                    { 7, new DateTime(2025, 8, 11, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5611), "Implementacja modułu generowania raportów z kampanii marketingowych.", "Moduł raportowania danych", 2000, new DateTime(2025, 8, 18, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5611), 0, "[\"Reporting\",\"SQL\",\"Dashboard\"]", 13 },
                    { 8, new DateTime(2025, 7, 27, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5613), "Tworzenie nowoczesnego UI/UX dla aplikacji bankowej w Figma.", "Projekt interfejsu systemu bankowego", 12000, new DateTime(2025, 8, 6, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5614), 0, "[\"UI\",\"UX\",\"Figma\"]", 14 },
                    { 9, new DateTime(2025, 7, 29, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5615), "Projekt systemu do zarządzania klientami i negocjacjami handlowymi.", "System CRM dla firmy B2B", 6000, new DateTime(2025, 8, 4, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5616), 1, "[\"CRM\",\"B2B\",\"ASP.NET Core\"]", 15 },
                    { 10, new DateTime(2025, 8, 9, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5619), "Budowa platformy e-learningowej do szkoleń sprzedażowych.", "Aplikacja szkoleniowa online", 5000, new DateTime(2025, 8, 17, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5620), 0, "[\"E-Learning\",\"Blazor\",\"WebApp\"]", 15 },
                    { 11, new DateTime(2025, 6, 27, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5621), "Wsparcie w prowadzeniu projektu IT z wykorzystaniem Scruma i Jiry.", "Koordynacja projektu w Agile", 9000, new DateTime(2025, 7, 7, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5622), 1, "[\"Agile\",\"Scrum\",\"Jira\"]", 16 },
                    { 12, new DateTime(2025, 7, 25, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5624), "Analiza luk bezpieczeństwa i wdrożenie rozwiązań DevSecOps.", "Audyt bezpieczeństwa aplikacji webowej", 11000, new DateTime(2025, 8, 1, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5625), 0, "[\"Security\",\"DevSecOps\",\"PenTest\"]", 17 },
                    { 13, new DateTime(2025, 8, 4, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5627), "Implementacja Prometheus i Grafana do monitorowania infrastruktury.", "System monitoringu serwerów", 5000, new DateTime(2025, 8, 9, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5627), 1, "[\"Monitoring\",\"Prometheus\",\"Grafana\"]", 17 },
                    { 14, new DateTime(2025, 7, 12, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5635), "Zbieranie wymagań i projektowanie modelu danych dla ERP.", "Analiza biznesowa systemu ERP", 14000, new DateTime(2025, 7, 22, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5635), 0, "[\"ERP\",\"SQL\",\"Business Analysis\"]", 18 },
                    { 15, new DateTime(2025, 8, 8, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5637), "Stworzenie architektury hurtowni danych dla systemu BI.", "Projekt hurtowni danych", 10000, new DateTime(2025, 8, 14, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5638), 1, "[\"ETL\",\"Data Warehouse\",\"BI\"]", 18 },
                    { 16, new DateTime(2025, 8, 13, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5645), "Projekt aplikacji webowej do obsługi zgłoszeń klientów.", "System zgłoszeń helpdesk", 1500, new DateTime(2025, 8, 15, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5646), 0, "[\"Helpdesk\",\"ASP.NET Core\",\"Support\"]", 19 },
                    { 17, new DateTime(2025, 8, 14, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5648), "Stworzenie panelu admina do zarządzania zgłoszeniami i SLA.", "Panel administracyjny dla helpdesk", 1000, new DateTime(2025, 8, 19, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5648), 1, "[\"Admin Panel\",\"Support\",\"WebApp\"]", 19 },
                    { 18, new DateTime(2025, 8, 2, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5651), "Budowa prostego CMS do zarządzania artykułami IT.", "System zarządzania treściami", 4500, new DateTime(2025, 8, 11, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5651), 0, "[\"CMS\",\"ASP.NET Core\",\"Content Management\"]", 20 },
                    { 19, new DateTime(2025, 8, 10, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5654), "Projekt REST API do eksportu danych do Excela i PDF.", "Moduł API do generowania raportów", 2500, new DateTime(2025, 8, 18, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5654), 1, "[\"API\",\"REST\",\"Reporting\"]", 20 },
                    { 20, new DateTime(2025, 7, 27, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5657), "Migracja starej aplikacji .NET Framework do .NET 8.", "Refaktoryzacja aplikacji legacy", 9000, new DateTime(2025, 8, 4, 15, 12, 4, 927, DateTimeKind.Utc).AddTicks(5657), 0, "[\".NET\",\"Refactoring\",\"Migration\"]", 20 }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEP04a1FSgbzEKa4WnKXUkdvAjXProoOKRB1WFTT/CqblpSTW4JavR15nvGag72yr4Q==", "[\".NET\",\"Java\",\"C#\",\"SQL\",\"Azure\",\"Microservices\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEN2+1N5FQkxCv232fKWcTMIOCPc8UPoKryBBG4lyHbzOnzcegRaO4wDz2xJ+Kr48RA==", "[\"C#\",\"Azure\",\"DevOps\",\"Cloud\",\"ASP.NET Core\",\"SQL\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEFE+5BcxITsJJFVnYKjkAi60eD9F2A6MnvXO5TvbGvlrruIxtroy3yHTTFVoR0JCSw==", "[\"React\",\"Node.js\",\"JavaScript\",\"TypeScript\",\"GraphQL\",\"MongoDB\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEAlhhKUq2fUc2FUK6Cd+KCHie1aYOVNExy+7lmR9QVOUn1iaCNRSARjeoHWXSk8MHg==", "[\"Java\",\"Spring Boot\",\"Hibernate\",\"Kotlin\",\"Microservices\",\"Docker\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEKCJmUuQ1fot6ZeHJRsGHWBzpE7z9F0H3A7SnyevFKv57cSvFdThfTLKiqmAc911Zg==", "[\"Angular\",\"TypeScript\",\"RxJS\",\"SCSS\",\"Material UI\",\"HTML5\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEIwM+8VNZ4yt7INnXYcDMi+HQI1ooDG+g8OGzQ0xQzv7zm4Q/lnDgZ878n0VrnFbFg==", "[\".NET\",\"Microservices\",\"DDD\",\"CQRS\",\"Azure\",\"Kubernetes\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEJ+ur1GGJWfLgJTlRnk53BygCgNQloM6LCF2mQ+EHmyt4EXEfVy+OxUILPMeybZkcg==", "[\"Selenium\",\"Cypress\",\"JUnit\",\"TestNG\",\"Postman\",\"Playwright\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAED1C00wUaEovRABubg+UlTtATJXxjVDSFsL459wtk+xjSUWrr9D7NCU2IPlLwqh75g==", "[\"Docker\",\"Kubernetes\",\"Helm\",\"Terraform\",\"CI/CD\",\"Linux\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEHcPZy0oHLBRiayxQQOtOW0SEbpRNpJGcxFlueNRTNdGsa8pbaT8LMTSQMguiXyHZw==", "[\"Python\",\"ML\",\"Pandas\",\"TensorFlow\",\"PyTorch\",\"Data Mining\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEP4W62AuwxKqSnqJIp/xfG2E3GZNsVtNpvjRd6aZ3zBu7q2RsYUK1+1rNMwOZQjc5A==", "[\"Flutter\",\"React Native\",\"Dart\",\"iOS\",\"Android\",\"Firebase\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEPJdSkk94rz4B/inoSJZCdz3cabjlefxFwb2p8SNX8p9vWPeFgMSDwR4ikaKsnZ2/g==", "[\".NET\",\"Java\",\"E-Commerce\",\"Mobile Apps\",\"Cloud\",\"API\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEEDO9Ppa3GloRQp0DBwxaXJpAFYlYOwBrW4MkMSXviYFm7Hrp3JxD6H1YuQR6jyGYw==", "[\"Recruitment\",\"Onboarding\",\"HR\",\"Employer Branding\",\"Talent Sourcing\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEGgDtcyE3MhXx9j91PRNsSr3q0a80G3YJxbzMK9+wFwXHl4wsyjGVxrL8ZyGKB+3YA==", "[\"SEO\",\"Google Ads\",\"SEM\",\"Content Marketing\",\"Analytics\",\"Copywriting\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEFI9pb5ILt138liwNYSHVFHMOKweZJT42/TExOpRwQfDOj/j3K6fftsuPQC1gHiUJw==", "[\"Figma\",\"UX\",\"UI Design\",\"Prototyping\",\"Adobe XD\",\"Accessibility\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEHn3GI/0LLkIcSPO9RrWg0VI5LLkNUo3iDDQIGOYkiP6ptOl2hI+FrLJWnqk0ysOtg==", "[\"B2B\",\"Negotiations\",\"Sales\",\"Consulting\",\"Partnerships\",\"CRM\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAENI2iGcn0vodxe7wXL7iAa/oF4/ev43yuc9U9B/m6iMPtOyehLYExFRYZptyBxGnuw==", "[\"Agile\",\"Scrum\",\"Kanban\",\"Project Management\",\"Jira\",\"Confluence\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEKc3AxE3vryIAtYEviqmUCcTcn6Sw8/dUZSSwx99CAoXDS/lMbTznul6+0Lugold5g==", "[\"Linux\",\"Networking\",\"Security\",\"Firewalls\",\"Monitoring\",\"DevSecOps\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAECJW4DC7FjJSxtrOgduRjc0h5mFu8Zaftxboa0oxfiZqH2+KenV8WS8Brk4kA5685w==", "[\"SQL\",\"UML\",\"Business Analysis\",\"BI\",\"ETL\",\"Data Warehousing\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEJAVxHU9UWQ7KgWfc+npL+ZLWF8QktGt8jA+Pgz+2j+tScIsqjxwngq8y9sMYQzMHw==", "[\"Customer Service\",\"ITIL\",\"Helpdesk\",\"Support\",\"Troubleshooting\",\"Windows\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEBj/eJZyvZbxx3Thra+JmmLhs78JcCpcDpDo19KhIlnYCI/CFyoeBMV5QkU+5XfhFA==", "[\"Copywriting\",\"Social Media\",\"Marketing\",\"Storytelling\",\"Branding\",\"Creative\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JobRequests",
                table: "JobRequests");

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.RenameTable(
                name: "JobsUser",
                newName: "JobsUsers");

            migrationBuilder.RenameTable(
                name: "JobRequests",
                newName: "UserJobs");

            migrationBuilder.RenameIndex(
                name: "IX_JobsUser_UserId",
                table: "JobsUsers",
                newName: "IX_JobsUsers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobsUser_JobId",
                table: "JobsUsers",
                newName: "IX_JobsUsers_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_JobRequests_UserId",
                table: "UserJobs",
                newName: "IX_UserJobs_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserJobs",
                table: "UserJobs",
                columns: new[] { "JobId", "UserId" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEBO1gCDFtkEd/kyYVxmKSpdJGgMFIxvGVu2iScNI0FydVI2xoGMqgrwavexro/QImg==", "[\".NET\",\"Java\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEHndJkY5o6FWutYrCnEpzU41ERGosj2EHlunXrI2vDSc3WN9wEfC+f5odBBw9Y43DA==", "[\"C#\",\"Azure\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEOS8T/34Pw8/8Ht1DJi1FFrkwjgo8WPcYCqudgvb6Nc83OCmbNNiKzyPGJhq0oqu3Q==", "[\"React\",\"Node.js\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEIjWpeNyKtW7+ODf0Sb+Anc6YOGbmnywtb1Z8nwL957FiPxzVKWDn2v2gCRjHfharg==", "[\"Java\",\"Spring Boot\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEBHyPCwtHaVP5QNn7XM0iGkx8KwK5b+ruArjVxwE8R79FZ8gZVtfm4T97mAmHdhCBA==", "[\"Angular\",\"TypeScript\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEHv/yUP5QuOK04NAh9ZG55JPWuauFB2Nx7Cc+uvUSIKNRTBBOqHBHVYjhOGFoZAP5w==", "[\".NET\",\"Microservices\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEKoKut819ZYcjbvjt4zsWve7C5kt2LEYEXgvSP5bQwYeU14E3QDKCqLlV+9sUlYXDA==", "[\"Selenium\",\"Cypress\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEAvxYcTps5fbWj7J3QBzr5bDkCDVZPK0AAx24Ar/NItF3MV3QfpVmOelbbKv+gH/1A==", "[\"Docker\",\"Kubernetes\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEErO4dsOutgSRVR7p1SeJCK4Joa4RHNpqvQpI061qWM8XVD88wQfXhlrutzWpksGQA==", "[\"Python\",\"ML\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEKD0NJcN4ZQZdvSFWwT1MIkkTueePOM7J0/Jz0G1g9ld+J+HuP0ZgESO7xxJ80uB+w==", "[\"Flutter\",\"React Native\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAECZ1gBQigIeYM4Dbeu77P5HHaVyI8JoAnyrIwvGwpZqBJWXY5kuYxFHDjSCYRCn9rA==", "[\".NET\",\"Java\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEGHjgvHPguifKMsQysaUdfrjFo3XkMvHu6ixm0dLw+u8OSuVwpnrRO6laOvBhxdbsw==", "[\"Recruitment\",\"Onboarding\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAECnRAwPjmqsb2Gh81ZV69v2UtcQMdl+qAxar+YhhsCHHJPBipW5TbnZvZRkkHGCmhQ==", "[\"SEO\",\"Google Ads\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEOVFDDkZxabR/O0GFUU9K5Jzrk0vfcyXZd23gD59YEJ5wx2g8WT2p9fp0779UN8jJg==", "[\"Figma\",\"UX\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEJ1ITWhkwmVaC/UP3oghyOGAba7S5c5+apkU+Gym5aoH/19IKw6T/hN2E7WOtrTZ7A==", "[\"B2B\",\"Negotiations\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEJSKnz3vbwYv0Ziv11CiBkVbpLe/mHqtlm9WZFCAvGPZdqtsebeuwAwrMn+gxmeF5A==", "[\"Agile\",\"Scrum\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAENs+iv6tGmL7envuCKoauNrQZ104RwI0qzp5NsYlTrue2hEWrg9SKYP78XOLxJ1l3Q==", "[\"Linux\",\"Networking\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEMuhpfhDyDCr8HcykULwPPXTkCiyHqKv0nuN7asXmDAoUye22WcfSmcWE9+qa89+uw==", "[\"SQL\",\"UML\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEIBc+UJNFK74bl1sSoWc1rMmStKS6o4dmaijOG7mexdhQVB16pm9wPlMzdis8w1LeA==", "[\"Customer Service\",\"ITIL\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "Tags" },
                values: new object[] { "AQAAAAIAAYagAAAAEPTeVyaGYTwMF9AecllFQlANfU/RXTrAGOdcBKJpbykZIxdTdCGdCy/EM+9ak+NElA==", "[\"Copywriting\",\"Social Media\"]" });
        }
    }
}
