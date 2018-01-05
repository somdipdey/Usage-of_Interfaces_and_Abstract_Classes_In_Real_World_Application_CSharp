using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usage_of_Interfaces_and_Abstract_Classes
{
    public class CurrentAccount: BankAccountInterface
    {
        // Constructor
        public CurrentAccount()
        { }

        // Implementing the method GetAccountType() of BankAccountInterface
        public int GetAccountType()
        {
            return 1;
        }

        // Implementing the method GetAccountName() of BankAccountInterface
        public string GetAccountName()
        {
            return "Current Account";
        }
    }
}
