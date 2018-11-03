using System;

namespace LeapYear.Lib
{
    public class LeapYearCalculator
    {
        public bool IsLeapYear(int year)
        {
            return ((year % 100 == 0 && year % 400 == 0) || (year % 4 == 0 && year % 100 !=0));                 
        }
    }
}
