using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            SendEmail _sendEmail = new SendEmail();
            SendFax _sendFax = new SendFax();

            Person person1 = new Person(_sendEmail, "Sherif");
            Person person2 = new Person(_sendFax, "Maha");

            person1.ContactPerson();
            person2.ContactPerson();
        }
    }
}
