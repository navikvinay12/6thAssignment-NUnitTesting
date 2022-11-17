namespace _6thAssignment_NUnitTesting
{
    internal class NUnitTesting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6th Assignment - NUnit Testing !");
            Console.WriteLine("Press 1 : for program on Calculating Monthly Payments on Loan amount\n" +
                "Press 2 : for calculating Square root .\n" +
                "Press 3 : for Temp Unit Conversion .");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    MonthlyPayment.CalculatingMonthlyPayment();
                    break;
                case 2:
                    FindingSqRoot.SquareRoot();
                    break;
                case 3:
                    TempValueConversion.TempUnitConversion();
                    break;
                default:
                    Console.WriteLine("You missed to enter proper option , Please input only in the given range .");
                    break;
            }
            
        }
    }
}