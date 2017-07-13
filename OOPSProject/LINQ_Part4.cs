using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class LINQ_Part4
    {
        //public static void Main()
        //{
        //    /* Group Join */

        //    //Example 1: Group employees by Department.
        //    var employeesByAccount = BankAccount.GetAllAccounts()
        //                                    .GroupJoin(EmployeeProjection.GetAllEmployees(), 
        //                                      d => d.BankAccountID, e => e.BankAccountID, 
        //                                      (account, employees) => new { BankAccount = account, Employees = employees });

        //    foreach (var account in employeesByAccount)
        //    {
        //        Console.WriteLine(account.BankAccount.BankName);
        //        foreach (var employee in account.Employees)
        //        {
        //            Console.WriteLine(" " + employee.FirstName + " " + employee.LastName);
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("=========================================================================\n");

        //    //Example 2: Rewrite Example 1 using SQL like syntax.
        //    var employeesByAccountSQL = from d in BankAccount.GetAllAccounts()
        //                                join e in EmployeeProjection.GetAllEmployees() 
        //                                on d.BankAccountID equals e.BankAccountID into eGroup
        //                                select new
        //                                {
        //                                    BankAccount = d,
        //                                    Employees = eGroup
        //                                };
        //    foreach (var account in employeesByAccountSQL)
        //    {
        //        Console.WriteLine(account.BankAccount.BankName);
        //        Console.WriteLine("-------------------------");
        //        foreach (var employee in account.Employees)
        //        {
        //            Console.WriteLine(" " + employee.FirstName + " " + employee.LastName);
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("=========================================================================\n");

        //    /* Inner Join */
        //    //Example 1 : Join the Employees and Department collections and print all the Employees and their respective department names.
        //    var employeesRes = EmployeeProjection.GetAllEmployees()
        //                        .Join(BankAccount.GetAllAccounts(), 
        //                            e => e.BankAccountID, d => d.BankAccountID, 
        //                            (employee, bankAccount) => new { EmployeeName = employee.FirstName, BankName = bankAccount.BankName });

        //    foreach (var employee in employeesRes)
        //    {
        //        Console.WriteLine(employee.EmployeeName + " " + employee.BankName);
        //    }
        //    /*Output: Notice that, in the output we don't have Priya and Mangesh record. 
        //              This is because, they does not have a matching bank accounts in BankAccount collection. 
        //              So this is effectively an inner join. */

        //    Console.WriteLine("=========================================================================\n");

        //    //Example 2 : Rewrite Example 1 using SQL like syntax.
        //    employeesRes = from e in EmployeeProjection.GetAllEmployees()
        //                   join d in BankAccount.GetAllAccounts() on e.BankAccountID
        //                   equals d.BankAccountID
        //                   select new
        //                   {
        //                       EmployeeName = e.FirstName,
        //                       BankName = d.BankName
        //                   };

        //    foreach (var employee in employeesRes)
        //    {
        //        Console.WriteLine(employee.EmployeeName + " " + employee.BankName);
        //    }

        //    Console.WriteLine("=========================================================================\n");

        //    /* Left Outer Join*/

        //    //Example 1 : Join the Employees and Department collections and print all the Employees and their respective department names.
        //    var employeesRes1 = EmployeeProjection.GetAllEmployees()
        //                        .GroupJoin(BankAccount.GetAllAccounts(),
        //                            e => e.BankAccountID, d => d.BankAccountID,
        //                            (employee, bankAccount) => new { employee, bankAccount })
        //                            .SelectMany(z => z.bankAccount.DefaultIfEmpty(), (a,b) => new { empName = a.employee.FirstName, BankName = (b == null) ? "No Bank Accounts" : b.BankName});

        //    foreach (var employee in employeesRes1)
        //    {
        //        Console.WriteLine(employee.empName + " - " + employee.BankName);
        //    }
        //    /*Output: Notice that, in the output will includes Priya and Mangesh record as well. 
        //              This is because, they does not have a matching bank accounts in BankAccount collection. 
        //              So this is effectively an Left Outer join. */

        //    Console.WriteLine("=========================================================================\n");

        //    //Example 2 : Using SQL Like Syntax
        //    var employeesRes2 = from e in EmployeeProjection.GetAllEmployees()
        //                        join d in BankAccount.GetAllAccounts() on e.BankAccountID
        //                        equals d.BankAccountID into eGroup
        //                        from d in eGroup.DefaultIfEmpty()
        //                        select new
        //                        {
        //                            EmployeeName = e.FirstName,
        //                            BankName = (d == null) ? "No Bank Accounts" : d.BankName
        //                        };

        //    foreach (var employee in employeesRes2)
        //    {
        //        Console.WriteLine(employee.EmployeeName + " - " + employee.BankName);
        //    }

        //    Console.WriteLine("=========================================================================\n");

        //    /* Cross Join*/
        //    //Example 1 : Cross Join the Employees and Department collections and print all the Employees and their respective department names.
        //    var employeesRes3 = from e in EmployeeProjection.GetAllEmployees()
        //                        from d in BankAccount.GetAllAccounts() 
        //                        select new { e, d };

        //    foreach (var employee in employeesRes3)
        //    {
        //        Console.WriteLine(employee.e.FirstName + " - " + employee.d.BankName);
        //    }

        //    Console.WriteLine("=========================================================================\n");
            
        //    //Example 2 : Using Extension method
        //    var employeesRes4 = EmployeeProjection.GetAllEmployees()
        //                        .SelectMany(e => BankAccount.GetAllAccounts(),
        //                        (e, d) => new { e, d});
        //    foreach (var employee in employeesRes4)
        //    {
        //        Console.WriteLine(employee.e.FirstName + " - " + employee.d.BankName);
        //    }

        //    Console.WriteLine("=========================================================================\n");

        //    //Example 3 : Join Extension method
        //    var employeesRes5 = EmployeeProjection.GetAllEmployees()
        //                        .Join(BankAccount.GetAllAccounts(),
        //                        e => true,
        //                        d => true,
        //                        (e,d) => new { e, d });
        //    foreach (var employee in employeesRes5)
        //    {
        //        Console.WriteLine(employee.e.FirstName + " - " + employee.d.BankName);
        //    }

        //    Console.WriteLine("=========================================================================\n");

        //    // SET Operators 

        //    /* Example 1 : Return distinct country names. In this example the default comparer is being used 
        //                 and the comparison is case-sensitive, so in the output we see country USA 2 times. */

        //    string[] countries = { "USA", "usa", "india", "INDIA", "UK", "UK" };
        //    var result = countries.Distinct();

        //    foreach (var v in result)
        //    {
        //        Console.WriteLine(v);
        //    }

        //    Console.WriteLine("=========================================================================\n");

        //    /* Example 2: For the comparision to be case-insensitive, use the other overloaded version of 
        //       Distinct() method to which we can pass a class that implements IEqualityComparer as an argument.
        //       In this case we see country USA only once in the output. */

        //    var result1 = countries.Distinct(StringComparer.OrdinalIgnoreCase);

        //    foreach (var v in result1)
        //    { Console.WriteLine(v);
        //    }

        //    Console.WriteLine("=========================================================================\n");

        //    //When comparing elements, Distinct() works in a slightly different manner with complex types like Employee, Customer etc. 

        //    /* Example 3: Notice that in the output we don't get unique employees. This is because, 
        //       the default comparer is being used which will just check for object references being equal 
        //       and not the individual property values. */

        //    List<EmployeeFindUnique> list = new List<EmployeeFindUnique>();
        //    list.Add(new EmployeeFindUnique() { ID = 101, Name = "Pankaj", Gender = "Male" });
        //    list.Add(new EmployeeFindUnique() { ID = 102, Name = "Manish", Gender = "Male" });
        //    list.Add(new EmployeeFindUnique() { ID = 103, Name = "Preety", Gender = "Female" });
        //    list.Add(new EmployeeFindUnique() { ID = 101, Name = "Pankaj", Gender = "Male" });
        //    list.Add(new EmployeeFindUnique() { ID = 103, Name = "Preety", Gender = "Female" });
        //    list.Add(new EmployeeFindUnique() { ID = 104, Name = "Geeta", Gender = "Female" });

        //    var result2 = list.Distinct();

        //    foreach (var v in result2)
        //    {
        //        Console.WriteLine(v.ID + "\t" + v.Name + "\t" + v.Gender);
        //    }

        //    Console.WriteLine("=========================================================================\n");

        //    /* To solve the problem in Example 3, there are 3 ways ( Remove Duplicates from result )
        //        a. Use the other overloaded version of Distinct() method to which we can pass a custom class 
        //           that implements IEqualityComparer
        //        b. Override Equals() and GetHashCode() methods in Employee class
        //        c. Project the properties into a new anonymous type, which overrides Equals() and GetHashCode() methods*/


        //    /* Example a : Using the overloaded version of Distinct() method to which we can pass a custom 
        //                   class that implements IEqualityComparer */
        //    /* Step 1 : Create a custom class (EmployeeRemoveDuplicate) that implements IEqualityComparer[T] 
        //                and implement Equals() and GetHashCode() methods 
        //       Step 2 : Pass an instance of EmployeeComparer as an argument to Distinct() method */

        //    var result3 = list.Distinct(new EmployeeRemoveDuplicate());

        //    foreach (var v in result3)
        //    {
        //        Console.WriteLine(v.ID + "\t" + v.Name + "\t" + v.Gender);
        //    }

        //    /* Example b : Override Equals() and GetHashCode() methods in EmployeeFindUnique class. 
        //                   ( Uncomment these methods Code in that class ) */

        //    /* Example c : Project the properties into a new anonymous type, which overrides Equals() 
        //                   and GetHashCode() methods */
        //    Console.WriteLine("=========================================================================\n");

        //    var result4 = list.Select(x => new { x.ID, x.Name, x.Gender }).Distinct();

        //    foreach (var v in result4)
        //    {
        //        Console.WriteLine(v.ID + "\t" + v.Name + "\t" + v.Gender);
        //    }

        //    //Union combines two collections into one collection while removing the duplicate elements.

        //    /* Example 1: numbers1 and numbers2 collections are combined into a single collection. 
        //                  Notice that, the duplicate elements are removed. */

        //    int[] numbers1 = { 1, 2, 3, 4, 5 };
        //    int[] numbers2 = { 1, 3, 6, 7, 8 };

        //    var result5 = numbers1.Union(numbers2);

        //    foreach (var v in result5)
        //    {
        //        Console.WriteLine(v); // O/P - 1, 2, 3, 4, 5, 6, 7, 8
        //    }
        //    Console.WriteLine("=========================================================================\n");

        //    /* When comparing elements, just like Distinct() method, Union(), Intersect() and Except() 
        //       methods work in a slightly different manner with complex types like Employee, Customer etc. */

        //    /* Example 2 : Notice that in the output the duplicate employee objects are not removed.
        //                   This is because, the default comparer is being used which will just check 
        //                   for object references being equal and not the individual property values. */

        //    List<EmployeeFindUnique> list2 = new List<EmployeeFindUnique>();
        //    list2.Add(new EmployeeFindUnique() { ID = 101, Name = "Pankaj", Gender = "Male" });
        //    list2.Add(new EmployeeFindUnique() { ID = 105, Name = "Umesh", Gender = "Male" });

        //    var result6 = list.Union(list2);

        //    foreach (var v in result6)
        //    {
        //        Console.WriteLine(v.ID + "\t" + v.Name + "\t" + v.Gender);
        //    }
        //    Console.WriteLine("=========================================================================\n");

        //    /*Example 3 : To solve the problem in Example 2, there are 3 ways 
        //     * ( Remove duplicate Complex types in Union)
        //        1.Use the other overloaded version of Union() method to which we can pass a custom class 
        //          that implements IEqualityComparer
        //        2. Override Equals() and GetHashCode() methods in Employee class
        //        3. Project the properties into a new anonymous type, which overrides Equals() and GetHashCode() methods */
            
        //    // 1. way
        //    //var result7 = list.Union(list2, new EmployeeRemoveDuplicate());

        //    // 2. Way ( Uncomment these methods Code in that class )
        //    //var result7 = list.Union(list2);

        //    // 3. Way 
        //    var result8 = list.Select(x => new { x.ID, x.Name, x.Gender }).Union(list2.Select(x => new { x.ID, x.Name, x.Gender }));

        //    foreach (var v in result8)
        //    {
        //        Console.WriteLine(v.ID + "\t" + v.Name + "\t" + v.Gender);
        //    }
        //    Console.WriteLine("=========================================================================\n");

        //    // Intersect() returns the common elements between the 2 collections.
        //    // Example 4 : Return common elements in numbers1 and numbers2 collections.

        //    var result9 = numbers1.Intersect(numbers2);

        //    foreach (var v in result9)
        //    {
        //        Console.WriteLine(v);   //O/P - 1,3 
        //    }

        //    /* Except() returns the elements that are present in the first collection but not in the 
        //       second collection. Includes common elements */
        //    /* Example 5: Return the elements that are present in the first collection but not in the 
        //                  second collection. */

        //    var result10 = numbers1.Except(numbers2);

        //    foreach (var v in result10)
        //    {
        //        Console.WriteLine(v);  // O/P - 1,3,2,4,5 (includes common elemnts)
        //    }
            
        //    Console.WriteLine("=========================================================================\n");



        //    Console.Read();
        //}
    }
}

