using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task
{
    internal class Calculator
    {
        public int Sum(int X, int Y)
        {
            return X + Y;
        }
        public int Sum(int X, int Y, int Z) 
        {
            return X + Y + Z;    
        }
        public double Sum(double X, double Y)
        {
            return X + Y;
        }
    }
}
