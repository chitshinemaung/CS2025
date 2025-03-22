using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Calculator
{
    internal class RangeCalculator
    {
        static void Main(string [] args)
        /*  1 - 50 ==> 50
            51 - 75 ==> 25
            76 - 150 ==> 75
            151 - 200 ==> 50
            201 >
        */
        {

            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int range = 0;

            if ( number >= 1 && number <= 50 )
            {
                if ( number == 50 )
                {
                    range = 50;
                }
                else
                {
                    range = number;
                }

                Console.WriteLine("1 - 50 ==> " + range);
                Console.WriteLine("51 - 75 ==> 0");
                Console.WriteLine("76 - 150 ==> 0");
                Console.WriteLine("151 - 200 ==> 0");
                Console.WriteLine("201 ==> 0");

            }
            if ( number >= 51 && number <= 75 )
            {
                if ( number == 75 )
                {
                    range = 25;
                }
                else
                {
                    range = number - 50;
                }
                Console.WriteLine("1 - 50 ==> 50");
                Console.WriteLine("51 - 75 ==> " + range);
                Console.WriteLine("76 - 150 ==> 0");
                Console.WriteLine("151 - 200 ==> 0");
                Console.WriteLine("201 ==> 0");

            }

            if ( number >= 76 && number <= 150 )
            {
                if ( number == 150 )
                {
                    range = 75;
                }
                else
                {
                    range = number - 75;
                }

                Console.WriteLine("1 - 50 ==> 50");
                Console.WriteLine("51 - 75 ==> 25");
                Console.WriteLine("76 - 150 ==> " + range);
                Console.WriteLine("151 - 200 ==> 0");
                Console.WriteLine("201 ==> 0");
            }

            if ( number >= 151 && number <= 200 )
            {
                if (number == 200 )
                {
                    range = 50;
                }
                else
                {
                    range = number - 150;
                }
                Console.WriteLine("1 - 50 ==> 50");
                Console.WriteLine("51 - 75 ==> 25");
                Console.WriteLine("76 - 150 ==> 75");
                Console.WriteLine("151 - 200 ==> " + range );
                Console.WriteLine("201 ==> 0");
            }
            if ( number >= 201 )
            {
                range = number - 200;
                Console.WriteLine("1 - 50 ==> 50");
                Console.WriteLine("51 - 75 ==> 25");
                Console.WriteLine("76 - 150 ==> 75");
                Console.WriteLine("151 - 200 ==> 50");
                Console.WriteLine("201 ==> " + range);
            }
            if ( number <= 202)
            {
                range = number;
                Console.WriteLine(range);
            }
        }
    }
}
