using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task
{
    public class Car
    {
        #region Attributes
        private int id;
        private string brand;
        private decimal price;
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region Constructors
        //1. Default constructor.
        public Car()
        {
        }
        //2. Constructor with one parameter (Id). 
        public Car(int id)
        {
            ID = id;
        }
        //3. Constructor with two parameters (Id, Brand). 
        public Car(int id, string brand)
        {
            ID = id;
            Brand = brand;
        }
        //4. Constructor with all three parameters.
        public Car(int id, string brand, decimal price)
        {
            ID = id;
            Brand = brand;
            Price = price;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Car ID is {id}, Car Brand is {brand}, Car Price is {price}";
        } 
        #endregion
    }
}
