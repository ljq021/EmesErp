using System;
using System.Collections.Generic;
using System.Text;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Posts
{
    public class PostDto : DtoWithIdBase
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
