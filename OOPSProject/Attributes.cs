using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public class Attributes
    {
        //static void Main(string[] args)
        //{
        //    Calculator.Add(10, 20);
        //    Calculator.Add(new List<int>() { 10, 20, 30 });
        //}
    }

    public class Calculator
    {
        [Obsolete("Use Add(List<int> numbers) method.", false)]     // true means raise error instead of warning.
        public static int Add(int firstNo, int secondNo)  // outdated method
        {
            return firstNo + secondNo;
        }

        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach(var no in numbers)
            {
                sum += no;
            }
            return sum;
        }
    }
}

/*  Attributes -
 
    *   Attributes allow you to add declarative information to your programs. This information can then be 
        queried at runtime using reflection.
        There are several pre-defined attributes provided by .NET, It is also possible to create our own Custom attributes.

    Pre-defined Attributes of .NET - 

        Onsolete - Marks types and type members outdated.
        WebMethod - To expose a method as an XML web service method.
        Serialiazable - Indicates that a class can be serialized.

    It is possible to customize the attribute using parameters.
    An attribute is a class that inherits from System.Attribute base class.

    Please Rebuild solution and see if warning is visible.
     
*/