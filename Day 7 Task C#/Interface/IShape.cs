using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task.Interface
{
    internal interface IShape
    {
        #region Properties
        double Area { get; }
        #endregion

        #region Methods
        void Draw();
        void PrintDetails()
        {
            Console.WriteLine($"Area: {Area}");
            Draw();
        } 
        #endregion
    }
}
