using System;
using System.Security.Principal;

namespace IllustrationShop.Entities
{
    public class User : Entity, IPrincipal
    {
        public User(Int32 id, String name) : base(id)
        {
            Name = name;
        }

        public String Name { get; private set; }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }

        public IIdentity Identity { get; private set; }
    }
}
