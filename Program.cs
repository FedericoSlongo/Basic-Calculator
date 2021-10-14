using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Double first, second, delta, soluction = 0;
            string oper;
            Console.Write("Insert the first number ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insert the second number ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insert the operator to use ");
            oper = Console.ReadLine();

            switch (oper)
            {
                case "-":
                    soluction = first - second;
                break;
                case "*":
                    soluction = first * second;
                break;
                case "/":
                    soluction = first / second;
                break;
                case "+":
                    soluction = first + second;
                break;
                case "^2":
                    soluction = (first + second) * (first + second);
                    break;
                case "^3":
                    soluction = (first + second) * (first + second) * (first + second);
                    break;
                case "//":
                    delta = first +second;
                    soluction = Math.Sqrt(delta);
                    break;
                default:
                    Console.WriteLine("The operator isn't correct :/");
                break;
            }
            Console.WriteLine($"The soluction is {soluction}");
        }
    }
}
