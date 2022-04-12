using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingg
{
    public class VowelConsonant
    {
        public void Vowel_Consonant()
        {
            Console.WriteLine("enter your alphabet: ");
            char alphabet = Console.ReadKey().KeyChar;
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine("entered alphabet is a vowel");
            }
            else if (alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
            {
                Console.WriteLine("ENTERED NUMBER IS A VOWEL");
            }
            else
            {
                Console.WriteLine("entered alphabet is a consonant");
            }

        }
    }
}