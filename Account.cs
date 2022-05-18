using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public abstract class Account
    {
        public abstract string CustomerDetails();
        public abstract string InterestRate();

        public abstract string TransactionLimit();

        public abstract int BalanceMaintenance();

        public virtual string IndividualJoint()
        {
            return "Individual and joint account facilities are available";
        }

    }

    public class CurrentAccount : Account
    {


        public override string CustomerDetails()
        {
            return "Sirisha";
        }

        public override int BalanceMaintenance()
        {
            return 100000;
        }

        public override string InterestRate()
        {
            return "Usually don't provide any interest income";
        }

        public override string TransactionLimit()
        {
            return "No restrictions on the number of transactions";
        }
    }
    public class SavingAccount : Account
    {

        public override string CustomerDetails()
        {
            return "Renuka";
        }

        public override int BalanceMaintenance()
        {
            return 500;
        }


        public override string InterestRate()
        {
            return "Between 3.5% to 4% per annum";
        }

        public override string TransactionLimit()
        {
            return "Permitted to certain number of transactions";
        }
    }
}



//-----Interfaces------


   public interface IAccountHolder
{

}



