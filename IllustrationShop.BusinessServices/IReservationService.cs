using System.Collections.Generic;
using IllustrationShop.Entities;

namespace IllustrationShop.BusinessServices
{
    public interface IReservationService
    {
        List<Reservation> GetAllForCurrentUser();

        void ReserveForCurrentUser(Product product);

        void ClearAllForCurrentUser();
    }
}