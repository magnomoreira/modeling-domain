using System;
using PaymentContext.Domain.Entities;

public class PayPalPayment : Payment {
    public PayPalPayment(string transactionCode,
    DateTime paiDate,
     DateTime expireDate,
      string payer,
       string document,
        decimal total,
         decimal totalPaid,
          string adress,
           string email):base( 
               paiDate,
                expireDate,
                 payer,
                  document,
                   total,
                    totalPaid,
                     adress,
                      email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; private set; }
    }