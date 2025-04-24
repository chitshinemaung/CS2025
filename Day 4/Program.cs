using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    //internal class Program
    //{
    //    static void Main(string [] args)
    //    {
    //        //Casting

    //        int a = 10;

    //        int b = a;

    //        byte c = ( byte ) b; //Explicit casting

    //        byte d = 20;

    //        int e = d; //Implicit casting

    //        float f = 10.5555f;

    //        a = ( int ) f; // data loss
    //        Console.WriteLine(a); // 10

    //        ArrayList Arr = new ArrayList();
    //        Arr.Add(1);
    //        Arr.Add("Arr");
    //        Arr.Add(false);

    //        foreach ( var item in Arr )
    //        {
    //            Console.WriteLine(item);

    //        }


    //        Queue Q1 = new Queue();
    //        Q1.Enqueue(DateTime.Now);
    //        Q1.Enqueue(111);

    //        Console.WriteLine(Q1.Peek());

    //        Stack S1 = new Stack();
    //        S1.Push(222);
    //        S1.Push("Stack");

    //        Console.WriteLine(S1.Peek());



    //    }

    //}
    



class APPConstant
    {
        public const string APPName = "Myapp";
        public const string APPColor = "Red";

        public static void Main(string[] args)
        {
            string Vv1 = APPConstant.APPName;
            Console.WriteLine(Vv1); // This will not work because V1 is not a constant expression

            string Vv2 = APPConstant.APPColor;
            Console.WriteLine(Vv2); // This will work because V2 is a constant expression
        }


    }
}
