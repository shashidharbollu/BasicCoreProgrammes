using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingg
{
    public class EvenOdd
    {
        public void EvenOddNumber()
        {
            Console.WriteLine("enter you number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("the entered number is a even number");
            }
            else
            {
                Console.WriteLine("the entered number is a odd number");
            }
        }
    }
}
