using System;
using System.Collections.Generic;
using System.Text;

namespace Emes.Erp.ISystem.Dtos.Users
{
   public  class UserDto
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
