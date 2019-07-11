using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emes.Core;
using Emes.Core.Data;
using Emes.Erp.ISystem;
using Emes.Erp.ISystem.Dtos.Organizations;
using Emes.Erp.System.Models;
using Surging.Core.AutoMapper;
using Surging.Core.ProxyGenerator;

namespace Emes.Erp.System.Implementation
{
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

        public Task<Result<OrganizationDto>> Delete(DeleteOrganizationDto request)
        {
            throw new NotImplementedException();
        }

        public Task<Result<OrganizationDto>> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IList<OrganizationDto>>> Query(QueryOrganizationDto request)
        {
            throw new NotImplementedException();
        }

        public Task<Result<OrganizationDto>> Update(UpdateOrganizationDto request)
        {
            throw new NotImplementedException();
        }
    }
}
