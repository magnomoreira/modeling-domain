using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using PaymentContext.Shared.Entity;

namespace PaymentContext.Domain.Entitie
{
    public class Subscription : Entity
    {

        private IList<Payment> _payments;

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        
        // lista de pagamento - tipo genérico/abstrato
        // public IReadOnlyCollection<Payment> Payments { get {return _payments.ToArray(); } }
        public IReadOnlyCollection<Payment> Payments { get => _payments.ToArray(); }

        public void AddPayment(Payment payment)
        {
            // pagamento não pode acontecer np passado - validando

            // if(Valid) só add se for valido
            _payments.Add(payment);
        }

        public void Activate()
        {
            Active = true;
            LastUpdateDate = DateTime.Now;
        }

        public void Deactivate()
        {
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }
}