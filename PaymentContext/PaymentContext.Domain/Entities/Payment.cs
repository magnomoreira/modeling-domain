using System;

namespace PaymentContext.Domain.Entities
{
    public  abstract class Payment {

        public string Number { get; private set; }
        public DateTime PaiDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public string  Payer { get; private set; }
        public string Document { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Adress {get ; private set;}
        public string Email { get; private set; }

    }

    public class BoletoPayment : Payment{

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }

    public class CreditCardpayment : Payment{
        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionnumber { get; private set; }
    }

    public class PayPalPayment : Payment {
        public string TransactionCode { get; private set; }
    }
}