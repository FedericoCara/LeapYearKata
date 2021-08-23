using System;

namespace Leap_Year_Kata
{
    public class LeapYear {
        public static bool IsLeapYear(int year) {
            return year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
        }

        public static void Main(string[] args) { 
        
        }
    }
}
