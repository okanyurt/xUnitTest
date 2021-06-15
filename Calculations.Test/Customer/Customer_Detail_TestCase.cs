using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Test
{
    [Collection("Customer")]
    public class Customer_Detail_TestCase
    {
        private readonly CustomerFixture _customerFixture;
        public Customer_Detail_TestCase(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        [Trait("Category","Customer_Detail")]
        public void GetFullName_GivenFirstAndLastName_ReturnFullName()
        {
            var customer = _customerFixture.customer;
            Assert.Equal("okan yurt",customer.GetFullName("okan","yurt"));

        }

    }
}
