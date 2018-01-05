using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usage_of_Interfaces_and_Abstract_Classes
{
    public class NonResidentialCustomer: CustomerAbstractClass
    {
        private string CustomerName;


        // Constructor
        public NonResidentialCustomer(string CustomerName) 
        {
            this.CustomerName = CustomerName;
        }

        // Get Customer Name
        public string GetName()
        {
            return CustomerName;
        }

        // Using override to return the
        // method, GetCustomerType() of Base class, which is CustomerAbstractClass
        public override int GetCustomerType()
        {
            return 2;
        }

        // Using override to return the 
        // method, GetCustomerTypeName() of Base class, which is CustomerAbstractClass
        public override string GetCustomerTypeName()
        {
            return "Non Residential";
        }

        // Using override to return the already 
        // implemented method, GetCountryRegion() of Base class, which is CustomerAbstractClass
        public override string GetCountryRegion()
        {
            return "Non Residential in " + base.GetCountryRegion();
        }

        // Returns the list of account types available
        public List<BankAccountInterface> GetAccounts()
        {
            List<BankAccountInterface> accounts = new List<BankAccountInterface>();

            var savingsAccount = new SavingsAccount();

            accounts.Add(savingsAccount);

            return accounts;
        }
    }
}
