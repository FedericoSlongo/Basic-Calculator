using System;

namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Double first, second, soluction = 0; 
            String operator;
            Console.Write("Insert the first number ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insert the second number ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insert the operator to use ");
            operator = Console.ReadLine();

            switch (operator)
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
                default:
                    Console.WriteLine("L'operatore inserito non è corretto :/");
                    break;
            }
            Console.WriteLine($"La soluzione è {soluction}");
        }
    }
}
