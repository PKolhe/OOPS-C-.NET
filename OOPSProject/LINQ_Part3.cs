using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class LINQ_Part3
    {
        //public static void Main()
        //{
        //    /*1. Deferred Execution */

        //    List<EmployeeProjection> empList = EmployeeProjection.GetAllEmployees();
        //    IEnumerable<EmployeeProjection> empCalc = empList.Where(emp => emp.Gender == "Male");

        //    /*Above Where Query gets executed actually when we iterates the data in foreach loop.
        //      This we called as deffered execution.*/

        //    empList.Add(new EmployeeProjection { EmployeeID = 115, FirstName = "Andrew", LastName = "Patil", Gender = "Male", AnnualSalary = 400000, Departments = new List<string> { "Computer", "Sales" } });

        //    foreach (var emp in empCalc)
        //        Console.WriteLine(emp.FirstName + "-" + emp.Gender);    // This results will also show record for Andrew.

        //    Console.WriteLine("=========================================================================");

        //    /* 2. Immediate execution */
        //    empList = EmployeeProjection.GetAllEmployees();
        //    empCalc = empList.Where(emp => emp.Gender == "Male").ToList();
            
        //    empList.Add(new EmployeeProjection { EmployeeID = 115, FirstName = "Andrew", LastName = "Patil", Gender = "Male", AnnualSalary = 400000, Departments = new List<string> { "Computer", "Sales" } });
            
        //    /*Above Where Query already got executed now, and it will only iterate the resulted data.
        //     * and will not include Andrew data.
        //     This we called as Immediate execution.*/

        //    foreach (var emp in empCalc)
        //        Console.WriteLine(emp.FirstName + "-" + emp.Gender);    // This results will also show record for Andrew.

        //    Console.WriteLine("=========================================================================");

        //    /* Conversion Operators */

        //    /* ToList() Operator - Converts integer array into List of integers */
        //    int[] numbers = { 1, 2, 3, 4, 5, 6 };
        //    List<int> nos = numbers.ToList();   

        //    /* ToArray() Operator - Converts List of strings into string array*/
        //    List<string> countries = new List<string>(){"US", "India", "UK", "AUS"  };
        //    string[] countryArrays = countries.ToArray();

        //    /* ToDictionary Operator - Converts list of employees into dictionary key-value pair
        //       Dictionary can not contain duplicate value */
        //    Dictionary<int,EmployeeProjection> empDictionary = EmployeeProjection.GetAllEmployees()
        //                                            .ToDictionary(x=> x.EmployeeID, y => y);
        //    foreach(KeyValuePair<int, EmployeeProjection> emp in empDictionary)
        //    {
        //        Console.WriteLine(emp.Key + "-" + emp.Value.FirstName + "-" + emp.Value.AnnualSalary);
        //    }

        //    Console.WriteLine("=========================================================================");

        //    /* ToLookup Operator - Converts list of employees into look up key-value pair
        //       ToLookup can contain duplicate values. It is used to group the results. */
        //    var empLookup = EmployeeProjection.GetAllEmployees().ToLookup(x => x.Gender);
        //    Console.WriteLine("Employees grouped by Gender:");
        //    foreach (var emp in empLookup)
        //    {
        //        Console.WriteLine("\nGrouped By: " + emp.Key + "\n");
        //        foreach (var item in empLookup[emp.Key])
        //        {
        //            Console.WriteLine(item.FirstName + "-" + item.Gender + "-" + item.AnnualSalary);
        //        }
        //    }

        //    Console.WriteLine("=========================================================================");

        //    /* Cast Operators - Cast operator attempts to convert all of the items within an existing collection to another type 
        //                        and return them in a new collection. */
        //    ArrayList arrayList = new ArrayList();
        //    arrayList.Add(102); arrayList.Add(122); arrayList.Add(134);
        //    //arrayList.Add("Pankaj");    // This item will throw InvalidCastException while casting

        //    IEnumerable<int> result = arrayList.Cast<int>();
        //    foreach(int i in result)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.WriteLine("=========================================================================");

        //    /* OfType Operators - OfType operator returns only the elements of the specified type and the rest of the items in 
        //                          the collection will be ignored and excluded from the result. */

        //    arrayList = new ArrayList();
        //    arrayList.Add(40); arrayList.Add(41); arrayList.Add(42);
        //    arrayList.Add("1345");      // will be ignored in the list and no Exception will be thrown
        //    arrayList.Add("Pankaj");    // will be ignored in the list and no Exception will be thrown

        //    IEnumerable<int> results = arrayList.OfType<int>();
        //    foreach (int i in results)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.WriteLine("=========================================================================");

        //    /* AsEnumerable Operator - AsEnumerable operator breaks the query into 2 parts -
        //        1. The "inside part" that is the query before AsEnumerable operator is executed as Linq-to-SQL.
        //        2. The "ouside part" that is the query after AsEnumerable operator is executed as Linq-to-Objects
        //    */

        //    //var resultData = dbContext.Employees()
        //    //                    .AsEnumerable()
        //    //                    .Where(x => x.Gender == "Male")
        //    //                    .OrderByDescending(x => x.Salary)
        //    //                    .Take(5);

        //    /* Group By Operator */

        //    // Example 1: Get Employee Count By Gender

        //    var employeeGroup1 = from employee in EmployeeProjection.GetAllEmployees()
        //                        group employee by employee.Gender;

        //    foreach (var group in employeeGroup1)
        //    {
        //        Console.WriteLine("{0} - {1}", group.Key, group.Count());
        //    }

        //    Console.WriteLine("=========================================================================");

        //    //Example 2: Get Employee Count By Gender and also each employee and Gender name

        //    var employeeGroup2 = from employee in EmployeeProjection.GetAllEmployees()
        //                         group employee by employee.Gender;

        //    foreach (var group in employeeGroup2)
        //    {
        //        Console.WriteLine("{0} - {1}", group.Key, group.Count());
        //        Console.WriteLine("----------");
        //        foreach (var employee in group)
        //        {
        //            Console.WriteLine(employee.FirstName + " " + employee.LastName);
        //        }
        //        Console.WriteLine();
        //    }

        //    /* Example 3: Get Employee Count By Gender and also each employee and Gender name. 
        //                  Data should be sorted first by Gender in ascending order and then by Employee Name 
        //                  in ascending order. */

        //    var employeeGroup3 = from employee in EmployeeProjection.GetAllEmployees()
        //                        group employee by employee.Gender into eGroup
        //                        orderby eGroup.Key
        //                        select new { Key = eGroup.Key, Employees = eGroup.OrderBy(x => x.FirstName) };

        //    foreach (var group in employeeGroup3)
        //    {
        //        Console.WriteLine("{0} - {1}", group.Key, group.Employees.Count());
        //        Console.WriteLine("----------");
        //        foreach (var employee in group.Employees)
        //        {
        //            Console.WriteLine(employee.FirstName + " " + employee.Gender);
        //        }
        //        Console.WriteLine(); 
        //    }
        //    Console.WriteLine("=========================================================================");

        //    /*Example 1: Group employees by Department and then by Gender. 
        //                 The employee groups should be sorted first by Department and then by 
        //                 Gender in ascending order. Also, employees within each group must be sorted in 
        //                 ascending order by Name. */
        //    var employeeGroups1 = EmployeeProjection.GetAllEmployees()
        //                            .GroupBy(x => new { x.Gender, x.LastName })
        //                            .OrderBy(g => g.Key.Gender)
        //                            .ThenBy(g => g.Key.LastName) 
        //                            .Select(g => new { Gender = g.Key.Gender, LastName = g.Key.LastName, Employees = g.OrderBy(x => x.FirstName) });

        //    foreach (var group in employeeGroups1)
        //    {
        //        Console.WriteLine("{0} - {1} - {2}", group.Gender, group.LastName, group.Employees.Count());
        //        Console.WriteLine("-----------------------------------------------------------");
        //        foreach (var employee in group.Employees)
        //        {
        //            Console.WriteLine(employee.FirstName + " " + employee.LastName);
        //        }
        //        Console.WriteLine();
        //    }

        //    //Example 2: Rewrite Example 1 using SQL like syntax
        //    var employeeGroups2 = from employee in EmployeeProjection.GetAllEmployees()
        //                          group employee by new { employee.Gender, employee.LastName } into eGroup
        //                          orderby eGroup.Key.Gender ascending, eGroup.Key.LastName ascending
        //                          select new
        //                          {
        //                              Gender = eGroup.Key.Gender,
        //                              LastName = eGroup.Key.LastName,
        //                              Employees = eGroup.OrderBy(x => x.FirstName)
        //                          };

        //    //foreach (var group in employeeGroups2)
        //    //{
        //    //    Console.WriteLine("{0} Gender - {1} LastName - {2} Count", group.Gender, group.LastName, group.Employees.Count());
        //    //    Console.WriteLine("-----------------------------------------------------------");
        //    //    foreach (var employee in group.Employees)
        //    //    {
        //    //        Console.WriteLine(employee.FirstName + " " + employee.FirstName + " - " + employee.Gender);
        //    //    }
        //    //    Console.WriteLine();
        //    //}

        //    /*  a) First / FirstOrDefault
        //        b) Last / LastOrDefault
        //        c) ElementAt / ElementAtOrDefault
        //        d) Single / SingleOrDefault
        //        e) DefaultIfEmpty */

        //    int[] numbersArray1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    int[] numbersArray2 = { };

        //    int result1 = numbersArray1.First(x => x%2 == 0);
        //    //int result2 = numbersArray2.First(x => x % 2 == 0); // throws Exception if input array is Empty.    
        //    Console.WriteLine("First Element {0}", result1);

        //    int result3 = numbersArray2.FirstOrDefault(x => x % 2 == 0);    
        //    Console.WriteLine("FirstOrDefault Element {0}", result3);

        //    int result4 = numbersArray1.Last(x => x % 2 == 0);
        //    //int result2 = numbersArray2.Last(x => x % 2 == 0); // throws Exception if input array is Empty.    
        //    Console.WriteLine("Last Element {0}", result4);

        //    int result5 = numbersArray1.LastOrDefault(x => x % 2 == 0);
        //    Console.WriteLine("LastOrDefault Element {0}", result5);

        //    int result6 = numbersArray1.ElementAt(2);
        //    //int result6 = numbersArray2.ElementAt(2);  // throws Exception if input array is Empty.    
        //    Console.WriteLine("ElementAt Element {0}", result6);

        //    int result7 = numbersArray2.ElementAtOrDefault(2);
        //    Console.WriteLine("ElementAtOrDefault Element {0}", result7);

        //    int[] numbersArray3 = { 10 };
        //    //int result8 = numbersArray1.Single(x => x%2 == 0);    // // throws Exception more than one element present.    
        //    //int result8 = numbersArray2.Single(x => x%2 == 0);  // throws Exception more than one element present.  
        //    int result8 = numbersArray3.Single(x => x % 2 == 0);
        //    Console.WriteLine("Single Element {0}", result8);

        //    int result9 = numbersArray2.SingleOrDefault(x => x % 2 == 0);
        //    Console.WriteLine("SingleOrDefault Element {0}", result9);

        //    IEnumerable<int> result10 = numbersArray1.DefaultIfEmpty(100); // O/P - 1, 2, 3, 4, 5, 6, 7, 8, 9
        //    IEnumerable<int> result11 = numbersArray2.DefaultIfEmpty(100); // O/p - 100
        //    foreach (int i in result10)
        //    {
        //        Console.Write("{0}\t", i);
        //    }


        //    Console.Read();
        //}
    }
}
/* 
    1. LINQ Query Deffered Execution -
        LINQ queries have two different behaviors of execution
            1. Deferred execution
            2. Immediate execution

        LINQ operators can be broadly classified into 2 categories based on the behaviour of query execution
            1. Deferred or Lazy Operators - 
                These query operators use deferred execution. Examples - select, where, Take, Skip etc...
                Query gets executed actually when we iterates the data in foreach loop.
            2. Immediate or Greedy Operators - 
                These query operators use immediate execution. Examples - count, average, min, max, ToList etc...
    
    2. Conversion Operators -
        ToList, ToArray, ToDictionary, ToLookup, Cast, OfType, AsEnumerable, AsQueryable
        
        ToList
            ToList operator extracts all of the items from the source sequence and returns a new List[T]. 
            This operator causes the query to be executed immediately. 
            This operator does not use deferred execution.

        ToArray
            ToArray operator extracts all of the items from the source sequence and returns a new Array. 
            This operator causes the query to be executed immediately. 
            This operator does not use deferred execution.

        ToDictionary 
            ToDictionary operator extracts all of the items from the source sequence and returns 
            a new Dictionary. This operator causes the query to be executed immediately. 
            This operator does not use deferred execution.

        Please Note: Keys in the dictionary must be unique. If two identical keys are created by the 
                     keySelector function, the following System.ArgumentException will be thrown at runtime.
        Unhandled Exception: System.ArgumentException: An item with the same key has already been added.

        ToLookup 
            ToLookup creates a Lookup. Just like a dictionary, a Lookup is a collection of key/value pairs. 
            A dictionary cannot contain keys with identical values, where as a Lookup can.
    
    3. Cast and OfType Operator -

        Cast operator:
            Cast operator attempts to convert all of the items within an existing collection to another type 
            and return them in a new collection. If an item fails conversion an exception will be thrown. 
            This method uses deferred execution.
        
        OfType operator
            OfType operator will return only elements of the specified type. The other type elements are 
            simply ignored and excluded from the result set. No exception will be thrown.

        What is the difference between Cast and OfType operators ?
            OfType operator returns only the elements of the specified type and the rest of the items in 
            the collection will be ignored and excluded from the result. 

            Cast operator will try to cast all the elements in the collection into the specified type. 
            If some of the items fail conversion, InvalidCastException will be thrown.
        
        When to use Cast over OfType and vice versa ?

            We would generally use Cast when the following 2 conditions are met -
                1. We want to cast all the items in the collection &
                2. We know for sure the collection contains only elements of the specified type

            If we want to filter the elements and return only the ones of the specified type, 
            then we would use OfType.

    4. AsQueryable and AsEnumerable Operator -

        AsQueryable operator : There are 2 overloaded versions of this method. 
            One overloaded version converts System.Collections.IEnumerable to System.Linq.IQueryable
            The other overloaded version converts a generic System.Collections.Generic.IEnumerable[T] 
            to a generic System.Linq.IQueryable[T]

            The main use of AsQueryable operator is unit testing to mock a queryable data source 
            using an in-memory data source. 
            We will discuss this operator in detail with examples in unit testing video series.

        AsEnumerable operator : AsEnumerable operator breaks the query into 2 parts -
            1. The "inside part" that is the query before AsEnumerable operator is executed as Linq-to-SQL.
            2. The "ouside part" that is the query after AsEnumerable operator is executed as Linq-to-Objects.

        So in this example the following SQL Query is executed against SQL Server, 
        all the data is brought into the console application and then the WHERE, ORDERBY & TOP operators 
        are applied on the client-side.

            SELECT [t0].[ID], [t0].[Name], [t0].[Gender], [t0].[Salary]
            FROM [dbo].[Employees] AS [t0]

        So in short, use AsEnumerable operator to move query processing to the client side.

    5. GroupBy Operator -

        GroupBy operator belong to Grouping Operators category. 
        This operator takes a flat sequence of items, organize that sequence into 
        groups (IGrouping[K,V]) based on a specific key and return groups of sequences. 

        In short, GroupBy creates and returns a sequence of IGrouping[K,V]

    6. Element Operators - 

        The following standard query operators belong to Element Operators category
            a) First / FirstOrDefault
            b) Last / LastOrDefault
            c) ElementAt / ElementAtOrDefault
            d) Single / SingleOrDefault
            e) DefaultIfEmpty

        Element Operators retrieve a single element from a sequence using the element index or based 
        on a condition. All of these methods have a corresponding overloaded version that accepts a predicate.

        a) First : There are 2 overloaded versions of this method. 
           
           The first overloaded version that does not have any parameters simply returns the first element of a sequence.
                If the sequence does not contain any elements, then First() method throws an InvalidOperationException.

           The second overloaded version is used to find the first element in a sequence based on a condition. 
                If the sequence does not contain any elements or if no element in the sequence satisfies the condition 
                then an InvalidOperationException is thrown.

        b) FirstOrDefault : This is very similar to First, except that this method does not throw an exception 
            when there are no elements in the sequence or when no element satisfies the condition specified 
            by the predicate. Instead, a default value of the type that is expected is returned. 
            For reference types the default is NULL and for value types the default depends on the actual type 
            expected.

        c) Last : Very similar to First, except it returns the last element of the sequence.

        d) LastOrDefault : Very similar to FirstOrDefault, except it returns the last element of the sequence.

        e) ElementAt : Returns an element at a specified index. If the sequence is empty or if the provided 
                       index value is out of range, then an ArgumentOutOfRangeException is thrown.

        f) ElementAtOrDefault : Similar to ElementAt except that this method does not throw an exception, 
                                if the sequence is empty or if the provided index value is out of range. 
                                Instead, a default value of the type that is expected is returned.

        g) Single : There are 2 overloaded versions of this method. The first overloaded version that does not have 
                    any parameters returns the only element of the sequence.
                    Single() method throws an exception if the sequence is empty or has more than one element.

          The second overloaded version of the Single() method is used to find the only element in a sequence 
          that satisfies a given condition. An exception will be thrown if any of the following is true
                a) If the sequence does not contain any elements OR
                b) If no element in the sequence satisfies the condition OR
                c) If more than one element in the sequence satisfies the condition

        h) SingleOrDefault : Very similar to Single(), except this method does not throw an exception 
                             when the sequence is empty or when no element in the sequence satisfies the given 
                             condition. Just like Single(), this method will still throw an exception, 
                             if more than one element in the sequence satisfies the given condition.

        i) DefaultIfEmpty : If the sequence on which this method is called is not empty, then the values 
                            of the original sequence are returned.
                            If the sequence is empty, then DefaultIfEmpty() returns a sequence with the 
                            defualt value of the expected type.

                The other overloaded version with a parameter allows us to specify a default value. 
                If this method is called on a sequence that is not empty, then the values of the original sequence 
                are returned. If the sequence is empty, then this method returns a sequence with the 
                specified defualt value.





*/
