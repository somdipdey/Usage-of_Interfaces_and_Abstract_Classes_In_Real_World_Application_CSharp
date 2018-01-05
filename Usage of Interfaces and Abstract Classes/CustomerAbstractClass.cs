using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usage_of_Interfaces_and_Abstract_Classes
{
    public abstract class CustomerAbstractClass
    {
        // Declare the GetCustomerType() default method here
        public abstract int GetCustomerType();

        // Implement the GetCustomerTypeName() default method here
        public abstract string GetCustomerTypeName();

        // Implement the GetCustomerTypeName() default method here
        public virtual string GetCountryRegion()
        {
            return "UK/EU";
        }
    }
}
