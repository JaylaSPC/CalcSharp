using System.Security.AccessControl;
using Console = System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 2 numbers: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double sum = Calculator.Add(firstNumber, secondNumber);
            double difference = Calculator.Subtract(firstNumber, secondNumber);
            double product = Calculator.Multiply(firstNumber, secondNumber);
            double quotient = Calculator.Divide(firstNumber, secondNumber);
            
            Console.WriteLine("Calculations:");
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {difference}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {product}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {quotient}");
        }
    }
}