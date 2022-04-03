using System;

namespace Coursework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Getting the inputs from the user
            Console.WriteLine("Enter the hourly wage: ");

            //Converting the string value to an integer value
            int hourlyWage = Convert.ToInt32(Console.ReadLine());

            // Getting the inputs from the user
            Console.WriteLine("Enter the total regular hours: ");
            
            // Total regular hours is trh
            int trh = Convert.ToInt32(Console.ReadLine());

            
            // Getting the inputs from the user
            Console.WriteLine("Enter the total overtime hours: ");

            // Total ovetime hours is toh
            int toh = Convert.ToInt32(Console.ReadLine());

            // Using double and implementing the arithmetic operations
            double totalWeeklyPay = (hourlyWage * trh) + (toh * 1.5);

            // Print out the employee's total weekly pay
            Console.WriteLine("The employee's total weekly pay " + totalWeeklyPay);


        }
    }
}
