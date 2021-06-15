using System;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

public class PayPalPayment : Payment {
    public PayPalPayment(string transactionCode,
    DateTime paiDate,
     DateTime expireDate,
      string payer,
       Document document,
        decimal total,
         decimal totalPaid,
          Adress adress,
           Email email):base( 
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