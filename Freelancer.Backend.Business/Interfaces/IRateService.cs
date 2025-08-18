using Freelancer.Backend.Business.Dto;

namespace Freelancer.Backend.Business.Interfaces
{
    public interface IRateService
    {
        Task<IEnumerable<RateDto>> GetAllAsync(int userId, int skip, int take);
        Task AddAsync(RateCreationRequest rateDto);
        Task DeleteAsync(int id);
        Task<int> GetAverageRating(int id);
    }
}
