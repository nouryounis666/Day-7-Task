using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_7_Task.Abstract;
using Day_7_Task.Interface;

namespace Day_7_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            //Car C1 = new Car();
            //Car C2 = new Car(4);
            //Car C3 = new Car(5, "BMW");
            //Car C4 = new Car(6, "Mercedes", 123456m);

            //Console.WriteLine(C1);
            //Console.WriteLine(C2);
            //Console.WriteLine(C3);
            //Console.WriteLine(C4);

            ///* Question: Why does defining a custom constructor suppress the default constructor in C#? 
            //   In C#, if a custom constructor is defined, the compiler does not provide a default constructor.
            //   This is because the compiler assumes that the programmer intends to define all constructor behaviors manually.
            // */
            #endregion

            #region Problem 2
            //Calculator calc = new Calculator();
            //int calc1 = calc.Sum(1, 2);
            //int calc2 = calc.Sum(1, 2, 7);
            //double calc3 = calc.Sum(10.5, 20.6);

            //Console.WriteLine(calc1);
            //Console.WriteLine(calc2);
            //Console.WriteLine(calc3);

            ///* Question: How does method overloading improve code readability and reusability? 
            //   Method overloading allows you to define multiple methods with the same name but different parameters.
            //   This improves readability by using a consistent method name for similar operations, making the code easier to understand.
            //   It also enhances reusability by allowing the same method name to handle different types or numbers of parameters.
            // */
            #endregion

            #region Problem 3 
            //Child child = new Child(1, 2, 3);

            //Console.WriteLine($"X={child.X}, Y={child.Y}, Z={child.Z}");

            ///* Question: What is the purpose of constructor chaining in inheritance?  
            //   Constructor chaining ensures that the base class is properly initialized when a derived class instance is created. 
            //   This helps in maintaining a consistent state for the base class properties and allows for better organization of initialization logic.
            // */
            #endregion

            #region Problem 4
            //Child child1 = new Child(4, 5, 6);

            //Console.WriteLine(child1.Product());
            //Console.WriteLine(child1.Sum());

            ///* Question: How does new differ from override in method overriding?
            //   Using the new keyword hides the base class method, while override allows the derived class to provide
            //   a specific implementation for the base class method. override ensures polymorphic behavior, meaning
            //   the appropriate method is called based on the runtime type of the object.
            // */
            #endregion

            #region Problem 5
            //Parent par = new Parent(2, 3);
            //Child ch = new Child(7, 8, 9);

            //Console.WriteLine(par);
            //Console.WriteLine(ch);

            ///* Question: Why is ToString() often overridden in custom classes?
            //   ToString() is overridden to provide a meaningful string representation of an object, which is useful for debugging and logging.
            //   It allows you to easily display the state of an object in a human-readable format.
            // */
            #endregion

            #region Problem 6
            //Rectangle rect = new Rectangle();
            //rect.Width = 5;
            //rect.Height = 10;
            //rect.Draw();
            //Console.WriteLine("Area: " + rect.Area);

            ///* Question: Why can't you create an instance of an interface directly? 
            //    An interface cannot be instantiated directly because it only defines a contract (methods and properties) 
            //    without providing any implementation. It requires a class to implement its members.
            // */
            #endregion

            #region Problem 7 
            //IShape circle = new Interface.Circle(5);
            //circle.PrintDetails();

            ///* Question: What are the benefits of default implementations in interfaces introduced in C# 8.0? 
            //   Default implementations allow adding methods with bodies in interfaces without breaking existing implementations. 
            //   This provides greater flexibility for evolving APIs while maintaining backward compatibility. It also helps in cases where 
            //   you want to add common behavior across classes that implement the interface, but don't want to enforce the implementation in every class.
            // */
            #endregion

            #region Problem 8
            //IMovable movable = new Interface.Car();
            //movable.Move();

            ///*  Question: Why is it useful to use an interface reference to access implementing class methods? 
            //    Using an interface reference promotes flexibility and decoupling. It allows different implementations 
            //    to be used interchangeably and supports polymorphism, making the code more modular and easier to maintain.
            // */
            #endregion

            #region Problem 9
            //File file = new File();
            //file.Read();
            //file.Write();

            ///* Question: How does C# overcome the limitation of single inheritance with interfaces? 
            //   C# allows multiple interface inheritance, meaning a class can implement multiple interfaces. 
            //   This overcomes the limitation of single inheritance, where a class can only inherit from one base class. 
            //   By using interfaces, you can combine behaviors from multiple sources without being restricted to a single inheritance chain.
            // */
            #endregion

            #region Problem 10
            //var rectangle = new Abstract.Rectangle(5, 10);
            //rectangle.Draw();
            //Console.WriteLine($"Area: {rectangle.CalculateArea()}");

            ///* Question: What is the difference between a virtual method and an abstract method in C#?
            //   A virtual method provides a default implementation that can be overridden by derived classes, 
            //   while an abstract method does not provide any implementation and must be overridden in derived classes
            // */
            #endregion
        }
    }
}
