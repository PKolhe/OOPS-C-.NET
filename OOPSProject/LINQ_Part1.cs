using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class LINQ_Part1
    {
        //public static void Main()
        //{
        //    //SQL Query like Expressions
        //    IEnumerable<Students> queryResult1 = from student in Students.GetAllStudents()
        //                                         where student.Gender == "Male"
        //                                         select student;

        //    Console.WriteLine(queryResult1);    

        //    //Lambda Expressions
        //    IEnumerable<Students> queryResult2 = Students.GetAllStudents().Where(student => student.Gender == "Male");

        //    Console.WriteLine(queryResult2);

        //    string strName = "pankaj";

        //    string result1 = StringHelper.ChangeFirstLetterCase(strName);
        //    string result = strName.ChangeFirstLetterCase();    // Extension Methods in StringHelper class
        //    Console.WriteLine(result);
        //    Console.WriteLine(result1);

        //    List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    IEnumerable<int> evenNumbers = Numbers.Where(n => n % 2 == 0);  // Where is Extension Method in List<T>

        //    IEnumerable<int> evenNumbers2 = Enumerable.Where(Numbers, n => n % 2 == 0);
        //    Console.WriteLine(evenNumbers);

        //    Console.ReadLine();
        //}
    }

    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if(inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }

            return inputString;
        }
    }
}

/*
 
    What is LINQ ?

    Linq stands for Linear Integrated Query. LINQ enables us to query any type of data store
    (SQL Server, XML Documents, Objects in memory etc..)

    LINQ => ADO.NET => Databases
    LINQ => XPATH/XSLT => XML Documents
    LINQ => Array Generics => In Memory Objects

    LINQ enables us to work with different data sources using a similar coding style without 
    having a need to know the syntax specific to the data sources.
    
    Another LINQ benefits are it provides intellisense & Compile time error checking.

    LINQ Providers ?

    LINQ Provider is a componenet between the LINQ query and actual data source, which converts the LINQ 
    query into a format that the underlying data source can understand.
    Ex. LINQ converts LINQ to SQL Provider to TSQL that SQL Server databases can understand.

    LINQ Proders => LINQ TO SQL      => Databases
                    LINQ TO XML      => XML DOCS
                    LINQ TO OBJECTS  => Object Data
                    LINQ TO ENTITIES => Entities
                    LINQ TO DATASET  => Datasets

    We can write LINQ Queries in 2 ways -

        a) Using Lambda Expressions
        b) Using SQL like Query Expressions

    From Performance perspective there is no difference between these two. It is our personal preference which
    one to use.

    Behind the scene the SQL like query expressions gets translated into Lambda expressions once they gets compiled.

    The standard Query operators are implemented as extension methods on IEnumerable<T> interface.
    All types which implements IEnumerable type we can use LINQ commands on these types directly.

    Query Like Expression -

        IEnumerable<Students> queryResult = from student in Students.GetAllStudents()
                                           where student.Gender === 'Male'
                                           select student; 

    Lambda Expressions -
        
        IEnumerable<Students> queryResult = Students.GetAllStudents().Where(student => student.Gender == 'Male')

    Extension Methods -
    
        1. Extension methods allows you to add methods to existing types without creating a new derived type, 
           recompiling or otherwise modifying the original type.
        2. Extension methods are special type of static method, but they are called as if they were instance 
           methods on the extended type.

        LINQ's standard query operators(select, where etc..) are implemented in Enumerable class 
        as extension methods on the Enumerable<T> interface.
        
    Ex. List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        IEnumerable<int> evenNumbers = Numbers.Where(n => n%2 == 0); 
        
        In spite of Where() metho not belonging to List<T> class we can access it. 
        It is because Where() method is implemented as Extension method in IEnumerable<T> interface.
        and List<T> implements IEnuemerale<T> interface.

    How to implement Extension Methods ?
            i) Make class as static class. Ex. static class StringHelper
            ii) Add "this" before parameter. Ex. this string inputString
            ii) MAke method static Ex. static string ChangeFirstLetterCase(this string inputString)

        1. We should be able to call extension method in the same way we call an instance method.
           Ex. string strName = "pankaj";
               string result = strName.ChangeFirstLetterCase();  
        2. We should still be able to call this extension method using wrapper class style syntax.
           Ex. string strName = "pankaj";
               string result1 = StringHelper.ChangeFirstLetterCase(strName);
        3. So, this also means we should also be able to call LINQ extension methods ( select, where etc.. )
           using a wrapper class style syntax. Since all LINQ extension methods defined in Enumerable class,
           the syntax will be as follows -
           Ex. List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
               IEnumerable<int> evenNumbers = Enumerable.Where(Numbers, n => n % 2 == 0); 
     
 */
