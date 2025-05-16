//Day_5
using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO.Pipes;
using System.Text;
using System.Xml.Serialization;
namespace Testing
{
    class Program
    {
        public static void Main(string [] agrs)
        {
            int k = 10;
            call(k);
            Console.WriteLine("Value of k : " + k);

            StringBuilder yy = new StringBuilder();
            call2(yy);
            Console.WriteLine("REF value " + yy.ToString());

            int nn = 10;
            call3(ref nn);
            Console.WriteLine("Value of nn : " + nn);

            int aaa = 10;
            int bbb = 20;
            call4(ref aaa, ref bbb);
            Console.WriteLine(aaa + " ," + bbb);

            int hh, hhh;
            call5(out hh, out hhh);
            Console.WriteLine("Value of Call from Main  : " + hh + "," + hhh);

            //Local Method
            Program PG = new Program();
            PG.Dosquare();

            //Extension Method
            string name = "Chit Shine Maung".Pll().AllUpper();
            Console.WriteLine(name);

            //Method Overloading
            Adation(10, 20);

            //Constructor
            Person p = new Person();



        }
        //Constructor
        class Person
         {
            //default constructor
            public Person()
            {

            }

            //parameterized constructor
            public Person(string name , string email)
            {

            }

            public Person(string Address)
            {

            }

         }

        //Method Overloading
        public static void Adation(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Int vlaue " + z);
        }

        public static void Adation(double x, double y)
        {
            double z = x + y;
            Console.WriteLine("Short vlaue " + z);
        }

        public static void Adation(string x, string y)
        {
            string z = x + y;
            Console.WriteLine("Long vlaue " + z);
        }

        //pass by value
        static void call(int x)
        {
            x = x + 1;
            Console.WriteLine("Method Value: " + x);
        }

        //pass by reference
        static void call2(StringBuilder y)
        {
            y.Append("Hello");
        }


        //pass by reference
        static void call3(ref int g)
        {
            g = g + 1;
            Console.WriteLine("Value of ref Method : " + g);
        }

        //pass by reference
        static void call4(ref int c, ref int d)
        {
            c = c + 1;
            d = d + 1;
            Console.WriteLine("Value of ref Method : " + c);
            Console.WriteLine("Value of ref Method : " + d);
        }

        //pass by out
        static void call5(out int hh, out int hhh)
        {
            hh = 100;
            hhh = 200;
            hh = hh + 10;
            hhh = hhh + 11;
            Console.WriteLine("Value of out Method : " + hh + "," + hhh);
        }

        //local Method

        void Dosquare()
        {
            Console.WriteLine(100);
            Console.WriteLine(200);

            int square (int x)
            {
                return x = x * x;
            }
        }
    }

    public static class streamExtension
    {
        public static string Pll (this string PP)
        {
            return PP + "S";
        }

        public static string AllUpper(this string PP)
        {
            return PP.ToUpper();
        }
    }

}



