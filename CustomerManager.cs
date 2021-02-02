using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer newcustomer)
        {
            Console.WriteLine("Name:" + newcustomer.Name + " " + "Customer Number:" + newcustomer.CustomerNo + " " +"Location:" + newcustomer.Location);
            Console.WriteLine("Customer Added. \n");
        }


        public void Delete(Customer oldcustomer)
        {
            Console.WriteLine("Name:" + oldcustomer.Name + " " + "Customer Number:" + oldcustomer.CustomerNo + " Branch Code:" + oldcustomer.BranchCode + " Account Number: " + oldcustomer.AccountNumber);
            Console.WriteLine("Customer Deleted. \n");
        }
    }
}
