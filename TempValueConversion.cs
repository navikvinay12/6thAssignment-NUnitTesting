using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6thAssignment_NUnitTesting
{
    internal class TempValueConversion
    {
        public static void TempUnitConversion()
        {
            Console.WriteLine("Press 1 : to convert celcius to fahrenheit\n" +
                              "Press 2 : to convert the fahrenheit to celcius");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter a value in Celcuis to convert in Fahrenheit");
                    double inputInCelcius = Convert.ToDouble(Console.ReadLine());
                    double outputInFahrenheit = (inputInCelcius * 9 / 5) + 32;
                    Console.WriteLine($"Input Celcius Value-->{inputInCelcius} and Ouput Fahrenheit value-->{outputInFahrenheit}");
                    break;
                case 2:
                    Console.WriteLine("Enter a value in Fahrenheit to convert in Celcius");
                    double inputInFahrenheit = Convert.ToDouble(Console.ReadLine());
                    double outputInCelcius = ((inputInFahrenheit - 32) * 5) / 9;
                    Console.WriteLine($"Input Fahrenheit Value-->{inputInFahrenheit} and Ouput Celcius value-->{outputInCelcius}");
                    break;
                default:
                    Console.WriteLine("Invalid option entered!");
                    break;
            }
        }
    }
}
