using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.Entitie;

namespace PaymentContext.Domain.Entities {

    public class Student {

        private IList<Subscription> _subscriptions;
        public Student(string firstName, string lastName, string email, string document)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Document = document;
            _subscriptions = new List<Subscription>();
        }

        public string  FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Document { get; private set; }
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