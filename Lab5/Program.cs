using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        private static bool toContinue = true;

        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the Factorial Calculator!");

            // looping through whole program
            while (toContinue) 
            {
                // user input               
                Console.Write("\n Enter an integer that's greater than 0 but less than 10 =\t");

                string inputInteger = Console.ReadLine();

                // validate input for numbers
                if (int.TryParse(inputInteger, out int x))
                {
                    int num = int.Parse(inputInteger);

                    
                    if (num > 0 && num < 10)
                    {
                        long factorial = CalculateFactorial(num);

                        Console.WriteLine("\nThe factorial of {0} is {1} ", num, factorial + ".");
                    }
                    else
                    {
                        Console.WriteLine("\n Number must be greater than 0 but less than 10 \n");
                    }
                }
                else
                {
                    Console.WriteLine("\n No characters Numbers only!\n");
                }

                RestartProgram();
            }
            Console.ReadKey();
        }

        // calculating factorial
        public static long CalculateFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            long factorial = 1;

            for (int i = num; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        // continue yes or no
        public static void  RestartProgram()
        {
            Console.Write("\nContinue Y/N ?\t");

            Console.WriteLine("\n");

            var userInput = Console.ReadKey().KeyChar;

            Console.WriteLine("\n");

            if (userInput != 'Y')
            {
                toContinue = false;

                Console.WriteLine("\n See You Next Time !");
            }
        }
    }
}