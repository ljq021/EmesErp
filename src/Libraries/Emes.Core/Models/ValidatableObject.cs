using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Emes.Core.Models
{
    public abstract class ValidatableObject
    {
        public virtual bool IsValid()
        {
            return Validate().Count == 0;
        }

        public virtual IList<ValidationResult> Validate()
        {
            IList<ValidationResult> validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(this, new ValidationContext(this, null, null), validationResults, true);
            for (int i = 0; i < validationResults.Count(); i++)
            {
                Message += validationResults[i].ErrorMessage + (i == validationResults.Count() - 1 ? "" : "__");
            }
            return validationResults;
        }

        /// <summary>
        /// 验证信息，在IsValid方法调用后才会赋值
        /// </summary>
        public string Message { get; set; }
    }
}
