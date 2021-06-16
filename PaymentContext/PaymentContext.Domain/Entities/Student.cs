using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities {

    public class Student : Entity {

        private IList<Subscription> _subscriptions;
        public Student(Name name, Email email, Document document)
        {
            Name = name;
            Email = email;
            Document = document;
            _subscriptions = new List<Subscription>();

    
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Document Document { get; private set; }
         public string Adress {get ; private set;}
        public IReadOnlyCollection<Subscription> Subscriptions { get {return _subscriptions.ToArray();}  }

        public void AddSubscription(Subscription subscription){

           foreach( var sub in Subscriptions){
               
               sub.Inactivate();
               
           }

           _subscriptions.Add(subscription);

        }
    }
}