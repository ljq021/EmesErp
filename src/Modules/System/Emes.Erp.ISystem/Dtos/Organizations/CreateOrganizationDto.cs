using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Organizations
{
    public class CreateOrganizationDto : DtoBase
    {
        public long ParentId { get; set; }
        public string No { get; set; }

        [Required(ErrorMessage = "名称是必填项")]
        [StringLength(10, ErrorMessage = "最大长度小于10")]
        public string Name { get; set; }
        public string MnemonicCode { get; set; }
        public bool IsFiliale { get; set; }
        public bool IsSubbranch { get; set; }
    }
}
