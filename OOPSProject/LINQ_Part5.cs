using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class LINQ_Part5
    {
        public static void Main()
        {
            /* Range operator generates a sequence of integers within a specified range. 
                This method has 2 integer parameters. The start parameter specifies the integer to start with 
                and the count parameter specifies the number of sequential integers to generate. */

            //For example to print the first 10 even numbers without using LINQ, we would use a for loop as shown below.
            for (int i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("=========================================================================\n");

            //To achieve the same using LINQ, we can use Range method as shown below.
            var evenNumbers = Enumerable.Range(1, 10).Where(x => x % 2 == 0);

            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("=========================================================================\n");

            /*Repeat operator is used to generate a sequence that contains one repeated value.

            For example the following code returns a string sequence that contains 5 "Hello" string objects 
            in it. */

            var result = Enumerable.Repeat("Hello", 5);

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("=========================================================================\n");

            /*
                Empty operator returns an empty sequence of the specified type. For example
                Enumerable.Empty[int]() - Returns an empty IEnumerable[int]
                Enumerable.Empty[string]() - Returns an empty IEnumerable[string]
                There may be scenarios where our application calls a method in a third party application that 
                returns IEnumerable[int]. There may be a situation where the third party method returns null. 
                For the purpose of this example, let us assume the third party method is similar 
                to GetIntegerSequence().

                A NULL reference exception will be thrown if GetIntegerSequence() return null 
                and if we try to iterate result.

                IEnumerable[int] result = GetIntegerSequence(); 

                We can fix this using Empty method - GetIntegerSequence() method will return empty sequence
                for iteration so it will not throw any error.

                IEnumerable[int] result = GetIntegerSequence() ?? Enumerable.Empty[int]();

             */

            /* Concat operator concatenates two sequences into one sequence.
            The following code will concatenate both the integer sequences(numbers3 & numbers4) 
            into one integer sequence. Notice that the duplicate elements ARE NOT REMOVED. */

            int[] numbers3 = { 1, 2, 3 };
            int[] numbers4 = { 1, 4, 5 };

            var result12 = numbers3.Concat(numbers4);

            foreach (var v in result12)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("=========================================================================\n");

            /* Now let us perform a union between the 2 integer sequences (numbers3 & numbers4).
               Just like concat operator, union operator also combines the 2 integer sequences
               (numbers3 & numbers4) into one integer sequence, but notice that the duplicate 
               elements ARE REMOVED. */

            var result13 = numbers3.Union(numbers4);

            foreach (var v in result13)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("=========================================================================\n");

            //Example 1 : SequenceEqual() returns true.

            string[] countries1 = { "USA", "India", "UK" };
            string[] countries2 = { "USA", "India", "UK" };

            var result14 = countries1.SequenceEqual(countries2);

            Console.WriteLine("Are Equal = " + result14);

            Console.WriteLine("=========================================================================\n");

            //Example 2 : In this case, SequenceEqual() returns false, as the default comparison is case sensitive.

            string[] countries3 = { "USA", "INDIA", "UK" };
            string[] countries4 = { "usa", "india", "uk" };

            var result15 = countries3.SequenceEqual(countries4);

            Console.WriteLine("Are Equal = " + result15);
            Console.WriteLine("=========================================================================\n");

            //Example 3: If we want the comparison to be case insensitive, then use the other overloaded version of SequenceEqual() method to which we can pass an alternate comparer.


            string[] countries5 = { "USA", "INDIA", "UK" };
            string[] countries6 = { "usa", "india", "uk" };

            var result16 = countries5.SequenceEqual(countries6, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Are Equal = " + result16);
            Console.WriteLine("=========================================================================\n");

            //Example 4 : SequenceEqual() returns false.This is because, although both the sequences contain same data, the data is not present in the same order.

            string[] countries7 = { "USA", "INDIA", "UK" };
            string[] countries8 = { "UK", "INDIA", "USA" };

            var result17 = countries7.SequenceEqual(countries8);

            Console.WriteLine("Are Equal = " + result17);
            Console.WriteLine("=========================================================================\n");

            //Example 5 : To fix the problem in Example 4, use OrderBy() to sort data in the source sequences.


            string[] countries9 = { "USA", "INDIA", "UK" };
            string[] countries10 = { "UK", "INDIA", "USA" };

            var result18 = countries9.OrderBy(c => c).SequenceEqual(countries10.OrderBy(c => c));

            Console.WriteLine("Are Equal = " + result18);
            Console.WriteLine("=========================================================================\n");

            /*Example 6 : When comparing complex types, the default comparer will only check if the object 
                          references are equal. So, in this case SequenceEqual() returns false. */

            List<EmployeeFindUnique> list = new List<EmployeeFindUnique>();
            list.Add(new EmployeeFindUnique() { ID = 101, Name = "Pankaj", Gender = "Male" });
            list.Add(new EmployeeFindUnique() { ID = 102, Name = "Manish", Gender = "Male" });
            list.Add(new EmployeeFindUnique() { ID = 103, Name = "Preety", Gender = "Female" });

            List<EmployeeFindUnique> list2 = new List<EmployeeFindUnique>();
            list2.Add(new EmployeeFindUnique() { ID = 101, Name = "Pankaj", Gender = "Male" });
            list2.Add(new EmployeeFindUnique() { ID = 101, Name = "Pankaj", Gender = "Male" });
            list2.Add(new EmployeeFindUnique() { ID = 102, Name = "Manish", Gender = "Male" });
            list2.Add(new EmployeeFindUnique() { ID = 103, Name = "Preety", Gender = "Female" });

            var result19 = list.SequenceEqual(list2);
            Console.WriteLine("Are Equal = " + result19);
            Console.WriteLine("=========================================================================\n");

            /* All these methods return true or false depending on whether if some or all of the elements 
               in a sequence satisfy a condition.

                All() method returns true if all the elements in a sequence satisfy a given condition, 
                otherwise false. */

            // Example 1 : Returns true, as all the numbers are less than 10

            int[] numbers = { 1, 2, 3, 4, 5 };

            var result20 = numbers.All(x => x < 10);

            Console.WriteLine(result20);
            Console.WriteLine("=========================================================================\n");

            /* There are 2 overloaded versions of Any() method.The version without any parameters checks 
               if the sequence contains at least one element. The other version with a predicate parameter 
               checks if the sequence contains at least one element that satisfies a given condition. */

            // Example 2 : Returns true as the sequence contains at least one element

            int[] numbers2 = { 1, 2, 3, 4, 5 };

            var result21 = numbers2.Any();

            Console.WriteLine(result21);
            Console.WriteLine("=========================================================================\n");

            /* Example 3 : Returns false as the sequence does not contain any element that satisfies the 
               given condition(No element in the sequence is greater than 10) */

            int[] numbers22 = { 1, 2, 3, 4, 5 };

            var result22 = numbers22.Any(x => x > 10);

            Console.WriteLine(result22);
            Console.WriteLine("=========================================================================\n");

            /* There are 2 overloaded versions of the Contains() method.One of the overloaded version checks 
               if the sequence contains a specified element using the default equality comparer.
               The other overloaded version checks if the sequence contains a specified element using an 
               alternate equality comparer. */

            // Example 4 : Returns true as the sequence contains number 3.In this case the default equality comparer is used.

            int[] numbers23 = { 1, 2, 3, 4, 5 };
            var result23 = numbers23.Contains(3);

            Console.WriteLine(result23);
            Console.WriteLine("=========================================================================\n");

            /* Example 5 : Returns true.In this case we are using an alternate equality comparer 
             * (StringComparer) for the comparison to be case-insensitive. */


            string[] countries = { "USA", "INDIA", "UK" };
            var result24 = countries.Contains("india", StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(result24);
            Console.WriteLine("=========================================================================\n");

            /* When comparing complex types like Employee, Customer etc, the default comparer will only 
               check if the object references are equal, and not the individual property values of the 
               objects that are being compared. */

            /* Example 6 : Returns false, as the default comparer will only check if the object references 
               are equal. */

            var result25 = list.Contains(new EmployeeFindUnique { ID = 102, Name = "Manish", Gender="Male" });
            Console.WriteLine(result25);

            /* To solve the problem in Example 6, there are 3 ways
                1. Use the other overloaded version of Contains() method to which we can pass a custom class that implements IEqualityComparer
                2. Override Equals() and GetHashCode() methods in EmployeeFindUnique class
                3. Project the properties into a new anonymous type, which overrides Equals() and GetHashCode() methods
            */

            Console.Read();
        }
    }
}

/*

    what is the difference between Concat and Union operators?
    
    Concat operator combines 2 sequences into 1 sequence. Duplicate elements are not removed. 
    It simply returns the items from the first sequence followed by the items from the second sequence. 

    Union operator also combines 2 sequences into 1 sequence, but will remove the duplicate elements.

    SequenceEqual() -

        SequenceEqual() method is used to determine whether two sequences are equal. 
        This method returns true if the sequences are equal otherwise false. 

        For 2 sequences to be equal
            1. Both the sequences should have same number of elements and
            2. Same values should be present in the same order in both the sequences
 
*/
