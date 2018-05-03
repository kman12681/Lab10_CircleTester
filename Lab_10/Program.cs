using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {

            /* CALCULATE A CIRCLE'S CIRCUMFERENCE AND AREA
             * the application prompts the user to enter a radius
             * the application displays an error if the user enters invalid data
             * when the user enters valid data, the application calculates the area and circumference rounded to nearest 2 decimal places
             * the application prompts the user to continue
             * the application displays a "goodbye" message that also indicates the number of circles the user built when user chooses not to continue
             */

            int counter = 0;

            Console.WriteLine("Welcome to the Circle Tester.\n\nThis program will calculate the circumference and area of a circle based on the radius.");

            bool again = true;
            while (again)
            {
                Circle circle = new Circle(Validator.Validate());

                Console.WriteLine();
                Console.WriteLine($"Radius:\t\t {circle.CalculateFormattedRadius()}");       
                Console.WriteLine($"Circumference:\t {circle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area:\t\t {circle.CalculateFormattedArea()}");
                Console.WriteLine();

                counter++;

                again = Continue();                
                
            }

            Console.WriteLine();
            Console.WriteLine($"You calculated: {counter} circle(s)\n\nGoodbye!\n");
            Console.ReadLine();
        }

        public static bool Continue()
        {
            while (true)
            {
                Console.Write("Would you like to continue? (y/n) ");
                string response = Console.ReadLine().ToLower();

                if (!(response == "y" || response == "n"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Incorrect Entry.");
                    Console.WriteLine();
                }
                else if (response == "y")
                {
                    return true;   
                }
                else
                {
                    return false;
                }
            } 
        }
    }
}