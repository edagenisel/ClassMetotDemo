using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void AddCustomer( string name, string surname, int customerNo)
        {
            Console.WriteLine("Customer is added.\nName:" + name + "\nSurname:" + surname + "\nCustomerNo:" + customerNo);
        }
        public void DeleteCustomer(string name, string surname, int customerNo)
        {
            Console.WriteLine("Customer is deleted.\nName:" + name + "\nSurname:" + surname + "\nCustomerNo:" + customerNo);
        }

    }
}
