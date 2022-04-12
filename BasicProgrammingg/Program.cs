using System;
using BasicProgrammingg;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("welcome to my basic programmes ");
        bool end = true;

        while (end)
        {
            Console.WriteLine("1.flipcoin/n2. end the programme ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                   FlipCoin flipCoin = new FlipCoin();
                    flipCoin.cointoss();
                    break;
                         
                    }
        }
    }
}

