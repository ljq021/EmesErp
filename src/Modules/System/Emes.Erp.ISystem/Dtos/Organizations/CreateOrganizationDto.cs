using System;
using System.Collections.Generic;
using System.Text;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Organizations
{
    public class CreateOrganizationDto : DtoBase
    {
        public long ParentId { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string MnemonicCode { get; set; }
        public bool IsFiliale { get; set; }
        public bool IsSubbranch { get; set; }
    }
}
