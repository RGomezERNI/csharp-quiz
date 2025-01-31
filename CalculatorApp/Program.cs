namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var calculator = new Calculator();

            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            var num1 = calculator.ParseInput(input1);

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            var num2 = calculator.ParseInput(input2);

            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

            double result = calculator.PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");

            Console.WriteLine("Calculation attempt finished.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("An error occurred: The specified operation is not supported.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input. Please Enter Numeric Values.");
        }
    }
}