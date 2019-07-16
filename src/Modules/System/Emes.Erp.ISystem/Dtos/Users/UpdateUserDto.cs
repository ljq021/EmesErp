using System;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Users
{
    public class UpdateUserDto : DtoWithIdBase
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string SystemName { get; set; }
        public bool IsLock { get; set; }
        public DateTimeOffset EffectiveDate { get; set; }
        public bool IsLimitDuplicateLogin { get; set; }
        public string Notes { get; set; }
    }
}
