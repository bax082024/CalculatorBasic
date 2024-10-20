namespace CalculatorApp
{ 
    public class Calculator : ICalculate
  {
    public double AddNumbers(double a, double b)
    {
        return a + b;
    }

    public double SubtractNumbers(double a, double b)
    {
        return a - b;
    }

    public double MultiplyNumbers(double a, double b)
    {
        return a * b; 
    }

    public double DivideNumbers(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
  }
}
