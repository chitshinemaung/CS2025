using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int mark = 85;

            string result = mark > 39 ? mark > 79 ? "Distinction" : "Pass" : "Fail";
            Console.WriteLine("This is Result: " + result);

            if ( mark > 39 )
            {
                if ( mark > 79 )
                {
                    Console.WriteLine("Pass With Distinction");
                }
                else
                {
                    Console.WriteLine("Normal Pass");
                }
            }
            else
            {
                Console.WriteLine("This person is Fail");
            }
            Console.WriteLine();

            int temp = 97;

            string status = temp > 100.4 ? "Sick" : "Healthy";
            Console.WriteLine($"This is Status:  {status}");

            if ( temp > 100.4 )
            {
                Console.WriteLine("This person is Sick");
            }
            else
            {
                Console.WriteLine("This person is Healthy");            
            }
            Console.WriteLine();


            int num1 = 10, num2 = 20, res;

            res = num1 + num2;
            Console.WriteLine("Addition: " + res);

            res = num1 - num2;
            Console.WriteLine("Subtraction: " + res);

            res = num1 * num2;
            Console.WriteLine("Multiplication: " + res);

            res = num1 / num2;
            Console.WriteLine("Division: " + res);
            Console.WriteLine();

            //Boolean Expression ( num1 = 10, num2 = 20 )
            bool isGreater = num1 > num2? true : false;
            Console.WriteLine("num1 Is Greater num2: " + isGreater);

            bool isLess = num1 < num2 ? true : false;
            Console.WriteLine("num1 Is Less num2: " + isLess);

            bool isEqual = num1 == num2 ? true : false;
            Console.WriteLine("num1 Is Equal num2: " + isEqual);

            bool isNotEqual = num1 != num2 ? true : false;
            Console.WriteLine("num1 Is Not Equal num2: " + isNotEqual);

            bool isGreaterOrEqual = num1 >= num2 ? true : false;
            Console.WriteLine("num1 Is Greater Or Equal num2: " + isGreaterOrEqual);

            bool isLessOrEqual = num1 <= num2 ? true : false;
            Console.WriteLine("num1 Is Less Or Equal num2: " + isLessOrEqual);

            bool isAnd = num1 > 5 && num2 < 30 ? true : false;
            Console.WriteLine("num1 > 5 And num2 < 30: " + isAnd);

            bool isOr = num1 > 5 || num2 < 30 ? true : false;
            Console.WriteLine("num1 > 5 Or num2 < 30: " + isOr);

            bool isNot = !( num1 > 5 ) ? true : false;
            Console.WriteLine("num1 > 5 Not: " + isNot);

            bool isXor = num1 > 5 ^ num2 < 30 ? true : false;
            Console.WriteLine("num1 > 5 Xor num2 < 30: " + isXor);
            Console.WriteLine();
            //Bitwise Operator

            int a, b;
            Console.WriteLine("Enter two Numbers: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int c = a + b;
            Console.WriteLine("Addition: " + c);
            Console.WriteLine();

















        }
    }
}
