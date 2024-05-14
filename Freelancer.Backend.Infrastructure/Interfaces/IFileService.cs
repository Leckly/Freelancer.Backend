namespace Freelancer.Backend.Infrastructure.Interfaces
{
    public interface IFileService
    {
        void CreateFile(string filePath);
        void CreateDirectory(string filePath);
        Task SaveFileContentAsync(string filePath, MemoryStream memoryStream);
        Task<MemoryStream> GetFileContentAsync(string filePath);
        void DeleteFileContent(string filePath);
    }
}
