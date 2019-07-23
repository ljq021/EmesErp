using System.Collections.Generic;
using AutoMapper;
using Emes.Erp.ISystem.Dtos.Organizations;
using Emes.Erp.System.Models;

namespace Emes.Erp.System.Implementation.AutoMapper
{
    public partial class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<Organization, OrganizationDto>();
            CreateMap<OrganizationDto, Organization>();
            CreateMap<CreateOrganizationDto, Organization>();
            CreateMap<UpdateOrganizationDto, Organization>();
            CreateMap<IList<Organization>, IList<OrganizationDto>>();
        }
    }
}
