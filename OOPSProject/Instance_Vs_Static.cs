using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class Instance_Vs_Static
    {
        //public static void Main()
        //{
        //    Circle c1 = new Circle(5);
        //    float area1 = c1.calculateArea();
        //    Console.WriteLine("Area: {0}", area1);

        //    Circle c2 = new Circle(6);
        //    float area2 = c2.calculateArea();
        //    Console.WriteLine("Area: {0}", area2);

        //    Console.Read();
        //}
    }

    class Circle
    {
        public static float _PI;
        int _radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor called");
            Circle._PI = 3.142f;
        }

        public Circle(int radius)
        {
            Console.WriteLine("Instance Constructor called");
            this._radius = radius;
        }

        public float calculateArea()
        {
            return Circle._PI * this._radius * this._radius;
        }
    }
}

class AccessPI
{
    //public static void Main()
    //{
    //    Console.WriteLine(OOPSProject.Circle._PI);   
          /* Here static constructor gets called of Circle class */
    //    Console.Read();
    //}
}

/* Static and Instance Members */

/* 
    1. When class member includes static modifiers, a member is called as static member.
    2. When no static modifier is present, the member is called as non-static 
       member or Instance member. 
    3. Static members are invoked using class name, where as instance 
       members are invoked using object of class.
    4. An instance member belongs to specific instance of class. If I create 3 objects 
       of a class, I will have 3 sets of instance members in the memory, whereas there 
       will ever be only one copy of static member, no matter how many instances of 
       classes are created.

    Note: Class members are noting but fields, methods, events, indexers, constructors etc..

    Static Constructor -
     
    1. Static constructors are used to initialize only static fields in class, instance 
       fields are not available in static constructor for intitialization.
    2. We can declare static constructor using static keyword.
    3. Static constructor only called once, no matter how many instances are created.
    4. Always Static constructors are called before instance constructors.
    5. Static constructors gets called even if we call static member outside of class using classname.
       ex. OOPSProject.Circle._PI

*/
