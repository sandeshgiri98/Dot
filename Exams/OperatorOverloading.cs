using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    class OperatorOverloading
    {
        private float length;
        private float breadth;
        private float height;

        public void getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(float len)
        {
            length = len;
        }
        public void setBreadth(float bth)
        {
            breadth = bth;
        }
        public void setHeight(float hei)
        {
            height = hei;
        }
        public static OperatorOverloading operator+ (OperatorOverloadingB + OperatorOverloadingC)
            {
            OperatorOverloading box= new OperatorOverloading();
            box.length = B.length + C.length;
            box.breadth = B.breadth + C.breadth;
            box.height = B.height + C.height;

           
        }
        public class program
        {
            public class 
        }
        
    }
}
