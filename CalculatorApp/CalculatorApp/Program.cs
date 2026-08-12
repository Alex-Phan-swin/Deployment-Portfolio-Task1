using System.Threading.Channels;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Operator (+, -, *, /):");
                string operation = Console.ReadLine();

                Console.Write("Enter Second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());


                double result;

                switch (operation)
                {
                    case  "+":
                            result = num1 + num2;
                            break;

                    case  "-":
                            result = num1 - num2;
                            break;

                    case  "*":
                            result = num1 * num2;
                            break;

                    case  "/":
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

                Console.WriteLine($"Result {result}");

            }
        }
    }
}
