using System;

namespace IllustrationShop.Entities
{
    public class Product : Entity
    {
        public Product(string name, string description, decimal price) : this(null, name, description, price)
        {
        }

        public Product(int? id, string name, string description, decimal price) : base(id)
        {
            Name = name;

            Description = description;

            Price = price;
        }

        public String Name { get; private set; }   

        public String Description { get; private set; }   

        public Decimal Price { get; private set; }
    }
}
