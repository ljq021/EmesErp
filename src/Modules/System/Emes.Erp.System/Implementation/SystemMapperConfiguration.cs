using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Emes.Erp.ISystem.Dtos.Organizations;
using Emes.Erp.System.Models;

namespace Emes.Erp.System.Implementation
{
    public class SystemMapperConfiguration : Profile
    {
        public SystemMapperConfiguration()
        {
            #region organization
            CreateMap<Organization, OrganizationDto>();
            CreateMap<OrganizationDto, Organization>();
            CreateMap<CreateOrganizationDto, Organization>();
            CreateMap<UpdateOrganizationDto, Organization>();

            #endregion
        }
    }
}
