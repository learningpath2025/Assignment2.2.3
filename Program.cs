
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
                            Console.WriteLine($"Area of the Circle is: {CircleArea()}");
                            break;
                        case "2":
                            Console.WriteLine($"Area of the Square is: {SquareArea()}");
                            break;
                        case "3":
                            Console.WriteLine($"Are of the Rectangle is: {RectangleArea()}");
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
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter color of circle:");
            string? color = Console.ReadLine();
            Shape shape = new Circle(radius);
            shape.ID = 1;
            shape.Name = "Circle";
            shape.Color = color;
            Console.WriteLine($"\n\nShape ID: {shape.ID}\nShape Name: {shape.Name}\nShape Color: {shape.Color}");
            return shape.CalculateArea();
        }

        static double SquareArea()
        {
            Console.WriteLine("Enter side of square:");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter color of square:");
            string? color = Console.ReadLine();
            Shape shape = new Square(side);
            shape.ID = 2;
            shape.Name = "Square";
            shape.Color = color;
            Console.WriteLine($"\n\nShape ID: {shape.ID}\nShape Name: {shape.Name}\nShape Color: {shape.Color}");
            return shape.CalculateArea();
        }

        static double RectangleArea()
        {
            Console.WriteLine("Enter length of rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle:");
            double breadth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter color of rectangle:");
            string? color = Console.ReadLine();
            Shape shape = new Rectangle(length, breadth);
            shape.ID = 3;
            shape.Name = "Rectangle";
            shape.Color = color;
            Console.WriteLine($"\n\nShape ID: {shape.ID}\nShape Name: {shape.Name}\nShape Color: {shape.Color}");
            return shape.CalculateArea();
        }

    }
}
