using Emes.Core.Models;

namespace Emes.Erp.System.Models
{
    public class Organization : EntityBase, IAggregateRoot
    {
        public long ParentId { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string MnemonicCode { get; set; }
        public bool IsFiliale { get; set; }
        public bool IsSubbranch { get; set; }
    }
}
