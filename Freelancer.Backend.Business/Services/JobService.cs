using AutoMapper;
using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Domain;
using Freelancer.Backend.Domain.Exceptions;
using Freelancer.Backend.Infrastructure.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace Freelancer.Backend.Business.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;
        private readonly IPhotoContentRepository _photoContentRepository;

        public JobService(IJobRepository jobRepository, IMapper mapper, IPhotoContentRepository photoContentRepository)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
            _photoContentRepository = photoContentRepository;
        }

        public async Task<JobDto> AddAsync(JobDto jobDto)
        {
            List<JobPhoto> photos = new List<JobPhoto>();

            foreach (var item in jobDto.FormFiles)
            {
                photos.Add(new JobPhoto()
                {
                    ContentType = item.ContentType,
                    Name = item.Name,
                });
            }

            var job = new Job()
            {
                Id = jobDto.Id,
                Description = jobDto.Description,
                Name = jobDto.Name,
                JobPhotos = photos
            };

            await _jobRepository.AddAsync(job);

            foreach (var photo in photos)
            {
                var photoContent = jobDto.FormFiles.FirstOrDefault(x => x.Name == photo.Name);

                var buffer = new byte[photoContent.Length];

                using (var content = new MemoryStream(buffer))
                {
                    await photoContent.CopyToAsync(content);
                    content.Position = 0;

                    _photoContentRepository.SaveJobPhotoAsync(job.Id, photo.Name, content);
                }
            }

            return _mapper.Map<JobDto>(job);
        }

        public async Task DeleteAsync(int id)
        {
            var job = await _jobRepository.GetByFilterWithPhotosAsync(x => x.Id == id);

            if (job == null)
            {
                throw new EntityNotFoundApiException();
            }
            
            foreach (var photo in job.JobPhotos)
            {
                _photoContentRepository.DeleteJobPhotoContent(job.Id, photo.Name);
            }

            await _jobRepository.DeleteAsync(id);
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
                jobs = jobs.Where(x => tags.Intersect(x.Tags).Any());
            }

            return jobs.Skip(skip).Take(take).Select(_mapper.Map<JobDto>);
        }

        public async Task<JobDto> GetByIdAsync(int id)
        {
            var job = await _jobRepository.GetByFilterAsync(x => x.Id == id);

            if (job is null)
            {
                throw new EntityNotFoundApiException();
            }
            
            return _mapper.Map<JobDto>(job);
        }

        public async Task UpdateAsync(int id, JobDto jobDto)
        {
            var job = await _jobRepository.GetByFilterWithPhotosAsync(x => x.Id == id);

            if (job is null)
            {
                throw new EntityNotFoundApiException();
            }

            job.Description = jobDto.Description;
            job.Tags = jobDto.Tags;
            job.Name = jobDto.Name;

            await _jobRepository.UpdateAsync(id, job);
        }
    }
}
