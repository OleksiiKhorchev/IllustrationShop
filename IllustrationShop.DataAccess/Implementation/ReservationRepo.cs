using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IllustrationShop.Entities;

namespace IllustrationShop.DataAccess
{
    public class ReservationRepo : IReservationRepo
    {
        public Reservation GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAllForCurrentUser()
        {
            throw new NotImplementedException();
        }

        public bool Save(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
