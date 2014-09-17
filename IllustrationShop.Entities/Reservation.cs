using System;

namespace IllustrationShop.Entities
{
    public class Reservation : Entity
    {
        public Reservation(Product product, DateTime createdOn) : this(null, product, createdOn, UserContext.Current)
        {
        }

        public Reservation(int? id, Product product, DateTime createdOn, User owner) : base(id)
        {
            Owner = owner;
            Product = product;
            CreatedOn = createdOn;
        }

        public Product Product { get; private set; }

        public User Owner { get; private set; }

        public DateTime CreatedOn { get; private set; }
    }
}
