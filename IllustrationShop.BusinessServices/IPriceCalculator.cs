using System.Collections.Generic;
using IllustrationShop.Entities;

namespace IllustrationShop.BusinessServices
{
    public interface IPriceCalculator
    {
        decimal CalculatePrice(List<Reservation> reservations);
    }
}
