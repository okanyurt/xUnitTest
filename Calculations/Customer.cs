using System;

namespace Calculations
{
    public  class Customer
    {
        public Customer()
        {
            int DisCount = 15;
        }
        public virtual  int GetOrdersByName(string name)        
        {
            if (string.IsNullOrEmpty(name))
            { 
                throw new ArgumentException("name boş olamaz");
            }
            return 100;
        }
        public string Name => "Okan";
        public int Age => 28;
        

        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }

    public  class LoyalCustomer : Customer
    {
        public int DisCount { get; set; }

        public LoyalCustomer()
        { DisCount = 10; }

        public override  int GetOrdersByName(string name)
        {
            return 101;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount <= 100)
                return new Customer();
            else
                return new LoyalCustomer();
        }
    }
}
