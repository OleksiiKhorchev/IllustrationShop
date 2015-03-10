using System;
using System.Collections.Generic;
using IllustrationShop.Entities;

namespace IllustrationShop.BusinessServices
{
    public class CachingReservationService : IReservationService
    {
        private readonly IReservationService _core;

        private List<Reservation> _reservations;

        private DateTime? _cachedOn;

        private readonly TimeSpan _timeout;

        public CachingReservationService(IReservationService core, TimeSpan timeout)
        {
            _core = core;

            _timeout = timeout;
        }

        public List<Reservation> GetAllForCurrentUser()
        {
            if (_reservations != null && _cachedOn != null && DateTime.UtcNow < _cachedOn + _timeout)
                return _reservations;

            _cachedOn = DateTime.UtcNow;

            _reservations = _core.GetAllForCurrentUser();

            return _reservations;
        }

        public void ReserveForCurrentUser(Product product)
        {
            _core.ReserveForCurrentUser(product);

            _reservations = null;
        }

        public void ClearAllForCurrentUser()
        {
            _core.ClearAllForCurrentUser();

            _reservations = null;

            MyDelegate test = DelegateImpl;

            test(5);
        }

        public delegate string MyDelegate(int i);

        private string DelegateImpl(int i)
        {
            return i.ToString();
        }

        public event MyDelegate MyDelegateEvent;

        protected virtual string OnMyDelegateEvent(int i)
        {
            var handler = MyDelegateEvent;
            if (handler != null)
                return handler(i);

            throw new Exception();
        }
    }
}