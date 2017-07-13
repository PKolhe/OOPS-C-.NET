using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class ProductEncapsulationAbstraction
    {
        private int _qty, _perProductCost;

        public int Qty
        {
            get
            {
                return _qty;
            }
            set
            {
                if(IsQuantityGreater(value))
                {
                    throw new Exception();
                }
                _qty = value;
            }
        }

        private bool IsQuantityGreater(int no)
        {
            if (no > 10000)
                return true;
            else
                return false;
        }
        public int PerProductCost
        {
            get
            {
                return _perProductCost;
            }
            set
            {
                if(IsProductCostZero(value))
                {
                    throw new Exception();
                }
                _perProductCost = value;
            }
        }
        private bool IsProductCostZero(int productCost)
        {
            if (productCost == 0)
                return true;
            else
                return false;
        }
    }
}

/* Data Abstraction - 
 
   * Abstraction means to show only the necessary details to the client of the object.
   * Abstraction and Encapsulation both compliment each other.
   * Abstraction is achieved through Encapsulation.
   * Abstraction solves the problem in design side while Encapsulation solves problems 
     at implementation.

 Ex. Person Class - Name, DOB, Age, Bloodgroup, CompanyName, ChildCount, JoiningDate, MobileNo.
     Employee Class - Name, DOB, Salary, JoiningDate etc..
     (Show only necessary details of Employee in employee class)
 
     
*/
