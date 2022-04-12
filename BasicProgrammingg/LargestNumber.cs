using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingg
{
    public class LargestNumber
    {
        public void largest_number()
        {
            Console.WriteLine("enter your first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " " + "is greater among the three numbers");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " " + "is greater among the three numbers");
            }
            else
            { 
            Console.WriteLine(num3 + " " + "is greater among the three numbers");
            }

        }
    }
}
