//Testing Day_5
using System;
using System.Runtime.CompilerServices;
namespace Day5Testing
{
    class LocalMethod
    {
        public static void Main(string [] agrs)
        {
            string name = "Chit Shine Maung";
            name.PLL();
            name.AllUpper();
            Console.WriteLine();

            Adation(10, 20);
        }

        public static void Adation( int x , int y)
        {
            int z = x + y;
            Console.WriteLine("Int vlaue " + z);
        }

        public static void Adation( double x , double y)
        {
            double z =  x + y ;
            Console.WriteLine("Short vlaue " + z);
        }

        public static void Adation(string  x, string y)
        {
            string z = x + y;
            Console.WriteLine("Long vlaue " + z);
        }
    }

    public static class streamExtension
    {
        public static string PLL(this string PP)
        {
            return PP + "S";
        }

        public static string AllUpper(this string PP)
        {
            return PP.ToUpper();
        }
    }
}