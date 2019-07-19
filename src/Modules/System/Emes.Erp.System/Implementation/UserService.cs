using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emes.Core;
using Emes.Core.Data;
using Emes.Erp.ISystem;
using Emes.Erp.ISystem.Dtos.Users;
using Emes.Erp.System.Models;
using Surging.Core.AutoMapper;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Core.ProxyGenerator;

namespace Emes.Erp.System.Implementation
{
    [ModuleName("User")]
    public class UserService : ProxyServiceBase, IUserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository
            )
        {
            _userRepository = userRepository;
        }

        public Task<UserDto> Authentication(AuthUserDto request)
        {
            if (request.IsValid())
            {
                var user = _userRepository.Query.FirstOrDefault(x => x.Name == request.UserName && x.Password == request.Password);
                if (user != null)
                {
                    return Task.FromResult(user.MapTo<UserDto>());
                }
                return Task.FromResult<UserDto>(null);
            }
            else
            {
                return Task.FromResult<UserDto>(null);
            }
        }

        public Task<Result<UserDto>> Create(CreateUserDto request)
        {
            if (request.IsValid())
            {
                var user = request.MapTo<User>();
                _userRepository.Add(user);
                return Result.Ok(user.MapTo<UserDto>());
            }
            else
            {
                return Result.Fail<UserDto>(request.Message());
            }
        }

        public async Task<Result<UserDto>> Delete(DeleteUserDto request)
        {
            if (request.IsValid())
            {
                var user = await _userRepository.GetById(request.Id);
                if (user != null)
                {
                    await _userRepository.Remove(user);
                    return await Result.Ok(user.MapTo<UserDto>());
                }
                return await Result.NotFound<UserDto>();

            }
            else
            {
                return await Result.Fail<UserDto>(request.Message());
            }
        }

        public async Task<Result<UserDto>> GetById(long id)
        {

            var user = await _userRepository.GetById(id);
            if (user != null)
            {
                return await Result.Ok(user.MapTo<UserDto>());
            }
            return await Result.NotFound<UserDto>();

        }

        public Task<Result<IEnumerable<UserDto>>> Query(QueryUserDto request)
        {
            var query = _userRepository.Query;
            if (!string.IsNullOrEmpty(request.Name))
            {
                query = query.Where(q => q.Name.Contains(request.Name));
            }
            return Result.Ok(query.MapTo<UserDto>());
        }

        public async Task<Result<UserDto>> Update(UpdateUserDto request)
        {
            if (request.IsValid())
            {
                var user = await _userRepository.GetById(request.Id);
                if (user != null)
                {
                    user = request.MapTo(user);
                    await _userRepository.Update(user);
                    return await Result.Ok(user.MapTo<UserDto>());
                }
                return await Result.NotFound<UserDto>();

            }
            else
            {
                return await Result.Fail<UserDto>(request.Message());
            }
        }
    }
}
