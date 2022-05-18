using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject2
{
    public class EmployeeDetails
    {
        public string name;

        public void work(string work)
        {
            Console.WriteLine("Work: " + work);

        }
    }

    class Employee1
    {
        static void Main(string[] args)
        {

            // create Employee object 
            EmployeeDetails e1 = new EmployeeDetails();

            Console.WriteLine("Employee 1");

            // set name of the Employee 
            e1.name = "Gloria";
            Console.WriteLine("Name: " + e1.name);

            //call method of the Employee
            e1.work("Coding");

            Console.ReadLine();

        }
    }
}
   
