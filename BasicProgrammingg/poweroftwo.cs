using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingg
{
    public class poweroftwo
    {
        public void Power()
        {
            Console.WriteLine("ENTER YOUR NUMBER");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            { 
            int number = (int)Math.Pow(i, 2);
                Console.WriteLine("the value of the enter number is" +number);
            }
        }
}
}
