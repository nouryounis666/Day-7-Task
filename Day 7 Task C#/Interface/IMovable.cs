using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task.Interface
{
    internal interface IMovable
    {
        void Move();
    }
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }
    }
}
