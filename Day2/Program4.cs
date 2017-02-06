using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program4
    {
        public static void Main()
        {
            Console.WriteLine("Entrance Ticket: $25.");
            Console.Write("Please enter the number of tix that you want: ");

            string input = Console.ReadLine(); // assume that input is a valid number

            int numTix = Convert.ToInt32(input);

            // bool isOK = Int32.TryParse(input, out numTix);

            //Display the total cost
            Console.WriteLine("Total cost = {0}", numTix * 25);

            int numTix2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