public class EmployeeFindUnique
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }

    // Remove duplicates from list
    //public override bool Equals(object obj)
    //{
    //    return this.ID == ((EmployeeFindUnique)obj).ID && this.Name == ((EmployeeFindUnique)obj).Name;
    //}

    //public override int GetHashCode()
    //{
    //    return this.ID.GetHashCode() ^ this.Name.GetHashCode();
    //}
}

public class EmployeeRemoveDuplicate : IEqualityComparer<EmployeeFindUnique>
{
    public bool Equals(EmployeeFindUnique x, EmployeeFindUnique y)
    {
        return x.ID == y.ID && x.Name == y.Name;
    }

    public int GetHashCode(EmployeeFindUnique obj)
    {
        return obj.ID.GetHashCode() ^ obj.Name.GetHashCode();
    }
}


/* 
    Joins - 
        The following are the different types of joins in LINQ
            1. Group Join
            2. Inner Join
            3. Left Outer Join
            4. Cross Join
    
    1. Group Join
        Group Join produces hierarchical data structures. 
        Each element from the first collection is paired with a set of correlated elements from the 
        second collection. 
        
        Please note: Group Join uses the join operator and the into keyword to group the results of the join.

    2. Inner Join
        If you have 2 collections, and when you perform an inner join, then only the matching elements 
        between the 2 collections are included in the result set. 
        Non - Matching elements are excluded from the result set.

    Difference between Group join and Inner join in LINQ -

        1. into keyword is used along with join operator to implement group join rest all syntax is similar.
        2. inner Join is similar to INNER JOIN in SQL and GroupJoin is similar to OUTER JOIN in SQL
    
    3. Left Outer Join
        With INNER JOIN only the matching elements are included in the result set. 
        Non-matching elements are excluded from the result set.

        With LEFT OUTER JOIN all the matching elements + all the non matching elements from the 
        left collection are included in the result set.
     
    4. Cross Join 
        Cross join produces a cartesian product i.e when we cross join two sequences, 
        every element in the first collection is combined with every element in the second collection. 
        The total number of elements in the resultant sequence will always be equal to the product of 
        the elements in the two source sequences. The on keyword that specfies the JOIN KEY is not required.

        To implement Cross Join using extension method syntax, we could either use SelectMany() method 
        or Join() method
*/
