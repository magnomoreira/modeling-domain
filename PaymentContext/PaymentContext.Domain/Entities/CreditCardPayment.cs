using System;
using PaymentContext.Domain.Entities;

public class CreditCardpayment : Payment{
    public CreditCardpayment(string cardHolderName,
     string cardNumber,
      string lastTransactionnumber,
       DateTime paiDate,
        DateTime expireDate,
         string payer,
          string document,
           decimal total,
            decimal totalPaid,
             string adress,
              string email): base(
                 paiDate,
                  expireDate,
                   payer,
                    document,
                      total,
                       totalPaid,
                        adress,
                         email)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionnumber = lastTransactionnumber;
    }

    public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionnumber { get; private set; }
    }