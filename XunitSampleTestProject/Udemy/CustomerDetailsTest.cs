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
    public class CustomerDetailsTest
    {
        private CustomerFixture _customerFixture;

        public CustomerDetailsTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void GetFullName_GiveFirstAndLastName_ReturnsFullName()
        {
            var customer = new Customer();
            Assert.Equal("Aref Karimi", customer.GetFullName("Aref", "Karimi"));
        }
    }
}
