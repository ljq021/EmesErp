using Emes.Core.Models;

namespace Emes.Erp.System.Models
{
    public class Role : EntityBase, IAggregateRoot
    {
        public string Name;
        public string Notes;
        public bool IsSystemRole;

    }
}
