using System;
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
using Surging.Core.ProxyGenerator;

namespace Emes.Erp.System.Implementation
{
    [ModuleName("Org")]
    public class OrganizationService : ProxyServiceBase, IOrganizationService
    {
        private readonly IRepository<Organization> _orgRepository;
        public OrganizationService(IRepository<Organization> orgRepository
            )
        {
            _orgRepository = orgRepository;
        }
        public Task<Result<OrganizationDto>> Create(CreateOrganizationDto request)
        {
            if (request.IsValid())
            {
                var org = request.MapTo<Organization>();
                _orgRepository.Add(org);
                return Result.Ok(org.MapTo<OrganizationDto>());
            }
            else
            {
                return Result.Fail<OrganizationDto>(request.Message());
            }
        }

        public async Task<Result<OrganizationDto>> Delete(DeleteOrganizationDto request)
        {
            if (request.IsValid())
            {
                var org = await _orgRepository.GetById(request.Id);
                if (org != null)
                {
                    await _orgRepository.Remove(org);
                    return await Result.Ok(org.MapTo<OrganizationDto>());
                }
                return await Result.NotFound<OrganizationDto>();

            }
            else
            {
                return await Result.Fail<OrganizationDto>(request.Message());
            }
        }

        public async Task<Result<OrganizationDto>> GetById(long id)
        {

            var org = await _orgRepository.GetById(id);
            if (org != null)
            {
                return await Result.Ok(org.MapTo<OrganizationDto>());
            }
            return await Result.NotFound<OrganizationDto>();

        }

        public Task<Result<IEnumerable<OrganizationDto>>> Query(QueryOrganizationDto request)
        {
            var query = _orgRepository.Query;
            if (!string.IsNullOrEmpty(request.Name))
            {
                query = query.Where(q => q.Name.Contains(request.Name));
            }
            return Result.Ok(query.MapTo<OrganizationDto>());
            ;
        }

        public async Task<Result<OrganizationDto>> Update(UpdateOrganizationDto request)
        {
            if (request.IsValid())
            {
                var org = await _orgRepository.GetById(request.Id);
                if (org != null)
                {
                    await _orgRepository.Update(org);
                    return await Result.Ok(org.MapTo<OrganizationDto>());
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
