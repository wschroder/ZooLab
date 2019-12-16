using System;

namespace Zoo.Domain.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; }

        public DateTime RecordedDate { get; set; }

        public EntityBase()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
