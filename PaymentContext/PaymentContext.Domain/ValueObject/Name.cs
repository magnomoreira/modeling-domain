using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            // poederiamos criar as noticações
            // if (string.IsNullOrEmpty(FirstName))
            // {
            //     AddNotification("Name.FisrtName", "Nome inválido");
            // }
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}