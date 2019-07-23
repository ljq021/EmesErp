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
using Emes.Erp.ISystem.Dtos.Organizations;
using Emes.Erp.System.Models;
using Surging.Core.AutoMapper;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Core.ProxyGenerator;

namespace Emes.Erp.System.Implementation
{
    [ModuleName("Organization")]
    public class OrganizationService : ProxyServiceBase, IOrganizationService
    {
        private readonly IRepository<Organization> _organizationRepository;
        public OrganizationService(IRepository<Organization> organizationRepository
            )
        {
            _organizationRepository = organizationRepository;
        }
        /// <summary>
        /// 创建组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<Result<OrganizationDto>> Create(CreateOrganizationDto request)
        {
            if (request.IsValid())
            {
                var organization = request.MapTo<Organization>();
                _organizationRepository.Add(organization);
                return Result.Ok(organization.MapTo<OrganizationDto>());
            }
            else
            {
                return Result.Fail<OrganizationDto>(request.Message());
            }
        }

        /// <summary>
        /// 删除组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Result<OrganizationDto>> Delete(DeleteOrganizationDto request)
        {
            if (request.IsValid())
            {
                var organization = await _organizationRepository.GetById(request.Id);
                if (organization != null)
                {
                    await _organizationRepository.Remove(organization);
                    return await Result.Ok(organization.MapTo<OrganizationDto>());
                }
                return await Result.NotFound<OrganizationDto>();

            }
            else
            {
                return await Result.Fail<OrganizationDto>(request.Message());
            }
        }

        /// <summary>
        /// 根据Id获取组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Result<OrganizationDto>> GetById(long id)
        {

            var organization = await _organizationRepository.GetById(id);
            if (organization != null)
            {
                return await Result.Ok(organization.MapTo<OrganizationDto>());
            }
            return await Result.NotFound<OrganizationDto>();

        }

        /// <summary>
        /// 查询组织机构列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<Result<IEnumerable<OrganizationDto>>> Query(QueryOrganizationDto request)
        {
            var query = _organizationRepository.Query;
           
            return Result.Ok(query.MapTo<OrganizationDto>());
            ;
        }

        /// <summary>
        /// 更新组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Result<OrganizationDto>> Update(UpdateOrganizationDto request)
        {
            if (request.IsValid())
            {
                var organization = await _organizationRepository.GetById(request.Id);
                if (organization != null)
                {
                    organization = request.MapTo(organization);
                    await _organizationRepository.Update(organization);
                    return await Result.Ok(organization.MapTo<OrganizationDto>());
                }
                return await Result.NotFound<OrganizationDto>();

            }
            else
            {
                return await Result.Fail<OrganizationDto>(request.Message());
            }
        }
    }
}