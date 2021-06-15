using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription {
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate  { get; private set; }
        public DateTime? Expiredate { get; private set; }
        public bool Active { get; private set; }
        public List<Payment> payments { get; private set; }
    }
}