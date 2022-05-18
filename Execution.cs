using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public  class Execution
    {
        static void Main(string[] args)
        {
            CurrentAccount obj = new CurrentAccount();
            int output=obj.BalanceMaintenance();

            SavingAccount obj1 = new SavingAccount();
            string a = obj1.IndividualJoint();
            Console.WriteLine(output);
            Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
