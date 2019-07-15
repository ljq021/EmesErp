using System;
using System.Collections.Generic;
using System.Text;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Users
{
   public class CreateUserDto : DtoBase
    {
        public string Name;
        public string Password;
        public bool IsLock;
        public DateTimeOffset EffectiveDate;
        public bool IsLimitDuplicateLogin;
        public string Notes;
    }
}
