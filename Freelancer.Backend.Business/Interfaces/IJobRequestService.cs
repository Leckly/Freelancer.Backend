using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Domain.Enums;

namespace Freelancer.Backend.Business.Interfaces;

public interface IJobRequestService
{
    Task<IEnumerable<JobRequestDto>> GetAllAsync();
    Task<IEnumerable<JobRequestForJobDto>> GetAllForJobAsync(int jobId);
    Task<IEnumerable<JobRequestDtoForProfile>> GetAllForUserAsync(int userId);
    Task<JobRequestDto> GetByIdAsync(int userId, int jobId);
    Task<JobRequestDto> AddAsync(int userId, int jobId);
    Task DeleteAsync(int userId, int jobId);
    Task UpdateAsync(int userId, int jobId , JobRequestStatus status);
}
