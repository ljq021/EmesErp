using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Emes.Erp.ISystem.Dtos.Organizations;
using Emes.Erp.ISystem.Dtos.Posts;
using Emes.Erp.ISystem.Dtos.Roles;
using Emes.Erp.ISystem.Dtos.Users;
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
            CreateMap<IList<Organization>, IList<OrganizationDto>>();
            #endregion

            #region post
            CreateMap<Post, PostDto>();
            CreateMap<PostDto, Post>();
            CreateMap<CreatePostDto, Post>();
            CreateMap<UpdatePostDto, Post>();
            CreateMap<IList<Post>, IList<PostDto>>();
            #endregion

            #region role
            CreateMap<Role, RoleDto>();
            CreateMap<RoleDto, Role>();
            CreateMap<CreateRoleDto, Role>();
            CreateMap<UpdateRoleDto, Role>();
            CreateMap<IList<Role>, IList<RoleDto>>();
            #endregion

            #region user
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<IList<User>, IList<UserDto>>();
            #endregion
        }
    }
}
