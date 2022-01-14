using Catalog.Api.Udemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XunitSampleTestProject.Udemy.CustomAttribute;
using XunitSampleTestProject.Udemy.Shared;

namespace XunitSampleTestProject.Udemy
{
    public class CalculationsTests
    {
        [Theory]
        //[InlineData(1, true)]
        //[InlineData(200, false)]
        //Custom Attribue
        //[IsOddOrEvenData]
        //
        [MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
        public void Isodd_TestOddAndEven(int value, bool expected)
        {
            var calc = new Calculations();
            var result = calc.IsOdd(value);
            Assert.True(expected);
        }
    }

}
