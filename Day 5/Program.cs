//Day_5
using System;
using System.Collections;
using System.Data.SqlTypes;
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

}



