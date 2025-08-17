using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Domain.Enums;

namespace Freelancer.Backend.Business.Interfaces
{
    public interface IJobService
    {
        Task<IEnumerable<JobDto>> GetAllAsync(int skip, int take, string searchBar, string[] tags, JobStatus status);
        Task<JobDto> GetByIdAsync(int id);
        Task<JobDto> AddAsync(JobCreationRequest jobDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, JobUpdateRequest jobDto);

        Task<ReceivePhotoResponse> GetJobPhoto(int jobId, int photoId);
        Task UpdateJobStatus(int jobId);
    }
}
