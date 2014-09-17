namespace IllustrationShop.BusinessServices
{
    public abstract class DiscountRateProvider : IDiscountRateProvider
    {
        public abstract decimal GetDiscountRateForCurrentUser();
    }
}