namespace CalculatorApp;

public class Calculator
{
    public double PerformOperation(double num1, double num2, string operation)
    {
        // TODO: Implement the PerformOperation method
        double result = 0.0;
        switch (operation) 
        {
            case "add":
                return result = num1 + num2;
                break;
            case "subtract":
                return result = num1 - num2;
                break;
            case "multiply":
                return result = num1 * num2;
                break;
            case "divide":
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero!");
                }
                else
                {
                    return num1 / num2;
                }
            default: 
                throw new InvalidOperationException("An error occurred: The specified operation is not supported.");
        }
    }
    public double ParseInput(string input)
    {
        if (!double.TryParse(input, out double num1))
        {
            throw new FormatException("Invalid input. Please enter numeric values.");
        }
        return num1;
    }
}