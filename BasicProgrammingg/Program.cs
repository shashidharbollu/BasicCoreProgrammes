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
            Console.WriteLine("1.flipcoin\n 2.leap_year\n , 3.PowerofTwo\n 4.harmonic_number\n 5.quotientandreminder\n 6.swapnumber\n 7.evenorodd\n 8.vowelconsonant\n end the programme/n4. ");
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
                case 3:
                    poweroftwo Power = new poweroftwo();
                    Power.Power();
                    break;
                case 4:
                    HarmonicNumber HarmonicNumber = new HarmonicNumber();
                    HarmonicNumber.harmonicnumbers();
                    break;
                case 5:
                    quotientreminder quotientreminder = new quotientreminder();
                    quotientreminder.quotientreminderr();
                    break;
                case 6: 
                    SwapNumbers swapNumbers = new SwapNumbers();
                    swapNumbers.swapnumberss();
                    break;
                case 7:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.EvenOddNumber();
                    break;
                case 8:
                    VowelConsonant vowelConsonant = new VowelConsonant();
                    vowelConsonant.Vowel_Consonant();
                    break;

                default:
                    Console.WriteLine("choose a proper number to execute");
                    break;
            }
        }
    }
}

 