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
using Emes.Erp.ISystem.Dtos.Posts;
using Emes.Erp.System.Models;
using Surging.Core.AutoMapper;
using Surging.Core.CPlatform.Exceptions;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Core.ProxyGenerator;

namespace Emes.Erp.System.Implementation
{
    [ModuleName("Post")]
    public class PostService : ProxyServiceBase, IPostService
    {
        private readonly IRepository<Post> _postRepository;
        public PostService(IRepository<Post> postRepository
            )
        {
            _postRepository = postRepository;
        }
        /// <summary>
        /// 创建岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PostDto> Create(CreatePostDto request)
        {
            if (!request.IsValid())
            {
                throw new ValidateException(request.Message());
            }
            var post = request.MapTo<Post>();
            await  _postRepository.Add(post);
            return post.MapTo<PostDto>();
           
        }

        /// <summary>
        /// 删除岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PostDto> Delete(DeletePostDto request)
        {
            if (!request.IsValid())
            {
                throw new ValidateException(request.Message());
            }
            var post = await _postRepository.GetById(request.Id);
            if (post == null)
            {
               throw new BusinessException(ExceptionMessage.NotFound);
            }
            await _postRepository.Remove(post);
            return post.MapTo<PostDto>();
        }

        /// <summary>
        /// 根据Id获取岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PostDto> GetById(long id)
        {

            var post = await _postRepository.GetById(id);
            if (post == null)
            {
                throw new BusinessException(ExceptionMessage.NotFound);
            }
            return post.MapTo<PostDto>();

        }

        /// <summary>
        /// 查询岗位列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<IEnumerable<PostDto>> Query(QueryPostDto request)
        {
            var query = _postRepository.Query;
           
            return Task.FromResult(query.MapTo<PostDto>());
        }

        /// <summary>
        /// 更新岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PostDto> Update(UpdatePostDto request)
        {
            if (!request.IsValid())
            {
                throw new ValidateException(request.Message());
            }
            var post = await _postRepository.GetById(request.Id);
            if (post == null)
            {
                throw new BusinessException(ExceptionMessage.NotFound);
            }
            post = request.MapTo(post);
            await _postRepository.Update(post);
            return post.MapTo<PostDto>();
        }
    }
}