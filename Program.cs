using System;

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

        // Function to calculate factorial of a number
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                return -1; // Invalid input
            }
            else if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        // Function to perform basic ATM operations
        public static string BasicATM(double balance, string operation, double amount)
        {
            while (true) 
            {
                Console.WriteLine("Welcome to the ATM System");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Select an operation: ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        if (amount > balance)
                        {
                            return "Insufficient funds.";
                        }
                        else
                        {
                            balance -= amount;
                            return $"Withdrawal successful. New balance: {balance}";
                        }
                    case 2:
                        balance += amount;
                        return $"Deposit successful. New balance: {balance}";
                    case 3:
                        return $"Current balance: {balance}";
                    case 4:
                        return "Exiting the ATM system.";
                    default:
                        return "Invalid operation. Please try again.";
                }
            }
        }

        // Function to calculate Geometry Calculator Circle, Square, and Triangle
        public static string GeometryCalculatorCircle(double r, out double Area, out double Circumference)
        {
            Area = Math.PI * r * r;
            Circumference = 2 * Math.PI * r;
            return $"Area: {Area}, Circumference: {Circumference}";
        }

        public static string GeometryCalculatorSquare(double s, out double Area1, out double Perimeter)
        {
            Area1 = s * s;
            Perimeter = 4 * s;
            return $"Area: {Area1}, Perimeter: {Perimeter}";
        }
        public static string GeometryCalculatorTriangle(double b, double h, out double Area2)
        {
            Area2 = 0.5 * b * h;
            return $"Area: {Area2}";
        }

        // Function to calculate the sum of even and odd numbers
        public static string SumOfEvenAndOdd(int n)
        {
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                }
                else
                {
                    sumOdd += i;
                }
            }
            return $"Sum of even numbers: {sumEven}, Sum of odd numbers: {sumOdd}";
        }

        // Function to perform scientific calculations
        public static double sinValue(double angle)
        {
            return Math.Sin(angle * Math.PI / 180);
        }
        public static double cosValue(double angle)
        {
            return Math.Cos(angle * Math.PI / 180);
        }
        public static double tanValue(double angle)
        {
            return Math.Tan(angle * Math.PI / 180);
        }
        public static double sqrtValue(double number)
        {
            return Math.Sqrt(number);
        }
        public static double logValue(double number)
        {
            return Math.Log(number);
        }
        public static double powValue(double baseNum, double exponent)
        {
            return Math.Pow(baseNum, exponent);
        }


        // Function to print a pattern
        public static string PrintPattern(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            return "Pattern printed successfully.";
        }

        // Function to print a pyramid pattern
        public static string PrintPyramid(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            return "Pyramid pattern printed successfully.";
        }

        // Function to print a diamond pattern
        public static string PrintDiamond(int rows)
        {
            // Print upper half of diamond
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // Print lower half of diamond
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            return "Diamond pattern printed successfully.";
        }

        // Function to play a guessing game
        public static string GuessGame(int numberToGuess, int userGuess, int numberOfTries)
        {
            if (userGuess == numberToGuess)
            {
                return $"Congratulations! You guessed the number {numberToGuess} in {numberOfTries} tries.";
            }
            else if (userGuess < numberToGuess)
            {
                return "Too low! Try again.";
            }
            else
            {
                return "Too high! Try again.";
            }
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
                Console.WriteLine("1. Check Even or Odd ");
                Console.WriteLine("2. Find Largest of Three Numbers");
                Console.WriteLine("3. Convert Celsius to Fahrenheit");
                Console.WriteLine("4. Calculate Discount");
                Console.WriteLine("5. Determine Grade");
                Console.WriteLine("6. Swap Two Numbers");
                Console.WriteLine("7. Convert Days to Weeks and Days");
                Console.WriteLine("8. Calculate Electricity Bill");
                Console.WriteLine("9. Simple Calculator");
                Console.WriteLine("10. Factorial of a Number");
                Console.WriteLine("11. Basic ATM System");
                Console.WriteLine("12. Geometry Calculator");
                Console.WriteLine("13. Sum of Even and Odd Numbers");
                Console.WriteLine("14. Scientific Calculator");
                Console.WriteLine("15. Print Pattern");
                Console.WriteLine("16. Print a Pyramid Pattern");
                Console.WriteLine("17. Print a Diamond Pattern");
                Console.WriteLine("18. Guess Game with helper");
                Console.WriteLine("19. Exit");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Please select an option from the menu above (1-19):");
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

                    // Factorial of a Number
                    case 10:
                        Console.WriteLine("Enter a number to calculate its factorial:");
                        int factorialNum = int.Parse(Console.ReadLine());
                        int factorialResult = Factorial(factorialNum);
                        if (factorialResult == -1)
                        {
                            printNotValue("Invalid input for factorial.");
                        }
                        else
                        {
                            printValue(factorialResult);
                        }
                        break;

                    // simple Basic ATM System
                    case 11:
                        Console.WriteLine("Enter your balance:");
                        double balance = 1000;
                        Console.WriteLine("Enter the operation (withdraw/deposit):");
                        string operation = Console.ReadLine();
                        Console.WriteLine("Enter the amount:");
                        double amount = double.Parse(Console.ReadLine());
                        string atmResult = BasicATM(balance, operation, amount);
                        printValue(atmResult);

                        break;

                    // Geometry Calculator
                    case 12:
                        
                        Console.WriteLine("Welcome to the Geometry Calculator");
                      do
                      { 
                        Console.Clear();
                        Console.WriteLine("Choose The Shapes : \n1. Circle \n2. Square \n3. Triangle  \n4. Exit");
                        int Shapes = int.Parse(Console.ReadLine());

                        switch (Shapes)
                        {
                            case 1:
                                Console.WriteLine("Circle");
                                Console.WriteLine("Enter The Radius(r)");
                                double r = double.Parse(Console.ReadLine());
                                double Area, Circumference;
                                string CircleArea = GeometryCalculatorCircle(r, out Area, out Circumference);
                                printValue(CircleArea);
                                break;
                            case 2:
                                Console.WriteLine("Square");
                                double s, Area1, Perimeter;
                                Console.WriteLine("Enter The Side");
                                s = double.Parse(Console.ReadLine());
                                string SqureArea = GeometryCalculatorSquare(s, out Area1, out Perimeter);
                                printValue(SqureArea);
                                break;
                            case 3:
                                Console.WriteLine("Triangle");
                                double b, h, Area2;
                                Console.WriteLine("Enter The Base");
                                b = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter The Height");
                                h = double.Parse(Console.ReadLine());
                                string TriangleArea = GeometryCalculatorTriangle(b, h, out Area2);
                                printValue(TriangleArea);
                                break;
                            case 4:
                                Console.WriteLine("Exiting the program. Goodbye!");
                                return;
                            default:
                                Console.WriteLine("Invalid choice. Please select a valid option.");
                                break;
                        }
                            Console.WriteLine("Choice Y/N.");
                            choice = char.Parse(Console.ReadLine());

                      } while (choice == 'Y' || choice == 'y');
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;

                    // Sum of Even and Odd Numbers
                    case 13:
                        Console.WriteLine("Enter the number of terms:");
                        int n = int.Parse(Console.ReadLine());
                        string SumEvenOdd = SumOfEvenAndOdd(n);
                        printValue(SumEvenOdd);
                        break;

                    // Scientific Calculator
                    case 14:

                        Console.WriteLine("Welcome to the Scientific Calculator");
                      do
                      { 
                        Console.Clear();
                        Console.WriteLine("Choose The Operation : \n1. sin \n2. cos \n3. tan \n4. sqrt \n5. log \n6. pow");
                        int Operation = int.Parse(Console.ReadLine());

                        switch (Operation)
                        {
                            case 1:
                                Console.WriteLine("Enter the angle in degrees:");
                                double angle = double.Parse(Console.ReadLine());
                                double sin = sinValue(angle);
                                printValue(sin);
                                break;

                            case 2:
                                Console.WriteLine("Enter the angle in degrees:");
                                double angle1 = double.Parse(Console.ReadLine());
                                double cos = cosValue(angle1);
                                printValue(cos);
                                break;

                            case 3:
                                Console.WriteLine("Enter the angle in degrees:");
                                double angle2 = double.Parse(Console.ReadLine());
                                double tan = tanValue(angle2);
                                printValue(tan);
                                break;

                            case 4:
                                Console.WriteLine("Enter the number to find the square root:");
                                double sqrtNum = double.Parse(Console.ReadLine());
                                double sqrt = sqrtValue(sqrtNum);
                                printValue(sqrt);
                                break;

                            case 5:
                                Console.WriteLine("Enter the number to find the logarithm:");
                                double logNum = double.Parse(Console.ReadLine());
                                double log = logValue(logNum);
                                printValue(log);
                                break;

                            case 6:
                                Console.WriteLine("Enter the base and exponent:");
                                double baseNum = double.Parse(Console.ReadLine());
                                double exponent = double.Parse(Console.ReadLine());
                                double pow = powValue(baseNum, exponent);
                                printValue(pow);
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please select a valid option.");
                                break;
                        }
                            Console.WriteLine("Choice Y/N.");
                            choice = char.Parse(Console.ReadLine());
                      } while (choice == 'Y' || choice == 'y');
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;

                    // Print Pattern
                    case 15:
                        Console.WriteLine("Enter the number of rows for the pattern:");
                        int rows = int.Parse(Console.ReadLine());
                        string patternResult = PrintPattern(rows);
                        printValue(patternResult);
                        break;

                    // Print Pyramid Pattern
                    case 16:
                        Console.WriteLine("Enter the number of rows for the pyramid pattern:");
                        int pyramidRows = int.Parse(Console.ReadLine());
                        string pyramidResult = PrintPyramid(pyramidRows);
                        printValue(pyramidResult);
                        break;

                    // Print Diamond Pattern
                    case 17:
                        Console.WriteLine("Enter the number of rows for the diamond pattern:");
                        int diamondRows = int.Parse(Console.ReadLine());
                        string diamondResult = PrintDiamond(diamondRows);
                        printValue(diamondResult);
                        break;

                    // Guess Game
                    case 18:
                        Console.WriteLine("Welcome to the Guessing Game!");
                        Random random = new Random();
                        int numberToGuess = random.Next(1, 101);
                        int numberOfTries = 0;
                        bool guessedCorrectly = false;
                        while (!guessedCorrectly)
                        {
                            Console.WriteLine("Guess a number between 1 and 100:");
                            int userGuess = int.Parse(Console.ReadLine());
                            numberOfTries++;
                            string guessResult = GuessGame(numberToGuess, userGuess, numberOfTries);
                            if (userGuess == numberToGuess)
                            {
                                guessedCorrectly = true;
                                printValue(guessResult);
                            }
                            else
                            {
                                printNotValue(guessResult);
                            }
                        }
                        break;

                    // Exit
                    case 19:
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
