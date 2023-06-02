using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArcsAndLinesWeek5.BL;
using System.Threading.Tasks;

namespace ArcsAndLinesWeek5
{
    

    public class Program
    {
        public static void Main()
        {
            MyLine line = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Make a Line");
                Console.WriteLine("2. Update the begin point");
                Console.WriteLine("3. Update the end point");
                Console.WriteLine("4. Show the begin Point");
                Console.WriteLine("5. Show the end point");
                Console.WriteLine("6. Get the Length of the line");
                Console.WriteLine("7. Get the Gradient of the Line");
                Console.WriteLine("8. Find the distance of begin point from zero coordinates");
                Console.WriteLine("9. Find the distance of end point from zero coordinates");
                Console.WriteLine("10. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Clear();
                    Console.Write("Enter the x-coordinate of the begin point: ");
                    int x1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the y-coordinate of the begin point: ");
                    int y1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the x-coordinate of the end point: ");
                    int x2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the y-coordinate of the end point: ");
                    int y2 = int.Parse(Console.ReadLine());
                    line = new MyLine(x1, y1, x2, y2);
                    Console.WriteLine("Line created.");
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.Write("Enter the new x-coordinate of the begin point: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new y-coordinate of the begin point: ");
                    int y = int.Parse(Console.ReadLine());
                    line.beginPoint.SetXY(x, y);
                    Console.WriteLine("Begin point updated.");
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.Write("Enter the new x-coordinate of the end point: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new y-coordinate of the end point: ");
                    int y = int.Parse(Console.ReadLine());
                    line.endPoint.SetXY(x, y);
                    Console.WriteLine("End point updated.");
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Begin Point: (" + line.beginPoint.x + ", " + line.beginPoint.y + ")");
                }
                else if (choice == 5)
                {
                    Console.Clear();
                    Console.WriteLine("End Point: (" + line.endPoint.x + ", " + line.endPoint.y + ")");
                }
                else if (choice == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Length of the line: " + line.Length());
                }
                else if (choice == 7)
                {
                    Console.WriteLine("Gradient of the line: " + line.Gradient());
                }
                else if (choice == 8)
                {
                    Console.Clear();
                    Console.WriteLine("Distance of the begin point from zero coordinates: " + line.beginPoint.DistanceFromZero());
                }
                else if (choice == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Distance of the end point from zero coordinates: " + line.endPoint.DistanceFromZero());
                }
                else if (choice == 10)
                {
                    Console.Clear();
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                }

                Console.WriteLine();
            }
        }
    }
}
