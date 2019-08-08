#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System.Collections.Generic;
using AutoMapper;
using Emes.Erp.ISystem.Dtos.Roles;
using Emes.Erp.System.Models;

namespace Emes.Erp.System.Implementation.AutoMapper
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>();
            CreateMap<RoleDto, Role>();
            CreateMap<CreateRoleDto, Role>();
            CreateMap<UpdateRoleDto, Role>();
            CreateMap<IList<Role>, IList<RoleDto>>();
        }
    }
}