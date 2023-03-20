//  A2JohnAldeguerP2.cs
//  Calculating all four shapes using overloaded Method
//  
//  Revision History:
//        John Aldeguer, 2020.10.07: Created
//        John Aldeguer, 2020.10.09: Revision: Changing double to decimal for Method1



using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace A2JohnAldeguerP2
{
    class Program
    {
        // Method 1: Area of a Square
        static decimal ComputeTotal(decimal SquareLength)
        {
            decimal perimeter;
            perimeter = (SquareLength * SquareLength);
            return perimeter;
        }

        // Method 2: Area of a Triangle
       static double ComputeTotal(double bottom, double height)//change to radius => bottom
        {
            return ((bottom * height) / 2);
        }

        // Method 3: Volume of a Cube
        static double ComputeTotal(double length, double width, double height)
        {
            return (length * width * height);
        }

        // Method 4: Volume of a Sphere
        static double ComputeTotal(double radius)
        {
            return ((4 * 3.14159 * (radius * radius * radius)) / 3 );
        }
        static void Main()
        {
            // Declaring Variables
            double length;
            decimal SquareLength;
            double bottom;
            double width;
            double height;
            double radius;
            decimal square;
            double cube;
            double triangle;
            double sphere;
            int MenuOption;
            string answer;
            

            // Intializing Variables
            length = 0;
            SquareLength = 0;
            width = 0;
            bottom = 0;
            height = 0;
            radius = 0;
            square = 0;
            triangle = 0;
            cube = 0;
            sphere = 0;
            MenuOption = 0;
            answer = "Yes";


            // Program Starts

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------- ");
            Console.WriteLine("|  Please choose one of the following option to compute: |");
            Console.WriteLine("| ------------------------------------------------------ |");
            Console.WriteLine("|  1. Press 1 for Calculating Area of a Square:          |");
            Console.WriteLine("|  2. Press 2 for Calculating Area of a Triangle:        |");
            Console.WriteLine("|  3. Press 3 for Calculating Volume of a Cube:          |");
            Console.WriteLine("|  4. Press 4 for Calculating Volume of a Sphere:        |");
            Console.WriteLine("---------------------------------------------------------- ");
            Console.WriteLine("");
            Console.Write("  Option: ");

            try
            {
                MenuOption = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException error)
            {
                Console.WriteLine("---------------------------------------------------------- ");
                Console.WriteLine("  " + error.Message);
            }
            // Loop
            if (MenuOption == 1) // Calculating Area of a Square
            {
                Console.Write("  Please enter a value for Length: ");
                SquareLength = decimal.Parse(Console.ReadLine());
                square = ComputeTotal(SquareLength);
                Console.WriteLine("  The Area of a Square is: " + square + ".");
                Console.Write("  Another calculation? (Yes or No) ");
                answer = Console.ReadLine();
                if (answer == "Yes" || answer == "Y" || answer == "y")
                {
                    Console.Clear();
                    Main();
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------------- ");
                    Console.WriteLine("  Thank you and have a nice day! ");
                    Console.ReadLine();
                }
            }
            else if (MenuOption == 2) // Calculating Area of a Triangle
            {
                Console.Write("  Please enter a value for Base: ");
                bottom = double.Parse(Console.ReadLine());
                Console.Write("  Please enter a value for Height: ");
                height = double.Parse(Console.ReadLine());
                triangle = ComputeTotal(bottom, height);
                Console.WriteLine("  The Area of a Triangle is: " + triangle + ".");
                Console.Write("  Another calculation? (Yes or No) ");
                answer = Console.ReadLine();
                if (answer == "Yes" || answer == "Y" || answer == "y")
                {
                    Console.Clear();
                    Main();
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------------- ");
                    Console.WriteLine("  Thank you and have a nice day! ");
                    Console.ReadLine();
                }
            }
            else if (MenuOption == 3) // Calculating Volume of a Cube
            {
                Console.Write("  Please enter a value for Length: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("  Please enter a value for Width: ");
                width = double.Parse(Console.ReadLine());
                Console.Write("  Please enter a value for Height: ");
                height = double.Parse(Console.ReadLine());
                cube = ComputeTotal(length, width, height);
                Console.WriteLine("  The Volume of a Cube is : " + cube + ".");
                Console.Write("  Another calculation? (Yes or No) ");
                answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    Console.Clear();
                    Main();
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------------- ");
                    Console.WriteLine("  Thank you and have a nice day! ");
                    Console.ReadLine();
                }
            }
            else if (MenuOption == 4) // Calculating Volume of a Sphere
            {
                Console.Write("  Please enter a value for Radius: ");
                radius = double.Parse(Console.ReadLine());
                sphere = ComputeTotal(radius);
                Console.WriteLine("  The Volume of a Sphere is : " + sphere + ".");
                Console.Write("  Another calculation? (Yes or No) ");
                answer = Console.ReadLine();
                if (answer == "Yes" || answer == "Y" || answer == "y")
                {
                    Console.Clear();
                    Main();
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------------- ");
                    Console.WriteLine("  Thank you and have a nice day! ");
                    Console.ReadLine();
                }
            }
            else if (MenuOption != 1 && MenuOption != 2 && MenuOption != 3 && MenuOption != 4)
            {
                Console.Write("  Choose again! \n");
                Console.WriteLine("---------------------------------------------------------- ");
                Main();
            }
            else
            {
                Console.WriteLine("Thank you");
                Console.ReadLine();
            }
        }
    }
}
