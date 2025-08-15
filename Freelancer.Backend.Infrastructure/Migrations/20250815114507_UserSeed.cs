using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Freelancer.Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CompanyName", "Country", "Description", "Email", "FirstName", "KRS", "LastName", "NIP", "PasswordHash", "RoleId", "Tags" },
                values: new object[,]
                {
                    { 1, "Warsaw, Aleje Jerozolimskie 5", "GoodCompany", "Poland", "Doświadczony programista .NET i Java z pasją do nowych technologii.", "john.smith@gmail.com", "John", "0123456789", "Smith", "0123456789", "AQAAAAIAAYagAAAAEBO1gCDFtkEd/kyYVxmKSpdJGgMFIxvGVu2iScNI0FydVI2xoGMqgrwavexro/QImg==", 1, "[\".NET\",\"Java\"]" },
                    { 2, "Krakow, Main Street 12", "DevMasters", "Poland", "Senior developer z wieloletnim doświadczeniem w pracy z chmurą Azure.", "michael.brown@gmail.com", "Michael", "9876543210", "Brown", "1234567890", "AQAAAAIAAYagAAAAEHndJkY5o6FWutYrCnEpzU41ERGosj2EHlunXrI2vDSc3WN9wEfC+f5odBBw9Y43DA==", 1, "[\"C#\",\"Azure\"]" },
                    { 3, "Gdansk, Dluga 1", "WebSolutions", "Poland", "Fullstack developer z doświadczeniem w React i Node.js.", "anna.kowalska@gmail.com", "Anna", "6655443322", "Kowalska", "2233445566", "AQAAAAIAAYagAAAAEOS8T/34Pw8/8Ht1DJi1FFrkwjgo8WPcYCqudgvb6Nc83OCmbNNiKzyPGJhq0oqu3Q==", 1, "[\"React\",\"Node.js\"]" },
                    { 4, "Lodz, Piotrkowska 100", "CloudTech", "Poland", "Specjalista backend z dużą wiedzą w zakresie Java i Spring Boot.", "piotr.nowak@gmail.com", "Piotr", "5566778899", "Nowak", "9988776655", "AQAAAAIAAYagAAAAEIjWpeNyKtW7+ODf0Sb+Anc6YOGbmnywtb1Z8nwL957FiPxzVKWDn2v2gCRjHfharg==", 1, "[\"Java\",\"Spring Boot\"]" },
                    { 5, "Poznan, Swiety Marcin 45", "UIWorks", "Poland", "Ekspert frontend z doświadczeniem w Angular i TypeScript.", "karolina.mazur@gmail.com", "Karolina", "4333222111", "Mazur", "1112223334", "AQAAAAIAAYagAAAAEBHyPCwtHaVP5QNn7XM0iGkx8KwK5b+ruArjVxwE8R79FZ8gZVtfm4T97mAmHdhCBA==", 1, "[\"Angular\",\"TypeScript\"]" },
                    { 6, "Szczecin, Aleja Piastów 10", "SoftBuild", "Poland", "Architekt oprogramowania specjalizujący się w .NET i mikroserwisach.", "pawel.zielinski@gmail.com", "Pawel", "0999888777", "Zielinski", "7778889990", "AQAAAAIAAYagAAAAEHv/yUP5QuOK04NAh9ZG55JPWuauFB2Nx7Cc+uvUSIKNRTBBOqHBHVYjhOGFoZAP5w==", 1, "[\".NET\",\"Microservices\"]" },
                    { 7, "Warsaw, Nowy Swiat 20", "TestIt", "Poland", "Inżynier QA z doświadczeniem w automatyzacji testów.", "magdalena.wisniewska@gmail.com", "Magdalena", "5544332211", "Wisniewska", "1122334455", "AQAAAAIAAYagAAAAEKoKut819ZYcjbvjt4zsWve7C5kt2LEYEXgvSP5bQwYeU14E3QDKCqLlV+9sUlYXDA==", 1, "[\"Selenium\",\"Cypress\"]" },
                    { 8, "Katowice, Mickiewicza 8", "OpsMasters", "Poland", "Inżynier DevOps specjalizujący się w Docker i Kubernetes.", "adam.lewandowski@gmail.com", "Adam", "9988776655", "Lewandowski", "5566778899", "AQAAAAIAAYagAAAAEAvxYcTps5fbWj7J3QBzr5bDkCDVZPK0AAx24Ar/NItF3MV3QfpVmOelbbKv+gH/1A==", 1, "[\"Docker\",\"Kubernetes\"]" },
                    { 9, "Bydgoszcz, Główna 22", "DataVision", "Poland", "Data scientist z doświadczeniem w Python i machine learning.", "dorota.kaczmarek@gmail.com", "Dorota", "5544211332", "Kaczmarek", "3322114455", "AQAAAAIAAYagAAAAEErO4dsOutgSRVR7p1SeJCK4Joa4RHNpqvQpI061qWM8XVD88wQfXhlrutzWpksGQA==", 1, "[\"Python\",\"ML\"]" },
                    { 10, "Opole, Krakowska 15", "Appify", "Poland", "Programista aplikacji mobilnych w Flutter i React Native.", "marcin.wozniak@gmail.com", "Marcin", "2211009988", "Wozniak", "8899001122", "AQAAAAIAAYagAAAAEKD0NJcN4ZQZdvSFWwT1MIkkTueePOM7J0/Jz0G1g9ld+J+HuP0ZgESO7xxJ80uB+w==", 1, "[\"Flutter\",\"React Native\"]" },
                    { 11, "Bialystok, Aleje Jerozolimskie 5", "PerfectCompany", "Poland", "Firma IT specjalizująca się w rozwiązaniach webowych i mobilnych dla sektora e-commerce.", "jack.smith@gmail.com", "Jack", "0123456789", "Smith", "0123456789", "AQAAAAIAAYagAAAAECZ1gBQigIeYM4Dbeu77P5HHaVyI8JoAnyrIwvGwpZqBJWXY5kuYxFHDjSCYRCn9rA==", 2, "[\".NET\",\"Java\"]" },
                    { 12, "Warsaw, Prosta 4", "HRPlus", "Poland", "Agencja HR oferująca kompleksowe usługi rekrutacyjne i doradztwo personalne.", "lisa.jones@gmail.com", "Lisa", "3213213210", "Jones", "1231231230", "AQAAAAIAAYagAAAAEGHjgvHPguifKMsQysaUdfrjFo3XkMvHu6ixm0dLw+u8OSuVwpnrRO6laOvBhxdbsw==", 2, "[\"Recruitment\",\"Onboarding\"]" },
                    { 13, "Lublin, Krakowskie Przedmieście 33", "MarketLead", "Poland", "Agencja marketingowa zajmująca się kampaniami SEO i reklamami Google Ads.", "tomasz.malinowski@gmail.com", "Tomasz", "7666555444", "Malinowski", "4445556667", "AQAAAAIAAYagAAAAECnRAwPjmqsb2Gh81ZV69v2UtcQMdl+qAxar+YhhsCHHJPBipW5TbnZvZRkkHGCmhQ==", 2, "[\"SEO\",\"Google Ads\"]" },
                    { 14, "Warsaw, Marszalkowska 7", "DesignHub", "Poland", "Studio projektowe tworzące nowoczesne interfejsy i doświadczenia użytkowników.", "ewa.adamska@gmail.com", "Ewa", "4131211101", "Adamska", "1011121314", "AQAAAAIAAYagAAAAEOVFDDkZxabR/O0GFUU9K5Jzrk0vfcyXZd23gD59YEJ5wx2g8WT2p9fp0779UN8jJg==", 2, "[\"Figma\",\"UX\"]" },
                    { 15, "Kielce, Sienkiewicza 11", "BizGrow", "Poland", "Firma doradcza specjalizująca się w obsłudze klientów B2B i negocjacjach handlowych.", "grzegorz.kubiak@gmail.com", "Grzegorz", "0099887766", "Kubiak", "6677889900", "AQAAAAIAAYagAAAAEJ1ITWhkwmVaC/UP3oghyOGAba7S5c5+apkU+Gym5aoH/19IKw6T/hN2E7WOtrTZ7A==", 2, "[\"B2B\",\"Negotiations\"]" },
                    { 16, "Rzeszow, Grunwaldzka 6", "PMExperts", "Poland", "Firma zajmująca się koordynacją projektów IT w metodykach Agile i Scrum.", "joanna.olszewska@gmail.com", "Joanna", "1100998877", "Olszewska", "7788990011", "AQAAAAIAAYagAAAAEJSKnz3vbwYv0Ziv11CiBkVbpLe/mHqtlm9WZFCAvGPZdqtsebeuwAwrMn+gxmeF5A==", 2, "[\"Agile\",\"Scrum\"]" },
                    { 17, "Gdynia, Skwer Kosciuszki 9", "ITSecure", "Poland", "Dostawca usług IT w zakresie administracji serwerami i bezpieczeństwa sieci.", "krzysztof.urban@gmail.com", "Krzysztof", "2233446655", "Urban", "5566443322", "AQAAAAIAAYagAAAAENs+iv6tGmL7envuCKoauNrQZ104RwI0qzp5NsYlTrue2hEWrg9SKYP78XOLxJ1l3Q==", 2, "[\"Linux\",\"Networking\"]" },
                    { 18, "Bielsko-Biala, Partyzantów 18", "BizAnalytics", "Poland", "Firma analityczna świadcząca usługi w zakresie analizy biznesowej i baz danych.", "monika.dabrowska@gmail.com", "Monika", "7766554433", "Dabrowska", "3344556677", "AQAAAAIAAYagAAAAEMuhpfhDyDCr8HcykULwPPXTkCiyHqKv0nuN7asXmDAoUye22WcfSmcWE9+qa89+uw==", 2, "[\"SQL\",\"UML\"]" },
                    { 19, "Torun, Szeroka 2", "HelpDeskPro", "Poland", "Firma świadcząca wsparcie techniczne oraz konsultacje w obszarze IT.", "dawid.pietrzak@gmail.com", "Dawid", "6655443322", "Pietrzak", "2233445566", "AQAAAAIAAYagAAAAEIBc+UJNFK74bl1sSoWc1rMmStKS6o4dmaijOG7mexdhQVB16pm9wPlMzdis8w1LeA==", 2, "[\"Customer Service\",\"ITIL\"]" },
                    { 20, "Plock, Tumskie 14", "ContentLab", "Poland", "Agencja kreatywna specjalizująca się w tworzeniu treści marketingowych.", "natalia.sawicka@gmail.com", "Natalia", "5566778899", "Sawicka", "9988776655", "AQAAAAIAAYagAAAAEPTeVyaGYTwMF9AecllFQlANfU/RXTrAGOdcBKJpbykZIxdTdCGdCy/EM+9ak+NElA==", 2, "[\"Copywriting\",\"Social Media\"]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
