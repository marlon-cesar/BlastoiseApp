using BlastoiseApp.Domain.Interfaces.Entities;

namespace BlastoiseApp.Domain.Entities.Common
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; protected set; }

        public DateTime CreatedAt { get; protected set; }

        public DateTime? UpdatedAt { get; protected set; }
    }
}
