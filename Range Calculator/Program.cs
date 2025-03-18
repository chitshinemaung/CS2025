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
            int r1, r2, r3, r4, r5, userinput;
            userinput = 100;
            //int userInput;
            //Console.WriteLine("Enter any number: ");
            //userInput = int.Parse(Console.ReadLine());

            r1 = userinput - 50;
            Console.WriteLine("This is the result R1: " + r1);
            r2 = r1 - 25;
            Console.WriteLine("This is the result R2: " + r2);
            r3 = r2;
            Console.WriteLine("This is the result R3: " + r3);
            r4 = userinput > 150 && userinput <= 200 ? 50 : 0;
            Console.WriteLine("This is the result R4: " + r4);
            r5 = userinput > 200 ? 0 : 0;
            Console.WriteLine("This is the result R5: " + r5);

        }
    }
}
