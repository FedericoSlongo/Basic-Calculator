using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, delta, soluction = 0;
            string oper;
            bool try_pep=false,switch_=false;
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

            do
            {
                switch (oper)
                {
                    case "-":
                        soluction = first - second;
                        switch_ = false;
                        break;
                    case "*":
                        soluction = first * second;
                        switch_ = false;
                        break;
                    case "/":
                        soluction = first / second;
                        switch_ = false;
                        break;
                    case "+":
                        soluction = first + second;
                        switch_ = false;
                        break;
                    case "^2":
                        soluction = Math.Pow(first + second, 2);
                        switch_ = false;
                        break;
                    case "^3":
                        soluction = Math.Pow(first + second, 3);
                        switch_ = false;
                        break;
                    case "//":
                        delta = first + second;
                        soluction = Math.Sqrt(delta);
                        switch_ = false;
                        break;
                    default:
                        Console.WriteLine("The operator isn't correct :/");
                        switch_ = true;
                        Console.Write("Insert the operator to use ");
                        oper = Console.ReadLine();
                        break;
                }
            } while (switch_);

            Console.WriteLine($"The soluction is {soluction}");
        }
    }
}
