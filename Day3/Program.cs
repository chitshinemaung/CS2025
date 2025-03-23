using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Day3
{
    internal class Program
    {
        static void Main(string [] args)
        {
            /* CSM: Console.Write("Enter Character: ");
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
             goto CSM; */
            Console.WriteLine("Enter any object: ");
            object obj;
            obj = Console.ReadLine();

            switch (obj)
            {
                case int i when i > 55:
                    Console.WriteLine("This is Integer");
                    Console.WriteLine("i is greater than 55");
                    break;
                case int i when i < 55:
                    Console.WriteLine("This is Integer");
                    Console.WriteLine("i is less than 55");
                    break;
                case int i when i == 55:
                    Console.WriteLine("This is Integer");
                    Console.WriteLine("i is equal to 55");
                    break;
                case int i:
                    Console.WriteLine("This is Integer");
                    Console.WriteLine("i is unknown");
                    break;

                case string s: 
                    Console.WriteLine("This is String");
                    break;
                case bool b:
                    Console.WriteLine("This is Boolean");
                    break;
                case double d:
                    Console.WriteLine("This is Double");
                    break;
                default:
                    Console.WriteLine("This is Unknown");
                    break;
            }

        }
    }
}
