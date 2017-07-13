using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        //public Singleton()
        //{
        //    counter++;
        //    Console.WriteLine("\nCounter Value: "+counter);
        //}

        private Singleton()
        {
            counter++;
            Console.WriteLine("\nCounter Value: " + counter);
        }

        public static Singleton GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Singleton fromEmployee = new Singleton();
    //        //fromEmployee.PrintDetails("\nFrom Employee");

    //        //Singleton fromStudent = new Singleton();
    //        //fromStudent.PrintDetails("\nFrom Student");

    //        Singleton fromEmployee = Singleton.GetInstance;
    //        fromEmployee.PrintDetails("\nFrom Employee");

    //        Singleton fromStudent = Singleton.GetInstance;
    //        fromStudent.PrintDetails("\nFrom Student");

    //        Console.ReadLine();
    //    }
    //}
}

/* Singleton Pattern - 
 
        *   Singleton pattern belongs to creational design pattern.
        *   This pattern is used when we need to ensure that only one object of particular class needs to be created.
            All further references to the objects are refered to the same underlying instance created.
        
                                    ClientObjA  ClientObjB  ClientObjC
                                             \      |       /
                                              \     |      /
                                              Singleton Object
                                                    |
                                                    |
                                                   Task
       * Advantages of Singleton -
       
            1. Singleton controls concurrent access to the resources.
            2. It ensures there is only one object available across tthe application in a controlled state.
       
       * Implemenation Guidelines -
       
            1. Ensure that only one instance of class is exists.
            2. Provide global access to the instance by -
                a) Declaring all constructors of the class to be private.
                b) Providing static method that returns a reference to the instance.
                c) The instance is stored as a private static variable.
            
                                                
 
*/
