using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task.Abstract
{
    internal class Rectangle : Shape
    {
        #region Properties
        public double Width { get; set; }
        public double Height { get; set; }
        #endregion

        #region Constructors
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        #endregion

        #region Override methods
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double CalculateArea()
        {
            return Width * Height;
        } 
        #endregion

    }
}
