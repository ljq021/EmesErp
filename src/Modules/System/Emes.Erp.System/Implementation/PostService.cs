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
        public Task<Result<PostDto>> Create(CreatePostDto request)
        {
            if (request.IsValid())
            {
                var post = request.MapTo<Post>();
                _postRepository.Add(post);
                return Result.Ok(post.MapTo<PostDto>());
            }
            else
            {
                return Result.Fail<PostDto>(request.Message());
            }
        }

        /// <summary>
        /// 删除岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Result<PostDto>> Delete(DeletePostDto request)
        {
            if (request.IsValid())
            {
                var post = await _postRepository.GetById(request.Id);
                if (post != null)
                {
                    await _postRepository.Remove(post);
                    return await Result.Ok(post.MapTo<PostDto>());
                }
                return await Result.NotFound<PostDto>();

            }
            else
            {
                return await Result.Fail<PostDto>(request.Message());
            }
        }

        /// <summary>
        /// 根据Id获取岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Result<PostDto>> GetById(long id)
        {

            var post = await _postRepository.GetById(id);
            if (post != null)
            {
                return await Result.Ok(post.MapTo<PostDto>());
            }
            return await Result.NotFound<PostDto>();

        }

        /// <summary>
        /// 查询岗位列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<Result<IEnumerable<PostDto>>> Query(QueryPostDto request)
        {
            var query = _postRepository.Query;
           
            return Result.Ok(query.MapTo<PostDto>());
            ;
        }

        /// <summary>
        /// 更新岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Result<PostDto>> Update(UpdatePostDto request)
        {
            if (request.IsValid())
            {
                var post = await _postRepository.GetById(request.Id);
                if (post != null)
                {
                    post = request.MapTo(post);
                    await _postRepository.Update(post);
                    return await Result.Ok(post.MapTo<PostDto>());
                }
                return await Result.NotFound<PostDto>();

            }
            else
            {
                return await Result.Fail<PostDto>(request.Message());
            }
        }
    }
}