using System;
using Emes.Core.Models;

namespace Emes.Erp.System.Models
{
    public class User : EntityBase, IAggregateRoot
    {
        public string Name;
        public string Password;
        public bool IsSystemAccount;
        public string SystemName;
        public bool IsLock;
        public DateTimeOffset EffectiveDate;
        public bool IsLimitDuplicateLogin;
        public string Notes;
    }
}
