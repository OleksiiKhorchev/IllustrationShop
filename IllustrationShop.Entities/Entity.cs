using System;

namespace IllustrationShop.Entities
{
    public abstract class Entity
    {
        public int? Id { get; protected set; }

        public bool IsDeleted { get; set; }

        protected Entity(int? id) : this(id, false)
        {
            Id = id;
        }

        protected Entity(int? id, bool isDeleted)
        {
            Id = id;
            IsDeleted = isDeleted;
        }
    }
}
