using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emes.Gateway.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string SystemName { get; set; }
        public bool IsLock { get; set; }
        public DateTimeOffset EffectiveDate { get; set; }
        public bool IsLimitDuplicateLogin { get; set; }
        public string Notes { get; set; }
    }
}
