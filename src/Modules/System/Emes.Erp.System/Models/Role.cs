using Emes.Core.Models;

namespace Emes.Erp.System.Models
{
    public class Role : EntityBase, IAggregateRoot
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool IsSystemRole { get; set; }

    }
}
