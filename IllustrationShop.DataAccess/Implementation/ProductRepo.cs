using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IllustrationShop.Entities;

namespace IllustrationShop.DataAccess
{
    public class ProductRepo : IRepo<Product>
    {
        public Product GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
