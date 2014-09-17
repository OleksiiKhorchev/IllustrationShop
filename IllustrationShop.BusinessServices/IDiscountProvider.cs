using IllustrationShop.Entities;

namespace IllustrationShop.BusinessServices
{
    public interface IDiscountProvider
    {
        decimal GetDiscountRateForCurrentUser();
    }

    public class DiscountProvider : IDiscountProvider
    {
        public decimal GetDiscountRateForCurrentUser()
        {
            var customer = UserContext.Current as Customer;

            if (customer == null)
                return 1;

            switch (customer.Type)
            {
                case CustomerType.Gold:
                    return 0.7M;

                // You should also give him
                // your clothes, your boots and your bike
                case CustomerType.T800:
                    return 0.0M;
            }

            return 1;
        }
    }
}