using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class SendFax : IContactPerson
    {
        public void Contact(string name)
        {
            Console.WriteLine($"Sending fax to {name}");
        }
    }
}