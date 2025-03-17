using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show_Months
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int month;
            Console.WriteLine("Enter Month Number: ");
            month = Convert.ToInt32(Console.ReadLine());
            string monthName = month == 1 ? "January" : month == 2 ? "February" : month == 3 ? "March" : month == 4 ? "April" : month == 5 ? "May" : month == 6 ? "June" : month == 7 ? "July" : month == 8 ? "August" : month == 9 ? "September" : month == 10 ? "October" : month == 11 ? "November" : month == 12 ? "December" : "Invalid Month";
            Console.WriteLine("This is Month: " + monthName);
            Console.WriteLine();

            Console.WriteLine("This is another way to show months: ");

            Console.WriteLine("This is another Way, Choose ( a to l ): ");
            Console.WriteLine();
            string a = "January";
            string b = "February";
            string c = "March";
            string d = "April";
            string e = "May";
            string f = "June";
            string g = "July";
            string h = "August";
            string i = "September";
            string j = "October";
            string k = "November";
            string l = "December";

            string monthName2 = Console.ReadLine();
            string monthName3 = monthName2 == "a" ? a : monthName2 == "b" ? b : monthName2 == "c" ? c : monthName2 == "d" ? d : monthName2 == "e" ? e : monthName2 == "f" ? f : monthName2 == "g" ? g : monthName2 == "h" ? h : monthName2 == "i" ? i : monthName2 == "j" ? j : monthName2 == "k" ? k : monthName2 == "l" ? l : "Invalid Month";
            Console.WriteLine("This is Month: " + monthName3 + "\t(Another Way)");
            Console.WriteLine();

            Console.WriteLine("......................................................................");
            Console.WriteLine();

            int Months = int.Parse(Console.ReadLine());
            if ( Months == 1 )
            {
                Console.WriteLine("January");
            }
            else if  ( Months == 2 )
            {
                Console.WriteLine("February");
            }
            else if ( Months == 3 )
            {
                Console.WriteLine("March");
            }
            else if ( Months == 4 )
            {
                Console.WriteLine("April");
            }
            else if ( Months == 5 )
            {
                Console.WriteLine("May");
            }
            else if ( Months == 6 )
            {
                Console.WriteLine("June");
            }
            else if ( Months == 7 )
            {
                Console.WriteLine("July");
            }
            else if ( Months == 8 )
            {
                Console.WriteLine("August");
            }
            else if ( Months == 9 )
            {
                Console.WriteLine("September");
            }
            else if ( Months == 10 )
            {
                Console.WriteLine("October");
            }
            else if ( Months == 11 )
            {
                Console.WriteLine("November");
            }
            else if ( Months == 12 )
            {
                Console.WriteLine("December");
            }
            else
            {
                Console.WriteLine("Invalid Month");
            }





        }
    }
}
