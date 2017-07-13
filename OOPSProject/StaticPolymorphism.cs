using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class StaticPolymorphism
    {
        public static void Add(int FN, int SN)
        {
            Console.WriteLine("SUM = {0}", FN + SN);
        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("SUM = {0}", FN + SN + TN);
        }

        public static void Add(int FN, int SN, out int SUM)
        {
            Console.WriteLine("SUM = {0}", FN + SN);
            SUM = FN + SN;
        }

        public static void Add(float FN, float SN)
        {
            Console.WriteLine("SUM = {0}", FN + SN);
        }

        public static void Add(int FN, float SN)
        {
            Console.WriteLine("SUM = {0}", FN + SN);
        }

    }
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StaticPolymorphism.Add(10, 20);
    //        StaticPolymorphism.Add(10, 20, 30);
    //        StaticPolymorphism.Add(10, 20);
    //        StaticPolymorphism.Add(10.46F, 20.30F);
    //        StaticPolymorphism.Add(10, 20.40F);
    //        Console.ReadLine();
    //    }
    //}
}

/*
* Polymorphism - 


    * It is ability of object or method to take different forms as per situation.
    * Polymorphism is one of the primary pillar of object oriented Programming Langauage
    
    * Static Polymorphism - Method Overloading 
    
    * Function overloading & Method Overloading are the terms which are used interchangeably.
    
    * Method overloading allows a class to have multiple methods with the same name but 
      with a different signature. So in C#, functions can be overloaded based on the number 
      of parameters, type(int, float etc..) of parameters, and 
      kind ( value, ref or out) of parameters etc..

    * Signature of method consists of name of the method, and the type, 
      kind(value, ref and out) and the no of its formal parameters. The signature of 
      method does not include the return type and "params" modifier. 
      So, it is not possible to overload a function, just based on the return type or "params" modifier.
    
        /* Compiler Error because of return type 

    //public static int Add(int FN, int SN)   
    //{
    //    return FN + SN;
    //}
    //public static void Add(int FN, int SN)   
    //{
    //    return FN + SN;
    //}

    /* Compiler Error because of params keyword 
    //public static void Add(int FN, int SN, params int[] nos)   // Compiler Error
    //{
    //    
    //}

    //public static void Add(int FN, int SN, int[] nos)   // Compiler Error
    //{
    //    
    //}

*/