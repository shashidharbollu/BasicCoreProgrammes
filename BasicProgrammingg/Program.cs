using System;
using BasicProgrammingg;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("welcome to my basic programmes ");
        bool end = true;

        while (end)
        {
            Console.WriteLine("1.flipcoin/n2. , 2.leap_year/n3. end the programme ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.cointoss();
                    break;
                case 2:
                    Leap_Year LEAPYEAR = new Leap_Year();
                    LEAPYEAR.LEAPYEAR();
                    break;

            }
        }
    }
}

