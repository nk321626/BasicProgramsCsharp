using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelorConsonant
{
    internal class Vowel_Consonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Alphabet to check");
            char alpha = char.Parse(Console.ReadLine());
            switch (alpha)
            {
                case 'a':
                    Console.WriteLine("Alphabet is vowel1");
                    break;
                case 'A':
                    Console.WriteLine("Alphabet is vowel1");
                    break ;
                case 'e':
                    Console.WriteLine("Alphabet is vowel1");
                    break;
                case'E':
                    Console.WriteLine("Alphabet is vowel1");
                    break;
                case 'i': 
                    Console.WriteLine("Alphabet is vowel1");
                    break;
                case 'I':
                    Console.WriteLine("Alphabet is vowel1");
                    break;
                case 'o':
                    Console.WriteLine("Alphabet is vowel1");
                    break;
                case 'O':
                    Console.WriteLine("Alphabet is vowel1");
                    break;
                case 'u':
                    Console.WriteLine("Alphabet is vowel1");
                    break;
                case 'U':
                    Console.WriteLine("Alphabet is vowel1");
                    break;
                default:
                    Console.WriteLine("Alphabet is Consonent");
                    break;

             }
        }
    }
}
