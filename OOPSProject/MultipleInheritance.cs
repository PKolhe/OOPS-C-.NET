using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    interface IA
    {
        void AMethod();
    }

    interface IB
    {
        void BMethod();
    }

    class A: IA
    {
        public void AMethod()
        {
            Console.WriteLine("A Interface Implementation");
        }

        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    class B: A, IB
    {
        public void BMethod()
        {
            Console.WriteLine("B Interface Implementation");
        }

        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }
    
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void BMethod()
        {
            b.BMethod();
        }

        public void AMethod()
        {
            a.AMethod();
        }

    }

    //class D : B, C      // Error: can not have multiple base classes
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine("D Implementation");
    //    }
    //}

    //public class Program 
    //{
    //    public static void Main()
    //    {
    //        //D obj = new D();
    //        //obj.Print();

    //        AB ab = new AB();
    //        ab.AMethod();
    //        ab.BMethod();

    //        Console.ReadLine();
    //    }
    //}
}

/* Multiple Class Inheritance
    1. Class B & C inherits from class A
    2. Class D inherits both B & C classes
    3. There will be ambiguity in class D, which method gets called from B Or C ?
    This is called as diamond problem.


 
     
*/