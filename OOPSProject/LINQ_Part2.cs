using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class LINQ_Part2
    {
        //public static void Main()
        //{
        //    // Aggregate Operators/Functions - SUM, Count, Min, Max, Average
        //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    int? minresult = null, maxresult = null, countResult = null, sumResult = null;
        //    double averageResult; 

        //    minresult = numbers.Where(x => x% 2 ==0).Min();
        //    maxresult = numbers.Where(x => x % 2 == 0).Max();
        //    countResult = numbers.Where(x => x % 2 == 0).Count();
        //    sumResult = numbers.Where(x => x % 2 == 0).Sum();
        //    averageResult = numbers.Where(x => x % 2 == 0).Average();
        //    Console.WriteLine("Min No:{0}, Max No: {1}, Count: {2}, Sum: {3}, Average: {4}", minresult, maxresult, countResult, sumResult, averageResult);

        //    string[] countires = { "India", "Pakistan", "Australia", "England", "US" };
        //    Console.WriteLine("Shortest country has {0} Characters", countires.Min(x=> x.Length));
        //    Console.WriteLine("Longest country has {0} Characters", countires.Max(x => x.Length));

        //    // Aggreagte Function - Write LINQ Query to print - India, Pakistan, Australia, England, US
        //    string result = countires.Aggregate((a,b) => a + "," + b);
        //    Console.WriteLine("Result:{0}", result);

        //    // Aggreagte Function - Write LINQ Query to multiply all numbers in numbers array
        //    numbers = new List<int> { 2, 3, 4 };
        //    int result12 = numbers.Aggregate(10, (a, b) => a * b); // 10 * 2 = 20 * 3 * 4
        //    Console.WriteLine("Result:{0}", result12);


        //    // Restriction Operators 

        //    var resultRestriction = numbers
        //                            .Select((num, index) => new { Number = num, Index = index })
        //                            .Where(x => x.Number % 2 == 0)
        //                            .Select(x => x.Index);

        //    Console.WriteLine(resultRestriction);

        //    // Projection Operators
            
        //    //1. Retrieve EmployeeID property of all employees
        //    var empListIds = EmployeeProjection.GetAllEmployees().Select(emp => emp.EmployeeID);
        //    foreach (var id in empListIds)
        //        Console.WriteLine(id);

        //    Console.WriteLine("============================================================================");

        //    //2. Projects FirstName and Gender properties of all employees into anonymous type.
        //    var empNames = EmployeeProjection.GetAllEmployees()
        //                   .Select(n => new { Name = n.FirstName, Gender = n.Gender });
        //    foreach (var emp in empNames)
        //        Console.WriteLine(emp.Name + "-" + emp.Gender);

        //    Console.WriteLine("============================================================================");

        //    //3. Calculate MonthlySalary & FullName of Employees and project these 2 properties into anonymous types.
        //    var empCalc = EmployeeProjection.GetAllEmployees()
        //                  .Select(emp => new
        //                  {
        //                      FullName = emp.FirstName + " " + emp.LastName,
        //                      MonthlySalary = emp.AnnualSalary / 12
        //                  });
        //    foreach (var emp in empCalc)
        //        Console.WriteLine(emp.FullName + "-" + emp.MonthlySalary);

        //    Console.WriteLine("============================================================================");

        //    /*4. Give 10% bonus to all employees whose monthly salary is greater than 50000 and 
        //         projects all such employees FullName, AnnualSalary, bonus info into anonymous types. */
        //    var empBonus = EmployeeProjection.GetAllEmployees().Where(emp => (emp.AnnualSalary / 12 > 70000))
        //                              .Select(emp => new
        //                              {
        //                                  FullName = emp.FirstName + " " + emp.LastName,
        //                                  AnnualSalary = emp.AnnualSalary,
        //                                  Bonus = emp.AnnualSalary * 0.10
        //                              });
        //    foreach (var emp in empBonus)
        //        Console.WriteLine("FullName:{0}, AnnualSalary:{1}, Bonus:{2}", emp.FullName , emp.AnnualSalary , emp.Bonus);

        //    Console.WriteLine("============================================================================");

        //    //Example 1. Retrieve List of all Departments of Employees
        //    IEnumerable<string> departments = EmployeeProjection.GetAllEmployees()
        //                                      .SelectMany(emp => emp.Departments);
        //    foreach (var dept in departments)
        //        Console.WriteLine("Departments: {0}",dept);

        //    Console.WriteLine("============================================================================");

        //    //Example 2. Rewrite example 1 using SQL like syntax
        //    IEnumerable<string> departmentSQL = from emp in EmployeeProjection.GetAllEmployees()
        //                                        from dept in emp.Departments
        //                                        select dept;
                                              
        //    foreach (var dept in departments)
        //        Console.WriteLine("Departments: {0}", dept);

        //    Console.WriteLine("============================================================================");

        //    //Example 3. Projects each string to an IEnumerable<char>
        //    string[] stringArray = { "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "0123456789" };
        //    IEnumerable<char> resultsArray = stringArray.SelectMany(c => c);

        //    foreach (var c in resultsArray)
        //        Console.WriteLine(c);

        //    Console.WriteLine("============================================================================");

        //    //Example 4. Rewrite example 3 using SQL like syntax
        //    var resultsArray1 = from c in stringArray
        //                        from ch in c
        //                        select ch;
        //    foreach (var c in resultsArray)
        //        Console.WriteLine(c);

        //    Console.WriteLine("============================================================================");

        //    //Example 5. Select only distincts departments
        //    var distinctDepartments = EmployeeProjection.GetAllEmployees().SelectMany(dept => dept.Departments).Distinct();
        //    foreach (var dept in distinctDepartments)
        //        Console.WriteLine(dept);

        //    Console.WriteLine("============================================================================");

        //    //Example 5. Rewrite example 5 into SQL like syntax
        //    var distinctDepartments1 = (from emp in EmployeeProjection.GetAllEmployees()
        //                                from dept in emp.Departments
        //                                select dept).Distinct();
        //    foreach (var dept in distinctDepartments1)
        //        Console.WriteLine(dept);

        //    Console.WriteLine("============================================================================");

        //    //Example 6. Select employee names along with departments
        //    var empNamesDepts = EmployeeProjection.GetAllEmployees().SelectMany(emp => emp.Departments, (emp, dept) => new { Employee = emp.FirstName+" " +emp.LastName, Department = dept}).Distinct();
        //    foreach (var dept in empNamesDepts)
        //        Console.WriteLine(dept);

        //    Console.WriteLine("============================================================================");

        //    //Example 6. Rewrite ex6 using SQL like syntax.
        //    var empNamesDepts1 = from emp in EmployeeProjection.GetAllEmployees()
        //                         from dept in emp.Departments
        //                         select new
        //                         {
        //                             Employee = emp.FirstName + " " +emp.LastName,
        //                             Department = dept
        //                         };
        //    foreach (var dept in empNamesDepts1)
        //        Console.WriteLine(dept);

        //    Console.WriteLine("============================================================================");

        //    //Example 7. Select() query to select all departments
        //    IEnumerable<List<string>> departments1 = EmployeeProjection.GetAllEmployees().Select(emp => emp.Departments);
        //    foreach (List<string> dept in departments1)
        //        foreach(string d in dept)
        //            Console.WriteLine(d);

        //    Console.WriteLine("============================================================================");

        //    //Example 8. SelectMany() query to select all departments
        //    IEnumerable<string> departments2 = EmployeeProjection.GetAllEmployees().SelectMany(emp => emp.Departments);
        //    foreach (string dept in departments2)
        //            Console.WriteLine(dept);

        //    Console.WriteLine("============================================================================");

        //    //Example 9: Sort Students by Name in ascending order
        //    IEnumerable<EmployeeProjection> resultAsc1 = EmployeeProjection.GetAllEmployees().OrderBy(s => s.FirstName);
        //    foreach (EmployeeProjection student in resultAsc1)
        //    {
        //        Console.WriteLine(student.FirstName);
        //    }

        //    Console.WriteLine("============================================================================");

        //    //Example 9: Rewrite Example 1 using SQL like syntax
        //    IEnumerable<EmployeeProjection> resultAsc2 = from emp in EmployeeProjection.GetAllEmployees()
        //                                                 orderby emp.FirstName
        //                                                 select emp;

        //    foreach (EmployeeProjection student in resultAsc2)
        //    {
        //        Console.WriteLine(student.FirstName);
        //    }

        //    Console.WriteLine("============================================================================");

        //    //Example 10: Sort Students by Name in descending order
        //    IEnumerable<EmployeeProjection> resultDesc1 = EmployeeProjection.GetAllEmployees()
        //                                                    .OrderByDescending(s => s.FirstName);
        //    foreach (EmployeeProjection emp in resultDesc1)
        //    {
        //        Console.WriteLine(emp.FirstName);
        //    }

        //    Console.WriteLine("============================================================================");

        //    //Example 10: Rewrite Example 3 using SQL like syntax
        //    IEnumerable<EmployeeProjection> resultDesc2 = from emp in EmployeeProjection.GetAllEmployees()
        //                                                  orderby emp.FirstName descending
        //                                                  select emp;

        //    foreach (EmployeeProjection emp in resultDesc2)
        //    {
        //        Console.WriteLine(emp.FirstName);
        //    }

        //    Console.WriteLine("============================================================================");

        //    /*Example 11: 
        //        a) Sorts Employees first by AnnualSalary in ascending order(Primary Sort) 
        //        b) The 4 Employees with TotalMarks of 800, will then be sorted by Name 
        //           in ascending order (First Secondary Sort)
        //        c) The 2 Employees with Name of Pankaj, will then be sorted by EmpId 
        //           in ascending order (Second Secondary Sort)*/

        //    IEnumerable<EmployeeProjection> resultsThenBy = EmployeeProjection.GetAllEmployees()
        //                                            .OrderBy(s => s.AnnualSalary)
        //                                            .ThenBy(s => s.FirstName).ThenBy(s => s.EmployeeID);
        //    foreach (EmployeeProjection emp in resultsThenBy)
        //    {
        //        Console.WriteLine(emp.AnnualSalary + "\t" + emp.FirstName + "\t" + emp.EmployeeID);
        //    }

        //    Console.WriteLine("============================================================================");

        //    /* Example 12: 
        //        Rewrite Example 1 using SQL like syntax.With SQL like syntax we donot use 
        //        ThenBy or ThenByDescending, instead we specify the sort expressions using a comma separated list. 
        //        The first sort expression will be used for primary sort and the subsequent sort expressions 
        //        for secondary sort. */

        //    IEnumerable<EmployeeProjection> resultsThenBySQL = from student in EmployeeProjection.GetAllEmployees()
        //                                                       orderby student.AnnualSalary, student.FirstName, student.EmployeeID
        //                                                       select student;
        //    foreach (EmployeeProjection emp in resultsThenBySQL)
        //    {
        //        Console.WriteLine(emp.AnnualSalary + "\t" + emp.FirstName + "\t" + emp.EmployeeID);
        //    }

        //    Console.WriteLine("============================================================================");

        //    //Example 13: Reverses the items in the collection. 
        //    IEnumerable<EmployeeProjection> reverseResults1 = EmployeeProjection.GetAllEmployees();
        //    Console.WriteLine("Before calling Reverse");
        //    foreach (EmployeeProjection s in reverseResults1)
        //    {
        //        Console.WriteLine(s.EmployeeID + "\t" + s.FirstName + "\t" + s.AnnualSalary);
        //    }

        //    Console.WriteLine("============================================================================");

        //    IEnumerable<EmployeeProjection> reverseResults2 = reverseResults1.Reverse();
        //    Console.WriteLine("After calling Reverse");
        //    foreach (EmployeeProjection s in reverseResults2)
        //    {
        //        Console.WriteLine(s.EmployeeID + "\t" + s.FirstName + "\t" + s.AnnualSalary);
        //    }

        //    Console.WriteLine("============================================================================");

        //    // Example 1: Retrieves only the first 3 countries of the array.
        //    string[] countries1 = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
        //    IEnumerable<string> resultCountires1 = countries1.Take(3);

        //    foreach (string country in resultCountires1)
        //    {
        //        Console.WriteLine(country);
        //    }

        //    Console.WriteLine("============================================================================");

        //    // Example 2: Rewrite Example 1 using SQL like syntax
        //    string[] countries2 = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
        //    IEnumerable<string> resultCountires2 = (from country in countries2
        //                                            select country).Take(3);

        //    foreach (string country in resultCountires2)
        //    {
        //        Console.WriteLine(country);
        //    }

        //    Console.WriteLine("============================================================================");

        //    // Example 3: Skips the first 3 countries and retrieves the rest of them.
        //    string[] countries3 = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
        //    IEnumerable<string> resultCountires3 = countries3.Skip(3);

        //    foreach (string country in resultCountires3)
        //    {
        //        Console.WriteLine(country);
        //    }

        //    Console.WriteLine("============================================================================");

        //    /* Example 4: Return countries starting from the beginning of the array until a 
        //                  country name is hit that does not have length greater than 2 characters. */
        //    string[] countries4 = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
        //    IEnumerable<string> resultCountires4 = countries4.TakeWhile(s => s.Length == 2);

        //    foreach (string country in resultCountires4)
        //    {
        //        Console.WriteLine(country);
        //    }

        //    Console.WriteLine("============================================================================");

        //    /* Example 5: Skip elements starting from the beginning of the array, until a country name 
        //                  is hit that does not have length greater than 2 characters, and then return 
        //                  the remaining elements. */
        //    string[] countries5 = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
        //    IEnumerable<string> resultCountires5 = countries5.SkipWhile(s => s.Length == 2);

        //    foreach (string country in resultCountires5)
        //    {
        //        Console.WriteLine(country);
        //    }

        //    Console.WriteLine("============================================================================");

        //    /* Example6: We will use the following EmployeeProjection class in this demo. Notice that, 
        //                 there are 11 total Employees. We want to display a maximum of 3 employees per page. 
        //                 So there will be 4 total pages. The last page, i.e Page 4 will display the last 2 
        //                 employees.
        //     Here is what we want to do -
        //                1. The program should prompt the user to enter a page number. 
        //                   The Page number must be between 1 and 4.
        //                2. If the user does not enter a valid page number, the program should prompt the user 
        //                   to enter a valid page number.
        //                3. Once a valid page number is entered, the program should display the correct set 
        //                   of Employees. */

        //    IEnumerable<EmployeeProjection> employees = EmployeeProjection.GetAllEmployees();
        //    do {
        //        Console.WriteLine("Please enter Page Number - 1,2,3 or 4");
        //        int pageNumber = 0;
        //        if (int.TryParse(Console.ReadLine(), out pageNumber))
        //        {
        //            if (pageNumber >= 1 && pageNumber <= 4) 
        //            {
        //                int pageSize = 3;
        //                IEnumerable<EmployeeProjection> resultValues = employees.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        //                Console.WriteLine();
        //                Console.WriteLine("Displaying Page " + pageNumber);
        //                foreach (EmployeeProjection emp in resultValues)
        //                {
        //                    Console.WriteLine(emp.EmployeeID + "\t" + emp.FirstName + "\t" + emp.AnnualSalary);
        //                }
        //                Console.WriteLine();
        //            }
        //            else 
        //            {
        //                Console.WriteLine("Page number must be an integer between 1 and 4");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Page number must be an integer between 1 and 4");
        //        }
        //    } while (1 == 1);
        //    Console.ReadLine();
        //}
    }
    
    public class EmployeeProjection
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnnualSalary { get; set; }
        public List<string> Departments { get; set; }
        public int BankAccountID { get; set; }

        public static List<EmployeeProjection> GetAllEmployees()
        {
            List<EmployeeProjection> listOfEmployees = new List<EmployeeProjection>();

            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 101, FirstName = "Pankaj", LastName = "Kolhe", Gender = "Male", AnnualSalary = 1000000, Departments = new List<string> { "Computer", "Sales" }, BankAccountID = 1});
            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 102, FirstName = "Preety", LastName = "Kolhe", Gender = "Female", AnnualSalary = 1200000, Departments = new List<string> { "Marketing", "Sales", "Media" }, BankAccountID = 2 });
            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 103, FirstName = "Harish", LastName = "Dhake", Gender = "Male", AnnualSalary = 1500000, Departments = new List<string> { "Computer", "Marketing", "Media" }, BankAccountID = 3 });
            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 104, FirstName = "Chaitali", LastName = "Narkhede", Gender = "Female", AnnualSalary = 900000, Departments = new List<string> { "Computer", "Marketing", "Sales", "Media" }, BankAccountID = 1 });
            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 105, FirstName = "Rajesh", LastName = "Dhake", Gender = "Male", AnnualSalary = 800000, Departments = new List<string> { "Marketing", "Sales", "Media" }, BankAccountID = 1 });

            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 106, FirstName = "Rahul", LastName = "Patil", Gender = "Male", AnnualSalary = 400000, Departments = new List<string> { "Computer", "Sales" }, BankAccountID = 2 });
            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 107, FirstName = "Sandeep", LastName = "Kolhe", Gender = "Male", AnnualSalary = 1000000, Departments = new List<string> { "Marketing", "Sales", "Media" }, BankAccountID = 3 });
            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 108, FirstName = "Priya", LastName = "Narkhede", Gender = "Female", AnnualSalary = 1800000, Departments = new List<string> { "Computer", "Marketing", "Media" } });
            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 109, FirstName = "Mangesh", LastName = "Dhake", Gender = "Male", AnnualSalary = 900000, Departments = new List<string> { "Computer", "Marketing", "Sales", "Media" } });
            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 110, FirstName = "Dipti", LastName = "Kolhe", Gender = "Female", AnnualSalary = 800000, Departments = new List<string> { "Marketing", "Sales", "Media" }, BankAccountID = 2 });
            listOfEmployees.Add(new EmployeeProjection { EmployeeID = 111, FirstName = "Sneha", LastName = "Patil", Gender = "Female", AnnualSalary = 600000, Departments = new List<string> { "Marketing", "Sales", "Media" }, BankAccountID = 2 });

            return listOfEmployees;
        }
    }

    public class BankAccount
    {
        public int BankAccountID { get; set; }
        public string BankName { get; set; }

        public static List<BankAccount> GetAllAccounts()
        {
            List<BankAccount> listOfBankAccounts = new List<BankAccount>()
            {
                new BankAccount() { BankAccountID = 1, BankName = "HDFC Bank" },
                new BankAccount() { BankAccountID = 2, BankName = "State Bank of India" },
                new BankAccount() { BankAccountID = 3, BankName = "ICICI Bank" },
                new BankAccount() { BankAccountID = 4, BankName = "Central Bank Of India" },
            };

            return listOfBankAccounts;
        }
    }
}

