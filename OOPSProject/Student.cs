using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public class Students
    {
        int _ID;
        string _name, _gender;

        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public static List<Students> GetAllStudents()
        {
            List<Students> listOfStudents = new List<Students>();
            listOfStudents.Add(new Students() { ID = 101, Name = "Pankaj", Gender = "Male"});
            listOfStudents.Add(new Students() { ID = 102, Name = "Preety", Gender = "Female" });
            listOfStudents.Add(new Students() { ID = 103, Name = "Harish", Gender = "Male" });
            listOfStudents.Add(new Students() { ID = 104, Name = "Chaitali", Gender = "Female" });
            listOfStudents.Add(new Students() { ID = 105, Name = "Mahesh", Gender = "Male" });
            listOfStudents.Add(new Students() { ID = 106, Name = "Poonam", Gender = "Female" });

            return listOfStudents;
        }
    }
}
