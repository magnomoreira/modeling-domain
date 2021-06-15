using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public  abstract class Payment {
        protected Payment(DateTime paiDate, DateTime expireDate, string payer, Document document, decimal total, decimal totalPaid, Adress adress, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaiDate = paiDate;
            ExpireDate = expireDate;
            Payer = payer;
            Document = document;
            Total = total;
            TotalPaid = totalPaid;
            Adress = adress;
            Email = email;
        }

        public string Number { get; private set; }
        public DateTime PaiDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public string  Payer { get; private set; }
        public Document Document { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public Adress Adress {get ; private set;}
        public Email Email { get; private set; }

    }
}