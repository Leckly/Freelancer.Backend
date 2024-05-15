namespace Freelancer.Backend.Infrastructure.Interfaces
{
    public interface IPhotoContentRepository
    {
        Task SaveUserPhotoAsync(string filename, MemoryStream content);
        Task<MemoryStream> GetUserPhotoAsync(string filename);
        void DeleteUserPhotoContent(string filename);
        Task SaveJobPhotoAsync(int jobId, string filename, MemoryStream content);
        Task<MemoryStream> GetJobPhotoAsync(int jobId, string filename);
        void DeleteJobPhotoContent(int jobId, string filename);
        void InitializeDatabase();
    }
}
