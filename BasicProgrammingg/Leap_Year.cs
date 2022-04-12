using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingg
{
    public class Leap_Year
    {
        public  void LEAPYEAR()
        {
            Console.WriteLine("ENTER A YEAR TO CHECK : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) ||
                    (year % 400 == 0))
            {
                Console.WriteLine("entered yaer is leap year");

            }
            else
            {
                Console.WriteLine("entered year is not a leap year");

            }
        }


    }

}
    