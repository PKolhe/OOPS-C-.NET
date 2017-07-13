using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public interface ICustomer
    {
        void Show();
        //int no; // Error
        //void Print()   // Error
        //{

        //}
    }

    public abstract class AbstractCustomer : ICustomer
    {
        public abstract void Print();

        public void Display()
        {
            Console.WriteLine("From Abstract Class Display Method. (non-abstract)");
        }

        public abstract void Show();
    }

    public abstract class AbstractCustomer2 : AbstractCustomer, ICustomer
    {
        
    }

    public class Program : AbstractCustomer
    {
        public override void Show()
        {
            Console.WriteLine("From Abstract Class Show Method");
        }

        public override void Print()
        {
            Console.WriteLine("From Implementation of overrided Abstract Print Method");
        }

        //public static void Main()
        //{
        //    Program obj = new Program();
        //    obj.Print();
        //    obj.Display();

        //    AbstractCustomer cust = new Program();
        //    cust.Print();
        //    cust.Display();

        //    Console.ReadLine();
        //}
    }
}

/*  Abstract Classes -
 
    *   Abstract keyword is used to create abstract classes.
    *   An abstract class is incomplete and hence can not be instantiated.
    *   An abstract class can only be used as a base Class.
    *   Abstract class can not be sealed class.
    *   An abtstract class may contain abstract members(properties, methods, events, indexers) 
        but not mandatory.
    *   A non-abstract class derived from abstract class must provide implementations for all inherited 
        abstract members.
    
    *   If a class inherits an abstract class, there are 2 options avilable for that class -
        1.  Provide implementations for all the abstract members inherited from the base abstract class.
        2.  If the class does not wish to provide implementations for all inherited members of 
            abstract class then class should be marked as abstract.

    Abstract Classes Vs Interfaces

    1.  Abstract Classes can have implementations for some of its members(Methods), 
        but Interfaces can not have implementations for any of its members.
    2.  Interfaces can not have fields while abstract class can contain fields.
    3.  Default members of interfaces are public while default members of abstract classes are private.
    4.  Access modifiers are not allowed on interface members, while access modifiers are allowed on 
        Abstract class members.
    5.  An interface can inherit from another interface only. and Interface can not inherit an abstract class
        where as abstract class can inherit from another abstract class and another interface.
    6.  A class can inherit from multiple interface at the same time, 
        but a class can not inherit from more than one classes.
    
 
*/