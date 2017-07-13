using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class Student
    {
        //public int ID;
        //public string Name;
        //public int PassMark = 35;

        private int _id;
        private string _name;
        private int _passMark = 35;

        public int Id
        {
            set {
                if (value < 0)
                {
                    throw new Exception("Student Id can not be Negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Student name can not be null or negative");
                }
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }

        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }

        public string Email
        {
            get;
            set;
        }

        public void SetId(int id)
        {
            if(id < 0)
            {
                throw new Exception("Student Id can not be Negative");
            }
            this._id = id;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetName( string name )
        {
            if(String.IsNullOrEmpty(name))
            {
                throw new Exception("Student name can not be null or negative");
            }
            this._name = name;
        }

        public string GetName()
        {
            return String.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        }

        public int GetPassMark()
        {
            return this._passMark;
        }
    }

    /*public class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            //c1.ID = -135;    // according to business rule , ID should always be non-negative number.
            //c1.Name = null;  // according to business rule , Name can not be set to NULL.
            //c1.PassMark = 60; //according to business rule, PassMark should be read only.

            //Console.WriteLine("ID={0}, Name={1}, PassMArk = {2}", c1.ID, c1.Name, c1.PassMark);
            c1.SetId(20);
            //c1.SetId(-35);
            c1.SetName("PAnkaj");
            //c1.SetName(null);

            c1.Id = 120; // property
            c1.Name = "Pankaj Kolhe"; // property
            c1.Email = "kolhe.pankaj@live.com";
            
            Console.WriteLine("ID={0}, Name={1}, PassMArk = {2}", c1.GetId(), c1.GetName(), c1.GetPassMark());
            Console.WriteLine("ID={0}, Name={1}, PassMArk = {2}, Email = {3}", c1.Id, c1.Name, c1.PassMark, c1.Email);
            Console.ReadLine();

        }
    }*/
}

/*
* Why Properties, Getter/Setter Methods ? - Encapsulation

    Making the class fields public and exposing to the external world is bad, 
    as we will not have control over what gets assigned and returned.

    Problem with public fields in above class -
    
    * ID should always be non-negative number.
    * Name can not be set to NULL.
    * If Student Name is missing "No Name should be returned"
    * PassMark should be read only.
     
     Getter/Setter Methods -  This is nothing but encapsulation.
     
    * Programming languages that does not have properties use getter & setter methods to
      encapsulate and protect fields.

    In above example we used SetId(int id) and GetId() methods to encapsulate _id class field.
    As a result, we have better control on what gets assigned and returned from the _id field.

    Properties - Encapsulation

    In C# to encapsulate and protect field we use properties.

    1. We use get & set accessors to implement properties.
    2. A property with both get/set accessors is Read/Write property.
    3. A property with only get accessors is Read only property.
    4. A property with only set accessors is Write only property.
    
    The adavantages of properties over using getter and setter methods is that, 
    we can access them as if they were public fields.

    Auto Implemented Properties - C# 3.0

    * If there is no additional logic in properties accessors, then we can make use 
      of auto implemented properties like above as Email. 
    * Auto impllemented properties reduce the amount of code we have to write.
    * When we use Auto implemented properties - Compiler creates private anonymous field 
      that can only be accessed through the property of get/set.

*/
