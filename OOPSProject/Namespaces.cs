using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = OOPSProject.TeamA;  
using PATB = OOPSProject.TeamB;

namespace OOPSProject
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("TeamA Print Method");
            }
        }
    }
}

namespace OOPSProject.TeamB
{
    class ClassA
    {
        public static void Print()
        {
            Console.WriteLine("TeamB Print Method");
        }
    }
}


class test
{
    public static void CallPrint()
    {
        //ClassA.Print();   //ambigious reference error

        OOPSProject.TeamA.ClassA.Print(); // Fully qualified name Works perfect
        OOPSProject.TeamB.ClassA.Print(); // Fully qualified name Works perfect

        PATA.ClassA.Print();
        PATB.ClassA.Print();
        /* If user wants to avoid using fully qualified name because its bigger
           We can use namespace alias as PATA & PATB as used above to avoid Namespace Collision*/
    }
}

/* Namespaces - */

/* What is Namespaces ?
   using System; & above statements indicates that we are using that 
   particular namespace. 
   A namespace is used to organize your code and is collection of classes, interfaces,
   structs, enums and delegates. 
 
   Main method is the entry point of our application.  
     
   Why Namespaces ?
    * Namespaces are used to organize our programs.
    * They also provide assistance in avoiding name collision.
   
    Namespaces do not correspond to file, directory or assembly names. 
    They could be written in seperate files and/or seperate assemblies and 
    still belongs to the same namespace.

    Namespaces can be nested in 2 ways - 
    1. using namespace inside namespace.
    2. using . operator as bove used OOPSProject.TeamB

    Namespace alias directives. ( To Avoid Namespace Collision )

    Sometimes we may encounter namespace longer and wish to have shorter. 
    This could improve readability and still avoid name clashes with similarly
    named methods. 

    A NAmespace can contain - Another namespace, A Class, Interface, Struct, 
                              enum, delegate,
    
 */
