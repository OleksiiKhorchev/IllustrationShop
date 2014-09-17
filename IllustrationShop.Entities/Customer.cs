namespace IllustrationShop.Entities
{
    public class Customer : User
    {
        public CustomerType Type { get; private set; }

        public Customer(int id, string name, CustomerType type) : base(id, name)
        {
            Type = type;
        }
    }
}