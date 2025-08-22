using AutoMapper;
using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Domain;
using Freelancer.Backend.Domain.Exceptions;
using Freelancer.Backend.Infrastructure.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace Freelancer.Backend.Business.Services
{
    public class RateService : IRateService
    {
        private readonly IRepository<Rating> _ratingRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public RateService(IRepository<Rating> ratingRepository, IUserRepository userRepository, IMapper mapper)
        {
            _ratingRepository = ratingRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(RateCreationRequest rateDto)
        {
            var user = await _userRepository.GetByEmailWithRoleAsync(x => x.Id == rateDto.UserId);

            if (user == null)
            {
                throw new EntityNotFoundApiException();
            }

            var ratingEntity = _mapper.Map<Rating>(rateDto);

            ratingEntity.User = user;

            await _ratingRepository.AddAsync(ratingEntity);
        }

        public async Task DeleteAsync(int id)
        {
            await _ratingRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<RateDto>> GetAllAsync(int userId, int skip, int take)
        {
            var ratings = await _ratingRepository.GetAllAsync();

            ratings = ratings.Where(x => x.UserId == userId).Skip(skip).Take(take);

            if (ratings.IsNullOrEmpty())
            {
                return Enumerable.Empty<RateDto>();
            }

            var creatingUserIds = ratings
                                .Where(r => r.CreatingUserId.HasValue)
                                .Select(r => r.CreatingUserId.Value)
                                .Distinct()
                                .ToList();

            // Fetch all creating users in a single query
            var creatingUsers = await _userRepository.GetAllByFilterAsync(u => creatingUserIds.Contains(u.Id));

            // Map to dictionary for quick lookup
            var userDictionary = creatingUsers.ToDictionary(u => u.Id);

            // Map ratings to DTOs with creating user information
            var rateDtos = ratings.Select(rating =>
            {
                var rateDto = _mapper.Map<RateDto>(rating);

                if (rating.CreatingUserId.HasValue && userDictionary.TryGetValue(rating.CreatingUserId.Value, out var user))
                {
                    // Assuming RateDto has these properties or they will be added
                    rateDto.CreatingName = $"{user.FirstName} {user.LastName}";
                }

                return rateDto;
            });

            return rateDtos;
        }

        public async Task<int> GetAverageRating(int id)
        {
            var ratings = await _ratingRepository.GetAllAsync();

            ratings = ratings.Where(x => x.UserId == id).ToList();

            if (ratings.IsNullOrEmpty())
            {
                return 0;
            }

            var average = ratings.Average(x => x.Rate);

            return (int)Math.Round(average, 0);
        }
    }
}
