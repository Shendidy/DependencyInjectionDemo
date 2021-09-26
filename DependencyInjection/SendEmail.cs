using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class SendEmail : IContactPerson
    {
        public void Contact(string name)
        {
            Console.WriteLine($"Sending email to {name}");
        }
    }
}
