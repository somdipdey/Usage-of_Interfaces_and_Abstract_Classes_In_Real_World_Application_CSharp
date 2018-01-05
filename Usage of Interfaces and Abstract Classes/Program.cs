using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usage_of_Interfaces_and_Abstract_Classes
{
    // Copyright @ Somdip Dey, 2018
    // Program created to explain the usage of Interface 
    // and Abstract Class in a real world application scenario

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Jon Skeet");
            NonResidentialCustomer customer2 = new NonResidentialCustomer("Somdip Dey");

            // Priting our details of Customer No. 1
            Console.WriteLine("Details of Customer No. 1::");
            Console.WriteLine("Customer Name: " + customer1.GetName());
            Console.WriteLine("Type: " + customer1.GetCustomerType());
            Console.WriteLine(Environment.NewLine + "Available Accounts:");
            
            foreach(BankAccountInterface account in customer1.GetAccounts())
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Account Type: " + account.GetAccountType());
                stringBuilder.AppendLine("Account Name: " + account.GetAccountName());
                stringBuilder.AppendLine();
                Console.WriteLine(stringBuilder);
            }

            Console.WriteLine("---------------------------");

            // Priting our details of Customer No. 2
            Console.WriteLine("Details of Customer No. 2::");
            Console.WriteLine("Customer Name: " + customer2.GetName());
            Console.WriteLine("Type: " + customer2.GetCustomerType());
            Console.WriteLine("Region: " + customer2.GetCountryRegion());
            Console.WriteLine(Environment.NewLine + "Available Accounts:");

            foreach (BankAccountInterface account in customer2.GetAccounts())
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Account Type: " + account.GetAccountType());
                stringBuilder.AppendLine("Account Name: " + account.GetAccountName());
                stringBuilder.AppendLine();
                Console.WriteLine(stringBuilder);
            }

            Console.WriteLine(Environment.NewLine + "Press any key to exit!");
            Console.ReadLine();
        }
    }
}
