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

            return ratings.Select( x => _mapper.Map<RateDto>(x));
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
