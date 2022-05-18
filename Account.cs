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




    public interface IAccountHolder
    {
        string AccountAccess();

        string AtmAvailability();
        long AccountNo();

    }
    interface IManager
    {
        string Create();
        string Read();

        string Delete();

        string Update();

    }
    public class CurrentAccount1: IAccountHolder, IManager
    {
        public string AccountAccess()
        {
            return "Account Holder only can access the current account";

        }

        public string AtmAvailability()
        {
            return "ATM card facility is available in current account";
        }

        public long AccountNo()
        {
            return 119879332451;
        }

        public string Create()
        {
            return "Create action on Current Account";
        }

        public string Delete()
        {
            return "Delete action on current account";
        }

        public string Read()
        {
            return "Read details from the current account";
        }

        public string Update()
        {
            return "Update details from current account";
        }
    }
    public class SavingAccount1 : IAccountHolder, IManager
    {
        public string AccountAccess()
        {
            return "Account Holder only can access the savings account";
        }

        public string AtmAvailability()
        {
            return "ATM card facility is available in savings account";

        }

        public long AccountNo()
        {
            return 001123425543;
        }
        public string Create()
        {
            return "Create action on Savings Account";
        }

        public string Delete()
        {
            return "Delete action on savings account";
        }

        public string Read()
        {
            return "Read details from the savings account";
        }

        public string Update()
        {
            return "Update details from savings account";
        }
    }
}

