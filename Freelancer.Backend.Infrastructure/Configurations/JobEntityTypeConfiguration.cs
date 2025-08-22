using Freelancer.Backend.Domain;
using Freelancer.Backend.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class JobEntityTypeConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("Job");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Description).HasMaxLength(512);
            builder.Property(e => e.Name).HasMaxLength(255);

            builder.HasMany(x => x.JobPhotos)
                .WithOne(x => x.Job)
                .HasForeignKey(x => x.JobId);

            builder.HasOne(d => d.User).WithMany(p => p.Jobs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Job__UserId__02084FDA");

            builder.HasData(new List<Job>
            {
                new Job
                {
                    Id = 1,
                    UserId = 11,
                    Name = "Rozwój aplikacji mobilnej e-commerce",
                    Description = "Projekt aplikacji mobilnej dla sklepu internetowego z wykorzystaniem Flutter i React Native.",
                    CreateDate = DateTime.UtcNow.AddDays(-30),
                    StartDate = DateTime.UtcNow.AddDays(-20),
                    Status = JobStatus.Opened,
                    Price = 15000,
                    Tags = ["Flutter", "React Native", "E-Commerce"]
                },
                new Job
                {
                    Id = 2,
                    UserId = 11,
                    Name = "Integracja Firebase w aplikacji mobilnej",
                    Description = "Dodanie logowania Google i obsługi powiadomień push w aplikacji mobilnej.",
                    CreateDate = DateTime.UtcNow.AddDays(-15),
                    StartDate = DateTime.UtcNow.AddDays(-10),
                    Status = JobStatus.Closed,
                    Price = 4000,
                    Tags = ["Firebase", "Push Notifications", "Mobile"]
                },
                new Job
                {
                    Id = 3,
                    UserId = 11,
                    Name = "Budowa platformy e-commerce w .NET",
                    Description = "Tworzenie skalowalnej platformy e-commerce opartej o mikroserwisy w .NET i Javie.",
                    CreateDate = DateTime.UtcNow.AddDays(-60),
                    StartDate = DateTime.UtcNow.AddDays(-45),
                    Status = JobStatus.Opened,
                    Price = 25000,
                    Tags = [".NET", "Java", "Microservices", "E-Commerce"]
                },
                new Job
                {
                    Id = 4,
                    UserId = 12,
                    Name = "System do zarządzania rekrutacją IT",
                    Description = "Projekt aplikacji webowej wspierającej proces rekrutacyjny i onboarding programistów.",
                    CreateDate = DateTime.UtcNow.AddDays(-25),
                    StartDate = DateTime.UtcNow.AddDays(-15),
                    Status = JobStatus.Closed,
                    Price = 7000,
                    Tags = ["ASP.NET Core", "HRTech", "Recruitment"]
                },
                new Job
                {
                    Id = 5,
                    UserId = 12,
                    Name = "Portal onboardingowy dla nowych pracowników",
                    Description = "Budowa platformy webowej z materiałami szkoleniowymi i check-listą onboardingu.",
                    CreateDate = DateTime.UtcNow.AddDays(-10),
                    StartDate = DateTime.UtcNow.AddDays(-5),
                    Status = JobStatus.Opened,
                    Price = 3000,
                    Tags = ["Blazor", "ASP.NET Core", "Onboarding"]
                },
                new Job
                {
                    Id = 6,
                    UserId = 13,
                    Name = "System analizy SEO",
                    Description = "Aplikacja webowa analizująca SEO stron i generująca raporty dla klientów.",
                    CreateDate = DateTime.UtcNow.AddDays(-40),
                    StartDate = DateTime.UtcNow.AddDays(-30),
                    Status = JobStatus.Closed,
                    Price = 8000,
                    Tags = ["SEO", "WebApp", "Analytics"]
                },
                new Job
                {
                    Id = 7,
                    UserId = 13,
                    Name = "Moduł raportowania danych",
                    Description = "Implementacja modułu generowania raportów z kampanii marketingowych.",
                    CreateDate = DateTime.UtcNow.AddDays(-5),
                    StartDate = DateTime.UtcNow.AddDays(2),
                    Status = JobStatus.Opened,
                    Price = 2000,
                    Tags = ["Reporting", "SQL", "Dashboard"]
                },
                new Job
                {
                    Id = 8,
                    UserId = 14,
                    Name = "Projekt interfejsu systemu bankowego",
                    Description = "Tworzenie nowoczesnego UI/UX dla aplikacji bankowej w Figma.",
                    CreateDate = DateTime.UtcNow.AddDays(-20),
                    StartDate = DateTime.UtcNow.AddDays(-10),
                    Status = JobStatus.Opened,
                    Price = 12000,
                    Tags = ["UI", "UX", "Figma"]
                },
                new Job
                {
                    Id = 9,
                    UserId = 15,
                    Name = "System CRM dla firmy B2B",
                    Description = "Projekt systemu do zarządzania klientami i negocjacjami handlowymi.",
                    CreateDate = DateTime.UtcNow.AddDays(-18),
                    StartDate = DateTime.UtcNow.AddDays(-12),
                    Status = JobStatus.Closed,
                    Price = 6000,
                    Tags = ["CRM", "B2B", "ASP.NET Core"]
                },
                new Job
                {
                    Id = 10,
                    UserId = 15,
                    Name = "Aplikacja szkoleniowa online",
                    Description = "Budowa platformy e-learningowej do szkoleń sprzedażowych.",
                    CreateDate = DateTime.UtcNow.AddDays(-7),
                    StartDate = DateTime.UtcNow.AddDays(1),
                    Status = JobStatus.Opened,
                    Price = 5000,
                    Tags = ["E-Learning", "Blazor", "WebApp"]
                },
                new Job
                {
                    Id = 11,
                    UserId = 16,
                    Name = "Koordynacja projektu w Agile",
                    Description = "Wsparcie w prowadzeniu projektu IT z wykorzystaniem Scruma i Jiry.",
                    CreateDate = DateTime.UtcNow.AddDays(-50),
                    StartDate = DateTime.UtcNow.AddDays(-40),
                    Status = JobStatus.Closed,
                    Price = 9000,
                    Tags = ["Agile", "Scrum", "Jira"]
                },
                new Job
                {
                    Id = 12,
                    UserId = 17,
                    Name = "Audyt bezpieczeństwa aplikacji webowej",
                    Description = "Analiza luk bezpieczeństwa i wdrożenie rozwiązań DevSecOps.",
                    CreateDate = DateTime.UtcNow.AddDays(-22),
                    StartDate = DateTime.UtcNow.AddDays(-15),
                    Status = JobStatus.Opened,
                    Price = 11000,
                    Tags = ["Security", "DevSecOps", "PenTest"]
                },
                new Job
                {
                    Id = 13,
                    UserId = 17,
                    Name = "System monitoringu serwerów",
                    Description = "Implementacja Prometheus i Grafana do monitorowania infrastruktury.",
                    CreateDate = DateTime.UtcNow.AddDays(-12),
                    StartDate = DateTime.UtcNow.AddDays(-7),
                    Status = JobStatus.Closed,
                    Price = 5000,
                    Tags = ["Monitoring", "Prometheus", "Grafana"]
                },
                new Job
                {
                    Id = 14,
                    UserId = 18,
                    Name = "Analiza biznesowa systemu ERP",
                    Description = "Zbieranie wymagań i projektowanie modelu danych dla ERP.",
                    CreateDate = DateTime.UtcNow.AddDays(-35),
                    StartDate = DateTime.UtcNow.AddDays(-25),
                    Status = JobStatus.Opened,
                    Price = 14000,
                    Tags = ["ERP", "SQL", "Business Analysis"]
                },
                new Job
                {
                    Id = 15,
                    UserId = 18,
                    Name = "Projekt hurtowni danych",
                    Description = "Stworzenie architektury hurtowni danych dla systemu BI.",
                    CreateDate = DateTime.UtcNow.AddDays(-8),
                    StartDate = DateTime.UtcNow.AddDays(-2),
                    Status = JobStatus.Closed,
                    Price = 10000,
                    Tags = ["ETL", "Data Warehouse", "BI"]
                },
                new Job
                {
                    Id = 16,
                    UserId = 19,
                    Name = "System zgłoszeń helpdesk",
                    Description = "Projekt aplikacji webowej do obsługi zgłoszeń klientów.",
                    CreateDate = DateTime.UtcNow.AddDays(-3),
                    StartDate = DateTime.UtcNow.AddDays(-1),
                    Status = JobStatus.Opened,
                    Price = 1500,
                    Tags = ["Helpdesk", "ASP.NET Core", "Support"]
                },
                new Job
                {
                    Id = 17,
                    UserId = 19,
                    Name = "Panel administracyjny dla helpdesk",
                    Description = "Stworzenie panelu admina do zarządzania zgłoszeniami i SLA.",
                    CreateDate = DateTime.UtcNow.AddDays(-2),
                    StartDate = DateTime.UtcNow.AddDays(3),
                    Status = JobStatus.Closed,
                    Price = 1000,
                    Tags = ["Admin Panel", "Support", "WebApp"]
                },
                new Job
                {
                    Id = 18,
                    UserId = 20,
                    Name = "System zarządzania treściami",
                    Description = "Budowa prostego CMS do zarządzania artykułami IT.",
                    CreateDate = DateTime.UtcNow.AddDays(-14),
                    StartDate = DateTime.UtcNow.AddDays(-5),
                    Status = JobStatus.Opened,
                    Price = 4500,
                    Tags = ["CMS", "ASP.NET Core", "Content Management"]
                },
                new Job
                {
                    Id = 19,
                    UserId = 20,
                    Name = "Moduł API do generowania raportów",
                    Description = "Projekt REST API do eksportu danych do Excela i PDF.",
                    CreateDate = DateTime.UtcNow.AddDays(-6),
                    StartDate = DateTime.UtcNow.AddDays(2),
                    Status = JobStatus.Closed,
                    Price = 2500,
                    Tags = ["API", "REST", "Reporting"]
                },
                new Job
                {
                    Id = 20,
                    UserId = 20,
                    Name = "Refaktoryzacja aplikacji legacy",
                    Description = "Migracja starej aplikacji .NET Framework do .NET 8.",
                    CreateDate = DateTime.UtcNow.AddDays(-20),
                    StartDate = DateTime.UtcNow.AddDays(-12),
                    Status = JobStatus.Opened,
                    Price = 9000,
                    Tags = [".NET", "Refactoring", "Migration"]
                }
            });
        }
    }
}
