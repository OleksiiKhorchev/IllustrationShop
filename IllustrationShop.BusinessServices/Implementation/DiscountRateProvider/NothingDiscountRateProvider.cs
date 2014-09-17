namespace IllustrationShop.BusinessServices
{
    public class NothingDiscountRateProvider : DiscountRateProvider
    {
        public override decimal GetDiscountRateForCurrentUser()
        {
            return 0;
        }
    }
}