using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task.Abstract
{
    internal abstract class Shape
    {
        #region Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        } 
        #endregion

        #region Abstract method
        public abstract double CalculateArea(); 
        #endregion
    }
}
