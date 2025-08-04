using System;

namespace MultiPurposeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== C# Multi-Purpose Console App ===");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GradeCalculator();
                        break;
                    case "2":
                        TicketPriceCalculator();
                        break;
                    case "3":
                        TriangleTypeIdentifier();
                        break;
                    case "4":
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }


    //  Grade Calculator
        static void GradeCalculator()
        {
            Console.Clear();
            Console.WriteLine("=== Grade Calculator ===");
            Console.Write("Enter a numerical grade (0-100): ");

            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                string letterGrade;

                if (grade >= 90)
                    letterGrade = "A";
                else if (grade >= 80)
                    letterGrade = "B";
                else if (grade >= 70)
                    letterGrade = "C";
                else if (grade >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";

                Console.WriteLine($"Your letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }


//  Ticket Price Calculator
        static void TicketPriceCalculator()
        {
            Console.Clear();
            Console.WriteLine("=== Ticket Price Calculator ===");
            Console.Write("Enter your age: ");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;
                Console.WriteLine($"Your ticket price is: GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }

            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }

        //  Triangle Type Identifier
        static void TriangleTypeIdentifier()
        {
            Console.Clear();
            Console.WriteLine("=== Triangle Type Identifier ===");

            Console.Write("Enter side A: ");
            double sideA = GetSide();

            Console.Write("Enter side B: ");
            double sideB = GetSide();

            Console.Write("Enter side C: ");
            double sideC = GetSide();

            if (IsValidTriangle(sideA, sideB, sideC))
            {
                if (sideA == sideB && sideB == sideC)
                    Console.WriteLine("This is an Equilateral triangle.");
                else if (sideA == sideB || sideB == sideC || sideA == sideC)
                    Console.WriteLine("This is an Isosceles triangle.");
                else
                    Console.WriteLine("This is a Scalene triangle.");
            }
            else
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
            }

            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }

        static double GetSide()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double side) && side > 0)
                    return side;
                else
                    Console.Write("Invalid input. Enter a positive number: ");
            }
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}