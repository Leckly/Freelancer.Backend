using Freelancer.Backend.Infrastructure.Interfaces;

namespace Freelancer.Backend.Infrastructure
{
    public class FileService : IFileService
    {
        public void CreateDirectory(string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
        }

        public void CreateFile(string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);
            if (string.IsNullOrEmpty(directory))
            {
                throw new ArgumentNullException(directory);
            }

            CreateDirectory(directory);

            if (!File.Exists(filePath))
            {
                using (File.Create(filePath))
                {

                }
            }
        }

        public void DeleteFileContent(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            var directory = Path.GetDirectoryName(filePath);
            if (Directory.Exists(directory) && Directory.GetFiles(directory).Length == 0)
            {
                DeleteDirectory(directory);
            }
        }

        public async Task<MemoryStream> GetFileContentAsync(string filePath)
        {
            var memoryStream = new MemoryStream();
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                await fileStream.CopyToAsync(memoryStream);
            }
            memoryStream.Position = 0;
            return memoryStream;
        }

        public async Task SaveFileContentAsync(string filePath, MemoryStream memoryStream)
        {
            using var file = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            await memoryStream.CopyToAsync(file);
        }

        private void DeleteDirectory(string filePath)
        {
            if (Directory.Exists(filePath))
            {
                Directory.Delete(filePath, true);
            }
        }
    }
}
