using System;
// if we create two or more members having same name but different in number of parameter then it is called member overloading

namespace Exams
{
    class Program
    {
        //Method OVerloading
        public static int add (int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
       
    }
}
