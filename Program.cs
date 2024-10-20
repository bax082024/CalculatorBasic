using System.Collections;
namespace CalculatorApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Calculator calc = new Calculator();

      Console.WriteLine("Enter first number");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter second number");
      double num2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter 1 for add, 2 for subtract, 3 for Multiply, 4 for Divide");
      int operation = Convert.ToInt32(Console.ReadLine());

      double result = 0;
      
      switch (operation)
      {
        case 1:
            result = calc.AddNumbers(num1, num2);
            break;
        case 2:
            result = calc.SubtractNumbers(num1, num2);
            break;
        case 3:
            result = calc.MultiplyNumbers(num1, num2);
            break;
        case 4:
            result = calc.DivideNumbers(num1, num2);
            break;
        default:
            Console.WriteLine("Invalid operation.");
            break;
      }
        

      Console.WriteLine($"Result is : {result}");

    }

  }

}