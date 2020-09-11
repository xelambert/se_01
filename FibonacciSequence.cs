using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_01_FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of numbers (from 1 to 40):");

            int amount = askForNumber();
            generateFibonacciSeq(amount);

            Console.ReadKey();
        }

        static int askForNumber()
        {
            int number = 0;
            bool correctInput;
            do
            {
                try
                {
                    correctInput = true;
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number >= 41 || number <= 0) throw new Exception("Must be an integer from 1 to 40");
                }
                catch (FormatException)
                {
                    correctInput = false;
                    Console.WriteLine("Wrong input format. (Must be an integer number)");
                }
                catch (Exception e)
                {
                    correctInput = false;
                    Console.WriteLine(e.Message);
                }
            }
            while (correctInput == false);

            return number;
        }

        static void generateFibonacciSeq(int amount)
        {
            int a = 0;
            int b = 1;
            int fib;

            Console.WriteLine("===================FIBONACCI==================");
            Console.WriteLine(0);
            if (amount == 1) return;

            Console.WriteLine(1);
            if (amount == 2) return;
            
            for (int i = 3; i <= amount; i++)
            {
                fib = a + b;
                Console.WriteLine(fib);

                a = b;
                b = fib;
            }
        }
    }
}
