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
