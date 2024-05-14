using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Domain;
using Freelancer.Backend.Infrastructure.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace Freelancer.Backend.Business.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<JobDto> AddAsync(JobDto jobDto)
        {
            var job = new Job()
            {
                Id = jobDto.Id,
                Description = jobDto.Description,
                Name = jobDto.Name,
                
            };

            return null;//await _jobRepository.AddAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<JobDto>> GetAllAsync(int skip, int take, string searchBar, string[] tags)
        {
            var jobs = await _jobRepository.GetAllWithIncludesAsync();
            if (!searchBar.IsNullOrEmpty())
            {
                jobs = jobs.Where(x => x.Name.Contains(searchBar));
            }

            if (tags != null && tags.Length > 0)
            {
                //jobs = jobs.Where(x => x.JobTags.Any(x => tags.Contains(x.Name)));
            }

            return null;
        }

        public async Task<JobDto> GetByIdAsync(int id)
        {
            await _jobRepository.GetByFilterAsync(x => x.Id == id);
            return null;
        }

        public Task UpdateAsync(int id, JobDto jobDto)
        {
            throw new NotImplementedException();
        }
    }
}
