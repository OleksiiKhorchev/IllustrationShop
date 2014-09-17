using System.Collections.Generic;
using IllustrationShop.Entities;

namespace IllustrationShop.DataAccess
{
    public interface IReservationRepo : IRepo<Reservation>
    {
        List<Reservation> GetAllForCurrentUser();
    }
}