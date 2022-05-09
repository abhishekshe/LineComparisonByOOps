using System;
using System.Collections.Generic;

namespace Line_Comparision_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparision Computation Program");
            List<double> lineLengths = new List<double>();
            for (int lineNumber = 0; lineNumber < 2; lineNumber++)
            {
                Console.WriteLine("Please enter the coordinates for 1st point seperated by commas");
                string coordinates = Console.ReadLine();
                string[] coordinatesArray = coordinates.Split(",");
                double x = Convert.ToDouble(coordinatesArray[0]);
                double y = Convert.ToDouble(coordinatesArray[1]);
                Console.WriteLine("Please enter the coordinates for 2nd point seperated by commas");
                coordinates = Console.ReadLine();
                string[] coordinatesArray2 = coordinates.Split(",");
                double x2 = Convert.ToDouble(coordinatesArray2[0]);
                double y2 = Convert.ToDouble(coordinatesArray2[1]);
                double length = Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));
                Console.WriteLine($"Length of a line is {length}");
                lineLengths.Add(length);
            }
            if (lineLengths[0] == lineLengths[1])
            {
                Console.WriteLine("Lines are Equal");
            }
            else
                Console.WriteLine("Lines are not equal");

        }
    }
}