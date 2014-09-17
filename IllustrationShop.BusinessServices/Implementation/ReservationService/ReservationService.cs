using System;
using System.Collections.Generic;
using System.Linq;
using IllustrationShop.DataAccess;
using IllustrationShop.Entities;

namespace IllustrationShop.BusinessServices
{
    // !TODO! Control freak

    public class ReservationService : IReservationService
    {
        public IReservationRepo Repo { get; private set; }

        public ReservationService()
        {
            Repo = new ReservationRepo();
        }

        public List<Reservation> GetAllForCurrentUser()
        {
            return Repo.GetAllForCurrentUser().Where(o => !o.IsDeleted).ToList();
        }

        public void ReserveForCurrentUser(Product product)
        {
            Repo.Save(new Reservation(product, DateTime.UtcNow));
        }

        public void ClearAllForCurrentUser()
        {
            foreach (var reservation in GetAllForCurrentUser())
            {
                reservation.IsDeleted = true;

                Repo.Save(reservation);
            }
        }
    }
}
