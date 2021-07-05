using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_Calculator1
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Sub(double a, double b)
        {
            return a - b;
        }

        static double Mul(double a, double b)
        {
            return a * b;
        }

        static double Div(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Division by zero");
                return 0;
            }

        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter first number: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter sign of operation: ");
                string z = Console.ReadLine();

                switch (z)
                {
                    case "+":
                        double a = Add(x, y);
                        Console.WriteLine(a);
                        break;
                    case "-":
                        Console.WriteLine(Sub(x, y));
                        break;
                    case "*":
                        Console.WriteLine(Mul(x, y));
                        break;
                    case "/":
                        Console.WriteLine(Div(x, y));
                        break;
                    default:
                        break;
                }
                Console.WriteLine("For Quit press ESC");
                Console.WriteLine("-------------------------");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
