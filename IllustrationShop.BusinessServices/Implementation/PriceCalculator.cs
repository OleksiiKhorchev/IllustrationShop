using System.Collections.Generic;
using System.Linq;
using IllustrationShop.Entities;

namespace IllustrationShop.BusinessServices
{
    public class PriceCalculator : IPriceCalculator
    {
        private IDiscountRateProvider _discountRateProvider;

        public PriceCalculator(IDiscountRateProvider discountRateProvider)
        {
            _discountRateProvider = discountRateProvider;
        }

        public decimal CalculatePrice(List<Reservation> reservations)
        {
            return (1 - _discountRateProvider.GetDiscountRateForCurrentUser())
                * reservations.Sum(o => o.Product.Price);
        }
    }
}