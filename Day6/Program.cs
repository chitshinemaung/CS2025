using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program3
    {
        //struct and class ( value type object and reference type object )
        
        struct Person
        {
            public string Name;
            public string Email;
            public Person(string Ex)
            {
                Name = "";
                Email = "";


            }  
        }
        class Person1
        {
            public Person1()
                {
                
                }

        }

        class stock
        {
            decimal _Currentprice;

            public decimal Currentprice
            {
                get { return _Currentprice; }
                set { _Currentprice = value; }

            }

            decimal _Owned;

            public decimal Owned
            {
                get { return _Owned; }
                set { _Owned = value; }
            }

            public decimal HMRish
            {
                get { return _Currentprice * _Owned; }
            }

            
        }

        partial class Bill
        {
            public Bill(decimal price)
            {
                BillingAmu(price);
            }

            partial void BillingAmu(decimal price);

        }

        partial class Bill
        {
            partial void BillingAmu(decimal price)
            {
                if ( price < 1000 )
                    Console.WriteLine("Price is Tool Low.");
                else
                    Console.WriteLine("Accept");
            }


        }




        static void Main(string [] args)
        {
           stock GG = new stock();
            GG.Currentprice = 100;
            GG.Owned = 12.11m;

            Console.WriteLine("Your Wealthy is : " + GG.HMRish);

            Bill BB = new Bill(100); 
        }
    }
}