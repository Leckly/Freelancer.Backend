using Freelancer.Backend.Infrastructure.Interfaces;

namespace Freelancer.Backend.Infrastructure
{
    public class DbInitializer : IDbInitializer
    {
        private readonly IPhotoContentRepository _photoContentRepository;

        public DbInitializer(IPhotoContentRepository photoContentRepository)
        {
            _photoContentRepository = photoContentRepository;
        }

        public void Initialize()
        {
            _photoContentRepository.InitializeDatabase();
        }
    }
}
