using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usage_of_Interfaces_and_Abstract_Classes
{
    public class Customer: CustomerAbstractClass
    {
        private string CustomerName;


        // Constructor
        public Customer(string CustomerName) 
        {
            this.CustomerName = CustomerName;
        }

        // Get Customer Name
        public string GetName()
        {
            return CustomerName;
        }

        // Using override to return the already 
        //implemented method, GetCustomerType() of Base class, which is CustomerAbstractClass
        public override int GetCustomerType()
        {
            return 1;
        }

        // Using override to return the already 
        //implemented method, GetCustomerTypeName() of Base class, which is CustomerAbstractClass
        public override string GetCustomerTypeName()
        {
            return "Citizen";
        }

        // Returns the list of account types available
        public List<BankAccountInterface> GetAccounts()
        {
            List<BankAccountInterface> accounts = new List<BankAccountInterface>();

            var currentAccount = new CurrentAccount();
            var savingsAccount = new SavingsAccount();

            accounts.Add(currentAccount);
            accounts.Add(savingsAccount);

            return accounts;
        }
    }
}
