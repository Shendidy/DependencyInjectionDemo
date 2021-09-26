using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Person : IPerson
    {
        public string name { get; set; }

        private IContactPerson _contactPerson;

        public Person(IContactPerson contactPerson, string name)
        {
            _contactPerson = contactPerson;
            this.name = name;
        }

        public void ContactPerson()
        {
            _contactPerson.Contact(name);
        }
    }
}
