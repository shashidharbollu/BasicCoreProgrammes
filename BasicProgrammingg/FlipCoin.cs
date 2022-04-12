using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingg
{
    public class FlipCoin
    {
        const double A = 0.5;
        int headCount = 0;
        int tailCount = 0;
        public void cointoss()
        {

            for (int i = 0; i < 50; i++)
            {
                Random random = new Random();
                double num = random.NextDouble();
                if (num > A)
                {
                    headCount++;

                }
                else
                {
                    tailCount++;

                }
            }
            double headpercentage = headCount % 100;
            double tailpercentage = tailCount % 100;
            Console.WriteLine("the percentage of heads is " + headpercentage);
            Console.WriteLine("The percentage of tails is " + tailpercentage);


        }

        internal void flipCoin()
        {
            throw new NotImplementedException();
        }

        internal void Flipcoin()
        {
            throw new NotImplementedException();
        }
    }
}