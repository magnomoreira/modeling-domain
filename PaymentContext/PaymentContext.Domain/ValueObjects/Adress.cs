namespace PaymentContext.Domain.ValueObjects
{
    public class Adress {
        public string  Street { get; private set; }
         public string  Number { get; private set; }
        public string  City { get; private set; }
        public string  State { get; private set; }
        public string  Contry { get; private set; }
        public string  ZipCode { get; private set; }
        public string  Neighborhood { get; private set; }


    }
}