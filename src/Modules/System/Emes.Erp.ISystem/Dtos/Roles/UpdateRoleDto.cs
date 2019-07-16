using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Roles
{
    public class UpdateRoleDto : DtoWithIdBase
    {
        public string Name { get; set; }
        public string Notes { get; set; }
    }
}