/*
    LINQ Operators - 
    
    Aggregate Operators 
    Restriction Operators

    Projection Operators -

        1) Select
        2) SelectMany

    Select clause in SQL allows to specify which columns we want to retrive. 
    In similar fashion we use Select & SelectMany, it also allowas to perform calculations

    Using Select Projection Operator - 

    1. We can select just EmployeeID property
    2. We can select multiple properties like FirstName & Gender into an anonymous type.
    3. Perform Calculations
        a) Monthly Salary = AnnualSalary / 12;
        b) FullName = FirstName + " "+ LastName;
    

     SelectMany Operator - 
        SelectMany is used to project each element of sequence to an IEnumerable<T> 
        and flatterns the resulting sequence into one sequence.
        Departments property is collection of strings in EmployeeProjection class.
    
    Difference between Select & SelectMany - Select and SelectMany are projection operators. 

    Select - Select() method returns List of List<string>. 
             To print all the departments we will have to use 2 nested foreach loops.
             Select operator is used to select value from a collection.

    SelectMany - SelectMany() flatterns queries that returns lists of lists into a single list.
                 So in this case to print all departments we need to use only one foreach loop.
                 SelectMany operator is used to select values from a collection of collection. i.e. nested collection.
     
    Ordering Operators -

        1. Orderby
        2. OrderbyDesending
        3. ThenBy
        4. ThenByDescending
        5. Reverse
        
        * OrderBy or OrderByDescending work fine when we want to sort a collection just by one value 
          or expression. If want to sort by more than one value or expression, that's when we use 
          ThenBy or ThenByDescending along with OrderBy or OrderByDescending.

        * OrderBy or OrderByDescending performs the primary sort. 
          ThenBy or ThenByDescending is used for adding secondary sort. 
          Secondary Sort operators (ThenBy or ThenByDescending ) can be used more than once in 
          the same LINQ query.
    
    Partitioning Operators - 
        1. Take
        2. Skip
        3. TakeWhile
        4. SkipWhile

        Take method returns a specified number of elements from the start of the collection. 
        number of items to return is specified using the count parameter this method expects.

        Skip method skips a specified number of elements in a collection and then returns the remaining 
        elements. The number of items to skip is specified using the count parameter this method expects. 

        Please Note: For the same argument value, the Skip method returns all of the items that 
                     the Take method would not return.

        TakeWhile method returns elements from a collection as long as the given condition specified 
        by the predicate is true. 

        SkipWhile method skips elements in a collection as long as the given condition specified 
        by the predicate is true, and then returns the remaining elements.

*/
