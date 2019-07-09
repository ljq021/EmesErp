using System;

namespace Emes.Core.Models
{
    public abstract class EntityBaseWithTypedId<TId> : ValidatableObject, IEntityWithTypedId<TId>
    {
        public virtual TId Id { get; set; }

        public virtual long OrgId { get; set; }
        public virtual int Version { get; set; }
        public virtual DateTimeOffset CreatedOn { get; set; }
        public virtual DateTimeOffset UpdatedOn { get; set; }
        public virtual long CreatedById { get; set; }
        public virtual long UpdatedById { get; set; }
    }
}
