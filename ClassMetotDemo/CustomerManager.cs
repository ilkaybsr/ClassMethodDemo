using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
     class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        

        public void AddCustomer(Customer customer) 
        {
            if (customer.IdNumber > 0==true)
            {
                customers.Add(customer);
                Console.WriteLine("Müşteri Sisteme Eklendi");
            }

            else
            {
                Console.WriteLine("Müşteri Sisteme Eklenemedi!");
            }
        }

        public List<Customer> GetList()
        {
            return customers;
        }

        public void Delete ( int Id) 
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].IdNumber == Id)
                    customers.Remove(customers[i]);
                Console.WriteLine("Müşteri Sistemdeen Siilindi");
            }
        }
        
           
    }
}
