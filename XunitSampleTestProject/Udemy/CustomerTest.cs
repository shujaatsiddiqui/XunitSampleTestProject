using Catalog.Api.Udemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitSampleTestProject.Udemy
{
    [Collection("Customer")]
    public class CustomerTest
    {
        private CustomerFixture _customerFixture;

        public CustomerTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void CheckLegitForDiscount()
        {
            var customer = _customerFixture.Cust;
            Assert.InRange(customer.Age, 25, 30);
        }
        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = _customerFixture.Cust;
            var exceptionDetails = Assert.Throws<ArgumentException>(()=>customer.GetOrdersByName(""));
            Assert.Equal("Hello", exceptionDetails.Message);
        }
        [Fact]
        public void LoyalCustomersForOrdersG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }
    }
}
