using AutoMapper;
using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Domain;
using Freelancer.Backend.Domain.Enums;
using Freelancer.Backend.Infrastructure.Interfaces;

namespace Freelancer.Backend.Business.Services;

public class JobRequestService : IJobRequestService
{
    private readonly IJobRequestRepository _jobRequestRepository;
    private readonly IJobRepository _jobRepository;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    private readonly IEmailService _emailService;

    public JobRequestService(IJobRequestRepository jobRequestRepository, IJobRepository jobRepository, IUserRepository userRepository, IMapper mapper, IEmailService emailService)
    {
        _jobRequestRepository = jobRequestRepository;
        _jobRepository = jobRepository;
        _userRepository = userRepository;
        _mapper = mapper;
        _emailService = emailService;
    }

    public async Task<JobRequestDto> AddAsync(int userId, int jobId)
    {
        var user = await _userRepository.GetByFilterAsync(x => x.Id == userId);
        var job = await _jobRepository.GetByFilterAsync(x => x.Id == jobId);
        var jobOwner = await _userRepository.GetByFilterAsync(x => x.Id == job.UserId);

        var jobRequest = new JobRequest()
        {
            Job = job,
            User = user,
            Status = JobRequestStatus.Pending
        };

        var request = await _jobRequestRepository.AddAsync(jobRequest);

        await _emailService.SendEmailToJobOwner(jobOwner.Email, $"{user.FirstName} {user.LastName}", job.Name);

        return _mapper.Map<JobRequestDto>(request);
    }

    public async Task DeleteAsync(int userId, int jobId)
    {
        await _jobRequestRepository.DeleteAsync(userId, jobId);
    }

    public Task<IEnumerable<JobRequestDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<JobRequestDtoForProfile>> GetAllForUserAsync(int userId)
    {
        var jobRequests = await _jobRequestRepository.GetAllWithJobsAsync(x => x.UserId == userId);

        return jobRequests.Select(x => _mapper.Map<JobRequestDtoForProfile>(x));
    }

    public async Task<JobRequestDto> GetByIdAsync(int userId, int jobId)
    {
        var request = await _jobRequestRepository.GetByFilterAsync(x => x.User.Id == userId && x.Job.Id == jobId);

        return _mapper.Map<JobRequestDto>(request);
    }

    public async Task UpdateAsync(int userId, int jobId, JobRequestStatus status)
    {
        var request = await _jobRequestRepository.GetByFilterAsync(x => x.User.Id == userId && x.Job.Id == jobId);

        request.Status = status;

        await _jobRequestRepository.UpdateAsync(userId, request);
    }
}
