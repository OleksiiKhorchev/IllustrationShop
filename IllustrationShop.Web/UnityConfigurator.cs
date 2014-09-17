using IllustrationShop.BusinessServices;
using IllustrationShop.DataAccess;
using IllustrationShop.Entities;
using Microsoft.Practices.Unity;

namespace IllustrationShop.Web
{
    public class UnityConfigurator
    {
        public static IUnityContainer GetContainer()
        {
            IUnityContainer container = new UnityContainer();

            // !TODO!
            container
                .RegisterType<IPriceCalculator, PriceCalculator>()

                .RegisterType<IReservationService>(
                    new InjectionFactory(c =>
                    {
                        if (UserContext.Current.IsInRole("TransientDatabaseStrategy"))
                            return c.Resolve<ReservationService>();

                        return c.Resolve<CachingReservationService>();
                    }))

                .RegisterType<IDiscountRateProvider>(
                    new InjectionFactory(c =>
                    {
                        var customer = UserContext.Current as Customer;

                        if (customer != null)
                        {
                            switch (customer.Type)
                            {
                                case CustomerType.Gold:
                                    return c.Resolve<GoldDiscountRateProvider>();

                                case CustomerType.T800:
                                    return c.Resolve<T800DiscountRateProvider>();
                            }
                        }

                        return c.Resolve<NothingDiscountRateProvider>();
                    }))

                .RegisterType<IRepo<Product>, ProductRepo>();

            return container;
        }
    }
}