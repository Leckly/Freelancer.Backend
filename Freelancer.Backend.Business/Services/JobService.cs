using AutoMapper;
using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Domain;
using Freelancer.Backend.Domain.Enums;
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
        private readonly IUserRepository _userRepository;

        public JobService(IJobRepository jobRepository, IMapper mapper, IPhotoContentRepository photoContentRepository, IUserRepository userRepository)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
            _photoContentRepository = photoContentRepository;
            _userRepository = userRepository;
        }

        public async Task<JobDto> AddAsync(JobCreationRequest jobDto)
        {
            List<JobPhoto> photos = new List<JobPhoto>();

            foreach (var photo in jobDto.FormFiles)
            {
                var model = new JobPhoto()
                {
                    ContentType = photo.ContentType,
                    Name = Guid.NewGuid().ToString(),
                };

                photos.Add(model);

                var buffer = new byte[photo.Length];

                using (var content = new MemoryStream(buffer))
                {
                    await photo.CopyToAsync(content);
                    content.Position = 0;

                    await _photoContentRepository.SaveJobPhotoAsync(model.Name, content);
                }
            }

            var job = new Job()
            {
                Description = jobDto.Description,
                Name = jobDto.Name,
                CreateDate = DateTime.Now,
                StartDate = jobDto.StartDate,
                Status = JobStatus.Opened,
                Price = jobDto.Price,
                Tags = jobDto.Tags ?? Array.Empty<string>(),
                JobPhotos = photos
            };

            var user = await _userRepository.GetByFilterAsync(x => x.Id == jobDto.UserId);

            job.User = user;

            await _jobRepository.AddAsync(job);

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

        public async Task<IEnumerable<JobDto>> GetAllAsync(int skip, int take, string searchBar, string[] tags, JobStatus status, int? minPrice, DateOnly? afterDate)
        {
            var jobs = await _jobRepository.GetAllWithIncludesAsync();

            if (status == JobStatus.Closed)
            {
                jobs = jobs.Where(x => x.Status != status);
            }

            if (minPrice is not null)
            {
                jobs = jobs.Where(x => x.Price >= minPrice);
            }

            if (afterDate is not null)
            {
                jobs = jobs.Where(x => DateOnly.FromDateTime(x.StartDate) >= afterDate);
            }

            if (!searchBar.IsNullOrEmpty())
            {
                jobs = jobs.Where(x => x.Name.ToLower().Contains(searchBar.ToLower()));
            }

            if (tags != null && tags.Length > 0)
            {
                jobs = jobs.Where(x => tags.Select(y => y.ToLower()).Intersect(x.Tags.Select(z => z.ToLower())).Any());
            }

            return jobs.Skip(skip).Take(take).Select(_mapper.Map<JobDto>);
        }

        public async Task<JobDto> GetByIdAsync(int id)
        {
            var job = await _jobRepository.GetByFilterWithPhotosAsync(x => x.Id == id);

            if (job is null)
            {
                throw new EntityNotFoundApiException();
            }
            
            return _mapper.Map<JobDto>(job);
        }

        public async Task<ReceivePhotoResponse> GetJobPhoto(int jobId, int photoId)
        {
            var job = await _jobRepository.GetByFilterWithPhotosAsync(x => x.Id == jobId);

            var photo = job.JobPhotos.FirstOrDefault(x => x.Id == photoId);

            if (photo is null)
            {
                throw new EntityNotFoundApiException();
            }

            var memoryStream = await _photoContentRepository.GetJobPhotoAsync(0, photo.Name);
            return new ReceivePhotoResponse(memoryStream, photo.ContentType, photo.Name);
        }

        public async Task UpdateAsync(int id, JobUpdateRequest jobDto)
        {
            var job = await _jobRepository.GetByFilterWithPhotosAsync(x => x.Id == id);

            if (job is null)
            {
                throw new EntityNotFoundApiException();
            }

            foreach (var photo in job.JobPhotos)
            {
                _photoContentRepository.DeleteJobPhotoContent(job.Id, job.Name);
            }

            job.JobPhotos = new List<JobPhoto>();

            foreach (var photo in jobDto.FormFiles)
            {
                job.JobPhotos.Add(new JobPhoto()
                {
                    ContentType = photo.ContentType,
                    Name = new Guid().ToString(),
                });

                var buffer = new byte[photo.Length];

                using (var content = new MemoryStream(buffer))
                {
                    await photo.CopyToAsync(content);
                    content.Position = 0;

                    await _photoContentRepository.SaveJobPhotoAsync(photo.Name, content);
                }
            }

            job.Price = jobDto.Price;
            job.StartDate = jobDto.StartDate;
            job.Description = jobDto.Description;
            job.Tags = jobDto.Tags;
            job.Name = jobDto.Name;

            await _jobRepository.UpdateAsync(id, job);
        }

        public async Task UpdateJobStatus(int jobId)
        {
            var job = await _jobRepository.GetByFilterWithRequestsAsync(x => x.Id == jobId);

            if (job is null) 
            {
                throw new EntityNotFoundApiException(); 
            }

            foreach (var request in job.JobRequests.Where(x => x.Status != JobRequestStatus.Accepted))
            {
                request.Status = JobRequestStatus.Declined;
            }

            job.Status = JobStatus.Closed;

            await _jobRepository.UpdateAsync(jobId, job);
        }
    }
}
