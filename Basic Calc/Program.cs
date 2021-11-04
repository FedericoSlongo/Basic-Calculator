using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, delta, soluction = 0;
            string oper;
            bool try_pep=false;
            do
            {
                if (try_pep)
                {
                    Console.WriteLine("The inserted number isn't a number ir isn't valid try again");
                }
                Console.Write("Insert the first number ");
            } while (try_pep = !double.TryParse(Console.ReadLine(), out first));

            try_pep = false;

            do
            {
                if (try_pep)
                {
                    Console.WriteLine("The inserted number isn't a number ir isn't valid try again");
                }
                Console.Write("Insert the second number ");
            } while (try_pep = !double.TryParse(Console.ReadLine(), out second));

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
                    soluction = Math.Pow(first + second,2);
                    break;
                case "^3":
                    soluction = Math.Pow(first + second, 3);
                    break;
                case "//":
                    delta = first + second;
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