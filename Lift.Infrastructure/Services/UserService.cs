using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Lift.Core.Domain;
using Lift.Core.Repositories;
using Lift.Infrastructure.DTO;
using Lift.Infrastructure.Exceptions;

namespace Lift.Infrastructure.Services
{
    public class UserService : IUserService
    { 
        private readonly IUserRepository _userRepository;
        private readonly IEncrypter _encrypter;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IEncrypter encrypter, IMapper mapper)
        {
            _userRepository = userRepository;
            _encrypter = encrypter;
            _mapper = mapper;
        }

        public async Task<UserDto> GetAsync(string email)
        {
            var user = await _userRepository.GetAsync(email);

            return _mapper.Map<User,UserDto>(user);
        }

        public async Task<IEnumerable<UserDto>> BrowseAsync()
        {
            var drivers = await _userRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<User>,IEnumerable<UserDto>>(drivers);
        }

        public async Task LoginAsync(string email, string password)
        {
            var user = await _userRepository.GetAsync(email);
            if(user == null)
            {
                throw new ServiceException(ErrorCodes.InvalidCredentials, 
                    "Invalid credentials");
            }
            
            var hash = _encrypter.GetHash(password, user.Salt);
            if(user.Password == hash)
            {
                return;
            }
            throw new ServiceException(ErrorCodes.InvalidCredentials, 
                "Invalid credentials");
        }

        public async Task RegisterAsync(Guid userId, string email, 
            string username, string password, string role)
        {
            var user = await _userRepository.GetAsync(email);
            if(user != null)
            {
                throw new ServiceException(ErrorCodes.EmailInUse, 
                    $"User with email: '{email}' already exists.");
            }

            var salt = _encrypter.GetSalt(password);
            var hash = _encrypter.GetHash(password, salt);
            user = new User(userId, email, username, role, hash, salt);
            await _userRepository.AddAsync(user);
        }
    }
}