using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Facultate
    {
        public string Name;
        public Student[] Students;

        public Facultate(string Name)
        {
            this.Name = Name;
        }
        public string Index(string CNP)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (string.Equals(CNP, Students[i].CNP))
                {
                    string s = Students[i].FirstName + " " + Students[i].LastName;
                    return s;
                }
            }
            return "Nu s-a gasit studentul!";
        }
    }
}
