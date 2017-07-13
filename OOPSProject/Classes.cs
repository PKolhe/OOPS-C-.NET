using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer() : this("No FirstName Provided", "No LastName Provided")
        {

        }

        public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("\nFull Name = {0}", this._firstName +" "+ this._lastName);
        }

        // Destructor
        ~Customer()
        {
            // Clean up code
        }
    }

    class ClientClass
    {
        /*static void Main(string[] args)
        {
            Customer C1 = new Customer(); // calls Default constructor
            C1.PrintFullName();

            Customer C2 = new Customer("Pankaj", "Kolhe"); // calls parameterized constructor
            C2.PrintFullName();

            Console.Read();
        }*/
    }
}

/* Classes */

/*
   If you want to create complex custom types, then we can make use of classes
   
   A Class consists of data (State) and behaviour. Class data is represented by its fields
   and behaviour is represented by its Methods. 
 
   this keyword refers to the object/instance of the class.

   Purpose of Class Constructor - 
   1. A Purpose of class construcotr is to initiate class fields. 
      Constructor is automatically called when object of class is created.
   2. Constructors do not have returns values and has same name method as class.
   3. Constructors are not mandatory, if we don't provide constructor, default 
      parameterless construtor is automatically provided.
   4. Constructors can be overloaded by no of types of parameters.
   
   Destructors -

   1. Destructors have the same name as the class name with ~ symbol in front of them.
   2. They do not take any parameters and do not have return values.
   3. Destructors are place where we can put code to release any resources our 
      class is holding during its lifetime.
   4. They are normally called when C# garbage collector decides to clean 
      your object from memory. 
   5. We do not need to write it and call it. Garbage Collector does evrything for us.


 */