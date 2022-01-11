using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitSampleTestProject.Udemy
{
    /// <summary>
    /// This class makes sures that class <CustomerFixture> should be applied or passed in contructor
    /// to all the classes that belongs to customer category.
    /// </summary>
    [CollectionDefinition("Customer")]
    public class CustomerFixtureCollection : ICollectionFixture<CustomerFixture>
    {
    }
}
