using System;

namespace Sandesh1.Inheritance
{
    // Moved Address class outside of the Sandesh1.inheritance class
    public class Address
    {
        public string addressLine, city, state;

        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }

    public class Employee
    {
        public int id;
        public string name;
        public Address address;

        public Employee(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name + " " + address.addressLine + " " + address.city + " " + address.state);
        }
    }
    
}
