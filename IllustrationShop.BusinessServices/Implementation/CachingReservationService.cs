using System;
using System.Collections.Generic;
using IllustrationShop.Entities;

namespace IllustrationShop.BusinessServices
{
    class CachingReservationService : IReservationService
    {
        private readonly IReservationService _core;

        private List<Reservation> _reservations;

        private DateTime? _cachedOn;

        private readonly TimeSpan _timout;

        public CachingReservationService(IReservationService core, TimeSpan timeout)
        {
            _core = core;

            _timout = timeout;
        }

        public List<Reservation> GetAllForCurrentUser()
        {
            if (_reservations != null && _cachedOn != null && DateTime.UtcNow < _cachedOn + _timout)
                return _reservations;

            _cachedOn = DateTime.UtcNow;

            _reservations = _core.GetAllForCurrentUser();

            return _reservations;
        }

        public void Reserve(Product product)
        {
            _core.Reserve(product);

            _reservations = null;
        }

        public void ClearReservations()
        {
            _core.ClearReservations();

            _reservations = null;
        }
    }
}