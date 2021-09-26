using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IContactPerson _sendEmail = new SendEmail();
            IContactPerson _sendFax = new SendFax();

            IPerson person1 = new Person(_sendEmail, "Sherif");
            IPerson person2 = new Person(_sendFax, "Maha");

            person1.ContactPerson();
            person2.ContactPerson();
        }
    }
}
