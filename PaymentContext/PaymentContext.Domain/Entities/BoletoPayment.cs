using System;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

public class BoletoPayment : Payment {
    public BoletoPayment(string barCode,
     string boletoNumber,
      DateTime paiDate,
       DateTime expireDate,
        string payer,
         Document document,
          decimal total,
           decimal totalPaid,
            Adress adress,
             Email email): base(
                  paiDate,
                   expireDate,
                    payer,
                     document,
                      total,
                       totalPaid,
                        adress,
                         email)
    {
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }

    public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }