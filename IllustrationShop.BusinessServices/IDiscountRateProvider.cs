namespace IllustrationShop.BusinessServices
{
    public interface IDiscountRateProvider
    {
        decimal GetDiscountRateForCurrentUser();
    }
}