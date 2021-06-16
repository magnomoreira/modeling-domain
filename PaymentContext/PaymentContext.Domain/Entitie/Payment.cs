using System;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entity;

namespace PaymentContext.Domain.Entitie
{
  public abstract class Payment : Entity
  {
    protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
    {
      Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
      PaidDate = paidDate;
      ExpireDate = expireDate;
      Total = total;
      TotalPaid = totalPaid;
      Payer = payer;
      Document = document;
      Address = address;
      Email = email;

     
    }

    // numero do pagamento - identificação interna
    public string Number { get; private set; }
    public DateTime PaidDate { get; private set; }
    public DateTime ExpireDate { get; private set; }
    public decimal Total { get; private set; }
    public decimal TotalPaid { get; private set; }
    public string Payer { get; private set; }
    public Document Document { get; private set; }

    //Enedreço de cobrança - para criação de nota
    public Address Address { get; private set; }
    public Email Email { get; private set; }

  }
}