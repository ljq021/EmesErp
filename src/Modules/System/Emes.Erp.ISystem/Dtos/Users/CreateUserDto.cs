using System;
using System.Collections.Generic;
using System.Text;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Users
{
   public class CreateUserDto : DtoBase
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsLock { get; set; }
        public DateTimeOffset EffectiveDate { get; set; }
        public bool IsLimitDuplicateLogin { get; set; }
        public string Notes { get; set; }
    }
}
