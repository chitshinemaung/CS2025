using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Program
    {
        static void Main(string [] args)
        {
            //Casting

            int a = 10;

            int b = a;

            byte c = (byte)b; //Explicit casting

            byte d = 20;

            int e = d; //Implicit casting

            float f = 10.5555f;

            a = ( int ) f; // data loss
            Console.WriteLine(a); // 10

            ArrayList Arr = new ArrayList();
            Arr.Add(1);
            Arr.Add("Arr");
            Arr.Add(false);

            foreach (var item in Arr)
            {
                Console.WriteLine(item);

            }


            Queue Q1 = new Queue();
            Q1.Enqueue(DateTime.Now);
            Q1.Enqueue(111);

            Console.WriteLine(Q1.Peek());

            Stack S1 = new Stack();
            S1.Push(222);
            S1.Push("Stack");

            Console.WriteLine(S1.Peek());




        }
    }
}
