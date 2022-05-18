using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    public  class UserDetails
    {
        public string Name;
        public int Age;
        public UserDetails(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void GetUser()
        {
            Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
        }
    }
}

