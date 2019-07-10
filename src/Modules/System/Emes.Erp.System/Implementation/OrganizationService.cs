using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Emes.Core;
using Emes.Core.Data;
using Emes.Erp.ISystem;
using Emes.Erp.ISystem.Dtos.Organizations;
using Emes.Erp.System.Models;
using Surging.Core.ProxyGenerator;

namespace Emes.Erp.System.Implementation
{
    public class OrganizationService : ProxyServiceBase, IOrganizationService
    {
        private readonly IRepository<Organization> _orgRepository;
        //private readonly IMapper _mapper;
        public OrganizationService(IRepository<Organization> orgRepository
            //IMapper mapper
            )
        {
            _orgRepository = orgRepository;
        }
        public Task<Result<OrganizationDto>> Create(CreateOrganizationDto request)
        {

            if (request.IsValid())
            {
                var org = new Organization
                {
                    ParentId = request.ParentId,
                    No = request.No,
                    Name = request.Name,
                    MnemonicCode = request.MnemonicCode,
                    IsFiliale = request.IsFiliale,
                    IsSubbranch = request.IsSubbranch
                };
                _orgRepository.Add(org);
                var orgDto = new OrganizationDto
                {
                    ParentId = request.ParentId,
                    No = request.No,
                    Name = request.Name,
                    MnemonicCode = request.MnemonicCode,
                    IsFiliale = request.IsFiliale,
                    IsSubbranch = request.IsSubbranch,
                    Id = org.Id
                };
                return Result.Ok<OrganizationDto>(orgDto);
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
