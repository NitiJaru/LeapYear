using System;
using LeapYear.Lib;
using Xunit;

namespace LeapYear.Test
{
    public class LeapYearCalculatorTest
    {
        [Theory(DisplayName="BeLeapYear")]
        [InlineData(400)]
        [InlineData(2000)]
        [InlineData(2008)]
        [InlineData(2012)]
        [InlineData(2016)]
        [InlineData(2020)]
        public void ShouldBeLeapYear(int number)
        {
            var cal = new LeapYearCalculator();
            var result = cal.IsLeapYear(number);
            Assert.True(result);
        }
        
        [Theory (DisplayName="NotBeLeapYear")]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(2100)]
        [InlineData(2017)]
        [InlineData(2018)]
        [InlineData(2019)] 
        public void ShouldNotBeLeapYear(int number)
        {
            var cal = new LeapYearCalculator();
            var result = cal.IsLeapYear(number);
            Assert.False(result);
        }
    }
}
