namespace IllustrationShop.BusinessServices
{
    public class GoldDiscountRateProvider : DiscountRateProvider
    {
        public override decimal GetDiscountRateForCurrentUser()
        {
            return 0.3M;
        }
    }
}