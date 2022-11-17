using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6thAssignment_NUnitTesting
{
    internal class MonthlyPayment
    {
        public static void CalculatingMonthlyPayment()
        {
            
            Console.WriteLine("Calculating the payments to be done on monthly basis with regards to the loan taken from someone");
            //taking inputs on P,Y and R (Principal amount ,Year/Duration , Rate of Interest (ROI)
            Console.WriteLine("Please enter the loan amount you wish to have");     
            double P = Convert.ToDouble(Console.ReadLine());    
            Console.WriteLine("Enter the duration of Loan Tenure in years (loan for how many years?)");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rate of Interest will be : ");
            double R = Convert.ToDouble(Console.ReadLine());
            //divided the formula into small parts to get the same calculated .
            double n = 12 * Y;
            double r = R / (12 * 100);
            double upsideCalculation = P * r;
            double downsideAddition = 1 + r;
            double downsideRaisedToCalculation = Math.Pow(downsideAddition, -n);
            double downsideCalculation = 1 - downsideRaisedToCalculation;
            double monthlyPayment = upsideCalculation / downsideCalculation;
            Console.WriteLine($"Monthly Payment will be : {monthlyPayment}");   //output.
        }
    }
}
