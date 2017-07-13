using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class User
    {

        internal double length = 0;  //can be accessed outside of class but only in same project.
        internal double width = 0;

        // can be accessed from outside class
        public bool AddUser(string name, string email, string phone)
        {
            if (ValidateUser(name, email, phone))
            {
                if (AddtoDb(name, email, phone) > 0)
                {
                    return true;
                }
            }
            return false;
        }

        // Can not access from outside of this class
        private bool ValidateUser(string name, string email, string phone)
        {
            // do your validation
            return true;
        }

        // Can not access from outside class
        private int AddtoDb(string name, string email, string phone)
        {
            // Write the Db code to insert the data
            return 1;
        }
    }
}

/* 
 Data Encapsulation - 

 Wraping up of data into a single unit. i.e. We call as classes & objects.
 
 Abstraction and encapsulation are related features in object oriented programming. 
 Abstraction allows making relevant information visible and encapsulation enables 
 a programmer to implement the desired level of abstraction.
 
 Encapsulation is implemented by using access specifiers. An access specifier defines 
 the scope and visibility of a class member. C# supports the following access specifiers:

    Public - All members have access in all classes & projects.
    Private - Only members of class have access.
    Protected - All members in current class & in derived classes can access the variables.
    Internal - Only members in current project have acess to elements
    Protected internal - All members in current project and all members 
                         in derived classes can access the variables.

    
    NEED FOR ENCAPSULATION:
   * To hide and prevent code (data) from the outside world.
     (here the world means other classes and assemblies).
   * The need of encapsulation is to protect or prevent the code (data) from accidental 
    corruption due to the silly little errors that we are all prone to make. 
    In Object oriented programming data is treated as a critical element in the program 
    development and data is packed closely to the functions that operate on it and 
    protects it from accidental modification from outside functions.
    Encapsulation provides a way to protect data from accidental corruption. 
   * To have a class better control over its fields (validating values etc…).
    

*/
