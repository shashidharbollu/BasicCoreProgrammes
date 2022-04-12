using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingg
{
    public class quotientreminder
    {
        public void quotientreminderr()
        {
            Console.WriteLine("enter the number for dividend ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the nuber for divisor");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int quotient = num1 / num2;
            int reminder = num1 % num2;
            Console.WriteLine("the quotient is " + quotient);
            Console.WriteLine("the reminder is "+ reminder);
        }
    }
}
