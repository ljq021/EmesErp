using Emes.Core;
using Emes.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Emes.Erp.System.Models
{

    public class Organization : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "父级部门是必填项")]
        public long ParentId { get; set; }

        public string No { get; set; }
        public string Name { get; set; }
        public string MnemonicCode { get; set; }
        public bool IsFiliale { get; set; }
        public bool IsSubbranch { get; set; }
    }
}
