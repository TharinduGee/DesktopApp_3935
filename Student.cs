using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp_3935
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
        public string DoB { get; set; }
        public double GPAValue { get; set; }
        public string ImageURL { get { return $"/Images/{Image}"; } }

        public Student() { }

        public Student(string firstName, string lastName, int age, string image, double gPAValue,string doB)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            GPAValue = gPAValue;
            DoB = doB;
            Image = image;
        }
    }
}
