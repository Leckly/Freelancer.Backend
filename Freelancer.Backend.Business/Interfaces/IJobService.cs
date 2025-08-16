using Freelancer.Backend.Business.Dto;

namespace Freelancer.Backend.Business.Interfaces
{
    public interface IJobService
    {
        Task<IEnumerable<JobDto>> GetAllAsync(int skip, int take, string searchBar, string[] tags);
        Task<JobDto> GetByIdAsync(int id);
        Task<JobDto> AddAsync(JobCreationRequest jobDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, JobUpdateRequest jobDto);

        Task<ReceivePhotoResponse> GetJobPhoto(int jobId, int photoId);
        Task UpdateJobStatus(int jobId);
    }
}
