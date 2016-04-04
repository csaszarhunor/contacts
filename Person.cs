using System;

namespace Contacts
{
    public struct Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        private Type type;

        public Person (string name, string address, int age, string phone, Type type)
        {
            this.Name = name;
            this.Address = adress;
            this.Age = age;
            this.PhoneNumber = phone;
            this.type = type;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " Address: " + this.Address + " Phone: " + this.PhoneNumber;
        }
    }

    public enum Type { Home, Workplace, Mobile }

}
