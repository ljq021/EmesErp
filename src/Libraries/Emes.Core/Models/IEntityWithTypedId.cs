using System;

namespace Emes.Core.Models
{
    public interface IEntity
    {

        long OrgId { get; set; }

        int Version { get; set; }
        DateTimeOffset CreatedOn { get; set; }

        DateTimeOffset UpdatedOn { get; set; }

        long CreatedById { get; set; }

        long UpdatedById { get; set; }
    }
    public interface IEntityWithTypedId<TId> : IEntity
    {
        TId Id { get; set; }

    }
}
