using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        /***
        var serviceProvider = new ServiceCollection()
                .AddLogging(configure => {
                    configure.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Warning);
                    configure.SetMinimumLevel(LogLevel.Warning);
                    })
                .BuildServiceProvider();

        var logger = serviceProvider.GetService<ILogger<Program>>();

        logger.LogInformation("Calculator application started.");
        ***/
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = factory.CreateLogger("Program");
        logger.LogInformation("Welcome to My Calculator App");
        Task.Delay(200);

        try
        {
            var calculator = new Calculator();

            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            var num1 = calculator.ParseInput(input1);
            //logger.LogInformation($"User entered first number: {num1}");

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            var num2 = calculator.ParseInput(input2);
            //logger.LogInformation($"User entered second number: {num2}");

            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.ToLower() ?? string.Empty;
            //logger.LogInformation($"User selected operation: {operation}");

            double result = calculator.PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");
            //logger.LogInformation($"Calculation performed: {operation} {num1} and {num2}. \n Result is equal to : {result}");

            Console.WriteLine("Calculation attempt finished.");
            logger.LogInformation("Calculation Attempt Successful");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
            logger.LogError("Cannot divide by zero.");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("An error occurred: The specified operation is not supported.");
            logger.LogError("An error occurred: The specified operation is not supported.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input. Please Enter Numeric Values.");
            logger.LogError("]Invalid Input. Please Enter Numeric Values.");

        }
    }
}