using System;
using System.Collections.Generic;
using System.Text;
using Emes.Core.Models;

namespace Emes.Erp.System.Models
{
    public class Post : EntityBase, IAggregateRoot
    {
        public long OrgId { get; set; }

        public string No { get; set; }

        public string Name { get; set; }

        public string MnemonicCode { get; set; }

        public bool IsKey { get; set; }
        public int Type { get; set; }

        public string Responsibility { get; set; }
        public string Desc { get; set; }
    }
}
