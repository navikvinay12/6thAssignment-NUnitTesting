using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6thAssignment_NUnitTesting
{
    internal class VendingMachine
    {
        public static void MinimumNotesCheck()
        {
            Console.WriteLine("Enter an amount to receive from vending machine . ");
            int returnAmount = Convert.ToInt32(Console.ReadLine());
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            foreach (int note in notes)
            {
                int i = 0;
                while (returnAmount >= note)
                {
                    returnAmount = returnAmount - note;
                    i++;
                }
                if (i > 0)
                {
                    Console.WriteLine($"{note} X {i} = {note*i}");
                }
            }
        }
    }
}
