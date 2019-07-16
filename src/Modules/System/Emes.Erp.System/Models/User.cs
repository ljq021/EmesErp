using System;
using Emes.Core.Models;

namespace Emes.Erp.System.Models
{
    public class User : EntityBase, IAggregateRoot
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsSystemAccount { get; set; }
        public string SystemName { get; set; }
        public bool IsLock { get; set; }
        public DateTimeOffset EffectiveDate { get; set; }
        public bool IsLimitDuplicateLogin { get; set; }
        public string Notes { get; set; }
    }
}
