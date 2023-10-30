using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Models
{
    public class CustomerService
    {
        public void AddCustomer(Customer customer)
        {
            // Code to add a customer to the database
            EmployeeDataBase.CustomerList.Add(customer);

        }
        public Customer FindCustomer(int? id)
        {
            // Code to find a customer according to id value
            if (id != null)
            {
                return EmployeeDataBase.CustomerList.Find(customer => customer.Id == id);
            }
            return null;
        }
    }
}
