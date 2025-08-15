using Freelancer.Backend.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.Property(e => e.Address).HasMaxLength(255);
            builder.Property(e => e.CompanyName).HasMaxLength(255);
            builder.Property(e => e.Country).HasMaxLength(255);
            builder.Property(e => e.Description).HasMaxLength(512);
            builder.Property(e => e.Email).HasMaxLength(255);
            builder.Property(e => e.FirstName).HasMaxLength(255);
            builder.Property(e => e.Krs)
                .HasMaxLength(10)
                .HasColumnName("KRS");
            builder.Property(e => e.LastName).HasMaxLength(255);
            builder.Property(e => e.Nip)
                .HasMaxLength(10)
                .HasColumnName("NIP");
            builder.Property(e => e.PasswordHash).HasMaxLength(255);

            builder.HasOne(a => a.Photo)
                    .WithOne(b => b.User)
                    .HasForeignKey<UserPhoto>(b => b.UserId)
                    .HasConstraintName("FK__User__PhotoId__7F2BE32F");

            builder.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__User__RoleId__7E37BEF6");

            var passwordHasher = new PasswordHasher<User>();

            builder.HasData(new List<User>
            {
                new User
                {
                    Id = 1,
                    Email = "john.smith@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "smthPassword12!"),
                    FirstName = "John",
                    LastName = "Smith",
                    Nip = "0123456789",
                    Krs = "0123456789",
                    Address = "Warsaw, Aleje Jerozolimskie 5",
                    Description = "Doświadczony programista .NET i Java z pasją do nowych technologii.",
                    Country = "Poland",
                    CompanyName = "GoodCompany",
                    RoleId = 1,
                    Tags = [".NET", "Java"]
                },
                new User
                {
                    Id = 2,
                    Email = "michael.brown@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "Password123!"),
                    FirstName = "Michael",
                    LastName = "Brown",
                    Nip = "1234567890",
                    Krs = "9876543210",
                    Address = "Krakow, Main Street 12",
                    Description = "Senior developer z wieloletnim doświadczeniem w pracy z chmurą Azure.",
                    Country = "Poland",
                    CompanyName = "DevMasters",
                    RoleId = 1,
                    Tags = ["C#", "Azure"]
                },
                new User
                {
                    Id = 3,
                    Email = "anna.kowalska@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "SecurePass!"),
                    FirstName = "Anna",
                    LastName = "Kowalska",
                    Nip = "2233445566",
                    Krs = "6655443322",
                    Address = "Gdansk, Dluga 1",
                    Description = "Fullstack developer z doświadczeniem w React i Node.js.",
                    Country = "Poland",
                    CompanyName = "WebSolutions",
                    RoleId = 1,
                    Tags = ["React", "Node.js"]
                },
                new User
                {
                    Id = 4,
                    Email = "piotr.nowak@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "PiotrPass12!"),
                    FirstName = "Piotr",
                    LastName = "Nowak",
                    Nip = "9988776655",
                    Krs = "5566778899",
                    Address = "Lodz, Piotrkowska 100",
                    Description = "Specjalista backend z dużą wiedzą w zakresie Java i Spring Boot.",
                    Country = "Poland",
                    CompanyName = "CloudTech",
                    RoleId = 1,
                    Tags = ["Java", "Spring Boot"]
                },
                new User
                {
                    Id = 5,
                    Email = "karolina.mazur@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "MazurKarolina!"),
                    FirstName = "Karolina",
                    LastName = "Mazur",
                    Nip = "1112223334",
                    Krs = "4333222111",
                    Address = "Poznan, Swiety Marcin 45",
                    Description = "Ekspert frontend z doświadczeniem w Angular i TypeScript.",
                    Country = "Poland",
                    CompanyName = "UIWorks",
                    RoleId = 1,
                    Tags = ["Angular", "TypeScript"]
                },
                new User
                {
                    Id = 6,
                    Email = "pawel.zielinski@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "ZielinskiPawel!"),
                    FirstName = "Pawel",
                    LastName = "Zielinski",
                    Nip = "7778889990",
                    Krs = "0999888777",
                    Address = "Szczecin, Aleja Piastów 10",
                    Description = "Architekt oprogramowania specjalizujący się w .NET i mikroserwisach.",
                    Country = "Poland",
                    CompanyName = "SoftBuild",
                    RoleId = 1,
                    Tags = [".NET", "Microservices"]
                },
                new User
                {
                    Id = 7,
                    Email = "magdalena.wisniewska@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "MagdaWisniewska!"),
                    FirstName = "Magdalena",
                    LastName = "Wisniewska",
                    Nip = "1122334455",
                    Krs = "5544332211",
                    Address = "Warsaw, Nowy Swiat 20",
                    Description = "Inżynier QA z doświadczeniem w automatyzacji testów.",
                    Country = "Poland",
                    CompanyName = "TestIt",
                    RoleId = 1,
                    Tags = ["Selenium", "Cypress"]
                },
                new User
                {
                    Id = 8,
                    Email = "adam.lewandowski@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "LewandowskiAdam!"),
                    FirstName = "Adam",
                    LastName = "Lewandowski",
                    Nip = "5566778899",
                    Krs = "9988776655",
                    Address = "Katowice, Mickiewicza 8",
                    Description = "Inżynier DevOps specjalizujący się w Docker i Kubernetes.",
                    Country = "Poland",
                    CompanyName = "OpsMasters",
                    RoleId = 1,
                    Tags = ["Docker", "Kubernetes"]
                },
                new User
                {
                    Id = 9,
                    Email = "dorota.kaczmarek@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "DorotaPass12!"),
                    FirstName = "Dorota",
                    LastName = "Kaczmarek",
                    Nip = "3322114455",
                    Krs = "5544211332",
                    Address = "Bydgoszcz, Główna 22",
                    Description = "Data scientist z doświadczeniem w Python i machine learning.",
                    Country = "Poland",
                    CompanyName = "DataVision",
                    RoleId = 1,
                    Tags = ["Python", "ML"]
                },
                new User
                {
                    Id = 10,
                    Email = "marcin.wozniak@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "WozniakMarcin!"),
                    FirstName = "Marcin",
                    LastName = "Wozniak",
                    Nip = "8899001122",
                    Krs = "2211009988",
                    Address = "Opole, Krakowska 15",
                    Description = "Programista aplikacji mobilnych w Flutter i React Native.",
                    Country = "Poland",
                    CompanyName = "Appify",
                    RoleId = 1,
                    Tags = ["Flutter", "React Native"]
                },
                new User
                {
                    Id = 11,
                    Email = "jack.smith@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "SmthPassword12!"),
                    FirstName = "Jack",
                    LastName = "Smith",
                    Nip = "0123456789",
                    Krs = "0123456789",
                    Address = "Bialystok, Aleje Jerozolimskie 5",
                    Description = "Firma IT specjalizująca się w rozwiązaniach webowych i mobilnych dla sektora e-commerce.",
                    Country = "Poland",
                    CompanyName = "PerfectCompany",
                    RoleId = 2,
                    Tags = [".NET", "Java"]
                },
                new User
                {
                    Id = 12,
                    Email = "lisa.jones@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "LisaPass12!"),
                    FirstName = "Lisa",
                    LastName = "Jones",
                    Nip = "1231231230",
                    Krs = "3213213210",
                    Address = "Warsaw, Prosta 4",
                    Description = "Agencja HR oferująca kompleksowe usługi rekrutacyjne i doradztwo personalne.",
                    Country = "Poland",
                    CompanyName = "HRPlus",
                    RoleId = 2,
                    Tags = ["Recruitment", "Onboarding"]
                },
                new User
                {
                    Id = 13,
                    Email = "tomasz.malinowski@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "MalinowskiTomasz!"),
                    FirstName = "Tomasz",
                    LastName = "Malinowski",
                    Nip = "4445556667",
                    Krs = "7666555444",
                    Address = "Lublin, Krakowskie Przedmieście 33",
                    Description = "Agencja marketingowa zajmująca się kampaniami SEO i reklamami Google Ads.",
                    Country = "Poland",
                    CompanyName = "MarketLead",
                    RoleId = 2,
                    Tags = ["SEO", "Google Ads"]
                },
                new User
                {
                    Id = 14,
                    Email = "ewa.adamska@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "EwaAdamska!"),
                    FirstName = "Ewa",
                    LastName = "Adamska",
                    Nip = "1011121314",
                    Krs = "4131211101",
                    Address = "Warsaw, Marszalkowska 7",
                    Description = "Studio projektowe tworzące nowoczesne interfejsy i doświadczenia użytkowników.",
                    Country = "Poland",
                    CompanyName = "DesignHub",
                    RoleId = 2,
                    Tags = ["Figma", "UX"]
                },
                new User
                {
                    Id = 15,
                    Email = "grzegorz.kubiak@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "KubiakGrzegorz!"),
                    FirstName = "Grzegorz",
                    LastName = "Kubiak",
                    Nip = "6677889900",
                    Krs = "0099887766",
                    Address = "Kielce, Sienkiewicza 11",
                    Description = "Firma doradcza specjalizująca się w obsłudze klientów B2B i negocjacjach handlowych.",
                    Country = "Poland",
                    CompanyName = "BizGrow",
                    RoleId = 2,
                    Tags = ["B2B", "Negotiations"]
                },
                new User
                {
                    Id = 16,
                    Email = "joanna.olszewska@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "JoannaOlszewska!"),
                    FirstName = "Joanna",
                    LastName = "Olszewska",
                    Nip = "7788990011",
                    Krs = "1100998877",
                    Address = "Rzeszow, Grunwaldzka 6",
                    Description = "Firma zajmująca się koordynacją projektów IT w metodykach Agile i Scrum.",
                    Country = "Poland",
                    CompanyName = "PMExperts",
                    RoleId = 2,
                    Tags = ["Agile", "Scrum"]
                },
                new User
                {
                    Id = 17,
                    Email = "krzysztof.urban@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "UrbanKrzysztof!"),
                    FirstName = "Krzysztof",
                    LastName = "Urban",
                    Nip = "5566443322",
                    Krs = "2233446655",
                    Address = "Gdynia, Skwer Kosciuszki 9",
                    Description = "Dostawca usług IT w zakresie administracji serwerami i bezpieczeństwa sieci.",
                    Country = "Poland",
                    CompanyName = "ITSecure",
                    RoleId = 2,
                    Tags = ["Linux", "Networking"]
                },
                new User
                {
                    Id = 18,
                    Email = "monika.dabrowska@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "MonikaDabrowska!"),
                    FirstName = "Monika",
                    LastName = "Dabrowska",
                    Nip = "3344556677",
                    Krs = "7766554433",
                    Address = "Bielsko-Biala, Partyzantów 18",
                    Description = "Firma analityczna świadcząca usługi w zakresie analizy biznesowej i baz danych.",
                    Country = "Poland",
                    CompanyName = "BizAnalytics",
                    RoleId = 2,
                    Tags = ["SQL", "UML"]
                },
                new User
                {
                    Id = 19,
                    Email = "dawid.pietrzak@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "DawidPietrzak!"),
                    FirstName = "Dawid",
                    LastName = "Pietrzak",
                    Nip = "2233445566",
                    Krs = "6655443322",
                    Address = "Torun, Szeroka 2",
                    Description = "Firma świadcząca wsparcie techniczne oraz konsultacje w obszarze IT.",
                    Country = "Poland",
                    CompanyName = "HelpDeskPro",
                    RoleId = 2,
                    Tags = ["Customer Service", "ITIL"]
                },
                new User
                {
                    Id = 20,
                    Email = "natalia.sawicka@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(default, "NataliaSawicka!"),
                    FirstName = "Natalia",
                    LastName = "Sawicka",
                    Nip = "9988776655",
                    Krs = "5566778899",
                    Address = "Plock, Tumskie 14",
                    Description = "Agencja kreatywna specjalizująca się w tworzeniu treści marketingowych.",
                    Country = "Poland",
                    CompanyName = "ContentLab",
                    RoleId = 2,
                    Tags = ["Copywriting", "Social Media"]
                }
            });
        }
    }
}
