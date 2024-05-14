namespace Freelancer.Backend.Infrastructure.Interfaces
{
    public interface IPhotoContentRepository
    {
        Task SaveUserPhotoAsync(string filename, MemoryStream content);
        Task<MemoryStream> GetUserPhotoAsync(string filename);
        void DeleteUserPhotoContent(string filename);
        void InitializeDatabase();
    }
}
