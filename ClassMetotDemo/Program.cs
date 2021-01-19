using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();
            Customer customer1 = new Customer();
            customer1.CustomerNo = 1000001;
            customer1.CustomerName = "Fatih";
            customer1.CustomerSurname = "Çınar";

            manager.AddCustomer(customer1.CustomerName, customer1.CustomerSurname, customer1.CustomerNo);

            Customer customer2 = new Customer();
            
            customer2.CustomerNo = 1000002;
            customer2.CustomerName = "Caner";
            customer2.CustomerSurname = "Başat";
            manager.AddCustomer(customer2.CustomerName, customer2.CustomerSurname, customer2.CustomerNo);

            Customer customer3 = new Customer();
            
            customer3.CustomerNo = 1000003;
            customer3.CustomerName = "Pınar";
            customer3.CustomerSurname = "Akın";
            manager.AddCustomer(customer3.CustomerName, customer3.CustomerSurname, customer3.CustomerNo);

            Customer customer4 = new Customer();
            
            customer4.CustomerNo = 1000004;
            customer4.CustomerName = "Efkan";
            customer4.CustomerSurname = "Yıldız";
            manager.AddCustomer(customer4.CustomerName, customer4.CustomerSurname, customer4.CustomerNo);

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            
            foreach (var customer in customers)
            {
                if (customer.CustomerNo % 2 > 0)
                {
                    manager.DeleteCustomer(customer.CustomerName, customer.CustomerSurname, customer.CustomerNo);
                
                }
            }

            

           
  
        }
    }
}
