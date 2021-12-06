using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_Programs
{
    class Persons
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public Persons(string ssn, string name, string addr, int age)
        {
            SSN = ssn;
            Name = name;
            Address = addr;
            Age = age;
        }
    }
}
