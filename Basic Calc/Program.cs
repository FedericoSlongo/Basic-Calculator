using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, delta, soluction = 0;
            string oper;
            bool try_pep = false, switch_ = false, second_cycle = false, average = false;
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
                    case "average":
                        int Voto = 1, Voto_Finale, Voto_temp = 0, cicli= 0;
                        bool insert_error = false;
            do
            {
                Console.Write("Insert the number ");
                do
                {
                    if (insert_error)
                    {
                        Console.WriteLine("The inserted number isn't valid retry");
                    }
                    Voto_temp = Voto_temp + Voto;
                } while (insert_error = !int.TryParse(Console.ReadLine(),out Voto));

                cicli++;
            } while (!(Voto == 0));

                        Voto_Finale = Voto_temp / cicli;
                        Console.WriteLine($"You inserted {cicli-1} numbers");
                        Console.WriteLine($"The average is {Voto_Finale}");
                        average = true;
                        break;
                    default:
                        if (!second_cycle)
                        {
                            Console.WriteLine("The operator isn't correct :/");
                            switch_ = true;
                        }
                        Console.Write("Insert the operator to use ");
                        oper = Console.ReadLine();
                        second_cycle = true;
                        break; 
                }
            } while (switch_);

            if (!average)
            {
                Console.WriteLine($"The soluction is {soluction}");
            }
        }
    }
}
