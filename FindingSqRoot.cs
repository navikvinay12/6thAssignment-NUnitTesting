using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6thAssignment_NUnitTesting
{
    public class FindingSqRoot
    {
        public static void SquareRoot()
        {
            Console.WriteLine("enter a number to find its square root ");
            double c = Convert.ToDouble(Console.ReadLine());    //taking a number to calculate Sq.root.
            Console.Write($"Square root of {c} is :");
            double t = c;
            double epsilon = 1.0e-15;                   //1.0e-15 = 1.0 x 10^-15 = 0.0000000000000010

            while (Math.Abs(t - c / t) > epsilon * t)   //Math.Abs()--> absolute positive no .
            {
                t = (c / t + t) / 2.0;                  //pre-defined formula 
            }
            Console.WriteLine(t);
        }
    }
}
