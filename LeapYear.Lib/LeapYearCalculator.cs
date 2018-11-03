using System;

namespace LeapYear.Lib
{
    public class LeapYearCalculator
    {
        public bool IsLeapYear(int year)
        {
            // return year % 400 == 0;
            if (year % 100 == 0 && year % 400 == 0)
            {
                return true;
            }
            if (year % 4 == 0 && year % 100 !=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
