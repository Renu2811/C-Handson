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

            CurrentAccount1 obj2 = new CurrentAccount1();
            long b = obj2.AccountNo();

            SavingAccount1 obj3 = new SavingAccount1();
            string c = obj3.Create();


            Console.WriteLine(output);
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
