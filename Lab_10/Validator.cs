using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Validator
    {
        public static double Validate()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter radius: ");
                string inputRadius = Console.ReadLine();

                double radius = 0;
                bool success = double.TryParse(inputRadius, out radius);

                if (!success)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid entry.");                   
                }
                else
                {
                    return radius;
                }
            }
        }           
    }
}
