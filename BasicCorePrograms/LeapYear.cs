using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class LeapYear
    {
        public static void CheckLeapYear(int Year)
        {
            string Y = Convert.ToString(Year);
            if(Y.Length == 4)
            {
                if (Year % 4 == 0)
                {
                    Console.WriteLine("{0} tear is Leap Year.", Year);
                }
                else
                {
                    Console.WriteLine("{0} tear is not Leap Year.", Year);
                }
            }
            else
            {
                Console.WriteLine("Enter only 4 digit number.");
            }
            
        }
    }
}
