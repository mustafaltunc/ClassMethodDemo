using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer customerone = new Customer
            {
                CustomerNo = 658217,
                Name = "Steve",
                Location = "United States",
                BranchCode = 812,
                AccountNumber = 8524556
            };

            Customer customertwo = new Customer
            {
                CustomerNo = 748212,
                Name = "Oliver",
                Location = "United Kingdom",
                BranchCode = 722,
                AccountNumber = 5524543
            };

            Customer customerthird = new Customer
            {
                CustomerNo = 748212,
                Name = "Halsey",
                Location = "Brasilia",
                BranchCode = 222,
                AccountNumber = 1524467
            };

            Customer[] newcustomers = new Customer[] { customerone, customertwo};
            Customer[] oldcustomers = new Customer[] { customerthird };

            CustomerManager customerManager = new CustomerManager();

            foreach (var customer in newcustomers)
            {
                customerManager.Add(customer);
            }

            foreach (var customer in oldcustomers)
            {
                customerManager.Delete(customer);
            }
        }
    }
}
