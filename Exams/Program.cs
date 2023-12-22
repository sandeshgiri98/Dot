using Sandesh1.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    class program
    {
        public static void Main(String[] args)
        {

            //this is example of a first practice
            Console.WriteLine("This is a test");
            Console.WriteLine("This is a test2");
           

            Console.WriteLine("-----------------C# Aggregiation-----------------");
            //class 1 prpperties displaying
            Address a1 = new Address("G-12, Sec-3", "Noida", "A");
            Employee e1 = new Employee(1, "Sonoo", a1);
            e1.display();

            Address a2 = new Address("R12, Sec B5", "Nepal", "NP");
            Employee e2 = new Employee(2, "Ram Krishna", a2);
            e2.display();

            Console.WriteLine("-----------------Method Overloading-----------------");
            Console.WriteLine(Program.add(25, 25));
            Console.WriteLine(Program.add(25, 25, 25));

            Console.WriteLine("-----------------Method Overloading-----------------");
            Console.WriteLine(Mtehodoverload.add(25, 100));
            Console.WriteLine(Mtehodoverload.add(25.56f, 25.55f));


            Console.WriteLine("-----------------Operator Overloading-----------------");
           
        }

    }
}
