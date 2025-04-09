namespace FunctionTask
{
    internal class Program
    {
        // Function to check if a number is even or odd
        public static string CheckEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

        // Function to find the largest of three numbers
        public static string FindLargestOfThree(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                return $"{num1} is the largest number.";
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                return $"{num2} is the largest number.";
            }
            else
            {
                return $"{num3} is the largest number.";
            }
        }

        // Function to convert temperature from Celsius to Fahrenheit
        public static double ConvertTemperature(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        // Function to calculate simple discount
        public static double CalculateDiscount(double originalPrice, double discountPercentage)
        {
            if (originalPrice > 100)
            {

                double discountAmount = (originalPrice * discountPercentage) / 100;
                double finalPrice = originalPrice - discountAmount;
                return finalPrice;
            }
            else
            {
                return originalPrice;
            }
        }

        // Function to determine the grade based on marks
        public static string DetermineGrade(int marks)
        {
            if (marks >= 90)
            {
                return "Grade A";
            }
            else if (marks >= 80)
            {
                return "Grade B";
            }
            else if (marks >= 70)
            {
                return "Grade C";
            }
            else if (marks >= 60)
            {
                return "Grade D";
            }
            else
            {
                return "Grade F";
            }
        }

        // Function to swap two numbers
        public static int SwapNumbers(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            return num1;
        }

        // Function to convert days to weeks and days
        public static string ConvertDaysToWeeksAndDays(int days)
        {
            int weeks = days / 7;
            int remainingDays = days % 7;
            return $"{weeks} weeks and {remainingDays} days.";
        }

        // Function to calculate electricity bill
        public static double CalculateElectricityBill(double units)
        {
            double billAmount = 0;
            if (units <= 100)
            {
                billAmount = units * 1.5;
            }
            else if (units <= 300)
            {
                billAmount = units * 2.5;
            }
            else
            {
                billAmount = units * 3.5;
            }
            return billAmount;
        }
        // Function to perform basic arithmetic operations
        public static string SimpleCalculator(double num1, double num2, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        return "Error: Division by zero.";
                    }
                    break;
                default:
                    return "Invalid operation.";
            }
            return result.ToString();
        }

        // Function to print the result of an operation
        public static void printValue(string input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        public static void printValue(int input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        public static void printValue(double input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        public static void printValue(bool input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        public static void printValue(int input, int input2)
        {
            Console.WriteLine("the result of this operation is: " + "Num1 = " + input + "   " + "Num2 = " + input2);
        }

        public static void printNotValue(string input)
        {
            Console.WriteLine("the result is invalid operation");
        }
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the C# Projects Tasks");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Select an option from the menu:");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1. Check Even or Odd");
                Console.WriteLine("2. Find Largest of Three Numbers");
                Console.WriteLine("3. Convert Celsius to Fahrenheit");
                Console.WriteLine("4. Calculate Discount");
                Console.WriteLine("5. Determine Grade");
                Console.WriteLine("6. Swap Two Numbers");
                Console.WriteLine("7. Convert Days to Weeks and Days");
                Console.WriteLine("8. Calculate Electricity Bill");
                Console.WriteLine("9. Simple Calculator");
                Console.WriteLine("10. Exit");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Please select an option from the menu above (1-10):");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------");
                switch (choice)
                {
                    // Check Even or Odd
                    case 1:
                        Console.WriteLine("Enter a number to check if it's even or odd:");
                        int number = int.Parse(Console.ReadLine());
                        string result = CheckEvenOrOdd(number);
                        printValue(result);
                        break;

                    // Find Largest of Three Numbers
                    case 2:
                        Console.WriteLine("Enter three numbers to find the largest:");
                        Console.Write("Number 1: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Number 2: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.Write("Number 3: ");
                        int num3 = int.Parse(Console.ReadLine());
                        string result1 = FindLargestOfThree(num1, num2, num3);
                        printValue(result1);
                        break;

                    // Convert Celsius to Fahrenheit
                    case 3:
                        Console.WriteLine("Enter temperature in Celsius to convert to Fahrenheit:");
                        double celsius = double.Parse(Console.ReadLine());
                        double result3 = ConvertTemperature(celsius);
                        printValue(result3);
                        break;

                    // Calculate Discount
                    case 4:
                        Console.WriteLine("Enter the original price:");
                        double originalPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the discount percentage:");
                        double discountPercentage = double.Parse(Console.ReadLine());
                        double resul4 = CalculateDiscount(originalPrice, discountPercentage);
                        printValue(resul4);
                        break;

                    // Determine Grade               
                    case 5:
                        Console.WriteLine("Enter marks to determine the grade:");
                        int marks = int.Parse(Console.ReadLine());
                        string result5 = DetermineGrade(marks);
                        printValue(result5);
                        break;

                    // Swap Two Numbers
                    case 6:
                        Console.WriteLine("Enter two numbers to swap:");
                        Console.Write("Number 1: ");
                        int swapNum1 = int.Parse(Console.ReadLine());
                        Console.Write("Number 2: ");
                        int swapNum2 = int.Parse(Console.ReadLine());
                        SwapNumbers(ref swapNum1, ref swapNum2);
                        printValue(swapNum1, swapNum2);
                        break;

                    // Convert Days to Weeks and Days
                    case 7:
                        Console.WriteLine("Enter the number of days to convert to weeks and days:");
                        int days = int.Parse(Console.ReadLine());
                        string result7 = ConvertDaysToWeeksAndDays(days);
                        printValue(result7);
                        break;

                    // Calculate Electricity Bill
                    case 8:
                        Console.WriteLine("Enter the number of units consumed:");
                        double units = double.Parse(Console.ReadLine());
                        double billAmount = CalculateElectricityBill(units);
                        printValue(billAmount);
                        break;

                    // Simple Calculator
                    case 9:
                        Console.WriteLine("Enter two numbers for the calculator:");
                        Console.Write("Number 1: ");
                        double calcNum1 = double.Parse(Console.ReadLine());
                        Console.Write("Number 2: ");
                        double calcNum2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the operation (+, -, *, /):");
                        string op = Console.ReadLine();
                        string result9 = SimpleCalculator(calcNum1, calcNum2, op);
                        if (result9 == "Error: Division by zero.")
                        {
                            printNotValue(result9);
                        }
                        else
                        {
                            printValue(result9);
                        }
                        break;

                    // Exit
                    case 10:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                        return;

                    // Invalid choice
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
                Console.WriteLine("Press any key to exit.");
                Console.ReadLine();
            }
        }
    }
}
