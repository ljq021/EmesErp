using System;
using System.Collections.Generic;
using System.Text;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Users
{
    public class AclDto : DtoBase
    {
        public Guid Id { get; set; }

        public IEnumerable<string> Abilities { get; set; }
    }
}
