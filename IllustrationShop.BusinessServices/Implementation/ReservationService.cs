using System;
using System.Collections.Generic;
using System.Linq;
using IllustrationShop.DataAccess;
using IllustrationShop.Entities;

namespace IllustrationShop.BusinessServices
{
    public class ReservationService : IReservationService
    {
        public IReservationRepo Repo { get; private set; }

        public ReservationService(IReservationRepo repo)
        {
            Repo = repo;
        }

        public List<Reservation> GetAllForCurrentUser()
        {
            return Repo.GetAllForCurrentUser().Where(o => !o.IsDeleted).ToList();
        }

        public void Reserve(Product product)
        {
            Repo.Save(new Reservation(product, DateTime.UtcNow));
        }

        public void ClearReservations()
        {
            foreach (var reservation in GetAllForCurrentUser())
            {
                reservation.IsDeleted = true;

                Repo.Save(reservation);
            }
        }
    }
}
