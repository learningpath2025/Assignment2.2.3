/*
Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .
Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.
Inherit square class from shape and change the calculate area logic. Add property like side of square.
Take the input from user to select circle or square and display the calculated area . no hard coded values!
*/

namespace Assignment2._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool continueProgram = true;
                string? choice;

                while (continueProgram)
                {
                    choice = MenuChoice();

                    if (choice == "4")
                    {
                        continueProgram = false;
                        Console.WriteLine("Exiting the program.");
                        break;
                    }

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine($"Area of the Circle is: {CircleArea}");
                            break;
                        case "2":
                            Console.WriteLine($"Area of the Square is: {SquareArea}");
                            break;
                        case "3":
                            Console.WriteLine($"Are of the Rectangle is: {RectangleArea}");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid operation.");
                            break;
                    }

                    Console.WriteLine("\n\n\nDo you want to perform another operation? (y/n)");
                    string? continueChoice = Console.ReadLine();
                    string? LowerContinueChoice = continueChoice?.ToLower();

                    if (continueChoice != null)
                    {
                        switch (LowerContinueChoice)
                        {
                            case "y":
                                continueProgram = true;
                                break;
                            case "n":
                                continueProgram = false;
                                Console.WriteLine("Exiting the program.");
                                break;
                            default:
                                Console.WriteLine("Invalid input. Exiting the program.");
                                continueProgram = false;
                                break;
                        }
                    }
                    else if (continueChoice == null)
                    {
                        Console.WriteLine("Null value is considered invalid input. Exiting the program.");
                        continueProgram = false;

                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"Exception: {e}");
            }
        }

        static string MenuChoice()
        {
            Console.WriteLine("Select Shape:");
            Console.WriteLine("############################################################################");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Exit");
            Console.WriteLine("############################################################################");

            string? choice = Console.ReadLine();
            if (choice == null)
            {
                choice = "Invalid";
            }
            return choice;
        }

        static double CircleArea()
        {
            Console.WriteLine("Enter radius of circle:");
            int radius = Convert.ToInt32(Console.ReadLine());
            Circle circle = new Circle(radius);
            return circle.CalculateArea();
        }

        static double SquareArea()
        {
            Console.WriteLine("Enter side of square:");
            int side = Convert.ToInt32(Console.ReadLine());
            Square square = new Square(side);
            return square.CalculateArea();
        }

        static double RectangleArea()
        {
            Console.WriteLine("Enter length of rectangle:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle:");
            int breadth = Convert.ToInt32(Console.ReadLine());
            Rectangle rectangle = new Rectangle(length, breadth);
            return rectangle.CalculateArea();
        }

    }
}
