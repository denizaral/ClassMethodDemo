using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemoo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer was added. " + customer.Id + " " + customer.Name + " " + customer.Surname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer was deleted. " + customer.Id + " " + customer.Name + " " + customer.Surname);
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Customer was listed. " + customer.Id + " " + customer.Name + " " + customer.Surname);
        }
    }
}
