using Freelancer.Backend.Domain.Exceptions;
using Freelancer.Backend.Infrastructure.Configurations;
using Freelancer.Backend.Infrastructure.Interfaces;
using Microsoft.Extensions.Options;

namespace Freelancer.Backend.Infrastructure
{
    public class PhotoContentRepository : IPhotoContentRepository
    {
        private readonly IFileService _fileService;
        private readonly string _userPhotoStoragePath;
        private readonly string _jobPhotoStoragePath;

        public PhotoContentRepository(IFileService fileService, IOptions<StorageOptions> options)
        {
            _fileService = fileService;
            _jobPhotoStoragePath = options.Value.JobPhotoStoragePath;
            _userPhotoStoragePath = options.Value.UserPhotoStoragePath;
        }

        public async Task<MemoryStream> GetUserPhotoAsync(string filename)
        {
            var blobPath = GetBlobUserFilePath(filename);

            if (!File.Exists(blobPath))
            {
                throw new EntityNotFoundApiException();
            }

            return await _fileService.GetFileContentAsync(blobPath);
        }

        public async Task SaveUserPhotoAsync(string filename, MemoryStream content)
        {
            var blobPath = GetBlobUserFilePath(filename);
            await _fileService.SaveFileContentAsync(blobPath, content);
        }

        public void DeleteUserPhotoContent(string filename)
        {
            var blobPath = GetBlobUserFilePath(filename);
            _fileService.DeleteFileContent(blobPath);
        }

        public void InitializeDatabase()
        {
            _fileService.CreateDirectory(_userPhotoStoragePath);
            _fileService.CreateDirectory(_jobPhotoStoragePath);
        }

        private string GetBlobUserFilePath(string filename)
            => Path.Combine(_userPhotoStoragePath, filename);

        private string GetBlobJobFilePath(/*int jobId, */string fileName)
            => Path.Combine(_jobPhotoStoragePath, /*jobId.ToString(),*/ $"{fileName}");

        public async Task SaveJobPhotoAsync(/*int jobId, */string filename, MemoryStream content)
        {
            var blobPath = GetBlobJobFilePath(/*jobId, */filename);
            //_fileService.CreateDirectory(Path.Combine(_jobPhotoStoragePath, jobId.ToString()));
            await _fileService.SaveFileContentAsync(blobPath, content);
        }

        public async Task<MemoryStream> GetJobPhotoAsync(int jobId,string filename)
        {
            var blobPath = GetBlobJobFilePath(filename);

            if (!File.Exists(blobPath))
            {
                throw new EntityNotFoundApiException();
            }

            return await _fileService.GetFileContentAsync(blobPath);
        }

        public void DeleteJobPhotoContent(int jobId, string filename)
        {
            var blobPath = GetBlobJobFilePath(filename);
            _fileService.DeleteFileContent(blobPath);
        }
    }
}
