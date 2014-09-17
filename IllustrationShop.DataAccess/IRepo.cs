using System;

namespace IllustrationShop.DataAccess
{
    public interface IRepo<T> where T : class
    {
        T GetBy(Int32 id);

        // Should return true if save was successful, false if unseccessful
        bool Save(T entity);
    }
}
