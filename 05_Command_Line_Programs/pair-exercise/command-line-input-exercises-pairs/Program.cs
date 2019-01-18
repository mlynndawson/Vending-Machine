using System;

namespace command_line_input_exercises_pairs
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.


        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
            // Print out message
            // Get bill from user
            // Parse string to decimal
            // Get amount tendered
            // Parse into decimal
            // Find difference save to variable change
            // Print change
            Console.WriteLine("Let's figure out your change!");
            Console.Write("Enter the amount of the bill:");
            decimal bill = decimal.Parse(Console.ReadLine());
            Console.Write("Enter amount paid:");
            decimal amountPaid = decimal.Parse(Console.ReadLine());
            decimal difference = amountPaid - bill;
            Console.WriteLine($"Your change is {difference:C}");
        }
    }
}
