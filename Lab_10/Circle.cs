using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Circle
    {
        /* should contain these constructors and methods:
         * public Circle (double radius)
         * public double CalculateCircumference()
         * public string CalculateFormattedCircumference()
         * public double CalculateArea()
         * public string CalculateFormattedArea()
         * private string FormatNumber (double x)
         * Define a member called radius. This member should be private.
         * Define a property to get access to the class member: Radius
         */

        private double radius;
        public double Radius { get => radius; set => radius = value; }       

        public double circumference;
        public double area;

        public int counter = 0;

        string radiusRound;
        string circumferenceRound;
        string areaRound;
        
        public Circle(double radius)
        {
            this.radius = radius;
            circumference = CalculateCircumference();
            area = CalculateArea();
            circumferenceRound = CalculateFormattedCircumference();
            areaRound = CalculateFormattedArea();
            radiusRound = CalculateFormattedRadius();
            counter = counter++;
        }

        public double CalculateCircumference()
        {
            return 2 * (Math.PI * Radius);
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(circumference);
        }

        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(area);
        }

        public string CalculateFormattedRadius()
        {
            return FormatNumber(radius);
        }

        private string FormatNumber(double x)
        {
            return x.ToString("#.##");
        }

    }
}