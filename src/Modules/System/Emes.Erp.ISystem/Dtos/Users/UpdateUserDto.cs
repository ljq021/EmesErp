using System;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Users
{
    public class UpdateUserDto : DtoWithIdBase
    {
        public string Name;
        public string Password;
        public string SystemName;
        public bool IsLock;
        public DateTimeOffset EffectiveDate;
        public bool IsLimitDuplicateLogin;
        public string Notes;
    }
}
