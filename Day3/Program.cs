using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {
        static void Main(string [] args)
        {
            CSM: Console.Write("Enter Character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' )
            {
                Console.WriteLine("This is Vowel");
            }
            else
            {
                Console.WriteLine("Not Vowel");
            }

            switch (ch )
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("This is Vowel");
                    break;
                default:
                    Console.WriteLine("Not Vowel");
                    break;
            }
            goto CSM;

        }
    }
}
