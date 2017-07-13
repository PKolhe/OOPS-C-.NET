using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public delegate void HelloFunctionDelegate(string message);

    public class DelegatesProgram
    {
        //static void Main(string[] args)
        //{
        //    // A delegate is a type safe function pointer.
        //    HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        //    del("Hello From Delegate");

        //    Hello("Hello From Pankaj\n");

        //    List<EmployeePeople> empList = new List<EmployeePeople>();
        //    empList.Add(new EmployeePeople { ID = 101, Name = "Pankaj", Experience = 6, Salary = 10000 });
        //    empList.Add(new EmployeePeople { ID = 102, Name = "Rahul", Experience = 4, Salary = 10000 });
        //    empList.Add(new EmployeePeople { ID = 103, Name = "Priyanka", Experience = 3, Salary = 10000 });
        //    empList.Add(new EmployeePeople { ID = 104, Name = "Meenakshi", Experience = 8, Salary = 10000 });
        //    empList.Add(new EmployeePeople { ID = 105, Name = "Jaya", Experience = 2, Salary = 10000 });

        //    IsPromotable isPromotable = new IsPromotable(Promote);

        //    // using Delegate
        //    EmployeePeople.PromoteEmployee(empList, isPromotable);

        //    // Using Lambda Expression - Alternative to Delegate ( No Need of Promote method )
        //    EmployeePeople.PromoteEmployee(empList, emp => emp.Experience >= 5);

        //    Console.ReadLine();

        //}

        public static bool Promote(EmployeePeople emp)
        {
            if (emp.Experience >= 5)
                return true;
            else
                return false;
        }

        public static void Hello(string message)    
        {
            Console.WriteLine("\nMessage:{0}", message);
        }
    }

    public delegate bool IsPromotable(EmployeePeople emp);

    public class EmployeePeople
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<EmployeePeople> empList, IsPromotable IsEligibleToPromote)
        {
            foreach(EmployeePeople emp in empList)
            {
                if(IsEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + " Promoted\n ");
                }
            }
        }
    }
}

/*  Delegates - 
        
     *  A delegate is a type safe function pointer, that is it holds the reference (pointer) to a function.
     *  The signature of the delegate must match the signature of the method that delegates points to, 
        Otherwise we will get compile time error.This is the reason delegates are called as type safe function pointer.

     *  A delegate is a similar to a class. We can create an instance of delegate, and when we do it we pass in the 
        function name as a parameter to the delegate constructor, and it is to this function the delegate will point to.

    Note: Delegates syntax looks very much similar to a method with delegate keyword.
       
 
     

 
     
*/
