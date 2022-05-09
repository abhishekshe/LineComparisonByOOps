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
            LineComparision lineCmp = new LineComparision();
            double[] xPositions = { 0, 0 };
            double[] yPositions = { 0, 0 };
            for (int lineNumber = 0; lineNumber < 2; lineNumber++)
            {
                lineCmp.Coordinates(ref xPositions, ref yPositions);
                double length = Math.Sqrt(Math.Pow(xPositions[1] - xPositions[0], 2) + Math.Pow(yPositions[1] - yPositions[0], 2));
                Console.WriteLine($"Length of a line is {length}");
                lineLengths.Add(length);
            }
            lineCmp.EqualityCheck(lineLengths);

        }
    }
    class LineComparision
    {
        public void Coordinates(ref double[] xPositions, ref double[] yPositions)
        {
           
            for (int points = 1; points < 3; points++)
            {
                Console.WriteLine($"Please enter the coordinates for {points}th point seperated by commas");
                string coordinates = Console.ReadLine();
                string[] coordinatesArray = coordinates.Split(",");
                xPositions[points - 1] = Convert.ToDouble(coordinatesArray[0]);
                yPositions[points - 1] = Convert.ToDouble(coordinatesArray[1]);
            }

        }
        public void EqualityCheck(List<double> lineLengths)
        {
            if (lineLengths[0] == lineLengths[1])
            {
                Console.WriteLine("Both Lines are Equal");
            }
            else if (lineLengths[0] > lineLengths[1])
            {
                Console.WriteLine($"1st line is greater than 2nd line by {lineLengths[0] - lineLengths[1]}");
            }
            else
                Console.WriteLine($"2nd line is greater than 1st line by {lineLengths[1] - lineLengths[0]}");

        }
    }
}