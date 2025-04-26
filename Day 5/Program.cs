using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int k = 5;
            call(k);
            Console.WriteLine("Original Value of K : " + k); //5

            //pass by value ref:
            StringBuilder sb = new StringBuilder();
            call2(sb);
            Console.WriteLine(sb.ToString());

            int j = 9;
            int j1 = 10;
            call3(ref j, ref j1);
            Console.WriteLine(j + j1);

        }

        static void call3(ref int z, ref int z1)
        {
            z = z + 1;
            z1 = z1 + 1;
            Console.WriteLine(z + ", "+ z1);
        }

        static void call2 (StringBuilder s )
        {
            s.Append("ChitShine");
        }

        

        static void call (int x)
        {
            x = x + 1;
            Console.WriteLine(x); //6
        }
    }
}
