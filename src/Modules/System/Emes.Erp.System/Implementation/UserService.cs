#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emes.Core;
using Emes.Core.Data;
using Emes.Erp.ISystem;
using Emes.Erp.ISystem.Dtos.Users;
using Emes.Erp.System.Models;
using Surging.Core.AutoMapper;
using Surging.Core.CPlatform.Exceptions;
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
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UserDto> Create(CreateUserDto request)
        {
            if (!request.IsValid())
            {
                throw new ValidateException(request.Message());
            }
            var user = request.MapTo<User>();
            await  _userRepository.Add(user);
            return user.MapTo<UserDto>();
           
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UserDto> Delete(DeleteUserDto request)
        {
            if (!request.IsValid())
            {
                throw new ValidateException(request.Message());
            }
            var user = await _userRepository.GetById(request.Id);
            if (user == null)
            {
               throw new BusinessException(ExceptionMessage.NotFound);
            }
            await _userRepository.Remove(user);
            return user.MapTo<UserDto>();
        }

        /// <summary>
        /// 根据Id获取用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UserDto> GetById(long id)
        {

            var user = await _userRepository.GetById(id);
            if (user == null)
            {
                throw new BusinessException(ExceptionMessage.NotFound);
            }
            return user.MapTo<UserDto>();

        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<IEnumerable<UserDto>> Query(QueryUserDto request)
        {
            var query = _userRepository.Query;
           
            return Task.FromResult(query.MapTo<UserDto>());
        }

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UserDto> Update(UpdateUserDto request)
        {
            if (!request.IsValid())
            {
                throw new ValidateException(request.Message());
            }
            var user = await _userRepository.GetById(request.Id);
            if (user == null)
            {
                throw new BusinessException(ExceptionMessage.NotFound);
            }
            user = request.MapTo(user);
            await _userRepository.Update(user);
            return user.MapTo<UserDto>();
        }

        /// <summary>
        /// 认证用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
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
    }
}