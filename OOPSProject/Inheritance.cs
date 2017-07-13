using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class Inheritance
    {
        public virtual void Print()
        {
            Console.Write("From Base class Inheritance");
        }
    }

    class Child1 : Inheritance
    {
        public override void Print()
        {
            Console.Write("\nFrom child class Child1");
        }
    }

    class Child2 : Inheritance
    {
        public override void Print()
        {
            Console.Write("\nFrom child class Child2");
        }
    }

    /* A class can not have multiple base classes (multiple Inheritance problem occurs.)
    class Child3 : Child1, Child2  
    {
        public override void Print()
        {
            Console.Write("\nFrom Child3 class");
        }
    } */

    public class Employee
    {
        public string firstName, lastName, email;

        public Employee()
        {
            Console.WriteLine("Base Class Constructor Called");
        }

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee()
        {
            Console.WriteLine("Derived Class Constructor Called");
        }
        public float hourlyRate;
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee()
        {
            Console.WriteLine("Derived Class Constructor Called");
        }
        public float yearlySalary;
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        /* FullTimeEmployee class is a specialisation of Employee class.
    //               Derived class has all the capabilities of base class plus it has his own capabilities.
    //               Derived class is always a specialisation of base class.
    //            */

    //        FullTimeEmployee FTE = new FullTimeEmployee();
    //        FTE.firstName = "Pankaj";
    //        FTE.lastName = "Kolhe";
    //        FTE.yearlySalary = 1000000;
    //        FTE.PrintFullName();

    //        PartTimeEmployee PTE = new PartTimeEmployee();
    //        PTE.firstName = "Harish";
    //        PTE.lastName = "Kolhe";
    //        PTE.hourlyRate = 500;
    //        PTE.PrintFullName();

    //        Console.ReadLine();
    //    }
    //}
}

/* Inheritance
  * We have Parent-Child relationship available in OOPS. We can create parent class and 
    extend the functionality of parent to child class. This called as Inheritance.
  
  * By using Inheritance, we can create a fresh child class which has all the qualities of 
    parent plus some extra new qualities of himself too.

  * Multiple Inheritance creates abiguity which is called as Diamond problem.
    We solve this problem using Interfaces.

    Benefits - ( Why Inheritance )
        * Solves problem of Extensibility.
        * Parent-Child relationship. 
    
    Why Inheritance ?

    1. Inheritance is one of the pillar of OOPS language.
    2. It allows code REvuse.
    3. Code reuse can reduce time and erros.
    
    Ex. Class FullTimeEmployee : firstName, lastName, email, yearlySalary, PrintFullName()
        Class PartTimeEmployee : firstName, lastName, email, hourlyRate, PrintFullName()

    A lots of code is duplicated in above 2 classes, except salary type.
    Instead of duplicating code, we can abstract common code into base class 
    and only specific code into derived classes.

    Class Empoyee : firstName, lastName, email, PrintFullName()
    Class FullTimeEmployee -> Employee : yearlySalary
    Class PartTimeEmployee -> Employee : hourlyRate

    * C# supports only Single class Inheritance
    * C# supports multiple Interface Inheritance & does not support multiple Inheritance.
    * Child class is specialisation of base class.
    * Base classes are automatically instantiated before derived classes.
    * Parent class constructor executes before child class constructor.
*/
