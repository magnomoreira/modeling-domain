using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entity;

namespace PaymentContext.Domain.Entitie
{
  public class Student : Entity
  {
    private IList<Subscription> _subscriptions;

    public Student(Name name, Document document, Email email)
    {
      Name = name;
      Document = document;
      Email = email;
      _subscriptions = new List<Subscription>();

      //agrupando todos erros que vieram VOs no Student
      AddNotifications(name, document, email);
    }

    public Name Name { get; private set; } // value object
    public Document Document { get; private set; } // value object
    public Email Email { get; private set; }

    //Enedreço de entrega
    public Address Address { get; private set; }

    // um aluno pode ter mais de uma assinatura - só uma ativa
    // public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

    public void AddSubscription(Subscription subscription)
    {
      

      foreach (var sub in Subscriptions)
      {
          if(sub.Active)
          {
            sub.Deactivate();
            //break;
          }
      }

      //validação por contrato

      // alternativa sem contrato - dessa forma teremos que ter um teste
      // if(hasSubscriptionActive)
      // {
      //   AddNotification("Student.Subscription", "Você já tem uma assinatura ativa");
      // }

      _subscriptions.Add(subscription);
    }

  }
}