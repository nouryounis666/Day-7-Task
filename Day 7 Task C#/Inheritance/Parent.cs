using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task
{
    internal class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructors
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Methods
        public virtual int Product()
        {
            return X * Y;
        }
        public virtual int Sum()
        {
            return X + Y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        #endregion
    }
}
