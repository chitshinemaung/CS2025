using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    internal class Program
    {
        delegate int Transform(int x);
        static void Main(string [] args)
        {
            // Delegate

            Transform t = Square;
            var ans = t(50);
            Console.WriteLine(ans);

            Transform tt = new Transform(Square);
            var res = tt.Invoke(100);
            Console.WriteLine(res);

        }

        static int Square (int x)
        {
            return x * x;
        }
    }
}
