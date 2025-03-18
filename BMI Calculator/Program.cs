using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    internal class BMIclaculator
    {
        public static void Main(string [] args)
        {
            double weight;
            double height;
            double bmi;

            Console.WriteLine("Enter your Weight(lb) and Hight (inches) :");
            Console.WriteLine();
            Console.WriteLine("Enter your weight: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height: ");
            height = Convert.ToDouble(Console.ReadLine());

            bmi = (weight* 703) /  (height * height);  // BMI = weight * height
            Console.WriteLine("Your BMI is: " + bmi);

            if ( bmi < 18.5)
            {
                Console.WriteLine("You are underweight");
            }
            else
            {
                if ( bmi > 18.5 && bmi < 24.9)
                {
                    Console.WriteLine("You are normal weight");
                }
                else
                {
                    if ( bmi > 25 )
                    {
                        Console.WriteLine("You are overweight");
                    }
                    
                }
            
        }
    }
}
 