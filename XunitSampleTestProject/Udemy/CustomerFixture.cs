using Catalog.Api.Udemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitSampleTestProject.Udemy
{
    public class CustomerFixture
    {
        public Customer Cust => new Customer();
    }
}
