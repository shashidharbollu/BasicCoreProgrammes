using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingg
{
    public class HarmonicNumber
    {
        public void harmonicnumbers()
        { 
       float sum = 0;
            Console.WriteLine("enter your number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = (float)1 / i;
                Console.WriteLine("the required harmonic nuber is" + sum);
            }
        }
    }
}
