using System;
using LeapYear.Lib;
using Xunit;

namespace LeapYear.Test
{
    public class LeapYearCalculatorTest
    {
        [Theory]
        [InlineData(400)]
        [InlineData(2000)]
        public void DivisibleBy400_ShouldBeLeapYear(int number)
        {
            var cal = new LeapYearCalculator();
            var result = cal.IsLeapYear(number);
            Assert.True(result);
        }

        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(2100)]
        public void DivisibleBy100_ShouldNotBeLeapYear(int number)
        {
            var cal = new LeapYearCalculator();
            var result = cal.IsLeapYear(number);
            Assert.False(result);
        }

        [Theory]
        [InlineData(2008)]
        [InlineData(2012)]
        [InlineData(2016)]
        [InlineData(2020)]
        public void DivisibleBy4AndNotBy100ShouldBeLeapYear(int number)
        {
            // ??? % 4 == 0 && ??? % 100 !=0 /
            var cal = new LeapYearCalculator();
            var result = cal.IsLeapYear(number);
            Assert.True(result);
        }

        [Theory]
        [InlineData(2017)]
        [InlineData(2018)]
        [InlineData(2019)]      
        public void DivisibleBy4AndNotBy100ShouldBeNotLeapYear(int number)
        {
            // ??? % 4 == 0 && ??? % 100 !=0 /
            var cal = new LeapYearCalculator();
            var result = cal.IsLeapYear(number);
            Assert.False(result);
        }

    }
}
