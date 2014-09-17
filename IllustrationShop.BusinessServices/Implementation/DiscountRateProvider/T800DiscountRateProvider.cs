namespace IllustrationShop.BusinessServices
{
    public class T800DiscountRateProvider : DiscountRateProvider
    {
        public override decimal GetDiscountRateForCurrentUser()
        {
            // You should also give him
            // your clothes, your boots and your bike
            return 1;
        }
    }
}