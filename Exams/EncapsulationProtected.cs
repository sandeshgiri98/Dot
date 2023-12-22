using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    internal class EncapsulationProtected
    {
        private double length;
        private double width;


        public void AcceptDetails()
        {
            Console.WriteLine("Enter the length :\t");
            length= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width : \t");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length *  width;
        }
        public void Display()
        {
            Console.WriteLine("Length : {0}", length);
            Console.WriteLine("Breadth: {0} ", width);
            Console.WriteLine("Area : {0}", GetArea()); 
        }
    }
}
