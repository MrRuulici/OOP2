using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public string CNP;

        public Student(string FirstName, string LastName, DateTime DateOfBirth, string CNP)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.CNP = CNP;
        }
    }
}
