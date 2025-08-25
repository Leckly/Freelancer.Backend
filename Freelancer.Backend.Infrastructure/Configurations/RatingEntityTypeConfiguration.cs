using Freelancer.Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class RatingEntityTypeConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable("Rating");

            builder.Property(e => e.Comment).HasMaxLength(255);

            builder.HasOne(d => d.User).WithMany(p => p.Ratings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Rating__UserId__06CD04F7");
            #region Seed Data
            builder.HasData(new List<Rating>
            {
                // Ratings for User 1
                new Rating { Id = 1, Rate = 4, Comment = "Great work!", UserId = 1, CreatingUserId = 2 },
                new Rating { Id = 2, Rate = 5, Comment = "Very professional.", UserId = 1, CreatingUserId = 3 },
                new Rating { Id = 3, Rate = 3, Comment = "Good, but room to improve.", UserId = 1, CreatingUserId = 4 },
                new Rating { Id = 4, Rate = 5, Comment = "Excellent skills!", UserId = 1, CreatingUserId = 5 },
                new Rating { Id = 5, Rate = 2, Comment = "Could be better.", UserId = 1, CreatingUserId = 6 },
                new Rating { Id = 6, Rate = 4, Comment = "Nice collaboration.", UserId = 1, CreatingUserId = 7 },

                // Ratings for User 2
                new Rating { Id = 7, Rate = 5, Comment = "Outstanding developer.", UserId = 2, CreatingUserId = 1 },
                new Rating { Id = 8, Rate = 4, Comment = "Very reliable.", UserId = 2, CreatingUserId = 3 },
                new Rating { Id = 9, Rate = 3, Comment = "Good, but slow on some tasks.", UserId = 2, CreatingUserId = 4 },
                new Rating { Id = 10, Rate = 5, Comment = "Highly recommended.", UserId = 2, CreatingUserId = 5 },
                new Rating { Id = 11, Rate = 2, Comment = "Needs more attention to detail.", UserId = 2, CreatingUserId = 6 },
                new Rating { Id = 12, Rate = 4, Comment = "Solid work ethic.", UserId = 2, CreatingUserId = 7 },

                // Ratings for User 3
                new Rating { Id = 13, Rate = 5, Comment = "Excellent in React.", UserId = 3, CreatingUserId = 1 },
                new Rating { Id = 14, Rate = 4, Comment = "Great teamwork.", UserId = 3, CreatingUserId = 2 },
                new Rating { Id = 15, Rate = 3, Comment = "Average communication.", UserId = 3, CreatingUserId = 4 },
                new Rating { Id = 16, Rate = 5, Comment = "Strong problem-solving skills.", UserId = 3, CreatingUserId = 5 },
                new Rating { Id = 17, Rate = 2, Comment = "Sometimes late with tasks.", UserId = 3, CreatingUserId = 6 },
                new Rating { Id = 18, Rate = 4, Comment = "Good coding standards.", UserId = 3, CreatingUserId = 7 },

                // Ratings for User 4
                new Rating { Id = 19, Rate = 5, Comment = "Backend expertise is solid.", UserId = 4, CreatingUserId = 1 },
                new Rating { Id = 20, Rate = 4, Comment = "Reliable developer.", UserId = 4, CreatingUserId = 2 },
                new Rating { Id = 21, Rate = 3, Comment = "Can improve testing.", UserId = 4, CreatingUserId = 3 },
                new Rating { Id = 22, Rate = 5, Comment = "Knows Spring Boot very well.", UserId = 4, CreatingUserId = 5 },
                new Rating { Id = 23, Rate = 2, Comment = "Slow in code reviews.", UserId = 4, CreatingUserId = 6 },
                new Rating { Id = 24, Rate = 4, Comment = "Good design patterns usage.", UserId = 4, CreatingUserId = 7 },

                // Ratings for User 5
                new Rating { Id = 25, Rate = 5, Comment = "Excellent frontend skills.", UserId = 5, CreatingUserId = 1 },
                new Rating { Id = 26, Rate = 4, Comment = "Creative UI designs.", UserId = 5, CreatingUserId = 2 },
                new Rating { Id = 27, Rate = 3, Comment = "Occasionally misses deadlines.", UserId = 5, CreatingUserId = 3 },
                new Rating { Id = 28, Rate = 5, Comment = "Very good with Angular.", UserId = 5, CreatingUserId = 4 },
                new Rating { Id = 29, Rate = 2, Comment = "Needs more TypeScript experience.", UserId = 5, CreatingUserId = 6 },
                new Rating { Id = 30, Rate = 4, Comment = "Strong in frontend architecture.", UserId = 5, CreatingUserId = 7 },

                // Ratings for User 6
                new Rating { Id = 31, Rate = 5, Comment = "Excellent software architect.", UserId = 6, CreatingUserId = 1 },
                new Rating { Id = 32, Rate = 4, Comment = "Great with DDD and CQRS.", UserId = 6, CreatingUserId = 2 },
                new Rating { Id = 33, Rate = 3, Comment = "Sometimes overcomplicates designs.", UserId = 6, CreatingUserId = 3 },
                new Rating { Id = 34, Rate = 5, Comment = "Good microservices design.", UserId = 6, CreatingUserId = 4 },
                new Rating { Id = 35, Rate = 2, Comment = "Needs better documentation.", UserId = 6, CreatingUserId = 5 },
                new Rating { Id = 36, Rate = 4, Comment = "Strong .NET expertise.", UserId = 6, CreatingUserId = 7 },

                // Ratings for User 7
                new Rating { Id = 37, Rate = 5, Comment = "QA automation expert.", UserId = 7, CreatingUserId = 1 },
                new Rating { Id = 38, Rate = 4, Comment = "Good test coverage.", UserId = 7, CreatingUserId = 2 },
                new Rating { Id = 39, Rate = 3, Comment = "Sometimes misses edge cases.", UserId = 7, CreatingUserId = 3 },
                new Rating { Id = 40, Rate = 5, Comment = "Excellent Selenium skills.", UserId = 7, CreatingUserId = 4 },
                new Rating { Id = 41, Rate = 2, Comment = "Needs improvement in Cypress.", UserId = 7, CreatingUserId = 5 },
                new Rating { Id = 42, Rate = 4, Comment = "Good testing practices.", UserId = 7, CreatingUserId = 6 },

                // Ratings for User 8
                new Rating { Id = 43, Rate = 5, Comment = "DevOps expertise is top-notch.", UserId = 8, CreatingUserId = 1 },
                new Rating { Id = 44, Rate = 4, Comment = "Very reliable with Kubernetes.", UserId = 8, CreatingUserId = 2 },
                new Rating { Id = 45, Rate = 3, Comment = "Occasionally slow CI/CD pipelines.", UserId = 8, CreatingUserId = 3 },
                new Rating { Id = 46, Rate = 5, Comment = "Excellent Docker knowledge.", UserId = 8, CreatingUserId = 4 },
                new Rating { Id = 47, Rate = 2, Comment = "Needs better Linux troubleshooting.", UserId = 8, CreatingUserId = 5 },
                new Rating { Id = 48, Rate = 4, Comment = "Good DevOps practices.", UserId = 8, CreatingUserId = 6 },

                // Ratings for User 9
                new Rating { Id = 49, Rate = 5, Comment = "Great data scientist.", UserId = 9, CreatingUserId = 1 },
                new Rating { Id = 50, Rate = 4, Comment = "Good Python skills.", UserId = 9, CreatingUserId = 2 },
                new Rating { Id = 51, Rate = 3, Comment = "Needs more ML optimization.", UserId = 9, CreatingUserId = 3 },
                new Rating { Id = 52, Rate = 5, Comment = "Excellent with TensorFlow.", UserId = 9, CreatingUserId = 4 },
                new Rating { Id = 53, Rate = 2, Comment = "PyTorch skills need improvement.", UserId = 9, CreatingUserId = 5 },
                new Rating { Id = 54, Rate = 4, Comment = "Strong data analysis.", UserId = 9, CreatingUserId = 6 },

                // Ratings for User 10
                new Rating { Id = 55, Rate = 5, Comment = "Mobile apps are excellent.", UserId = 10, CreatingUserId = 1 },
                new Rating { Id = 56, Rate = 4, Comment = "Great Flutter skills.", UserId = 10, CreatingUserId = 2 },
                new Rating { Id = 57, Rate = 3, Comment = "Sometimes slow in React Native.", UserId = 10, CreatingUserId = 3 },
                new Rating { Id = 58, Rate = 5, Comment = "Good cross-platform knowledge.", UserId = 10, CreatingUserId = 4 },
                new Rating { Id = 59, Rate = 2, Comment = "Firebase integration can improve.", UserId = 10, CreatingUserId = 5 },
                new Rating { Id = 60, Rate = 4, Comment = "Strong mobile architecture.", UserId = 10, CreatingUserId = 6 },

                // Ratings for User 11
                new Rating { Id = 61, Rate = 4, Comment = "Solid IT solutions.", UserId = 11, CreatingUserId = 12 },
                new Rating { Id = 62, Rate = 5, Comment = "Great APIs.", UserId = 11, CreatingUserId = 13 },
                new Rating { Id = 63, Rate = 3, Comment = "Some delays in projects.", UserId = 11, CreatingUserId = 14 },
                new Rating { Id = 64, Rate = 5, Comment = "Excellent mobile apps.", UserId = 11, CreatingUserId = 15 },
                new Rating { Id = 65, Rate = 2, Comment = "Needs better documentation.", UserId = 11, CreatingUserId = 16 },
                new Rating { Id = 66, Rate = 4, Comment = "Very professional.", UserId = 11, CreatingUserId = 17 },

                // Ratings for User 12
                new Rating { Id = 67, Rate = 5, Comment = "Excellent recruitment services.", UserId = 12, CreatingUserId = 11 },
                new Rating { Id = 68, Rate = 4, Comment = "Great onboarding processes.", UserId = 12, CreatingUserId = 13 },
                new Rating { Id = 69, Rate = 3, Comment = "Communication can improve.", UserId = 12, CreatingUserId = 14 },
                new Rating { Id = 70, Rate = 5, Comment = "Very professional team.", UserId = 12, CreatingUserId = 15 },
                new Rating { Id = 71, Rate = 2, Comment = "Needs more follow-ups.", UserId = 12, CreatingUserId = 16 },
                new Rating { Id = 72, Rate = 4, Comment = "Reliable HR services.", UserId = 12, CreatingUserId = 17 },

                // Ratings for User 13
                new Rating { Id = 73, Rate = 5, Comment = "Great SEO campaigns.", UserId = 13, CreatingUserId = 11 },
                new Rating { Id = 74, Rate = 4, Comment = "Effective Google Ads.", UserId = 13, CreatingUserId = 12 },
                new Rating { Id = 75, Rate = 3, Comment = "Reporting can improve.", UserId = 13, CreatingUserId = 14 },
                new Rating { Id = 76, Rate = 5, Comment = "Creative marketing team.", UserId = 13, CreatingUserId = 15 },
                new Rating { Id = 77, Rate = 2, Comment = "Needs faster execution.", UserId = 13, CreatingUserId = 16 },
                new Rating { Id = 78, Rate = 4, Comment = "Strong analytics expertise.", UserId = 13, CreatingUserId = 17 },

                // Ratings for User 14
                new Rating { Id = 79, Rate = 5, Comment = "Amazing design studio.", UserId = 14, CreatingUserId = 11 },
                new Rating { Id = 80, Rate = 4, Comment = "Good UX/UI work.", UserId = 14, CreatingUserId = 12 },
                new Rating { Id = 81, Rate = 3, Comment = "Could improve accessibility.", UserId = 14, CreatingUserId = 13 },
                new Rating { Id = 82, Rate = 5, Comment = "Very creative designs.", UserId = 14, CreatingUserId = 15 },
                new Rating { Id = 83, Rate = 2, Comment = "Some delays in delivery.", UserId = 14, CreatingUserId = 16 },
                new Rating { Id = 84, Rate = 4, Comment = "Strong prototyping skills.", UserId = 14, CreatingUserId = 17 },

                // Ratings for User 15
                new Rating { Id = 85, Rate = 5, Comment = "Excellent B2B consulting.", UserId = 15, CreatingUserId = 11 },
                new Rating { Id = 86, Rate = 4, Comment = "Great negotiation skills.", UserId = 15, CreatingUserId = 12 },
                new Rating { Id = 87, Rate = 3, Comment = "Sales approach can improve.", UserId = 15, CreatingUserId = 13 },
                new Rating { Id = 88, Rate = 5, Comment = "Reliable business partner.", UserId = 15, CreatingUserId = 14 },
                new Rating { Id = 89, Rate = 2, Comment = "CRM usage needs improvement.", UserId = 15, CreatingUserId = 16 },
                new Rating { Id = 90, Rate = 4, Comment = "Strong consulting services.", UserId = 15, CreatingUserId = 17 },

                // Ratings for User 16
                new Rating { Id = 91, Rate = 5, Comment = "Excellent Agile coordination.", UserId = 16, CreatingUserId = 11 },
                new Rating { Id = 92, Rate = 4, Comment = "Good project management.", UserId = 16, CreatingUserId = 12 },
                new Rating { Id = 93, Rate = 3, Comment = "Some sprints delayed.", UserId = 16, CreatingUserId = 13 },
                new Rating { Id = 94, Rate = 5, Comment = "Very organized team.", UserId = 16, CreatingUserId = 14 },
                new Rating { Id = 95, Rate = 2, Comment = "Jira usage can improve.", UserId = 16, CreatingUserId = 15 },
                new Rating { Id = 96, Rate = 4, Comment = "Strong Scrum practices.", UserId = 16, CreatingUserId = 17 },

                // Ratings for User 17
                new Rating { Id = 97, Rate = 5, Comment = "Excellent IT security.", UserId = 17, CreatingUserId = 11 },
                new Rating { Id = 98, Rate = 4, Comment = "Good networking skills.", UserId = 17, CreatingUserId = 12 },
                new Rating { Id = 99, Rate = 3, Comment = "Monitoring can improve.", UserId = 17, CreatingUserId = 13 },
                new Rating { Id = 100, Rate = 5, Comment = "Reliable server management.", UserId = 17, CreatingUserId = 14 },
                new Rating { Id = 101, Rate = 2, Comment = "Needs faster incident response.", UserId = 17, CreatingUserId = 15 },
                new Rating { Id = 102, Rate = 4, Comment = "Strong DevSecOps practices.", UserId = 17, CreatingUserId = 16 },

                // Ratings for User 18
                new Rating { Id = 103, Rate = 5, Comment = "Great business analytics.", UserId = 18, CreatingUserId = 11 },
                new Rating { Id = 104, Rate = 4, Comment = "Good SQL skills.", UserId = 18, CreatingUserId = 12 },
                new Rating { Id = 105, Rate = 3, Comment = "ETL pipelines need improvement.", UserId = 18, CreatingUserId = 13 },
                new Rating { Id = 106, Rate = 5, Comment = "Excellent BI knowledge.", UserId = 18, CreatingUserId = 14 },
                new Rating { Id = 107, Rate = 2, Comment = "UML diagrams can be clearer.", UserId = 18, CreatingUserId = 15 },
                new Rating { Id = 108, Rate = 4, Comment = "Strong data warehousing skills.", UserId = 18, CreatingUserId = 16 },

                // Ratings for User 19
                new Rating { Id = 109, Rate = 5, Comment = "Excellent IT support.", UserId = 19, CreatingUserId = 11 },
                new Rating { Id = 110, Rate = 4, Comment = "Reliable helpdesk services.", UserId = 19, CreatingUserId = 12 },
                new Rating { Id = 111, Rate = 3, Comment = "Troubleshooting can be faster.", UserId = 19, CreatingUserId = 13 }
            });
            #endregion
        }
    }
}
