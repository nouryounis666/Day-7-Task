using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task.Interface
{
    internal class Circle : IShape
    {
        #region Properties
        public double Radius { get; set; } 
        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }
        #endregion

        #region Constructors
        public Circle(double radius)
        {
            Radius = radius;
        }
        #endregion

        #region Methods
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        } 
        #endregion
    }
}