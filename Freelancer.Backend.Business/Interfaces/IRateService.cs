using Freelancer.Backend.Business.Dto;

namespace Freelancer.Backend.Business.Interfaces
{
    public interface IRateService
    {
        Task<IEnumerable<RateDto>> GetAllAsync(int userId, int skip, int take);
        Task AddAsync(RateDto rateDto);
        Task DeleteAsync(int id);
    }
}
