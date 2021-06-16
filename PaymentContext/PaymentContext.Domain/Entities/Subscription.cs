using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
        public class Subscription {

            private IList<Payment> _payments;
        public Subscription( DateTime? expiredate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            Expiredate = expiredate;
            Active = true;
            _payments = new List<Payment>();


        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate  { get; private set; }
        public DateTime? Expiredate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> payments { get; private set; }

        public void AddPayment(Payment payments){

            _payments.Add(payments);
        }

        public void Activate(){

            Active = true;
            LastUpdateDate = DateTime.Now;

        }

        public void Inactivate(){
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }
}