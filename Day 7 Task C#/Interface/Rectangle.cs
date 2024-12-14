using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task.Interface
{
    internal class Rectangle: IShape
    {
        #region Properties
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area
        {
            get { return Width * Height; }
        } 
        #endregion

        #region Methods
        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with width={Width} and height={Height}");
        } 
        #endregion
    }
}
