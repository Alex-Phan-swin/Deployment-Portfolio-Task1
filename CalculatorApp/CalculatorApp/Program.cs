using MathNet.Numerics;
using MathNet.Numerics.Statistics;
using System.Threading.Channels;
using Newtonsoft.Json;
using System.Xml;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Operator (+, -, *, /, mean):");
                string operation = Console.ReadLine();

                // Calculate the mean value
                if (operation == "mean")
                {
                    Console.Write("Enter numbers separated by spaces:");
                    string input = Console.ReadLine();

                    double[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                    double mean_result = numbers.Mean();
                        
                    Console.WriteLine($"Mean: {mean_result}");
                    Console.WriteLine();

                    continue;
                }

                Console.Write("Enter Second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result;

                // Standard math operations
                switch (operation)
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
                        if (num2 == 0) 
                        {
                            Console.WriteLine("Cannot divideby 0");
                            continue;
                        }

                         result = num1 / num2;
                         break;

                    default:
                        Console.WriteLine("Invalid operator or number");
                        continue ;

                }

                Console.WriteLine($"Result: {result}");

                var calculation = new
                {
                    first_num = num1,
                    second_num = num2,
                    math_method = operation,
                    output = result
                };

                // Use Newtonsoft.Json to convert calculation to JSON
                string json = JsonConvert.SerializeObject(calculation);

                Console.WriteLine($"JSON: {json}");
                Console.WriteLine();

            }
        }
    }
}
