using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public class EmpPolymorphism
    {
        public string firstName = "FN", lastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmpPolymorphism : EmpPolymorphism
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " Part Time Employee");
        }
    }

    public class FullTimeEmpPolymorphism : EmpPolymorphism
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " Full Time Employee");
        }
    }

    public class TemproryEmpPolymorphism : EmpPolymorphism
    {
        
    }

    public class HardWorkingEmpPolymorphism : EmpPolymorphism
    {
        // base class Method Hiding in derived class
        public new void PrintFullName()
        {
            //base.PrintFullName();    //Call the base class hidden method.
            Console.WriteLine(firstName + " " + lastName + " Hard Working Employee");
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        EmpPolymorphism[] employees = new EmpPolymorphism[4];
    //        employees[0] = new EmpPolymorphism();
    //        employees[1] = new PartTimeEmpPolymorphism();
    //        employees[2] = new FullTimeEmpPolymorphism();
    //        employees[3] = new TemproryEmpPolymorphism();

    //        foreach (EmpPolymorphism emp in employees)
    //        {
    //            emp.PrintFullName();
    //        }

    //        // base class Method Hiding in derived class
    //        HardWorkingEmpPolymorphism empObj = new HardWorkingEmpPolymorphism();
    //        empObj.PrintFullName(); // derived class method gets called.

    //        ((EmpPolymorphism)empObj).PrintFullName();   //Call the base class hidden method.

    //        EmpPolymorphism empObj2 = new EmpPolymorphism();
    //        empObj2.PrintFullName();    //Call the base class hidden method.

    //        Console.ReadLine();
    //    }
    //}
}

/*

    * Polymorphism - 
     
    * It is ability of object or method to take different forms as per situation.
    * Polymorphism is one of the primary pillar of object oriented Programming Langauage
    
    * Dynamic Polymorphism - Method Overriding 
     
    * Polymorphism allows you to invoke derived class methods through a base class 
      reference during runtime.
    * In the base class method is declared virtual and In the derived class same method 
      is declared as override.
    * The virtual keyword indicates that method can be overriden in derived class.
    * If we do not override method in derived class, then base class method gets invoked.
 
    * Dynamic Polymorphism - Method Hiding
    
    * Use the new keyword to hide the base member, we will get compiler warning if we miss 
      the new keyword.
    
    * Different way to invoke a hidden base class member from derived class - 
        1. Using base keyword.
        2. Cast child type to parent type and then invoke the hidden member.
        3. EmpPolymorphism empObj2 = new EmpPolymorphism();
           empObj2.PrintFullName();   
     

    Method Overriding Vs Method Hiding

    * In Method Overrding - A base class reference variable pointing to a child class 
      object, will invoke the overriden method in child class.
    * In Method Hiding - A base class reference variable pointing to a child class 
      object, will invoke the hidden method in the base class.

*/
