using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJECTMETOTS
{
    internal class Student
    {
        //----Object Methots -----
        public string Name;
        public string Departmant;
        public double gpa;


        public Student(string aName, string aDepartmant, double agpa)
        {
            Name = aName;
            Departmant = aDepartmant;
            gpa = agpa;
        }


        public bool HasCheck()
        {
            if (gpa < 2.5)
            {
                return true;
            }
            return false;
        }



    }
}
