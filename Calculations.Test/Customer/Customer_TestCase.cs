using System;
using System.IO;
using Xunit;

namespace Calculations.Test
{
   
    [Collection("Customer")]
    public class Customer_TestCase : IDisposable
    {
        private readonly CustomerFixture _customerFixture;
        private readonly MemoryStream _memoryStream;

        public Customer_TestCase(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
            _memoryStream = new MemoryStream();
        }


        [Fact]
        [Trait("Category", "Customer")]
        public void CheckNameEmpty()
        {
            //var customer = new Customer();
            var customer = _customerFixture.customer;
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }
        [Fact]
        [Trait("Category", "Customer")]
        public void CheckLegiForDiscount()
        {
            //var customer = new Customer();
            var customer = _customerFixture.customer;
            Assert.InRange(customer.Age, 25,30);
        }

        [Fact]
        [Trait("Category", "Customer")]
        public void GetOrdersByNameNotNull()
        {
            //var customer = new Customer();
            var customer = _customerFixture.customer;
            Assert.Throws<ArgumentException>(() =>  (customer.GetOrdersByName("")));
        }

        [Fact]
        [Trait("Category", "Customer")]
        public void GetOrdersByNameNotNullParameter()
        {
            //var customer = new Customer();
            var customer = _customerFixture.customer;
            var exceptionDetails = Assert.Throws<ArgumentException>(() => (customer.GetOrdersByName("")));
            Assert.Contains(" boş ",exceptionDetails.Message);
        }

        [Fact]
        [Trait("Category","Customer")]
        public void Check_Type()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            Assert.IsType(typeof(LoyalCustomer), customer);
        }

        public void Dispose()
        {
            _memoryStream.Close();
        }
    }
}
