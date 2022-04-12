using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingg
{
    public class SwapNumbers
    {
        public void swapnumberss()
        {
            Console.WriteLine("enter your first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enet your second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("after swapping numbers are : " + " " + n1 + " " + n2);
        }
    }
}
