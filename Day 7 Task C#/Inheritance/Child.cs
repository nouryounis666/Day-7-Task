using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task
{
    internal class Child : Parent
    {
        #region Properties
        public int Z { get; set; }
        #endregion

        #region Constructors
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        #endregion

        #region Methods
        public new int Product()
        {
            return base.Product() * Z;
        }
        public override int Sum()
        {
            return base.Sum() + Z;
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})" ;
        } 
        #endregion
    }
}
