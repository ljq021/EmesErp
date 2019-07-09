using System;
using System.Collections.Generic;
using System.Text;
using Emes.Core.Models;

namespace Emes.Core.Dtos
{
    public abstract class DtoBase : ValidatableObject, IDto
    {

    }

    public abstract class DtoWithIdBase : DtoBase
    {
        public virtual long Id { get; set; }
    }
}
