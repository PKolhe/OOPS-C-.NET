using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    interface ICustomer1
    {
        //int id;                   //Compile time error
        //void Print()              //Compile time error
        //{
        //    Console.WriteLine("hello");
        //}
        void Print1();
        void Display();
    }

    interface ICustomer2: ICustomer1
    {
        void Print2();
        void Display();
    }

    class CustomerEmp: ICustomer2
    {
        //public void Print( int name )     // interfcae member signature does not match
        //{

        //}

        public void Print1()
        {
            Console.WriteLine("ICustomer1 Interface Print1 Method Implementation\n");
        }

        public void Print2()        // Compile time error we do not provide this implementation
        {
            Console.WriteLine("ICustomer2 Interface Print2 Method Implementation\n");
        }

        void ICustomer1.Display()   // access modifiers are not allowed
        {
            Console.WriteLine("ICustomer1 Interface Display Method Implementation\n");
        }

        void ICustomer2.Display()
        {
            Console.WriteLine("ICustomer2 Interface Display Method Implementation\n");
        }
        
    }

    //public class Program 
    //{
    //    public static void Main()
    //    {
    //        CustomerEmp cust = new CustomerEmp();
    //        cust.Print1();
    //        cust.Print2();

    //        ((ICustomer1)cust).Display();
    //        ((ICustomer2)cust).Display();

    //        //ICustomer1 icust = new ICustomer1();        // compile time error

    //        ICustomer1 icust = new CustomerEmp();
    //        icust.Print1();
    //        icust.Display();

    //        ICustomer2 icust2 = new CustomerEmp();
    //        icust2.Print1();
    //        icust2.Print2();
    //        icust2.Display();
            
    //        Console.ReadLine();
    //    }
    //}
}

/* Interfaces - 

    We create interfaces using interface keyword. Just like classes interface also contains -
        1. Properties
        2. Methods
        3. Delegates or Events
    But only declarations with no implementation. It is compile time error to provide implementation for any interface member.

    *   Interface members are public by default and they don't allow exlicit access modifiers.
    *   Interfaces can not contain fields.
    *   Signature of method in class should match the signature of methods in interfaces.
    *   If a class or struct inherits from an interface, it must provide implementation 
        for all interface members. Otherwise we get compile time error.
    *   A class or struct can inherit from more than one interface at the same time, 
        but where as, a class can not inherit from more than one class at the same time.
    *   Interfaces can inherit from other interfaces. A class that inherits the interface 
        must provide implementation for all interfcae members in the entire interface inheritance chain.
    *   We can not create an instance of an interface, but an interfcae reference variable can point 
        to a derived class object.
    *   Interface Naming Convention - Interfcae names are prefixed with capital I.
    
    Explicit Interface Implementation -      

    We can use explicit interface implementation technique when our class inherits 2 interfaces which 
    has same name methods.

    *   When a class explicitely implements an interface member, the interface member can no longer be accssed 
        through class reference variable but only through the interface reference variable.
    *   Access modifiers are not allowed on explicitely implemented interface members.
    
    If we want to make one of the method default accessible, then we can implement one method as 
    default and one method as explicit.
     
*/
