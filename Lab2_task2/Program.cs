using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPoints;

            while (true)
            {
                Console.Write("Enter the number of points (3-5): ");
                if (int.TryParse(Console.ReadLine(), out numPoints) && numPoints >= 3 && numPoints <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number of points (3-5).");
                }
            }

            List<Point> figurePoints = new List<Point>();
            for (int i = 1; i <= numPoints; i++)
            {
                Console.Write($"Enter the X coordinate of point {i}: ");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.Write($"Enter the Y coordinate of point {i}: ");
                    if (double.TryParse(Console.ReadLine(), out double y))
                    {
                        Console.Write($"Enter the name of point {i}: ");
                        string name = Console.ReadLine();
                        figurePoints.Add(new Point(x, y, name));
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid Y coordinate.");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid X coordinate.");
                    i--;
                }

               
            }

            Figure figure = new Figure(figurePoints.ToArray());
            double perimeter = figure.CalculatePerimeter();
            Console.WriteLine($"Perimeter of the {figurePoints.Count}-sided figure is {perimeter}");

        }
    }
    
}
